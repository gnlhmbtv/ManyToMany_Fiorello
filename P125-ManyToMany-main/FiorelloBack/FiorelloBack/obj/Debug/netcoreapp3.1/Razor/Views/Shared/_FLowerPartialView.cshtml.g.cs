#pragma checksum "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c8bedac1deb374dd2ba717885f16d2185e7258d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FLowerPartialView), @"mvc.1.0.view", @"/Views/Shared/_FLowerPartialView.cshtml")]
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
#line 1 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\_ViewImports.cshtml"
using FiorelloBack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\_ViewImports.cshtml"
using FiorelloBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\_ViewImports.cshtml"
using FiorelloBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8bedac1deb374dd2ba717885f16d2185e7258d", @"/Views/Shared/_FLowerPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13b0eb7506d954a10f5093c41afae51b8a5a7022", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FLowerPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Flower>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Flower", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
 foreach (var flower in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div data-aos-offset=\"100\"");
            BeginWriteAttribute("class", "\n         class=\"", 84, "\"", 346, 5);
            WriteAttributeValue("", 101, "product", 101, 7, true);
            WriteAttributeValue(" ", 108, "col-lg-3", 109, 9, true);
            WriteAttributeValue(" ", 117, "col-md-6", 118, 9, true);
            WriteAttributeValue("\n                     ", 126, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 7 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
                      foreach (var flowerCategory in flower.FlowerCategories)
                     {
                         

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
                     Write(flowerCategory.Category.Name.ToLower()+" ");

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
                                                                      
                     }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 148, 174, false);
            WriteAttributeValue("                     ", 322, "all", 343, 24, true);
            EndWriteAttribute();
            WriteLiteral(">\n        <div class=\"productImage\">\n");
#nullable restore
#line 13 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
             foreach (var image in flower.FlowerImages)
            {
                if (image.IsMain && image.Image.Contains("https://"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c8bedac1deb374dd2ba717885f16d2185e7258d6819", async() => {
                WriteLiteral("\n                        <img");
                BeginWriteAttribute("src", " src=\"", 741, "\"", 759, 1);
#nullable restore
#line 18 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
WriteAttributeValue("", 747, image.Image, 747, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 760, "\"", 766, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
                                                                      WriteLiteral(flower.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
                                                                                                        WriteLiteral(flower.FlowerCategories.FirstOrDefault().CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 20 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
                }
                if (image.IsMain)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c8bedac1deb374dd2ba717885f16d2185e7258d10958", async() => {
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1c8bedac1deb374dd2ba717885f16d2185e7258d11236", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1069, "~/assets/images/", 1069, 16, true);
#nullable restore
#line 24 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
AddHtmlAttributeValue("", 1085, image.Image, 1085, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
                                                                      WriteLiteral(flower.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
                                                                                                        WriteLiteral(flower.FlowerCategories.FirstOrDefault().CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 26 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        </div>\n        <div class=\"productTitle\">\n            <p>");
#nullable restore
#line 33 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
          Write(flower.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n        <div class=\"productPrice\">\n");
#nullable restore
#line 36 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
             if (flower.CampaignId == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"addToCardBtn\" data-id=\"");
#nullable restore
#line 38 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
                                               Write(flower.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Add to cart</span><span>$</span><span>");
#nullable restore
#line 38 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
                                                                                                 Write(flower.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 39 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"addToCardBtn\" data-id=\"5\">Add to cart</span> <span style=\"text-decoration: line-through;\">");
#nullable restore
#line 42 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
                                                                                                                  Write(flower.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                <span>$</span><span>");
#nullable restore
#line 43 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
                                Write(flower.Price*(100-flower.Campaign.Dicount)/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 44 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"addToCart\">\n\n        </div>\n\n    </div>\n");
#nullable restore
#line 52 "C:\Users\user\Desktop\P125-ManyToMany-main\FiorelloBack\FiorelloBack\Views\Shared\_FLowerPartialView.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Flower>> Html { get; private set; }
    }
}
#pragma warning restore 1591
