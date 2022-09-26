using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class User: IdentityUser<Guid>
    {
        public string? Name { get; set; }
        public string? About { get; set; }
        public string? ProfileUrl { get; set; }
    }
}
