using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataContracts
{

    public enum EmployeeLevel
    {
        Level1,
        Level2,
        Level3,
        Level4,
        Staff,
        Partner
    }

    [DataContract]
    public class Employee
    {
        private int id;
        private string name;
        private EmployeeLevel level;

        [DataMember]
        public int ID { get { return this.id; } set { this.id = value; } }
        [DataMember]
        public string Name { get { return this.name; } set { this.name = value; } }
        [DataMember]
        public EmployeeLevel Level { get { return this.level; } set { this.level = value; } }
    }
}
