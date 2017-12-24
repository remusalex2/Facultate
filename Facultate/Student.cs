using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate
{
    public class Student
    {
        #region Proprietati
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }
        public List<float> NoteMaterieComuna { get; set; }
        public float MedieMaterieComuna { get; set; }
        public TipStudentEnum TipStudent { get; set; }
        #endregion

        #region Functii
        public void CalculeazaMediaComuna()
        {
            float suma = 0;
            for (int i=0; i<NoteMaterieComuna.Count;i++)
            {
                suma = suma + NoteMaterieComuna[i];
            }
            MedieMaterieComuna = suma / NoteMaterieComuna.Count;
        }
        #endregion

        public enum TipStudentEnum
        {
            Fizica,
            Mate
        }
    }
}
