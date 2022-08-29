using DataAccess;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Entities.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        UserRepository db;
        public UserController(AppDbContext context)
        {
            db = new UserRepository(context);
        }
        [HttpGet("List")]
        public IActionResult List()
        {
            List<User> list = db.GetActive();
            return Json(list);
        }
        [HttpGet("Get")]
        public IActionResult Get(Guid id)
        {
            return Json(db.GetById(id));
        }
        [HttpPost("Add")]
        public IActionResult Add(User user)
        {
            db.Add(user);
            db.Activate(user.Id);
            return Json("Ok");
        }
        [HttpPut("Update")]
        public IActionResult Update(User user)
        {
            db.Update(user);
            db.Activate(user.Id);
            return Json("Ok");
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(User user)
        {
            db.Remove(user);
            return Json("Ok");
        }
    }
}
