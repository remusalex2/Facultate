using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facultate
{
    public partial class Form1 : Form
    {
        public Student student;
        public StudentMate studentMate;
        public StudentFizica studentFizica;

        public Form1()
        {
            InitializeComponent();
            CreeazaStudentMate();
            Afisare();
        }

        public void CreeazaStudentMate()
        {
            studentMate = new StudentMate();
            studentMate.Nume = "NUME STUNDENT MATE";
            studentMate.Prenume = "PRENUME STUNDENT MATE";
            studentMate.Varsta = 20;
            studentMate.NoteMaterieComuna = new List<float>();
            studentMate.NoteMaterieComuna.Add(4);
            studentMate.NoteMaterieComuna.Add(5);
            studentMate.CalculeazaMediaComuna();
            studentMate.TipStudent = Student.TipStudentEnum.Mate;
        }

        public void Afisare()
        {
            label6.Text = studentMate.Nume;
            label7.Text = studentMate.Prenume;
            label8.Text = studentMate.Varsta.ToString();
            listBox1.DataSource = studentMate.NoteMaterieComuna;
            label9.Text = studentMate.MedieMaterieComuna.ToString();
        }
    }
}
