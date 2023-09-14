using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaOOP.Clases
{
    public class Estudiante : MiembroDeLaComunidad
    {
        string ID { get; set; }
        string Carrer { get; set; }

        public Estudiante(string name, int age, string id, string carrer) : base(name, age)
        {
            ID = id;
            Carrer = carrer;
        }
    }
}
