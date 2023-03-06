using Microsoft.AspNetCore.Identity;

namespace BlazorProject.Server.Data
{
    public class ApplicationsUser: IdentityUser
    {
        public string Name { get; set; } = default!;
        public string CellPhone { get; set; } = default!;
        public string Country { get; set; } = default!;
    }
}
