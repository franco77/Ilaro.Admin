﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
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
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Ilaro.Admin;
    using Ilaro.Admin.Core;
    using Ilaro.Admin.Extensions;
    using Ilaro.Admin.Models;
    using Resources;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/IlaroAdmin/Views/Shared/EditorTemplates/TimePartial.cshtml")]
    public partial class _Areas_IlaroAdmin_Views_Shared_EditorTemplates_TimePartial_cshtml_ : System.Web.Mvc.WebViewPage<Property>
    {
        public _Areas_IlaroAdmin_Views_Shared_EditorTemplates_TimePartial_cshtml_()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\TimePartial.cshtml"
  Html.ClearPrefix();
            
            #line default
            #line hidden
WriteLiteral("\r\n<label");

WriteAttribute("for", Tuple.Create(" for=\"", 49), Tuple.Create("\"", 75)
            
            #line 4 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\TimePartial.cshtml"
, Tuple.Create(Tuple.Create("", 55), Tuple.Create<System.Object, System.Int32>(Html.Id(Model.Name)
            
            #line default
            #line hidden
, 55), false)
);

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">");

            
            #line 4 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\TimePartial.cshtml"
                                                            Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 4 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\TimePartial.cshtml"
                                                                               Write(Html.Condition(Model.IsRequired, () => "<span class=\"text-danger\">*</span>"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n<div");

WriteLiteral(" class=\"controls col-md-3\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"input-group date time-picker\"");

WriteLiteral(" data-date-format=\"HH:mm\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 7 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\TimePartial.cshtml"
   Write(Html.TextBox(Model.Name, Model.Value.Raw, Model, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"input-group-addon\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"glyphicon glyphicon-time\"");

WriteLiteral("></span>\r\n        </span>\r\n    </div>\r\n");

WriteLiteral("    ");

            
            #line 12 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\TimePartial.cshtml"
Write(Html.Condition(!string.IsNullOrEmpty(Model.Description), () => "<span class=\"help-block\">" + Model.Description + "</span>"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

            
            #line 14 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\TimePartial.cshtml"
Write(Html.ValidationMessage(Model.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
