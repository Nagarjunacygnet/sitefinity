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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.MultipleChoiceField
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/MultipleChoiceField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.MultipleChoiceField.MultipleChoiceFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
  
    var fieldName = string.IsNullOrEmpty(Model.MetaField.FieldName) ? "multiple-choice-field-name" : Model.MetaField.FieldName;
    var requiredAttributes = MvcHtmlString.Create(Model.ValidationAttributes);
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\n\n<fieldset");

WriteAttribute("class", Tuple.Create(" class=\"", 692), Tuple.Create("\"", 726)
            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 700), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 700), false)
, Tuple.Create(Tuple.Create(" ", 715), Tuple.Create("form-group", 716), true)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-container\"");

WriteLiteral(">\n        <legend");

WriteLiteral(" class=\"h6\"");

WriteAttribute("id", Tuple.Create(" id=\'", 802), Tuple.Create("\'", 840)
            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 807), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupLabel")
            
            #line default
            #line hidden
, 807), false)
);

WriteLiteral(">");

            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                             Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</legend>\n\n        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 937), Tuple.Create("\'", 993)
, Tuple.Create(Tuple.Create("", 945), Tuple.Create("{", 945), true)
, Tuple.Create(Tuple.Create(" ", 946), Tuple.Create("\"required\":", 947), true)
, Tuple.Create(Tuple.Create(" ", 958), Tuple.Create("\"", 959), true)
            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
      , Tuple.Create(Tuple.Create("", 960), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 960), false)
, Tuple.Create(Tuple.Create("", 991), Tuple.Create("\"}", 991), true)
);

WriteLiteral(" />\n\n        <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1032), Tuple.Create("\'", 1083)
            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1050), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupLabel")
            
            #line default
            #line hidden
, 1050), false)
);

WriteLiteral(" ");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                        if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("aria-describedby=\'");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                 Write(Html.UniqueId("RadioGroupInfo"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" ");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                                                               } 
            
            #line default
            #line hidden
WriteLiteral(">\n");

            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
             foreach (var choice in Model.Choices)
            {
                string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
                bool isSelected = (!string.IsNullOrEmpty(value) && choice == value) ||
                                    (string.IsNullOrEmpty(value) && !Model.IsRequired && choice == Model.MetaField.DefaultValue as string);

                var selctedAttributes = isSelected ? "checked" : string.Empty;

            
            #line default
            #line hidden
WriteLiteral("                <li>\n                    <label>\n                    <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1755), Tuple.Create("\"", 1772)
            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1762), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 1762), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1773), Tuple.Create("\"", 1788)
            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1781), Tuple.Create<System.Object, System.Int32>(choice
            
            #line default
            #line hidden
, 1781), false)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" ");

            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                Write(selctedAttributes);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                   Write(requiredAttributes);

            
            #line default
            #line hidden
WriteLiteral(" role=\"radio\" aria-required=\"");

            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                                                                                                   Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\" />\n");

WriteLiteral("                        ");

            
            #line 33 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                   Write(choice);

            
            #line default
            #line hidden
WriteLiteral("\n                    </label>\n                </li>\n");

            
            #line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 38 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 38 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
             if(Model.HasOtherChoice)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li>\n                    <label>\n                            <inp" +
"ut");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2162), Tuple.Create("\"", 2179)
            
            #line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2169), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 2169), false)
);

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-radio\"");

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" role=\"radio\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2286), Tuple.Create("\"", 2313)
            
            #line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                                                           , Tuple.Create(Tuple.Create("", 2302), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2302), false)
);

WriteLiteral(" />\n");

WriteLiteral("                            ");

            
            #line 43 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                       Write(Html.Resource("Other"));

            
            #line default
            #line hidden
WriteLiteral("\n                            <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                             Write(Html.Resource("ThisChoiceWillExpandTextbox"));

            
            #line default
            #line hidden
WriteLiteral("</span>\n                    </label>\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-text\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2591), Tuple.Create("\"", 2618)
            
            #line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                         , Tuple.Create(Tuple.Create("", 2607), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2607), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2619), Tuple.Create("\"", 2661)
            
            #line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                  , Tuple.Create(Tuple.Create("", 2632), Tuple.Create<System.Object, System.Int32>(Html.Resource("OtherOption")
            
            #line default
            #line hidden
, 2632), false)
);

WriteLiteral(" />\n                </li>\n");

            
            #line 48 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
            
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\n");

            
            #line 51 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 51 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
         if (hasDescription) 
        {

            
            #line default
            #line hidden
WriteLiteral("           <p");

WriteAttribute("id", Tuple.Create(" id=\'", 2782), Tuple.Create("\'", 2819)
            
            #line 53 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2787), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupInfo")
            
            #line default
            #line hidden
, 2787), false)
);

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 53 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
                                                                  Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 54 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("</fieldset>\n\n");

            
            #line 57 "..\..\ResourcePackages\Bootstrap4\MVC\Views\MultipleChoiceField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/MultipleChoiceField/multiple-choice-field.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591