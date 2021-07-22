using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuQiJing.Model
{
    public class Employee
    {
        private string employeeID;

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        private string employeeName;

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        private int sex;

        public int Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private DateTime birthday;

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        private string brief;

        public string Brief
        {
            get { return brief; }
            set { brief = value; }
        }
        public Employee()
        {

        }
        public Employee(string employeeID,string employeeName, int sex,DateTime birthday,string brief)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.sex = sex;
            this.birthday = birthday;
            this.brief = brief;
        }
    }
}
