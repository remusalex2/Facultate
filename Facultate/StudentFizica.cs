using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate
{
    public class StudentFizica : Student
    {
        public List<float> NoteFizica { get; set; }
        public float MedieFizica { get; set; }

        public void CalculeazaNoteFizica()
        {
            float suma = 0;
            for (int i = 0; i < NoteFizica.Count; i++)
            {
                suma = suma + NoteMaterieComuna[i];
            }
            MedieFizica = suma / NoteFizica.Count;
        }
    }
}
