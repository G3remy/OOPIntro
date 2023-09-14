using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaOOP.Clases
{
    public class MiembroDeLaComunidad
    {
        string Name { get; set; }
        int Age { get; set; }

        public MiembroDeLaComunidad(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
