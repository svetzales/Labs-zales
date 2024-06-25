﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Yeroma.UI.TagHelpers
{
    [HtmlTargetElement("img", Attributes = "img-action, img-controller")]
    public class ImageTagHelper(LinkGenerator linkGenerator) : TagHelper
    {
        public string ImgController { get; set; }
        public string ImgAction { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.Add("src",
            linkGenerator.GetPathByAction(ImgAction, ImgController));
        }
    }
}
