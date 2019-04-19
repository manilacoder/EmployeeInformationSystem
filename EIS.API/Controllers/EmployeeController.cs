using EIS.BL;
using EIS.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace EIS.API.Controllers
{
    public class EmployeeController : ApiController
    {

        EmployeeBs employeeObjBs;

        public EmployeeController()
        {
            employeeObjBs = new EmployeeBs();
        }

        [ResponseType(typeof(IEnumerable<Employee>))]
        public IHttpActionResult Get()
        {
            return Ok(employeeObjBs.GetAll());
        }

        [ResponseType(typeof(Employee))]
        public IHttpActionResult Get(string id)
        {
            Employee employee = employeeObjBs.GetByID(id);
            if (employee != null)
                return Ok(employee);
            else
                return NotFound();
        }

        [ResponseType(typeof(Employee))]
        public IHttpActionResult Post(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeObjBs.Insert(employee);
                return CreatedAtRoute("DefaultApi", new { id = employee.EmployeeId }, employee);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
        [ResponseType(typeof(Employee))]
        public IHttpActionResult Put(int id, Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeObjBs.Update(employee);
                return Ok(employee);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [ResponseType(typeof(Employee))]
        public IHttpActionResult Delete(string id)
        {
            Employee employee = employeeObjBs.GetByID(id);
            if (employee != null)
            {
                employeeObjBs.Delete(id);
                return Ok(employee);
            }
            else
            {
                return NotFound();
            }
        }

    }
}
