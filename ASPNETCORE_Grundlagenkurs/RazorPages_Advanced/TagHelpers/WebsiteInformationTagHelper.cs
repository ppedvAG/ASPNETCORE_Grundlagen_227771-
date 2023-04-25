using Microsoft.AspNetCore.Razor.TagHelpers;

namespace RazorPages_Advanced.TagHelpers
{
    public class WebsiteInformationTagHelper : TagHelper
    {

        //Attribute in HTML 
        public WebsiteContext Info { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";

            output.Content.SetHtmlContent(
             $@"<ul><li><strong>Version:</strong> {Info.Version}</li>
                <li><strong>Copyright Year:</strong> {Info.CopyrigthYear}</li>
                <li><strong>Approved:</strong> {Info.Approved}</li>
                <li><strong>Number of tags to show:</strong> {Info.TagsToShow}</li></ul>");

            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }

    public class WebsiteContext
    {
        public Version Version { get; set; }
        public int CopyrigthYear { get; set; }

        public bool Approved { get; set; }

        public int TagsToShow { get; set; }
    }
}
