using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace TraningSession
{
    class Assign_Session3
    {
        public Assign_Session3()
        {
            List<Employee> LobjEmpList = new List<Employee>();

            string[] LobjEmpNames = { "Kishor", "Rushikesh", "Arvind", "parag", "Soham" };
            double[] LobjEmpSalary = { 18000, 21000, 19000, 22000, 24000 };
            string[] LobjEmpbranch = { "CS", "IT", "CS", "IT", "CS" };

            for (int i = 0; i < LobjEmpNames.Length; i++)
            {
                Employee LobjEmployee = new Employee
                {
                    Id = i,
                    EmpName = LobjEmpNames[i],
                    EmpDesignation = "Software Enginer" + i,
                    EmpSalary = LobjEmpSalary[i],
                    EmpBranch = LobjEmpbranch[i]
                };
                LobjEmpList.Add(LobjEmployee);
            }

            //from operator
            List<Employee> LobjSampleEmp = (from emp in LobjEmpList select emp).ToList();
            Console.WriteLine("\nList of Employee");
            foreach (Employee emp  in LobjSampleEmp)
            {
                Console.WriteLine($"Id:{emp.Id} Name:{emp.EmpName}");
            }

            //where operator
            Console.WriteLine("\nEmployee less than Id 3");
            var LvEmployee = from Employee in LobjEmpList where Employee.Id < 3 select Employee;
            foreach (var emp in LvEmployee)
            {
                Console.WriteLine($"Id:{emp.Id} Name:{emp.EmpName}");
            }

            //from, orderBy, select and string.Format
            Console.WriteLine("\nEmployee List OrderBy");
            var LvOrderById = from LsEmployee in LobjEmpList orderby LsEmployee.Id select LsEmployee;
            foreach (var LsEmployee in LvOrderById)
            {
                Console.WriteLine(string.Format("Employee ID {0} with Employee Name {1}", LsEmployee.Id, LsEmployee.EmpName));
            }

            //order By Descneding
            Console.WriteLine("\nOrder By Descneding");
            var LvDescOrderById = from LsEmployee in LobjEmpList orderby LsEmployee.Id descending select LsEmployee;
            foreach (var LsEmployee in LvDescOrderById)
            {
                Console.WriteLine("Employee Id {0} with Employee Name {1}",LsEmployee.Id, LsEmployee.EmpName);
            }

            //sum operator
            var LvTotalSalary = LobjEmpList.Sum(emp => emp.EmpSalary);
            Console.WriteLine(string.Format("\nTotal salary is:{0}", LvTotalSalary));

            //Max Oparator
            var LvMaximumId = LobjEmpList.Max(emp => emp.Id);
            Console.WriteLine($"\nMaximum Id is: {LvMaximumId}");

            //Average Operator
            var LvAvgSalary = LobjEmpList.Average(emp => emp.EmpSalary);
            Console.WriteLine($"\nAverage Salary is:{LvAvgSalary}");

            //All
            bool LbAllOperator = LobjEmpList.All(emp => emp.EmpSalary == 20000);
            Console.WriteLine($"\nAll Salaries are 20000 : {LbAllOperator}");

            //Any, Equals
            bool LbAnyOperator = LobjEmpList.Any(emp => emp.EmpName.Equals("Kishor"));
            Console.WriteLine($"There is Employee with Name:");

            //Group By
            var LvGroupBy = LobjEmpList.GroupBy(emp => emp.EmpBranch);
            foreach (var LvGroup in LvGroupBy)
            {
                Console.WriteLine(LvGroup.Key+ ":" +LvGroup.Count());
            }
        }
    }
}
