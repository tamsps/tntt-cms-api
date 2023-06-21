using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThieuNhiTT.Api.Models;

namespace ThieuNhiTT.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HiepdoanController : ControllerBase
    {
        // GET: HiepdoanController
        private readonly ILogger<HiepdoanController> _logger;
        private TNContext _tnContext;

        public HiepdoanController(TNContext tnContext, ILogger<HiepdoanController> logger)
        {
            _logger = logger;
            _tnContext = tnContext;
        }
        [HttpGet]
        public IEnumerable<HiepDoan> Get()
        {
            return _tnContext.HiepDoan;
        }

        [HttpGet("{id}")]
        public HiepDoan Get(int id)
        {
            return _tnContext.HiepDoan.FirstOrDefault(s => s.Id == id);

        }

        // POST api/<HiepdoanController>
        [HttpPost]
        public void Post([FromBody] HiepDoan value)
        {
            _tnContext.HiepDoan.Add(value);
            _tnContext.SaveChanges();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var hiepDoan = _tnContext.HiepDoan.FirstOrDefault(s => s.Id == id);
            if (hiepDoan != null)
            {
                _tnContext.HiepDoan.Remove(hiepDoan);
                _tnContext.SaveChanges();
            }
        }

        //// POST: HiepdoanController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: HiepdoanController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: HiepdoanController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: HiepdoanController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: HiepdoanController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
