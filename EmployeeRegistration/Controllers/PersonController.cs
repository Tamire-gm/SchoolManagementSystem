using DataAccess.DTO;
using DataAccess.Entity;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        IPersonRepository personrepo;
        public PersonController(IPersonRepository _personrepo)
        {
            personrepo = _personrepo;
        }

        // GET: api/<PersonController>
        [HttpGet]
        [Route("GetEmployeeList")]
        public IEnumerable<Person> GetEmployeeList()
        {
            return personrepo.GetEmployeeList();
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return personrepo.GetEmployee(id);
        }

        // GET: api/<PersonController>
        [HttpGet("GetEmployeeEducation/{id}")]
        public IEnumerable<EmployeeEducationDTO> GetEmployeeList(int id)
        {
            return personrepo.PersonEducation(id);
        }

        // POST api/<PersonController>
        [HttpPost]
        [Route("SaveEmployee")]
        public Person Post([FromBody] Person value)
        {
            return personrepo.SaveEmployee(value);
        }

        // PUT api/<PersonController>/5
        [HttpPut("updateEmployee/{id}")]
        public Person Put(int id, [FromBody] Person value)
        {
            return personrepo.updateEmployee(value);
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("DeleteEmployee/{id}")]
        //[Route("DeleteEmployee/{id}")]
        public bool Delete(int id)
        {
            return personrepo.Delete(id);
        }
    }
}
