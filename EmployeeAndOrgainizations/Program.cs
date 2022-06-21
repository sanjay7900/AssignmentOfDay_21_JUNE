using EmployeeAndOrgainizations.Entites;

namespace EmployeeAndOrgainizations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CRUD_OperationforEmployee cRUD_OperationforEmployee=new CRUD_OperationforEmployee();
            //Employee employee = new Employee { Name = "Rahul Sharma", Age = 21, Address = "Mathura" };
            //List<EmployeeOrganizations> employeeOrganizations = new List<EmployeeOrganizations>();
            //employeeOrganizations.Add(new EmployeeOrganizations { OrgnizatinName = "TCS" });
            //employeeOrganizations.Add(new EmployeeOrganizations { OrgnizatinName = "Wipro" });
            //employeeOrganizations.Add(new EmployeeOrganizations { OrgnizatinName = "CheckBox Android Development" });
            //cRUD_OperationforEmployee.InsertEmployeeWithItsOrgnization(employee, employeeOrganizations);


            //cRUD_OperationforEmployee.PrintEmployeeById(1);

            //Console.WriteLine("delete 1");
            //cRUD_OperationforEmployee.DeleteEmployee(1);


            //cRUD_OperationforEmployee.PrintEmployeeById(1);

            //Console.WriteLine("updateing ...");
            //List<EmployeeOrganizations> update = new List<EmployeeOrganizations>();
            //update.Add(new EmployeeOrganizations { OrgnizatinName = "Infosys" });
            //update.Add(new EmployeeOrganizations { OrgnizatinName = "SAP Labs" });
            //update.Add(new EmployeeOrganizations { OrgnizatinName = "CheckBox Android Development" });

            //cRUD_OperationforEmployee.UpdateEmployeeAndOrgnization(2, "sanjay", update);


            //cRUD_OperationforEmployee.PrintEmployeeById(2);
            //cRUD_OperationforEmployee.PrintEmployeeById(1);
            //Employee newemp = new Employee { Name = "Shivam", Age = 22, Address = "Aligarh" };
            //List<EmployeeOrganizations> secondwaytoinsert = new List<EmployeeOrganizations>();
            //secondwaytoinsert.Add(new EmployeeOrganizations { OrgnizatinName = "Infosys", Employee = newemp });
            //secondwaytoinsert.Add(new EmployeeOrganizations { OrgnizatinName = "BriskMind", Employee = newemp });
            //cRUD_OperationforEmployee.TheSecondWayToInsertEMP(secondwaytoinsert);   

            cRUD_OperationforEmployee.PrintAllEmployee();   
            Console.WriteLine("done...");
            Console.ReadKey();

        }
    }

}
