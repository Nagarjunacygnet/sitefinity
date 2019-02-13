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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Registration
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Utilities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/Registration/Registration.RegistrationForm" +
        ".cshtml")]
    public partial class Registration_RegistrationForm : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Registration.RegistrationViewModel>
    {
        public Registration_RegistrationForm()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 11 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
Write(Html.Script(ScriptRef.JQueryValidate, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 12 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/JQueryValidate/jquery.validate.unobtrusive.min.js"), "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
  
    HtmlHelper.ClientValidationEnabled = true;
    HtmlHelper.UnobtrusiveJavaScriptEnabled = true;
    var isTwoCols = (Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0) ? "col-md-6" : "";

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 753), Tuple.Create("\"", 789)
            
            #line 20 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 761), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 761), false)
, Tuple.Create(Tuple.Create(" ", 776), Tuple.Create("row", 777), true)
, Tuple.Create(Tuple.Create(" ", 780), Tuple.Create("sf-m-xxs", 781), true)
);

WriteLiteral(">\n");

            
            #line 21 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
	
            
            #line default
            #line hidden
            
            #line 21 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
     if ((Request.QueryString["ShowActivationMsg"] == "true") ||
	 (ViewBag.ShowActivationMsg is bool && ViewBag.ShowActivationMsg))
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>\n");

WriteLiteral("            ");

            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
       Write(Html.Resource("VisitYourEmail"));

            
            #line default
            #line hidden
WriteLiteral("\n        </h3>\n");

            
            #line 27 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <p>");

            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
      Write(string.Format(Html.Resource("ActivationLinkHasBeenSent"), Model.Email));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

WriteLiteral("        <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-sf-role=\"sendAgainLink\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 29 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                                     Write(Html.Resource("SendAgain"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 30 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" data-sf-role=\"confirmationResendInfo\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\n");

WriteLiteral("            ");

            
            #line 32 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
       Write(string.Format(Html.Resource("ActivationLinkHasBeenSentAgain"), Model.Email));

            
            #line default
            #line hidden
WriteLiteral("\n            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-sf-role=\"sendAgainLink\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 33 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                                         Write(Html.Resource("SendAgain"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n        </div>\n");

            
            #line 35 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-resend-confirmation-endpoint-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1595), Tuple.Create("\"", 1669)
            
            #line 36 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
       , Tuple.Create(Tuple.Create("", 1603), Tuple.Create<System.Object, System.Int32>(Url.Action("ResendConfirmationEmail", new { email = Model.Email})
            
            #line default
            #line hidden
, 1603), false)
);

