using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaOOP.Clases
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        int Graduation { get; set; }


        public ExAlumno(string name, int age, int graduation) : base(name, age)
        {
            Graduation = graduation;
        }
    }
}
