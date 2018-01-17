using Luisalabs_Employee_Manager.DAL;
using Luisalabs_Employee_Manager.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace Luisalabs_Employee_Manager.Controllers
{
    public class EmployeeController : ApiController
    {
        //Instância de referência ao banco de dados
        LuizalabsContext db = new LuizalabsContext();

        /**
          * Lista os funcionários de maneira paginada (GET).
          * 
          * @param page_size   Número de elementos da mágina
          * @param page        Número da página
          * @author            Rafael M. S. Siqueira
          */
        public IHttpActionResult GetAllEmployees(int page_size, int page)
        {            
            if ((page_size == 0) || (page == 0))
            {
                return BadRequest();
            }
            var employees = db.Employees.ToList();
            return Ok(employees.Skip((page-1)*page_size).Take(page_size));
        }

        /**
          * Gravar um novo funcionário no banco de dados (POST).
          */
        public IHttpActionResult PostEmployee(Employee employee)
        {
            employee.Id = 0;
            db.Employees.Add(employee);
            db.SaveChanges();
            return Created("",employee);
        }


        /**
          * Apaga um funcionário no banco de dados (DELETE).
          */
        public IHttpActionResult DeleteEmployee(int id)
        {
            var employee = db.Employees.FirstOrDefault((e) => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            db.Employees.Remove(employee);
            db.SaveChanges();
            return Ok(employee);
        }
    }
}
