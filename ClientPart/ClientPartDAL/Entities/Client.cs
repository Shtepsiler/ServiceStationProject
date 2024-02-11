using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClientPartDAL.Entities
{
    public class Client : IdentityUser<int>
    {

        // public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public string Phone { get; set; }
        //public string Email { get; set; }

        [NotMapped]
        public List<Job> Jobs { get; set; }
        [NotMapped]
        public RefreshToken RefreshToken { get; set; }

    }

}
