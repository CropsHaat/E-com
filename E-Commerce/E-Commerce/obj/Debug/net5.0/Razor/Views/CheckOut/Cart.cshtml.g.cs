#pragma checksum "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ff908ee6c639c53247253699e6f57f2575af0c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CheckOut_Cart), @"mvc.1.0.view", @"/Views/CheckOut/Cart.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\_ViewImports.cshtml"
using E_Commerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\_ViewImports.cshtml"
using E_Commerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ff908ee6c639c53247253699e6f57f2575af0c4", @"/Views/CheckOut/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f015392c42bf201d3f4fa8f785de821ea8cb926", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CheckOut_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("lazy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_1 gray"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_1 full-width cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

		<div class=""container margin_30"">
		<div class=""page_header"">
			<div class=""breadcrumbs"">
				<ul>
					<li><a href=""#"">Home</a></li>
					<li><a href=""#"">CheckOut</a></li>
					<li>Cart</li>
				</ul>
			</div>
			<h1>Cart page</h1>
		</div>
		<!-- /page_header -->
		<table class=""table table-striped cart-list"">
							<thead>
								<tr>
									<th>
										<b>Product</b>
									</th>
									<th>
										<b>Price</b>
										
									</th>
									<th>
										<b>Quantity</b>
										
									</th>
									<th>
										<b>Subtotal</b>
										
									</th>
									<th>
										
									</th>
								</tr>
							</thead>
							<tbody>

");
#nullable restore
#line 44 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
                                 if ( ViewBag.ItemCount<1)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n\t\t\t\t\t\t\t\t\t<td colspan=\"4\">\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t<span >No Product in Cart</span>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 51 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
									
							
								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
                                 foreach(Cart cart in Model.CartDetails){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"thumb_cart\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3ff908ee6c639c53247253699e6f57f2575af0c47610", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1115, "~/img/products/", 1115, 15, true);
#nullable restore
#line 59 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
AddHtmlAttributeValue("", 1130, cart.ProductId, 1130, 15, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 1145, "Bowl.png", 1146, 9, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"item_cart\">");
#nullable restore
#line 61 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
                                                           Write(cart.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t<input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 1322, "\"", 1347, 2);
