using BAI_01.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BAI_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        public static List<SinhVien> sinhViens = new List<SinhVien>();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(sinhViens);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            try
            {
                // LinQ [Object] query
                var student = sinhViens.SingleOrDefault(x => x.Code == Guid.Parse(id));
                if (student == null)
                {
                    return NotFound();
                }
                return Ok(sinhViens);
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
        [HttpPost]
        public IActionResult Create(SinhVienPTPM sv)
        {
            var student = new SinhVien
            {
                Code = Guid.NewGuid(),
                Name = sv.Name,
                Class = sv.Class
            };
            sinhViens.Add(student);
            return Ok(new
            {
                Success = true, Data = student
            });
        }
        [HttpPut("{id}")]
        public IActionResult Edit(string id,SinhVien sinhvienEdit)
        {
            try
            {
                // LinQ [Object] query
                var student = sinhViens.SingleOrDefault(x => x.Code == Guid.Parse(id));
                if (student == null)
                {
                    return NotFound();
                }
                if (id != student.Code.ToString())
                {
                    return BadRequest();
                }
                // Update
                student.Name = sinhvienEdit.Name;
                student.Class = sinhvienEdit.Class;
                return Ok(student);
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
        [HttpDelete]
        public IActionResult Delete(string id)
        {
            try
            {
                // LinQ [Object] query
                var student = sinhViens.SingleOrDefault(x => x.Code == Guid.Parse(id));
                if (student == null)
                {
                    return NotFound();
                }
                if (id != student.Code.ToString())
                {
                    return BadRequest();
                }
                // Delete 
                sinhViens.Remove(student);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
    }
}