using E_Commerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace E_Commerce.Controllers
{
    public class AccountController : Controller
    {

        private void UpdateLayout()
        {
            var data2 = Request.Cookies["HeaderCokiee"];
            ViewBag.IP = data2;
            int itemCount = 0;
            decimal Subtotal = 0;
            List<Cart> Tempcartsdata = Globals.GetCartData();
            List<Cart> cartsdata = new List<Cart>();

            foreach (var cart in Globals.GetCartData().Where(w => w.Token == data2))
            {

                cartsdata.Add(cart);

            }
            if (cartsdata != null)
            {
                itemCount = cartsdata.Sum(c => c.Qty);
                Subtotal = cartsdata.Sum(c => c.Subtotal);

                ViewBag.Cart = cartsdata;
            }

            if (cartsdata == null)
            {
                if (ViewBag.Cart != null)
                {
                    Globals.cart = ViewBag.Cart;
                }



            }
            ViewBag.FoodCrops = GetData.GetProductSubCategory("Food Crops");
            ViewBag.CashCrops = GetData.GetProductSubCategory("Cash Crops");
            ViewBag.ProcessedCrops = GetData.GetProductSubCategory("Processed crops");
            ViewBag.ItemCount = itemCount;
            ViewBag.SubTotal = Subtotal;

            ViewData["CartCount"] = itemCount;

            string key1 = "UserIDCokiee";
            string key2 = "UserFullNameCokiee";
            string key3 = "UserFullAddressCokiee";
            string key4 = "UserAreaCokiee";
            string key5 = "UserPhoneNumberCokiee";
            string key6 = "UserDistrictCokiee";

            ViewBag.UserID = Request.Cookies[key1];
            ViewBag.UserFullName = Request.Cookies[key2];
            ViewBag.FullAddress = Request.Cookies[key3];
            ViewBag.Area = Request.Cookies[key4];
            ViewBag.PhoneNumber = Request.Cookies[key5];
            ViewBag.District = Request.Cookies[key6];
        }
        public IActionResult Index()
        {

            UpdateLayout();


            // string datetime = DateTime.Now.ToString();


            dynamic LandingData = new ExpandoObject();
            LandingData.TopSellingProducts = GetData.GetTopSellingProducts();
            LandingData.FeaturedProducts = GetData.GetFeaturedProducts();

            string key = "HeaderCokiee";
            string value = DateTime.UtcNow.ToString("ddMMyyyyHHmmssFFFFF");

            var data = Request.Cookies[key];
            if (data == null)
            {
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Append("HeaderCokiee", value, options);
                RedirectToAction("index");

            }
            else
            {
               // ViewBag.IP = data;
            }

           









            return View(LandingData);
            
        }
       
       
     
        public IActionResult Trackorder(string ID)
        {

            UpdateLayout();


            // string datetime = DateTime.Now.ToString();


            dynamic LandingData = new ExpandoObject();
            List<OrderTrackingModel> OrderData= new List<OrderTrackingModel>();
            OrderData= GetData.GetOrderTrackingDetails(ID);
            LandingData.OrderTrackingDetails = OrderData;
            LandingData.FeaturedProducts = GetData.GetFeaturedProducts();
            ViewBag.TrackingDataAvailable = OrderData.Count;
            string key = "HeaderCokiee";
            string value = DateTime.UtcNow.ToString("ddMMyyyyHHmmssFFFFF");
            
            var data = Request.Cookies[key];
            if (data == null)
            {
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Append("HeaderCokiee", value, options);
                RedirectToAction("index");

            }
            else
            {
                //ViewBag.IP = data;
            }


            return View(LandingData);

        }

        [HttpPost]
        public IActionResult RegesterNewUser(
            string FullName, string FullAddress,
            string PhoneNumber, string Password,
            string District, string Area)
        {

            if (Account.PhoneNumberAvaliable(PhoneNumber))
            {




                TempData["error"] = "Please Login with your credentials";
                TempData["Header"] = "Number Already Exists";
                return RedirectToAction("index");

            }
            else
            {
                Account.AddNewUser(FullName, FullAddress, PhoneNumber, Password, District, Area);




                TempData["success"] = "User Created Succesfully.Please Login with your credentials";
                TempData["Header"] = "New User Created";
                return RedirectToAction("index");

            }

           

        }

        [HttpPost]
        public IActionResult RetrivePassword(string PhoneNumber)
        {


            Account.ForgetPassword(PhoneNumber);


           
            TempData["info"] = "Password Will send to your Registered Number" +
                "\n(If Number is Registered!!)";
            TempData["Header"] = "Request Accepted";

            return RedirectToAction("index");

        }
    
        public IActionResult Logout()
        {
            string key = "UserIDCokiee";
         
            
                Response.Cookies.Delete(key, new CookieOptions()
                {
                    Secure = true,
                });
            
            string key2 = "UserFullNameCokiee";
           

            
                Response.Cookies.Delete(key2, new CookieOptions()
                {
                    Secure = true,
                });
            

            string key3 = "UserFullAddressCokiee";
         
           
                Response.Cookies.Delete(key3, new CookieOptions()
                {
                    Secure = true,
                });
            

            string key4 = "UserAreaCokiee";
         
           
                Response.Cookies.Delete(key4, new CookieOptions()
                {
                    Secure = true,
                });
            string key5 = "UserPhoneNumberCokiee";
           
                Response.Cookies.Delete(key5, new CookieOptions()
                {
                    Secure = true,
                });
            string key6 = "UserDistrictCokiee";
          
                Response.Cookies.Delete(key6, new CookieOptions()
                {
                    Secure = true,
                });
           

            return RedirectToAction("index");
        }




        [HttpPost]
        public IActionResult LoginValidate(string PhoneNumber, string Password)
        {
            string name = "";

            List<UserModel> User = Account.LoginValidate(PhoneNumber, Password);

            if (User.Count()!=0)
            {
               

               
              
                string value = DateTime.UtcNow.ToString("ddMMyyyyHHmmssFFFFF");

                
                    
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddDays(2);

                foreach (UserModel user in User)
                {
                    string key = "UserIDCokiee";
                    var data = Request.Cookies[key];
                    if (data == null)
                    {
                       Response.Cookies.Append(key, user.ID, options);
                    }
                    else
                    {
                        Response.Cookies.Delete(key, new CookieOptions()
                        {
                            Secure = true,
                        });
                        Response.Cookies.Append(key, user.ID, options);
                    }

                    string key2 = "UserFullNameCokiee";
                    var data2 = Request.Cookies[key2];
                   
                    if (data2 == null)
                    {
                        Response.Cookies.Append(key2, user.FullName, options);
                        name = user.FullName;
                    }
                    else
                    {

                        Response.Cookies.Delete(key2, new CookieOptions()
                        {
                            Secure = true,
                        });
                        Response.Cookies.Append(key2, user.FullName, options);
                    }

                    string key3 = "UserFullAddressCokiee";
                    var data3 = Request.Cookies[key3];
                    if (data3 == null)
                    {
                        Response.Cookies.Append(key3, user.FullAddress, options);
                    }
                    else
                    {
                        Response.Cookies.Delete(key3, new CookieOptions()
                        {
                            Secure = true,
                        });
                        Response.Cookies.Append(key3, user.FullAddress, options);
                    }

                    string key4 = "UserAreaCokiee";
                    var data4 = Request.Cookies[key4];
                    if (data4 == null)
                    {
                        Response.Cookies.Append(key4, user.Area, options);
                    }
                    else
                    {
                        Response.Cookies.Delete(key4, new CookieOptions()
                        {
                            Secure = true,
                        });
                        Response.Cookies.Append(key4, user.Area, options);
                    }
                    string key5 = "UserPhoneNumberCokiee";
                    var data5 = Request.Cookies[key5];
                    if (data5 == null)
                    {
                        Response.Cookies.Append(key5, user.PhoneNumber, options);
                    }
                    else
                    {
                        Response.Cookies.Delete(key5, new CookieOptions()
                        {
                            Secure = true,
                        });
                        Response.Cookies.Append(key5, user.PhoneNumber, options);
                    }

                    string key6 = "UserDistrictCokiee";
                    var data6 = Request.Cookies[key6];
                    if (data6 == null)
                    {
                        Response.Cookies.Append(key6, user.District, options);
                    }
                    else
                    {
                        Response.Cookies.Delete(key6, new CookieOptions()
                        {
                            Secure = true,
                        });
                        Response.Cookies.Append(key6, user.District, options);
                    }
                }
               

                               
                

                






                TempData["success"] = "Welcome. "+name;
                TempData["Header"] = "Login Successfull";
                return RedirectToAction("index");
            }
            else
            {
                TempData["error"] = "Credentials Not Recognized";
                TempData["Header"] = "Login Unsuccessfull";
                return RedirectToAction("index");
            }

            




            

        }
    }
}
