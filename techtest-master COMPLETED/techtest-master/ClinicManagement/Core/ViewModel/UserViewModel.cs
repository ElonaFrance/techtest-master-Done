using System.Collections.Generic;
using System.Web.Mvc;

namespace ClinicManagement.Core.ViewModel
{
    public class UserViewModel
    {
        public string Id { get; set; }

        //public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool? IsActive { get; set; }

        public bool? Doctor { get; set; }
        public bool? Administrator { get; set; }
        public string Password { get; set; }

        //public IEnumerable<SelectListItem> RolesList { get; set; }


    }
}