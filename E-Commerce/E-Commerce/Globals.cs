 using E_Commerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.InteropServices;
using Ubiety.Dns.Core;
using Xamarin.Forms;

namespace E_Commerce
{
    public class Globals
    {
        public static string ConnectionString()
        {
            //  return "Data Source=DESKTOP-NQ6ENV1\\SQLEXPRESS; Initial Catalog=Cropshaat; User Id=Superadmin;Password=12345;";
            return "Data Source=103.108.140.160,1434;Initial Catalog=xylidic;User Id=charmless;password=G{m7TH,m%5zeHtVTcS{Sf]?LnG!3+";
        }



        public static string encryptString = DateTime.UtcNow.ToString("ddMMyyyyHHmmssFFFFF");
        public static List<Cart> GetCartData() {


            if (Cart.carts != null)
            {
                return Cart.carts;
            }
            else
            {
                return new List<Cart>();
            }
            


        }
       [ResponseCache(Duration = 120, Location = ResponseCacheLocation.Client)]
       
        public static string UserID()
        {


            return DateTime.UtcNow.ToString("ddMMyyyyHHmmssFFFFF"); 

        }

        public static List<Cart> cart { get; set; }

        public static void Addincart(Cart InputCart)
        {
            
            if (Cart.carts == null)
            {


                Cart.carts = new List<Cart>();
                Cart.carts.Add(InputCart);


            }
            else
            {
                Cart.carts.Add(InputCart);
               
            }


    


        }
      
      

        // public static List<Cart> cart = new List<Cart>();




        public static string GetWeightinWord(int gm)
        {
           
            string SolidWight;
           
            int div = 1000;
            decimal temp1;
            temp1 = (Decimal)gm / div;
            int KG_in_gm = (int)temp1;
            int gm_out_gm = (int)(((Decimal)temp1 - (int)KG_in_gm) * 1000);

            if (KG_in_gm > 0 && KG_in_gm < 1000)
            {
                SolidWight = KG_in_gm + " KG";
                return  SolidWight + " " + gm_out_gm + " GM ";


            }
           

            else if (KG_in_gm > 1000)
            {

                decimal temp2;
                temp2 = (Decimal)KG_in_gm / 1000;
                int Ton_in_KG = (int)temp2;
                int KG_out_KG = (int)(((Decimal)temp2 - (int)Ton_in_KG) * 1000);

                SolidWight = Ton_in_KG + " Ton " + KG_out_KG + " KG";
                return SolidWight + " " + gm_out_gm + " GM ";
               
            }

            else if (KG_in_gm == 0)
            {
                SolidWight = "";
                return SolidWight + " " + gm_out_gm + " GM ";

            }
            else
            {
                return "";
            }




        }
    }

    public static class PostData
    {
        public static void InsertSMSDetails(
            string csms_id,
            string sms,
            string msisdn,
            string sid,
            string Response,
            string System
            )
        {
            using (SqlConnection connec = new SqlConnection(Globals.ConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("insertSMSDetails", connec))
                {

                    connec.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                                       

                    cmd.Parameters.AddWithValue("@csms_id", csms_id);
                     cmd.Parameters.AddWithValue("@DateTime", DateTime.UtcNow.ToString());
                     cmd.Parameters.AddWithValue("@sms", sms);
                     cmd.Parameters.AddWithValue("@msisdn", msisdn);
                     cmd.Parameters.AddWithValue("@sid", sid);
                     cmd.Parameters.AddWithValue("@Response", Response);
                     cmd.Parameters.AddWithValue("@System", System);





                    cmd.ExecuteNonQuery();
                    // ID = cmd.ExecuteScalar().ToString();


                   
                    connec.Close();

                }

            }

        }



