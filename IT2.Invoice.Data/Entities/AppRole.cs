using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT2.Invoice.Data.Entities
{
    public class AppRole: IdentityRole<Guid>
    {
        public string Descriptions { get; set; }
    }
}
