using EmployeeAndOrgainizations.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndOrgainizations
{
    public class CRUD_OperationforEmployee
    {
        DbContextFile DbContextFile;
        public CRUD_OperationforEmployee()
        {
            DbContextFile = new DbContextFile();
        }
        public void InsertEmployeeWithItsOrgnization(Employee employee, List<EmployeeOrganizations> employeeOrganizationsList)
        {
            var Employee = new Employee
            {
                Name = employee.Name,
                Age = employee.Age,
                Address = employee.Address,
                EmployeesOrganizations = employeeOrganizationsList
            };
            DbContextFile.Add(Employee);
            DbContextFile.SaveChanges();


        }
        public void PrintEmployeeById(int id)
        {
            var emp = DbContextFile.Employees.Where(empl => empl.Id == id).Include(e => e.EmployeesOrganizations).FirstOrDefault();
            if(emp != null)
            {
                Console.WriteLine("Employe Name   :" + emp.Name);
                Console.WriteLine("Employee Age   :" + emp.Age);
                Console.WriteLine("Employee Address:" + emp.Address);
                Console.WriteLine("==================================");
                foreach (EmployeeOrganizations employeeOrganizations in emp.EmployeesOrganizations)
                {
                    Console.WriteLine("Employee Organization  :" + employeeOrganizations.OrgnizatinName);
                }
            }
            else
            {
                Console.WriteLine(" Record not Found with Id :"+id);
            }
        }


        public void PrintAllEmployee()
        {
            var empl = DbContextFile.Employees.Include(e => e.EmployeesOrganizations).ToList();
            if (empl != null)
            {
                foreach (Employee emp in empl)
                {
                    Console.WriteLine("Employe Name   :" + emp.Name);
                    Console.WriteLine("Employee Age   :" + emp.Age);
                    Console.WriteLine("Employee Address:" + emp.Address);
                    Console.WriteLine("===============Orgnizations=================");
                    foreach (EmployeeOrganizations employeeOrganizations in emp.EmployeesOrganizations)
                    {
                        Console.WriteLine("Employee Organization  :" + employeeOrganizations.OrgnizatinName);
                    }
                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine();
                    Console.WriteLine();

                }
            }
            else
            {
                Console.WriteLine(" Record not Found with Id :");
            }
        }


        public  void DeleteEmployee(int empId)
        {
            var delEmp=DbContextFile.Employees.Where(emp=>emp.Id==empId).Include(e=>e.EmployeesOrganizations).First();
            if(delEmp != null)
            {
                DbContextFile.Employees.Remove(delEmp);
                delEmp.EmployeesOrganizations.Clear();
                DbContextFile.SaveChanges();
            }
            else
            {
                Console.WriteLine("No Record Found With This Id : "+empId);
            }
        }

        public void UpdateEmployeeAndOrgnization(int empId,string empname, List<EmployeeOrganizations> UpdateList)
        {
            var updateemp = DbContextFile.Employees.Where(emp => emp.Id == empId).Include(e => e.EmployeesOrganizations).First();
           if(updateemp != null)
            {
                updateemp.Name = empname;
                updateemp.EmployeesOrganizations = UpdateList;
                DbContextFile.SaveChanges();
            }
            else
            {
                Console.WriteLine(" No Record Exist With This Id "+empId);
            }

        }
        public void TheSecondWayToInsertEMP(List<EmployeeOrganizations> orgainizationsList)
        {
            DbContextFile.Organizations.AddRange(orgainizationsList);
            DbContextFile.SaveChanges();
            Console.WriteLine("added");

        }
    }
}
