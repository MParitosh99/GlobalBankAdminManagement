using GlobalBankAdminManagement.Models;
using GlobalBankAdminManagement.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GlobalBankAdminManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private BranchRepository repo;
        public BranchController(BranchRepository _repo)
        {
            repo = _repo;
        }
        //[HttpGet]
        //[Route("GetAll")]
        //public IActionResult GetProducts()
        //{
        //    try
        //    {
        //        List<GlobalBankBranch> list = repo.GetAll();
        //        return Ok(list);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex.Message);
        //    }
        //}

        //[HttpGet]
        //[Route("GetById/{id}")]
        //public IActionResult Get(int id)
        //{
        //    GlobalBankBranch p = repo.Get(id);
        //    if (p == null)
        //        return NotFound("Invalid Id");
        //    else
        //        return Ok(p);
        //}

        [HttpPost]
        [Route("Add")]
        public IActionResult Post(GlobalBankBranch item)
        {
            repo.RegisterBranch(item);
            return Ok("Record Added");
        }
        //[HttpDelete]
        //[Route("Delete/{id}")]
        //public IActionResult Delete(string id)
        //{
        //    repo.DeleteBranch(id);
        //    return Ok("Record Deleted");
        //}
        //[HttpPut]
        //[Route("Update")]
        //public IActionResult Put(GlobalBankBranch item)
        //{
        //    repo.Update(item);
        //    return Ok("Record Updated");
        //}
    }
}
