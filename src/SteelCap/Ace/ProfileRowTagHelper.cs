﻿using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Razor.TagHelpers;

namespace SteelCap
{
    [HtmlTargetElement("profileRow")]
    public class ProfileRowTagHelper : TagHelper
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes["class"] = "profile-info-row";

            var sb = new StringBuilder();
            sb.AppendFormat(@"
        <div class=""profile-info-name"">{0}</div>
        <div class=""profile-info-value"">
            <span>{1}</span>
        </div>", Name, Value);
            
            output.Content.Clear();
            output.Content.AppendHtml(sb.ToString());

            base.Process(context, output);
        }
    }
}
