using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace Spotidie.DAL.EF
{
    public class ApplicationUser : IdentityUser, IUser<string>
    {
    }
}
