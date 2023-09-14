using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaOOP.Clases
{
    public class Administrador : Docente
    {
        List<string> DepartamentosACargo = new List<string>();
        public Administrador(string name, int age, int salary, int id, string subject) : base(name, age, salary, id, subject)
        { }

        public void Administrar()
        {
            Console.WriteLine("Administrando...");
        }
    }
}
