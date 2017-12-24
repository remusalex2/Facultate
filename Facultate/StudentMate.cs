using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate
{
    public class StudentMate : Student
    {
        public List<float> NoteMate { get; set; }
        public float MedieMate { get; set; }

        public void CalculeazaMediaMate()
        {
            float suma = 0;
            for (int i = 0; i < NoteMate.Count; i++)
            {
                suma = suma + NoteMaterieComuna[i];
            }
            MedieMate = suma / NoteMate.Count;
        }
    }
}
