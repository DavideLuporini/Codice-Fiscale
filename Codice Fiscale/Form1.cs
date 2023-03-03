using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codice_Fiscale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            string path = "C:\\Users\\davide.luporini\\Desktop\\csv";

            using (var reader = new StreamReader(path))
            {
                List<string> cities = new List<string>();
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(' ');

                    cities.Add(values[0]);
                }
            }



        }

        private void Input_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input_comune_di_nascita_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Calcola_Click(object sender, EventArgs e)
        {
            //Funzione per il calcolo , devo prendere
            //Input_Nome.Text;
            //input_Cognome.Text
            //Input_comune_di_nascita.Value;
        }

        private void Input_Cognome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Maschio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Sesso_Enter(object sender, EventArgs e)
        {

        }
    }
}