#nullable restore
#line 64 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
WriteAttributeValue("", 1327, cart.ProductId, 1327, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1342, "Rate", 1343, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1348, "\"", 1366, 1);
#nullable restore
#line 64 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
WriteAttributeValue("", 1356, cart.Rate, 1356, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t<strong  >৳ ");
#nullable restore
#line 65 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
                                               Write(cart.Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\r\n\t\t\t\t\t\t\t\t\t\t<input type=\"text\"");
            BeginWriteAttribute("onchange", " onchange=\"", 1474, "\"", 1521, 2);
#nullable restore
#line 69 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
WriteAttributeValue("", 1485, cart.ProductId+"Qtychanged", 1485, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1515, "(this)", 1515, 6, true);
            EndWriteAttribute();
            WriteLiteral(" runat=\"server\"");
            BeginWriteAttribute("value", " value=\"", 1537, "\"", 1554, 1);
#nullable restore
#line 69 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
WriteAttributeValue("", 1545, cart.Qty, 1545, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1555, "\"", 1579, 2);
#nullable restore
#line 69 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
WriteAttributeValue("", 1560, cart.ProductId, 1560, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1575, "Qty", 1576, 4, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1580, "\"", 1606, 2);
#nullable restore
#line 69 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
WriteAttributeValue("", 1587, cart.ProductId, 1587, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1602, "Qty", 1603, 4, true);
            EndWriteAttribute();
            WriteLiteral("class=\"form-control\">\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t<strong");
            BeginWriteAttribute("id", " id=\"", 1690, "\"", 1719, 2);
#nullable restore
#line 73 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
WriteAttributeValue("", 1695, cart.ProductId, 1695, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1710, "Subtotal", 1711, 9, true);
            EndWriteAttribute();
            WriteLiteral("  runat=\"server\">৳ ");
#nullable restore
#line 73 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
                                                                                           Write(cart.Subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td class=\"options\">\r\n\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("onclick", " onclick=\"", 1823, "\"", 1865, 2);
#nullable restore
#line 76 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
WriteAttributeValue("", 1833, cart.ProductId+"Remove", 1833, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1859, "(this)", 1859, 6, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn_1 outline\"");
            BeginWriteAttribute("href", " href=\"", 1902, "\"", 1973, 1);
#nullable restore
#line 76 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
WriteAttributeValue("", 1909, Url.Action("DeleteFromCart","CheckOut",new{id=@cart.ProductId}), 1909, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"ti-trash\"></i></a>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n");
            WriteLiteral("\t\t\t\t\t\t\t <script type=\"text/javascript\">\r\n\r\n\r\n\t\t\t\t\t\t\t\t \tfunction ");
#nullable restore
#line 83 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
                                          Write(cart.ProductId+"Remove");

#line default
#line hidden
#nullable disable
            WriteLiteral("() {\r\n\t\t\t\t\t\t\t\t\t\t$.post(");
#nullable restore
#line 84 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
                                          Write(Url.Action("DeleteFromCart","CheckOut",new{id=@cart.ProductId}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@")
											.done(function(data){
												
											}).fail(function(e,f,g){
											   console.log({e:e,f:f,g:g})
										  });
										
										} 

										</script>
								<script type=""text/javascript"">

									
									function ");
#nullable restore
#line 97 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
                                         Write(cart.ProductId+"Qtychanged");

#line default
#line hidden
#nullable disable
            WriteLiteral("(txt) {\r\n\t\t\t\t\t\t\t\t\t\tvar qty = document.getElementById(\'");
#nullable restore
#line 98 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
                                                                      Write(cart.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Qty\').value;\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\tvar Rate = document.getElementById(\'");
#nullable restore
#line 100 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
                                                                       Write(cart.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Rate\').value;\r\n\t\t\t\t\t\t\t\t\t\tdocument.getElementById(\'");
#nullable restore
#line 101 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
                                                            Write(cart.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Subtotal\').innerHTML =\"৳ \"+parseFloat(Rate) * parseFloat(qty)+\".00\";\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\r\n");
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t$.post(\"");
#nullable restore
#line 114 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
                                           Write(Url.Action("cart","Checkout",new{id=@cart.ProductId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("?quantity=\"+qty)\r\n\t\t\t\t\t\t\t\t\t\t\t.done(function(data){\r\n\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t}).fail(function(e,f,g){\r\n\t\t\t\t\t\t\t\t\t\t\t   console.log({e:e,f:f,g:g})\r\n\t\t\t\t\t\t\t\t\t\t  });\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t} \r\n\r\n\t\t\t\t\t\t\t\t\t\t</script>\r\n");
#nullable restore
#line 124 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
								
								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\r\n\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\r\n");
            WriteLiteral("\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\r\n\t\t\t\t\t\t<div class=\"row add_top_30 flex-sm-row-reverse cart_actions\">\r\n\t\t\t\t\t\t<div class=\"col-sm-4 text-end\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ff908ee6c639c53247253699e6f57f2575af0c418356", async() => {
                WriteLiteral("Update Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t<div class=\"apply-coupon\">\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"row g-2\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-md-6\"><input type=\"text\" name=\"coupon-code\"");
            BeginWriteAttribute("value", " value=\"", 4744, "\"", 4752, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Promo code"" class=""form-control""></div>
										<div class=""col-md-4""><button type=""button"" class=""btn_1 outline"">Apply Coupon</button></div>
									</div>
								</div>
							</div>
						</div>
					</div>
					<!-- /cart_actions -->
	
		</div>
		<!-- /container -->
		
		<div class=""box_cart"">
			<div class=""container"">
			<div class=""row justify-content-end"">
				<div class=""col-xl-4 col-lg-4 col-md-6"">
			<ul>
				<li>
					<span>Subtotal</span> ৳ ");
#nullable restore
#line 183 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
                                       Write(ViewBag.Subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</li>\r\n\t\t\t\t<li>\r\n\t\t\t\t\t<span>Total Weight</span> ");
#nullable restore
#line 186 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
                                         Write(ViewBag.TotalWeight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" KG\r\n\t\t\t\t</li>\r\n\t\t\t\t<li>\r\n\t\t\t\t\t<span>Special Discount</span> ৳ 0.00\r\n\t\t\t\t</li>\r\n\t\t\t\t<li>\r\n\t\t\t\t\t<span>Grand Total</span> ৳ ");
#nullable restore
#line 192 "D:\DEVELOPMENT\CropsHaat\E-Commerce\E-Commerce\E-Commerce\Views\CheckOut\Cart.cshtml"
                                          Write(ViewBag.Grandtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</li>\r\n\t\t\t</ul>\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ff908ee6c639c53247253699e6f57f2575af0c421839", async() => {
                WriteLiteral("Proceed to Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<!-- /box_cart -->\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591