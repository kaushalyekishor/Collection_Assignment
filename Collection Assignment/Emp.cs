using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TraningSession
{
    class Emp
    {
        public Emp()
        {
            List<Employee> LobjListofEmp = new List<Employee>();
            Dictionary<int, string> LobjDic = new Dictionary<int, string>();

            for (int i = 0; i < 10; i++)
            {
                Employee LobjEmplyee = new Employee
                {
                    Id = i,
                    EmpName = "Kishor"+i,
                    EmpDesignation = "Software Engineer"+i,
                    EmpSalary = 25000.52
                };
                LobjDic.Add(LobjEmplyee.Id, LobjEmplyee.EmpName);
                LobjListofEmp.Add(LobjEmplyee);
            }

            Employee LobjTest = LobjListofEmp.Where(x => x.Id == 3).FirstOrDefault();
           // Employee LobjDictObj = LobjDic.Where(x => x.Key == 1).FirstOrDefault().Value; //Error

            


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
