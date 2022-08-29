using DataAccess.Repositories;
using DataAccess;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmantController : Controller
    {
        RentedApartmantRepository db;
        public ApartmantController(AppDbContext context)
        {
            db = new RentedApartmantRepository(context);
        }
        [HttpGet("List")]
        public IActionResult List()
        {
            List<RentedApartmant> list = db.GetActive();
            return Json(list);
        }
        [HttpGet("Get")]
        public IActionResult Get(Guid id)
        {
            return Json(db.GetById(id));
        }
        [HttpPost("Add")]
        public IActionResult Add(RentedApartmant apartmant)
        {
            db.Add(apartmant);
            db.Activate(apartmant.Id);
            return Json("Ok");
        }
        [HttpPut("Update")]
        public IActionResult Update(RentedApartmant apartmant)
        {
            db.Update(apartmant);
            db.Activate(apartmant.Id);
            return Json("Ok");
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(RentedApartmant apartmant)
        {
            db.Remove(apartmant);
            return Json("Ok");
        }
    }
}
