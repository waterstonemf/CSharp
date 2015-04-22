using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace DataContracts
{
    [ServiceContract]
    public interface IEmployee
    {
        [OperationContract]
        List<Employee> GetAllEmployees();
    }
}
