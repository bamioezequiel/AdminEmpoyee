using System;
using System.Collections.Generic;
using System.Text;

namespace AdminEmployee.BLL
{
    class EmployeeBLL
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int Departament { get; set; }

        public byte[] Image { get; set; }

    }
}
