using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.StaticFiles;

namespace Yeroma.UI.Data
{
    public class ApplicationUser : IdentityUser
    {
        public byte[]? Avatar{ get; set; }
        public string MimeType { get; set; } = string.Empty;

        //var extProvider = new FileExtensionContentTypeProvider();
        //var MimeType = extProvider.Mappings[".png"];
    }
}