        public static void InsertOrderMasterTbl(
            string OrderID,
            string OrderDateTime,
            string CustomerID,
            string ShippingAddrName,
            string ShippingAddrPhnNum,
            string ShippingAddrAddress,
            string ShippingAddrDis,
            string ShippingAddrArea,
            string PaymentMode,
            string ShippingMethod,
            string Subtotal,
            string TotalWeight,
            string ShippingCharge,
            string GrandTotal,
            string PaidAmoint,
            string Due,
            string Status)
        {
            using (SqlConnection connec = new SqlConnection(Globals.ConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("insertOrderMasterTbl", connec))
                {

                    connec.Open();

                    cmd.CommandType = CommandType.StoredProcedure;


                     cmd.Parameters.AddWithValue("@OrderID", OrderID);
                     cmd.Parameters.AddWithValue("@OrderDateTime",OrderDateTime);
                     cmd.Parameters.AddWithValue("@CustomerID",CustomerID);
                     cmd.Parameters.AddWithValue("@ShippingAddrName",ShippingAddrName);
                     cmd.Parameters.AddWithValue("@ShippingAddrPhnNum",ShippingAddrPhnNum);
                     cmd.Parameters.AddWithValue("@ShippingAddrAddress",ShippingAddrAddress);
                     cmd.Parameters.AddWithValue("@ShippingAddrDis",ShippingAddrDis);
                     cmd.Parameters.AddWithValue("@ShippingAddrArea",ShippingAddrArea);
                     cmd.Parameters.AddWithValue("@PaymentMode",PaymentMode);
                     cmd.Parameters.AddWithValue("@ShippingMethod",ShippingMethod);
                     cmd.Parameters.AddWithValue("@Subtotal",Subtotal);
                     cmd.Parameters.AddWithValue("@TotalWeight",TotalWeight);
                     cmd.Parameters.AddWithValue("@ShippingCharge",ShippingCharge);
                     cmd.Parameters.AddWithValue("@GrandTotal",GrandTotal);
                     cmd.Parameters.AddWithValue("@PaidAmoint",PaidAmoint);
                     cmd.Parameters.AddWithValue("@Due",Due);
                     cmd.Parameters.AddWithValue("@Status",Status);




                    cmd.ExecuteNonQuery();
                    // ID = cmd.ExecuteScalar().ToString();



                    connec.Close();

                }

            }

        }






        public static void InsertOrderDetailsTable(
            string OrderID,
            string ProductID,
            string Rate,
            string Qty,
            string ProductSubTotal )
        {
            using (SqlConnection connec = new SqlConnection(Globals.ConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("insertOrderDetailsTable", connec))
                {

                    connec.Open();

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd.Parameters.AddWithValue("@ProductID", ProductID);
                    cmd.Parameters.AddWithValue("@Rate", Rate);
                    cmd.Parameters.AddWithValue("@Qty", Qty);
                    cmd.Parameters.AddWithValue("@SubTotal", ProductSubTotal);
                   




                    cmd.ExecuteNonQuery();
                    // ID = cmd.ExecuteScalar().ToString();



                    connec.Close();

                }

            }

        }







        public static void InsertOrderTrackingMaster(
           string OrderID,
           string OrderStatus,
           string StatusDiscriptions
           )
        {
            using (SqlConnection connec = new SqlConnection(Globals.ConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("insertOrderTrackingMaster", connec))
                {

                    connec.Open();

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd.Parameters.AddWithValue("@OrderStatus", OrderStatus);
                    cmd.Parameters.AddWithValue("@StatusDiscriptions", StatusDiscriptions);
                    cmd.Parameters.AddWithValue("@DateTime", DateTime.Now.ToString());
                   





                    cmd.ExecuteNonQuery();
                    // ID = cmd.ExecuteScalar().ToString();



                    connec.Close();

                }

            }

        }


    }


    public static class IPG
    {
        public static string CityBankBaseURL = "https://sandbox.thecitybank.com:7788/";
        public static string CityBankUserName = "test";
        public static string CityBankPassword = "123456Aa";

        public static string CityBankGetToken()
        {
            var url = CityBankBaseURL + "transaction/token";
            CitybankToken responce;
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "Post";

           


                string data = $@"{{
                                ""password"": ""{CityBankPassword}"",
                                ""userName"": ""{CityBankUserName}""
                               }}";


            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            // Pass the handler to httpclient(from you are calling api)
            HttpClient client = new HttpClient(clientHandler);

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                responce= JsonConvert.DeserializeObject<CitybankToken>(result);

