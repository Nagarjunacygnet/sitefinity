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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.FileField
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
    
    #line 3 "..\..MVC\Views\FileField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\FileField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\FileField\Write.Default.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/FileField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.FileField.FileFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..MVC\Views\FileField\Write.Default.cshtml"
  
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 369), Tuple.Create("\"", 416)
            
            #line 11 "..\..MVC\Views\FileField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 377), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 377), false)
, Tuple.Create(Tuple.Create(" ", 392), Tuple.Create("sf-FileField", 393), true)
, Tuple.Create(Tuple.Create(" ", 405), Tuple.Create("form-group", 406), true)
);

WriteLiteral(" data-sf-role=\"file-field-container\"");

WriteLiteral(" data-sf-config=\"");

            
            #line 11 "..\..MVC\Views\FileField\Write.Default.cshtml"
                                                                                                     Write(Html.AttributeEncode(Model.Serialize()));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" class=\"h6\"");

WriteAttribute("for", Tuple.Create(" for=\'", 537), Tuple.Create("\'", 571)
            
            #line 12 "..\..MVC\Views\FileField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 543), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("FileUpload")
            
            #line default
            #line hidden
, 543), false)
);

WriteLiteral(">");

            
            #line 12 "..\..MVC\Views\FileField\Write.Default.cshtml"
                                                    Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n    <div");

WriteLiteral(" data-sf-role=\"file-field-inputs\"");

WriteLiteral(">\r\n");

            
            #line 14 "..\..MVC\Views\FileField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 14 "..\..MVC\Views\FileField\Write.Default.cshtml"
         if (!SystemManager.IsDesignMode)
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("<script type=\"text/template\" data-sf-role=\"file-input-template\">\r\n");

            
            #line 17 "..\..MVC\Views\FileField\Write.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" data-sf-role=\"single-file-input\"");

WriteLiteral(">\r\n            <input");

WriteAttribute("id", Tuple.Create(" id=\'", 864), Tuple.Create("\'", 897)
            
            #line 19 "..\..MVC\Views\FileField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 869), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("FileUpload")
            
            #line default
            #line hidden
, 869), false)
);

WriteLiteral("\r\n                   title=\"file\"");

WriteLiteral("\r\n                   type=\"file\"");

WriteAttribute("name", Tuple.Create("\r\n                   name=\"", 963), Tuple.Create("\"", 1018)
            
            #line 22 "..\..MVC\Views\FileField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 990), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 990), false)
);

WriteLiteral("\r\n                   ");

            
            #line 23 "..\..MVC\Views\FileField\Write.Default.cshtml"
              Write(Html.Raw(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral("\r\n                   class=\"sf-FileField-input\"\r\n                   aria-required" +
"=\"");

            
            #line 25 "..\..MVC\Views\FileField\Write.Default.cshtml"
                             Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n");

            
            #line 26 "..\..MVC\Views\FileField\Write.Default.cshtml"
                   
            
            #line default
            #line hidden
            
            #line 26 "..\..MVC\Views\FileField\Write.Default.cshtml"
                     if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 26 "..\..MVC\Views\FileField\Write.Default.cshtml"
                                                               Write(Html.UniqueId("FileUploadInfo"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 26 "..\..MVC\Views\FileField\Write.Default.cshtml"
                                                                                                               } 
            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 27 "..\..MVC\Views\FileField\Write.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 27 "..\..MVC\Views\FileField\Write.Default.cshtml"
             if (Model.AllowMultipleFiles)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" data-sf-role=\"remove-input\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1446), Tuple.Create("\"", 1483)
            
            #line 29 "..\..MVC\Views\FileField\Write.Default.cshtml"
                             , Tuple.Create(Tuple.Create("", 1459), Tuple.Create<System.Object, System.Int32>(Html.Resource("Remove")
            
            #line default
            #line hidden
, 1459), false)
);

WriteLiteral(">\r\n                    <svg");

WriteLiteral(" class=\"sf-icon-xs sf-icon-remove\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" data-sf-role=\"remove-input\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                        <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 1646), Tuple.Create("\"", 1731)
, Tuple.Create(Tuple.Create("", 1659), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap4/assets/dist/sprites/solid.svg#times-circle")
, 1659), false)
);

WriteLiteral("></use>\r\n                    </svg>\r\n");

WriteLiteral("                    ");

            
            #line 33 "..\..MVC\Views\FileField\Write.Default.cshtml"
               Write(Html.Resource("Remove"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </a>\r\n");

            
            #line 35 "..\..MVC\Views\FileField\Write.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 36 "..\..MVC\Views\FileField\Write.Default.cshtml"
             if (Model.AcceptedFileTypes.Length > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <p");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"filetype-violation-message\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 38 "..\..MVC\Views\FileField\Write.Default.cshtml"
                                                                                                                                      Write(Model.FileTypeViolationMessage);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 39 "..\..MVC\Views\FileField\Write.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 40 "..\..MVC\Views\FileField\Write.Default.cshtml"
             if (Model.MinFileSizeInMb > 0 || Model.MaxFileSizeInMb > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <p");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"filesize-violation-message\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 42 "..\..MVC\Views\FileField\Write.Default.cshtml"
                                                                                                                                      Write(Model.FileSizeViolationMessage);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 43 "..\..MVC\Views\FileField\Write.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 45 "..\..MVC\Views\FileField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 45 "..\..MVC\Views\FileField\Write.Default.cshtml"
         if (!SystemManager.IsDesignMode)
        {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("</script>\r\n");

            
            #line 48 "..\..MVC\Views\FileField\Write.Default.cshtml"
    }

    
            
            #line default
            #line hidden
            
            #line 50 "..\..MVC\Views\FileField\Write.Default.cshtml"
                                            

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");

            
            #line 52 "..\..MVC\Views\FileField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 52 "..\..MVC\Views\FileField\Write.Default.cshtml"
     if (Model.AllowMultipleFiles)
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" data-sf-role=\"add-input\"");

WriteLiteral(">");

            
            #line 54 "..\..MVC\Views\FileField\Write.Default.cshtml"
                                                          Write(Html.Resource("AddAnother"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 55 "..\..MVC\Views\FileField\Write.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <p");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"required-violation-message\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 56 "..\..MVC\Views\FileField\Write.Default.cshtml"
                                                                                                                          Write(Model.RequiredViolationMessage);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 57 "..\..MVC\Views\FileField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 57 "..\..MVC\Views\FileField\Write.Default.cshtml"
     if (hasDescription)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"text-muted\"");

WriteAttribute("id", Tuple.Create(" id=\'", 2923), Tuple.Create("\'", 2960)
            
            #line 59 "..\..MVC\Views\FileField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2928), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("FileUploadInfo")
            
            #line default
            #line hidden
, 2928), false)
);

WriteLiteral(">");

            
            #line 59 "..\..MVC\Views\FileField\Write.Default.cshtml"
                                                               Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 60 "..\..MVC\Views\FileField\Write.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 62 "..\..MVC\Views\FileField\Write.Default.cshtml"
 if (!SystemManager.IsDesignMode)
{
    
            
            #line default
            #line hidden
            
            #line 64 "..\..MVC\Views\FileField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
            
            #line 64 "..\..MVC\Views\FileField\Write.Default.cshtml"
                                                
    
            
            #line default
            #line hidden
            
            #line 65 "..\..MVC\Views\FileField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/FileField/file-field.js"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 65 "..\..MVC\Views\FileField\Write.Default.cshtml"
                                                                                           
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591