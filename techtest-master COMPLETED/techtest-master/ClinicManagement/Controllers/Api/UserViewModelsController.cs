using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ClinicManagement.Core.ViewModel;
using ClinicManagement.Persistence;

namespace ClinicManagement.Controllers.Api
{
    public class UserViewModelsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/UserViewModels
        public IQueryable<UserViewModel> GetUserViewModels()
        {
            bool isActive = db.UserViewModels.Any(a => a.IsActive.Equals(true));
            if (isActive) 
            { 
                return db.UserViewModels;
            }
            return null;
        }
        [HttpGet]
        // GET: api/UserViewModels/5
        [ResponseType(typeof(UserViewModel))]
        public IHttpActionResult GetUserViewModel(string id)
        {
            UserViewModel userViewModel = db.UserViewModels.Find(id);
            if (userViewModel == null)
            {
                return NotFound();
            }

            return Ok(userViewModel);
        }

     }
}