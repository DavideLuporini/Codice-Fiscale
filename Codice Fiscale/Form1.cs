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
using System.Xml.Linq;
using Tecnosoftware.CodiceFiscale;

namespace Codice_Fiscale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var CalcoliEffettuali = new List<CodiceFiscale>();
            var History = new History();
            //Aggiungere storico.
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


            var nome = Input_Nome.Text;
            var cognome = Input_Cognome.Text;
            var sesso = Maschio.Checked ? "M" : "F";
            var dataDiNascita = dateTimePicker_Data_di_nascita.Value;
            var comune = (Comune)Input_comune_di_nascita.SelectedItem;
            //la richiamerei con Comune.Codice
            var calcolatoreCF = new Tecnosoftware.CodiceFiscale.CodiceFiscale(cognome, nome, dataDiNascita, comune.Codice, sesso);
            var element = calcolatoreCF.estraiCF();
            MessageBox.Show(element);

            //aggiungo l'elemento al CSV

            using (var sw = new StreamWriter("C:\\Users\\davide.luporini\\source\\repos\\Codice Fiscale\\Codice Fiscale\\HistoryDB.csv", true))
            {
                sw.WriteLine($"{element}");
            }



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

        private void Form1_Load(object sender, EventArgs e)
        {
            var listaComuni = new List<Comune>();
            var allLines = File.ReadAllLines("C:\\Users\\davide.luporini\\Desktop\\csv\\ElencoComuni.csv");

            foreach (var line in allLines)
            {
                var split = line.Split(',');
                listaComuni.Add(new Comune(split[0], split[1]));
            }

            Input_comune_di_nascita.DisplayMember = "Nome";
            Input_comune_di_nascita.DataSource = listaComuni;

        }

        private void Storico_Click(object sender, EventArgs e)
        {

            var listaRicerche = new List<string>();
            var allLines = File.ReadAllLines("C:\\Users\\davide.luporini\\source\\repos\\Codice Fiscale\\Codice Fiscale\\HistoryDB.csv");

            foreach (var line in allLines)
            {
                var split = line.Split(',');
                listaRicerche.Add(line);
            }
            history_list.DataSource = listaRicerche;
            //ogni volta che leggo una lista la aggiungo alla lista
            if (Storico.Text == "Storico ricerche")
            {
                Storico.Text = "Chiudi Storico";
                history_list.Size = new Size(300, 100);

            }
            else
            {
                Storico.Text = "Storico ricerche";
                history_list.Size = new Size(0, 0);

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
