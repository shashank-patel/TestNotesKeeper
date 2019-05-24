using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestNotesKeeper.Models
{
    public class User : IdentityUser
    {
        [ScaffoldColumn(false)]
        public override string Id { get => base.Id; set => base.Id = value; }

        [PersonalData]
        [Display(Name = "Name")]
        public string FirstName { get; set; }

        [PersonalData]
        [ScaffoldColumn(false)]
        public string LastName { get; set; }

        public override string UserName { get => base.UserName; set => base.UserName = value; }

        public override string Email { get => base.Email; set => base.Email = value; }

        [ScaffoldColumn(false)]
        public override string PasswordHash { get => base.PasswordHash; set => base.PasswordHash = value; }

        [ScaffoldColumn(false)]
        public bool IsActive { get; set; }
    }
}
