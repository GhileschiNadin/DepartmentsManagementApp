using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp1
{
    internal class Department
    {
        public int id { get; set; }
        public string departmentName { get; set; }
        public string description { get; set; }
        public Department parentId { get; set; }
    }
}
