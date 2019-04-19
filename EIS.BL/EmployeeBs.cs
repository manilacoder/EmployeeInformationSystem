using EIS.BOL;
using EIS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIS.BL
{
    public class EmployeeBs
    {
        private EmployeeDb ObjDb;

        public List<string> Erros = new List<string>();

        public EmployeeBs()
        {
            ObjDb = new EmployeeDb();
        }
        public IEnumerable<Employee> GetAll()
        {
            return ObjDb.GetAll();
        }
        public Employee GetByID(string Id)
        {
            return ObjDb.GetByID(Id);
        }
        public bool Insert(Employee emp)
        {
            if (IsValidOnInsert(emp))
            {
                ObjDb.Insert(emp);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Delete(string Id)
        {
            ObjDb.Delete(Id);
        }
        public bool Update(Employee emp)
        {
            if (IsValidOnUpdate(emp))
            {
                ObjDb.Insert(emp);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Employee GetByEmail(string email)
        {
            var emp =  ObjDb.GetByEmail(email);
            return emp;
        }
        public bool IsValidOnInsert(Employee emp)
        {
            return true;
        }
        public bool IsValidOnUpdate(Employee emp)
        {
            return true;
        }
    }
}
