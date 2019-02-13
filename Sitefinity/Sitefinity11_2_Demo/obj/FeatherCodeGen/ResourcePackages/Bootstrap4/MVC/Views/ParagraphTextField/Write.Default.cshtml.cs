#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.ParagraphTextField
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 4 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/ParagraphTextField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.ParagraphTextField.ParagraphTextFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 8 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 10 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
  
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 418), Tuple.Create("\"", 452)
, Tuple.Create(Tuple.Create("", 426), Tuple.Create("form-group", 426), true)
            
            #line 14 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create(" ", 436), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 437), false)
);

WriteLiteral(" data-sf-role=\"paragraph-text-field-container\"");

WriteLiteral(">\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 559), Tuple.Create("\'", 662)
, Tuple.Create(Tuple.Create("", 567), Tuple.Create("{\"maxLength\":\"", 567), true)
            
            #line 15 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
 , Tuple.Create(Tuple.Create("", 581), Tuple.Create<System.Object, System.Int32>(Model.MaxLengthViolationMessage
            
            #line default
            #line hidden
, 581), false)
, Tuple.Create(Tuple.Create("", 613), Tuple.Create("\",", 613), true)
, Tuple.Create(Tuple.Create(" ", 615), Tuple.Create("\"required\":", 616), true)
, Tuple.Create(Tuple.Create(" ", 627), Tuple.Create("\"", 628), true)
            
            #line 15 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                 , Tuple.Create(Tuple.Create("", 629), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 629), false)
, Tuple.Create(Tuple.Create("", 660), Tuple.Create("\"}", 660), true)
);

WriteLiteral(" />\n    <label");

WriteLiteral(" class=\"h6\"");

WriteAttribute("for", Tuple.Create(" for=\'", 688), Tuple.Create("\'", 720)
            
            #line 16 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 694), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textarea")
            
            #line default
            #line hidden
, 694), false)
);

WriteLiteral(">");

            
            #line 16 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                  Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral(" </label>\n    <textarea\n        id=\'");

            
            #line 18 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
       Write(Html.UniqueId("Textarea"));

            
            #line default
            #line hidden
WriteLiteral("\'\n        class=\"form-control\"\n        rows=\"4\"\n        data-sf-role=\"paragraph-t" +
"ext-field-textarea\"\n        name=\"");

            
            #line 22 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
         Write(Model.MetaField.FieldName);

            
            #line default
            #line hidden
WriteLiteral("\"\n        placeholder=\"");

            
            #line 23 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                Write(Model.PlaceholderText);

            
            #line default
            #line hidden
WriteLiteral("\"\n");

WriteLiteral("        ");

            
            #line 24 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
   Write(MvcHtmlString.Create(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 25 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 25 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
          if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("aria-describedby=\'");

            
            #line 25 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                   Write(Html.UniqueId("ParagraphInfo"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" ");

            
            #line 25 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                                                                } 
            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 25 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                                                               Write(Model.Value);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\n  \n");

            
            #line 27 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
     
            
            #line default
            #line hidden
            
            #line 27 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
      if (hasDescription)
     {

            
            #line default
            #line hidden
WriteLiteral("         <p");

WriteLiteral(" class=\"text-muted\"");

WriteAttribute("id", Tuple.Create(" id=\'", 1242), Tuple.Create("\'", 1278)
            
            #line 29 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1247), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("ParagraphInfo")
            
            #line default
            #line hidden
, 1247), false)
);

WriteLiteral(">");

            
            #line 29 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
                                                               Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 30 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
     }

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n");

            
            #line 33 "..\..MVC\Views\ParagraphTextField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/ParagraphTextField/paragraph-text-field.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591