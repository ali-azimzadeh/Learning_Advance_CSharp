using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp_OOP.SOLID._4_ISP_Interface_segregation_principle_
{
    public interface IEmployeeDatabase
    {
        bool AddEmployeeDetails();
        bool ShowEmployeeDetails(int employeeId);
    }
}
