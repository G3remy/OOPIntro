using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaOOP.Clases
{
    public class Administrativo : Empleado
    {
        public Administrativo(string name, int age, int salary, int id) : base(name, age, salary, id)
        { }
    }
}
