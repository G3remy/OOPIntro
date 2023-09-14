using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaOOP.Clases
{
    public class Docente : Empleado
    {
        string Subject { get; set; }
        public Docente(string name, int age, int salary, int id, string subject) : base(name, age, salary, id)
        {
            Subject = subject;
        }
    }
}
