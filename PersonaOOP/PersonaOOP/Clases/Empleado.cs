using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaOOP.Clases
{
    public class Empleado : MiembroDeLaComunidad
    {
        int Salary { get; set; }
        int ID { get; set; }

        public Empleado(string name, int age, int salary, int id) : base(name, age)
        {
            Salary = salary;
            ID = id;
        }
    }
}
