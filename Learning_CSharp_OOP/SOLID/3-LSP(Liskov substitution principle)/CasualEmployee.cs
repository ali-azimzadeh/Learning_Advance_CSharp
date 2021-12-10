using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp_OOP.SOLID._3_LSP_Liskov_substitution_principle_
{
    public class CasualEmployee : Employee
    {

        //***************
        // Solution(1) 
        //***************
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
        // May be for contractual employee we do not need to store the details into database.
        public override string GetEmployeeDetails(int employeeId)
        {
            return "Child Employee";
        }
    }


    //***************
    // Solution(2) 
    //***************

    //public class CasualEmployee : IEmployee ,IProject
    //{
    //    public string GetEmployeeDetails(int employeeId)
    //    {
    //        return "Child Employee";
    //    }

    //    public string GetProjectDetails(int employeeId)
    //    {
    //        return "Child Employee";
    //    }
    //}
}
