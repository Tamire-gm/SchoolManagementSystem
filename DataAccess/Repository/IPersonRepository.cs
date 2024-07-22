using DataAccess.DTO;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IPersonRepository
    {
        public List<Person> GetEmployeeList();
        public Person GetEmployee(int id);
        public Person SaveEmployee(Person newPerson);

        public Person updateEmployee(Person updatePerson);

        public bool Delete(int personId);

        List<EmployeeEducationDTO> PersonEducation(int personId);


    }
}
