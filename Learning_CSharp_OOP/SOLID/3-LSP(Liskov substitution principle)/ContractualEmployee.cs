using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp_OOP.SOLID._3_LSP_Liskov_substitution_principle_
{

    //***************
    // Solution(1) 
    //***************

    public class ContractualEmployee : Employee
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
        // May be for contractual employee we do not need to store the details into database.
        public override string GetEmployeeDetails(int employeeId)
        {
            throw new NotImplementedException();
        }
    }


    //***************
    // Solution(2) 
    //***************

    //public class ContractualEmployee : IProject
    //{
    //    public string GetProjectDetails(int employeeId)
    //    {
    //        return "Child Project";
    //    }
    //}

}
