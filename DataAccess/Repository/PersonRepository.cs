using DataAccess.DTO;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class PersonRepository : IPersonRepository
    {
        EmployeeRegistrationDbContext context;
        public PersonRepository(EmployeeRegistrationDbContext _context)
        {
            context = _context;
        }

        public List<Person> GetEmployeeList()
        {
            List<Person> emplist= context.Persons.ToList();
            return emplist;
        }
        public Person SaveEmployee(Person newPerson)
        {
            context.Persons.Add(newPerson);
            context.SaveChanges();
            return newPerson;
        }
        public Person UpdateEmployee(Person updatePerson)
        {
            context.Persons.Update(updatePerson);
            context.SaveChanges();
            return updatePerson;           
        }

        public Person updateEmployee(Person updatePerson)
        {
            context.Persons.Update(updatePerson);
            context.SaveChanges();
            return updatePerson;
        }
        public bool Delete(int personId)
        {
            Person personToDelete = context.Persons.SingleOrDefault(param => param.Id == personId);
            context.Persons.Remove(personToDelete);
            context.SaveChanges();
            return true;
        }

        public Person GetEmployee(int id)
        {
            return context.Persons.SingleOrDefault(p => p.Id == id);
        }

        public List<EmployeeEducationDTO> PersonEducation(int personId)
        {
            return (from per in context.Persons
                    join edu in context.EducationHistorys on per.Id equals edu.PersonId
                    where per.Id == personId
                    select new
                    EmployeeEducationDTO
                    {
                        Education = edu.EducationLevel,
                        FullName = per.FirstName + ' ' + per.MiddeleName + ' ' + per.LastName
                    }).ToList();
        }
    }
}
