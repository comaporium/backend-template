using backend_template.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace backend_template.Controllers
{
    //[EnableCors("CorsPolicy")]
    //[Route("api/[controller]/[action]")]
    //[ApiController]
    //public class HomeController : Controller
    //{

    //    readonly TodoContext db = new TodoContext();

    //    [HttpGet]
    //    public IActionResult GetSve()
    //    {
    //        List<OnoStoGetamo> sviKorisnici = db.OnoStoGetamos.OrderBy(x => x.Id).ToList();

    //        return Ok(sviKorisnici);
    //    }

    //    [HttpGet("{id}")]
    //    public IActionResult GetPoIdu(int id)
    //    {
    //        OnoStoGetamo? korisnik = db.OnoStoGetamos.Where(x => x.Id == id).FirstOrDefault();

    //        return Ok(korisnik);
    //    }

    //    [HttpPost]
    //    public IActionResult dodaj([FromBody] OnoStoDodajemo onoStoDodajemo)
    //    {
    //        db.Add(onoStoDodajemo);
    //        db.SaveChanges();

    //        return Ok(onoStoDodajemo);
    //    }

    //    [HttpPut]
    //    public IActionResult azuriraj([FromBody] OnoStoAzuriramo onoStoAzuriramo)
    //    {
    //        Korisnici? onoStoAzuriramo = db.OnoStoAzuriramos.Where(x => x.Id == OnoStoAzuriramos.Id).FirstOrDefault();

    //        if (onoStoAzuriramo == null) return NotFound($"Ono sto azuriramo sa id {onoStoAzuriramo.Id} nije pronađeno.");
    //        edit
    //        db.SaveChanges();

    //        return Ok(korisnik);
    //    }

    //    [HttpDelete("{id}")]
    //    public IActionResult Brisanje(int id)
    //    {
    //        OnoStoBrisemo? onoStoBrisemo = db.OnoStoBrisemos.Where(x => x.Id == id).FirstOrDefault();

    //        if (onoStoBrisemo == null) return NotFound($"Ono sto brisemo id {id} ne postoji u bazi podataka.");

    //        db.Remove(onoStoBrisemo);
    //        db.SaveChanges();

    //        return Ok(onoStoBrisemo);
    //    }

    //}
}