WriteLiteral(" />\n");

            
            #line 37 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    }
    else if ((Request.QueryString["ShowSuccessfulRegistrationMsg"] == "true") ||
             (ViewBag.ShowSuccessfulRegistrationMsg is bool && ViewBag.ShowSuccessfulRegistrationMsg))
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>");

            
            #line 41 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
       Write(Html.Resource("ThankYou"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n");

WriteLiteral("        <p>");

            
            #line 42 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
      Write(Html.Resource("DefaultSuccessfulRegistrationMessage"));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 43 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"

    }
    else
    {
        using (Html.BeginFormSitefinity(true))
        {
          
            
            #line default
            #line hidden
            
            #line 49 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
     Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 49 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                       ;

            
            #line default
            #line hidden
WriteLiteral("          <div");

WriteAttribute("class", Tuple.Create(" class=\"", 2118), Tuple.Create("\"", 2136)
            
            #line 50 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 2126), Tuple.Create<System.Object, System.Int32>(isTwoCols
            
            #line default
            #line hidden
, 2126), false)
);

WriteLiteral(">\n               <h3");

WriteLiteral(" class=\"sf-mb-xl\"");

WriteLiteral(">");

            
            #line 51 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                               Write(Html.Resource("Registration"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n");

            
            #line 52 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               
            
            #line default
            #line hidden
            
            #line 52 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                if (!string.IsNullOrEmpty(ViewBag.Error))
               {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 55 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(ViewBag.Error);

            
            #line default
            #line hidden
WriteLiteral("\n                    </div>\n");

            
            #line 57 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               }

            
            #line default
            #line hidden
WriteLiteral("                \n");

WriteLiteral("\t\t\t   ");

            
            #line 59 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
          Write(Html.HiddenFor(m => m.RequiresQuestionAndAnswer));

            
            #line default
            #line hidden
WriteLiteral("\n\t\t\t\t\n               <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                    <label>\n");

WriteLiteral("                        ");

            
            #line 63 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.Resource("FirstName"));

            
            #line default
            #line hidden
WriteLiteral("\n                    </label>\n\n");

WriteLiteral("                    ");

            
            #line 66 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(Html.TextBox("Profile[FirstName]", null, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n                </div>\n            \n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                    <label>\n");

WriteLiteral("                        ");

            
            #line 72 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.Resource("LastName"));

            
            #line default
            #line hidden
WriteLiteral("\n                    </label>\n\n");

WriteLiteral("                    ");

            
            #line 75 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(Html.TextBox("Profile[LastName]", null, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n                </div>\n            \n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                    <label>\n");

WriteLiteral("                        ");

            
            #line 81 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.Resource("Email"));

            
            #line default
            #line hidden
WriteLiteral("\n                    </label>\n\n");

WriteLiteral("                    ");

            
            #line 84 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control", type = "email" }));

            
            #line default
            #line hidden
WriteLiteral("\n                          \n");

            
            #line 86 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 86 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                     if (Html.ValidationMessageFor(m => m.Email) != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n                            <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 89 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                Write(Html.ValidationMessageFor(m => m.Email));

            
            #line default
            #line hidden
WriteLiteral("</span>\n                        </div>\n");

            
            #line 91 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    } 

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n       \n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                    <label>\n");

WriteLiteral("                        ");

            
            #line 97 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.Resource("Password"));

            
            #line default
            #line hidden
WriteLiteral("\n                    </label>\n\n");

WriteLiteral("                    ");

            
            #line 100 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 102 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 102 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                     if (Html.ValidationMessageFor(m => m.Password) != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n                            <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral("> ");

            
            #line 105 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                 Write(Html.ValidationMessageFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("</span>\n                        </div>\n");

            
            #line 107 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    } 

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n            \n               <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n                    <label>\n");

WriteLiteral("                        ");

            
            #line 113 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.Resource("ReTypePassword"));

            
            #line default
            #line hidden
WriteLiteral("\n                    </label>\n\n");

WriteLiteral("                    ");

            
            #line 116 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(Html.PasswordFor(m => m.ReTypePassword, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n                            \n");

            
            #line 118 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 118 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                     if (Html.ValidationMessageFor(m => m.ReTypePassword) != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n                            <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 121 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                Write(Html.ValidationMessageFor(m => m.ReTypePassword));

            
            #line default
            #line hidden
WriteLiteral("</span>\n                        </div>\n");

            
            #line 123 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    } 

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n    \t\t\t\n");

            
            #line 127 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    			
            
            #line default
            #line hidden
            
            #line 127 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                 if (Model.RequiresQuestionAndAnswer)
                {
    				

            
            #line default
            #line hidden
WriteLiteral("    \t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n    \t\t\t\t\t<label>\n");

WriteLiteral("    \t\t\t\t\t\t");

            
            #line 132 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                       Write(Html.Resource("Question"));

            
            #line default
            #line hidden
WriteLiteral("\n    \t\t\t\t\t</label>\n\n");

WriteLiteral("    \t\t\t\t\t");

            
            #line 135 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.TextBoxFor(m => m.Question, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 137 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    					
            
            #line default
            #line hidden
            
            #line 137 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                         if (Html.ValidationMessageFor(m => m.Question) != null)
    					{

            
            #line default
            #line hidden
WriteLiteral("    \t\t\t\t\t\t<div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n    \t\t\t\t\t\t\t<span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral("> ");

            
            #line 140 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                     Write(Html.ValidationMessageFor(m => m.Question));

            
            #line default
            #line hidden
WriteLiteral("</span>\n    \t\t\t\t\t\t</div>\n");

            
            #line 142 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    					} 

            
            #line default
            #line hidden
WriteLiteral("    \t\t\t\t</div>\n");

            
            #line 144 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    				

            
            #line default
            #line hidden
WriteLiteral("    \t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n    \t\t\t\t\t<label>\n");

WriteLiteral("    \t\t\t\t\t\t");

            
            #line 147 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                       Write(Html.Resource("Answer"));

            
            #line default
            #line hidden
WriteLiteral("\n    \t\t\t\t\t</label>\n\n");

WriteLiteral("    \t\t\t\t\t");

            
            #line 150 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.TextBoxFor(m => m.Answer, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 152 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    					
            
            #line default
            #line hidden
            
            #line 152 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                         if (Html.ValidationMessageFor(m => m.Answer) != null)
    					{

            
            #line default
            #line hidden
WriteLiteral("    \t\t\t\t\t\t<div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\n    \t\t\t\t\t\t\t<span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral("> ");

            
            #line 155 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                     Write(Html.ValidationMessageFor(m => m.Answer));

            
            #line default
            #line hidden
WriteLiteral("</span>\n    \t\t\t\t\t\t</div>\n");

            
            #line 157 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    					}

            
            #line default
            #line hidden
WriteLiteral("    \t\t\t\t</div>\n");

            
            #line 159 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 162 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 162 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                 if (SystemManager.IsDesignMode && !SystemManager.IsPreviewMode )
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 164 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                             Write(Html.Resource("Register"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n");

            
            #line 165 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 168 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                             Write(Html.Resource("Register"));

            
            #line default
            #line hidden
WriteLiteral("</button>\n");

            
            #line 169 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\n                <div");

WriteLiteral(" class=\"sf-mt-l\"");

WriteLiteral(">\n                    <div>Already registered?</div>\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 6312), Tuple.Create("\"", 6338)
            
            #line 173 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 6319), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 6319), false)
);

WriteLiteral(">");

            
            #line 173 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                             Write(Html.Resource("BackToLogin"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n                </div>\n            </div>\n");

            
            #line 176 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
			
			if (Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">    \n                <h3");

WriteLiteral(" class=\"sf-mb-xl\"");

WriteLiteral(">");

            
            #line 180 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                Write(Html.Resource("ConnectWith"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n\n");

            
            #line 182 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 182 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                 foreach (var provider in Model.ExternalProviders)
                {
                    var classToBeAdd = "btn btn-default btn-lg btn-block " + @provider.Value;                 
                    
            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"sf-mb-xs\"");

WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 186 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(Html.ActionLink(provider.Key, "LoginExternalProvider", new { model = provider.Key }, new { @class = classToBeAdd }));

            
            #line default
            #line hidden
WriteLiteral("\n                    </div>\n");

            
            #line 188 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\n");

            
            #line 190 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 194 "..\..\ResourcePackages\Bootstrap\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Registration/registration-form.js"), "bottom", true));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591