                if (responce.responseCode != "100")
                {
                    System.Diagnostics.Debug.WriteLine("Error! didn't got 100");
                    CityBankGetToken();

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine(responce.transactionId);
                   
                }
            }


            return responce.transactionId;
        }
    }

    public static class SMS
    {

       public static string sid = "CROPSHAATOTP";

       public static string api_token = "joj7wxwu-ms9xqu4n-equ2egn7-q0m7ytda-tkjf4vi2";

       public static string sms_url = "https://smsplus.sslwireless.com/api/v3/send-sms?";
        public static void SendQuickSms(string msisdn, string sms)
        {
            string csms_id = DateTime.UtcNow.ToString("ddMMyyyyHHmmssFFFFF");
            string myParameters = "api_token=" + api_token +
           "&msisdn=" + msisdn + "&sms=" + System.Web.HttpUtility.UrlEncode(sms) +
           "&csms_id=" + csms_id + "&sid=" + sid;
             
              HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sms_url +
             myParameters);
            request.AutomaticDecompression = DecompressionMethods.GZip;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
               var resp = reader.ReadToEnd();
                PostData.InsertSMSDetails(csms_id,sms, msisdn, sid, resp, "Web");
                
            }
           
        }

        public static void SendQuickSmsAdmin(string sms)
        {
            SendQuickSms("01869666755", sms);
            SendQuickSms("01709816108", sms);
        }
    }
    public class Account
    {
        public static void AddNewUser(
            string FullName, string FullAddress,
            string PhoneNumber, string Password,
            string District, string Area)
        {
            using (SqlConnection connec = new SqlConnection(Globals.ConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("insert_UserDetails", connec))
                {

                    connec.Open();

                    cmd.CommandType = CommandType.StoredProcedure;




                    cmd.Parameters.AddWithValue("@ID       ", DateTime.UtcNow.ToString("ddMMyyyyHHmmssFFFFF"));

                    cmd.Parameters.AddWithValue("@FullName   ", FullName);
                    cmd.Parameters.AddWithValue("@FullAddress   ", FullAddress);

                    cmd.Parameters.AddWithValue("@PhoneNumber          ", PhoneNumber);

                    cmd.Parameters.AddWithValue("@Password      ", Password);
                    cmd.Parameters.AddWithValue("@District      ", District);
                    cmd.Parameters.AddWithValue("@Area      ", Area);





                    cmd.ExecuteNonQuery();
                    // ID = cmd.ExecuteScalar().ToString();


                    string msgString = "Welcome "+ FullName + ",\nYour account is Successfully Created in Crops Haat. \nYour Password is: " 
                        + Password+" (Please Do Not Share the password With anyone.)";
                    SMS.SendQuickSms(PhoneNumber, msgString);
                    connec.Close();

                }

            }
        }

        public static void ForgetPassword(string PhoneNumber)
        {
            string count = "";
            using (SqlConnection con = new SqlConnection(Globals.ConnectionString()))
            {
                // MessageBox.Show("SELECT ProductName FROM Products WHERE ProductName like  '" + SearchString + "'");
                using (SqlCommand cmd = new SqlCommand("SELECT[Password] FROM [xylidic].[dbo].[UserDetails] where [PhoneNumber]='"+ PhoneNumber + "'", con))
                {
                    con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        count = sdr.GetValue(0).ToString();

                        string msgString = "Your Password is: "+ count +"\nRegards,\nCrops Haat";
                        SMS.SendQuickSms(PhoneNumber, msgString);
                    }
                    else
                    {
                        count = "";
                    }

                }
            }
           
        }
        public static bool PhoneNumberAvaliable(string PhoneNumber)
        {
            string count = "";
            using (SqlConnection con = new SqlConnection(Globals.ConnectionString()))
            {
                // MessageBox.Show("SELECT ProductName FROM Products WHERE ProductName like  '" + SearchString + "'");
                using (SqlCommand cmd = new SqlCommand("SELECT[Password] FROM [xylidic].[dbo].[UserDetails] where [PhoneNumber]='" + PhoneNumber + "'", con))
                {
                    con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                       return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }

        }

        public static List<UserModel> LoginValidate(string PhoneNumber, string Password)
        {
            string Responce = "";
            using (SqlConnection con = new SqlConnection(Globals.ConnectionString()))
            {
                // MessageBox.Show("SELECT ProductName FROM Products WHERE ProductName like  '" + SearchString + "'");
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [xylidic].[dbo].[UserDetails] where [PhoneNumber]='" + PhoneNumber + "' and [Password]='"+Password+"'", con))
                {
                    con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();
                  
                    if (sdr.Read())
                    {
                        con.Close();
                        con.Open();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "DataTable1");
                        con.Close();

                        DataTable dt = ds.Tables["DataTable1"];

                        
                        List<UserModel> User = new List<UserModel>();

                        return User = (from DataRow dr in dt.Rows
                                           select new UserModel()
                                           {
                                               ID = dr["ID"].ToString(),
                                               FullName = dr["FullName"].ToString(),
                                               FullAddress = dr["FullAddress"].ToString(),
                                               PhoneNumber = dr["PhoneNumber"].ToString(),
                                               District = dr["District"].ToString(),
                                               Area = dr["Area"].ToString()                                            

                                           }).ToList();
                    }
                    else
                    {
                        return new List<UserModel>();
                    }

                }
            }

        }
    }
    public class GetData
    {
        public static int allProductCount(string SearchKey)
        {
            int count = 0;
            using (SqlConnection con = new SqlConnection(Globals.ConnectionString()))
            {
                // MessageBox.Show("SELECT ProductName FROM Products WHERE ProductName like  '" + SearchString + "'");
                using (SqlCommand cmd = new SqlCommand("SELECT Count(*)  FROM [dbo].[ProductDetailsCatagory] where [ProductName] like  '%" + SearchKey + "%' OR [MainCategory] like  '%" + SearchKey + "%'  OR [Catagory] like  '%" + SearchKey + "%'  OR [Catagory] like  '%" + SearchKey + "%'", con))
                {
                    con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        count =Convert.ToInt32(sdr.GetValue(0).ToString());
                    }
                    else
                    {
                        count = 0;
                    }

                }
            }
            return count;
        }

        public static List<ProductDetailsModel> GridViewProducts(string SearchKey, int Skip, int NextLoad)
        {
            using (SqlConnection con = new SqlConnection(Globals.ConnectionString()))
            {
                // MessageBox.Show("SELECT ProductName FROM Products WHERE ProductName like  '" + SearchString + "'");
                using (SqlCommand cmd = new SqlCommand("SELECT  *  FROM [dbo].[ProductDetailsCatagory]  where [IsAvailableStockl]='1' order by MarketPrice OFFSET (" + Skip + ") ROWS FETCH NEXT (" + NextLoad + ") ROWS ONLY", con))
                {
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DataTable1");
                    con.Close();

                    DataTable dt = ds.Tables["DataTable1"];


                    List<ProductDetailsModel> productdetails = new List<ProductDetailsModel>();

                    return productdetails = (from DataRow dr in dt.Rows
                                             select new ProductDetailsModel()
                                             {

                                                 //StudentName = dr["StudentName"].ToString(),
                                                 //Address = dr["Address"].ToString(),
                                                 //MobileNo = dr["MobileNo"].ToString()

                                                 ProductId = dr["ProductId"].ToString(),
                                                 ProductName = dr["ProductName"].ToString(),
                                                 SubCatagory = dr["Catagory"].ToString(),
                                                 ReviewRating = dr["Rating"].ToString(),
                                                 SKUColor = dr["SKUColor"].ToString(),
                                                 SKUSize = dr["SKUSize"].ToString(),
                                                 SKUWeight = dr["SKUWeight"].ToString(),
                                                 ShortDetails = dr["ShortDetails"].ToString(),
                                                 Description = dr["Description"].ToString(),
                                                 MarketPrice = Convert.ToDecimal(dr["MarketPrice"].ToString()),
                                                 DiscountRatio = Convert.ToDecimal(dr["DiscountRatio"].ToString()),
                                                 HaatPrice = Convert.ToDecimal(dr["HaatPrice"].ToString()),
                                                 Supplier = dr["Supplier"].ToString(),
                                                 FeatureProduct = dr["FeatureProduct"].ToString(),
                                                 TopSellingProduct = dr["TopSellingProduct"].ToString(),
                                                 IsAvailableStockl = dr["IsAvailableStockl"].ToString(),
                                                 Origin = dr["Origin"].ToString(),
                                                 MainCatagory = dr["MainCategory"].ToString()


                                             }).ToList();




                }
            }




        }

        public static List<ProductDetailsModel> GridViewSearchProducts(string SearchKey, int Skip, int NextLoad)
        {
            using (SqlConnection con = new SqlConnection(Globals.ConnectionString()))
            {
                // MessageBox.Show("SELECT ProductName FROM Products WHERE ProductName like  '" + SearchString + "'");
                using (SqlCommand cmd = new SqlCommand("SELECT  *  FROM [dbo].[ProductDetailsCatagory]  where [ProductName] like  '%" + SearchKey + "%' OR [MainCategory] like  '%" + SearchKey + "%'  OR [Catagory] like  '%" + SearchKey + "%'  OR [Catagory] like  '%" + SearchKey + "%'order by MarketPrice OFFSET (" + Skip + ") ROWS FETCH NEXT (" + NextLoad + ") ROWS ONLY", con))
                {
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DataTable1");
                    con.Close();

                    DataTable dt = ds.Tables["DataTable1"];


                    List<ProductDetailsModel> productdetails = new List<ProductDetailsModel>();

                    return productdetails = (from DataRow dr in dt.Rows
                                             select new ProductDetailsModel()
                                             {

                                                 //StudentName = dr["StudentName"].ToString(),
                                                 //Address = dr["Address"].ToString(),
                                                 //MobileNo = dr["MobileNo"].ToString()

                                                 ProductId = dr["ProductId"].ToString(),
                                                 ProductName = dr["ProductName"].ToString(),
                                                 SubCatagory = dr["Catagory"].ToString(),
                                                 ReviewRating = dr["Rating"].ToString(),
                                                 SKUColor = dr["SKUColor"].ToString(),
                                                 SKUSize = dr["SKUSize"].ToString(),
                                                 SKUWeight = dr["SKUWeight"].ToString(),
                                                 ShortDetails = dr["ShortDetails"].ToString(),
                                                 Description = dr["Description"].ToString(),
                                                 MarketPrice = Convert.ToDecimal(dr["MarketPrice"].ToString()),
                                                 DiscountRatio = Convert.ToDecimal(dr["DiscountRatio"].ToString()),
                                                 HaatPrice = Convert.ToDecimal(dr["HaatPrice"].ToString()),
                                                 Supplier = dr["Supplier"].ToString(),
                                                 FeatureProduct = dr["FeatureProduct"].ToString(),
                                                 TopSellingProduct = dr["TopSellingProduct"].ToString(),
                                                 IsAvailableStockl = dr["IsAvailableStockl"].ToString(),
                                                 Origin = dr["Origin"].ToString(),
                                                 MainCatagory = dr["MainCategory"].ToString()


                                             }).ToList();




                }
            }




        }














        public static List<ProductsModel> GetTopSellingProducts()
        {
            using (SqlConnection con = new SqlConnection(Globals.ConnectionString()))
            {
                // MessageBox.Show("SELECT ProductName FROM Products WHERE ProductName like  '" + SearchString + "'");
                using (SqlCommand cmd = new SqlCommand("SELECT TOP (8) *  FROM [dbo].[ProductTable]  where [TopSellingProduct]='1'", con))
                {
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DataTable1");
                    con.Close();

                    DataTable dt = ds.Tables["DataTable1"];



                    List<ProductsModel> products = new List<ProductsModel>();

                    return products = (from DataRow dr in dt.Rows
                                       select new ProductsModel()
                                       {

                                           //StudentName = dr["StudentName"].ToString(),
                                           //Address = dr["Address"].ToString(),
                                           //MobileNo = dr["MobileNo"].ToString()

                                           ProductId = dr["ProductId"].ToString(),
                                           ProductName = dr["ProductName"].ToString(),
                                           Catagory = dr["Catagory"].ToString(),
                                           SKUColor = dr["SKUColor"].ToString(),
                                           SKUSize = dr["SKUSize"].ToString(),
                                           SKUWeight = dr["SKUWeight"].ToString(),
                                           Rating = dr["Rating"].ToString(),

                                           ShortDetails = dr["ShortDetails"].ToString(),
                                           Description = dr["Description"].ToString(),

                                          
                                           MarketPrice = Convert.ToDecimal(dr["MarketPrice"].ToString()),
                                           DiscountRatio = Convert.ToDecimal(dr["DiscountRatio"].ToString()),
                                           HaatPrice = Convert.ToDecimal(dr["HaatPrice"].ToString()),
                                           Supplier = dr["Supplier"].ToString(),

                                           FeatureProduct = dr["FeatureProduct"].ToString(),
                                           TopSellingProduct = dr["TopSellingProduct"].ToString(),
                                           IsAvailableStockl = dr["IsAvailableStockl"].ToString(),
                                           Origin = dr["Origin"].ToString()


                                       }).ToList();

                    


                }
            }




        }




        public static List<ProductsModel> GetRecomendedProducts(string category)
        {
            using (SqlConnection con = new SqlConnection(Globals.ConnectionString()))
            {
                // MessageBox.Show("SELECT ProductName FROM Products WHERE ProductName like  '" + SearchString + "'");
                using (SqlCommand cmd = new SqlCommand("SELECT TOP (8) *  FROM [dbo].[ProductTable]  where [Catagory]='"+category+"'", con))
                {
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DataTable1");
                    con.Close();

                    DataTable dt = ds.Tables["DataTable1"];



                    List<ProductsModel> products = new List<ProductsModel>();

                    return products = (from DataRow dr in dt.Rows
                                       select new ProductsModel()
                                       {

                                           //StudentName = dr["StudentName"].ToString(),
                                           //Address = dr["Address"].ToString(),
                                           //MobileNo = dr["MobileNo"].ToString()

                                           ProductId = dr["ProductId"].ToString(),
                                           ProductName = dr["ProductName"].ToString(),
                                           Catagory = dr["Catagory"].ToString(),
                                           SKUColor = dr["SKUColor"].ToString(),
                                           SKUSize = dr["SKUSize"].ToString(),
                                           SKUWeight = dr["SKUWeight"].ToString(),
                                           Rating = dr["Rating"].ToString(),

                                           ShortDetails = dr["ShortDetails"].ToString(),
                                           Description = dr["Description"].ToString(),


                                           MarketPrice = Convert.ToDecimal(dr["MarketPrice"].ToString()),
                                           DiscountRatio = Convert.ToDecimal(dr["DiscountRatio"].ToString()),
                                           HaatPrice = Convert.ToDecimal(dr["HaatPrice"].ToString()),
                                           Supplier = dr["Supplier"].ToString(),

                                           FeatureProduct = dr["FeatureProduct"].ToString(),
                                           TopSellingProduct = dr["TopSellingProduct"].ToString(),
                                           IsAvailableStockl = dr["IsAvailableStockl"].ToString(),
                                           Origin = dr["Origin"].ToString()


                                       }).ToList();




                }
            }




        }





        public static List<OrderTrackingModel> GetOrderTrackingDetails(string OrderID)
        {
            
            using (SqlConnection con = new SqlConnection(Globals.ConnectionString()))
            {
                // MessageBox.Show("SELECT ProductName FROM Products WHERE ProductName like  '" + SearchString + "'");
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM [xylidic].[dbo].[OrderTrackingMaster] where [OrderID]='"+ OrderID + "' order by [DateTime]", con))
                {
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DataTable1");
                    con.Close();

                    DataTable dt = ds.Tables["DataTable1"];



                    List<OrderTrackingModel> OrderTrackingModel = new List<OrderTrackingModel>();

                    return OrderTrackingModel = (from DataRow dr in dt.Rows
                                       select new OrderTrackingModel()
                                       {

                                           //StudentName = dr["StudentName"].ToString(),
                                           //Address = dr["Address"].ToString(),
                                           //MobileNo = dr["MobileNo"].ToString()

                                           ID = dr["ID"].ToString(),
                                           OrderID = dr["OrderID"].ToString(),
                                           OrderStatus = dr["OrderStatus"].ToString(),
                                           StatusDiscriptions = dr["StatusDiscriptions"].ToString(),
                                           DateTime = dr["DateTime"].ToString()
                                           


                                       }).ToList();




                }
            }




        }






        List<ProductSKUSize> sKUSizes = new List<ProductSKUSize>();
        public static List<ProductSKUSize> GetQtyDropData()
        {
            List<ProductSKUSize> sKUSizes = new List<ProductSKUSize>();
            
            for (int i = 500; i <= 5000000;)
            {
                sKUSizes.Add(new ProductSKUSize()
                {
                    Text = Globals.GetWeightinWord(i),
                    Value = i

                }) ;


                i = i + 500;
            }
            return sKUSizes;
        }
        List<Cart> cart = new List<Cart>();
      
        public static int CartData()
        {
           

            return 0;
        }


        public static List<ProductsModel> GetFeaturedProducts()
        {
            using (SqlConnection con = new SqlConnection(Globals.ConnectionString()))
            {
                // MessageBox.Show("SELECT ProductName FROM Products WHERE ProductName like  '" + SearchString + "'");
                using (SqlCommand cmd = new SqlCommand("SELECT TOP (8) *  FROM [dbo].[ProductTable]  where [FeatureProduct]='1'", con))
                {
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DataTable1");
                    con.Close();

                    DataTable dt = ds.Tables["DataTable1"];



                    List<ProductsModel> products = new List<ProductsModel>();

                    return products = (from DataRow dr in dt.Rows
                                       select new ProductsModel()
                                       {

                                           //StudentName = dr["StudentName"].ToString(),
                                           //Address = dr["Address"].ToString(),
                                           //MobileNo = dr["MobileNo"].ToString()

                                           ProductId = dr["ProductId"].ToString(),
                                           ProductName = dr["ProductName"].ToString(),
                                           Catagory = dr["Catagory"].ToString(),
                                           SKUColor = dr["SKUColor"].ToString(),
                                           SKUSize = dr["SKUSize"].ToString(),
                                           SKUWeight = dr["SKUWeight"].ToString(),
                                           Rating= dr["Rating"].ToString(),

                                           ShortDetails = dr["ShortDetails"].ToString(),
                                           Description = dr["Description"].ToString(),


                                           MarketPrice = Convert.ToDecimal(dr["MarketPrice"].ToString()),
                                           DiscountRatio = Convert.ToDecimal(dr["DiscountRatio"].ToString()),
                                           HaatPrice = Convert.ToDecimal(dr["HaatPrice"].ToString()),
                                           Supplier = dr["Supplier"].ToString(),

                                           FeatureProduct = dr["FeatureProduct"].ToString(),
                                           TopSellingProduct = dr["TopSellingProduct"].ToString(),
                                           IsAvailableStockl = dr["IsAvailableStockl"].ToString(),
                                           Origin = dr["Origin"].ToString()


                                       }).ToList();




                }
            }
        }

        public static List<ProductDetailsModel> GetProductdetails(string ProductID)
        {
            using (SqlConnection con = new SqlConnection(Globals.ConnectionString()))
            {
                // MessageBox.Show("SELECT ProductName FROM Products WHERE ProductName like  '" + SearchString + "'");
                using (SqlCommand cmd = new SqlCommand("SELECT TOP (1) *  FROM [dbo].[ProductDetailsCatagory]  where [ProductID]='" + ProductID + "'", con))
                {
                    con.Open();

                    SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2, "DataTable2");
                    con.Close();

                    DataTable dt = ds2.Tables["DataTable2"];



                    List<ProductDetailsModel> productdetails = new List<ProductDetailsModel>();

                    return productdetails = (from DataRow dr in dt.Rows
                                       select new ProductDetailsModel()
                                       {

                                           //StudentName = dr["StudentName"].ToString(),
                                           //Address = dr["Address"].ToString(),
                                           //MobileNo = dr["MobileNo"].ToString()

                                           ProductId = dr["ProductId"].ToString(),
                                           ProductName = dr["ProductName"].ToString(),
                                           SubCatagory = dr["Catagory"].ToString(),
                                           ReviewRating = dr["Rating"].ToString(),
                                           SKUColor = dr["SKUColor"].ToString(),
                                           SKUSize = dr["SKUSize"].ToString(),
                                           SKUWeight = dr["SKUWeight"].ToString(),
                                           ShortDetails = dr["ShortDetails"].ToString(),
                                           Description = dr["Description"].ToString(),
                                           MarketPrice = Convert.ToDecimal(dr["MarketPrice"].ToString()),
                                           DiscountRatio = Convert.ToDecimal(dr["DiscountRatio"].ToString()),
                                           HaatPrice = Convert.ToDecimal(dr["HaatPrice"].ToString()),
                                           Supplier = dr["Supplier"].ToString(),
                                           FeatureProduct = dr["FeatureProduct"].ToString(),
                                           TopSellingProduct = dr["TopSellingProduct"].ToString(),
                                           IsAvailableStockl = dr["IsAvailableStockl"].ToString(),
                                           Origin = dr["Origin"].ToString(),
                                           MainCatagory = dr["MainCategory"].ToString()


                                       }).ToList();




                }
            }

        }
        public static List<ProductCetegory> GetProductSubCategory(string MainCategory)
        {
            using (SqlConnection con = new SqlConnection(Globals.ConnectionString()))
            {
                // MessageBox.Show("SELECT ProductName FROM Products WHERE ProductName like  '" + SearchString + "'");
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM [dbo].[ProductcetagoryTable] where [MainCategory]='" + MainCategory + "'", con))
                {
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DataTable1");
                    con.Close();

                    DataTable dt = ds.Tables["DataTable1"];



                    List<ProductCetegory> ProductCetegory = new List<ProductCetegory>();

                    return ProductCetegory = (from DataRow dr in dt.Rows
                                               select new ProductCetegory()
                                               {

                                                   //StudentName = dr["StudentName"].ToString(),
                                                   //Address = dr["Address"].ToString(),
                                                   //MobileNo = dr["MobileNo"].ToString()

                                                   ID = Convert.ToInt32(dr["ID"].ToString()),
                                                   MainCategory = dr["MainCategory"].ToString(),
                                                   SubCategory = dr["SubCategory"].ToString(),
                                          


                                               }).ToList();




                }
            }
        }


        public static List<ProductReviewModel> GetProductReviwes(string ID)
        {
            using (SqlConnection con = new SqlConnection(Globals.ConnectionString()))
            {
                // MessageBox.Show("SELECT ProductName FROM Products WHERE ProductName like  '" + SearchString + "'");
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM [dbo].[ReviewTable] where [ProductID]='" + ID + "'", con))
                {
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DataTable1");
                    con.Close();

                    DataTable dt = ds.Tables["DataTable1"];



                    List<ProductReviewModel> ProductCetegory = new List<ProductReviewModel>();

                    return ProductCetegory = (from DataRow dr in dt.Rows
                                              select new ProductReviewModel()
                                              {

                                                  //StudentName = dr["StudentName"].ToString(),
                                                  //Address = dr["Address"].ToString(),
                                                  //MobileNo = dr["MobileNo"].ToString()

                                                  ID = Convert.ToInt32(dr["ID"].ToString()),
                                                  ProductID = dr["ProductID"].ToString(),
                                                  OrderNumber = dr["OrderNumber"].ToString(),
                                                  Rating = dr["Rating"].ToString(),
                                                  Time = dr["Time"].ToString(),
                                                  Title = dr["Title"].ToString(),
                                                  Body = dr["Body"].ToString()



                                              }).ToList();


                   

                }
            }
        }
    }



   
}
