using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datumcas02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static TimeSpan pocetDnu(DateTime narozen)
        {
            TimeSpan uplynulo;
            narozen = narozen.AddYears(65);
            uplynulo = DateTime.Today - narozen;
            return uplynulo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("pocet dnu od doby, kdy osoba dovršila 65 let " + pocetDnu(dateTimePicker1.Value).Days);
        }
    }
}
