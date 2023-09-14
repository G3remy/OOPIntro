using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaOOP.Clases
{
    public class Maestro : Docente
    {
        public Maestro(string name, int age, int salary, int id, string subject) : base(name, age, salary, id, subject)
        { }

        public void Enseñar()
        {
            Console.WriteLine("Enseñando...");
        }
    }
}
