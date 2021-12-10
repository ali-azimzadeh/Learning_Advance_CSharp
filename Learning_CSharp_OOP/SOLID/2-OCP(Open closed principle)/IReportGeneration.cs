using Learning_CSharp_OOP.SOLID.SRP_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp_OOP.SOLID._2_OCP
{
    public interface IReportGeneration
    {
        void GenerateReport(Employee em); 
    }
}
