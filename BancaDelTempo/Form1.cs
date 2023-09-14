using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace BancaDelTempo
{
    public partial class Form1 : Form
    {

        public List<Socio> soci = new List<Socio>();
        public List<Prestazione> prestazioni = new List<Prestazione>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void LoadData() //IMPORTAZIONE DATI DAL JSON
        {
            if (File.Exists("soci.json"))
            {
                string sociJson = File.ReadAllText("soci.json");
                soci = JsonConvert.DeserializeObject<List<Socio>>(sociJson);
            }

            if (File.Exists("prestazioni.json"))
            {
                string prestazioniJson = File.ReadAllText("prestazioni.json");
                prestazioni = JsonConvert.DeserializeObject<List<Prestazione>>(prestazioniJson);
            }
        } 

        private void btnDebito_Click(object sender, EventArgs e) //SOCI CON DEBITO
        {
            List<Socio> debitori = soci.Where(s => s.CalcolaDebito() > 0).ToList();

            list.Items.Clear();
            foreach (Socio debitor in debitori)
            {
                list.Items.Add($"{debitor.Cognome}, {debitor.Nome} | Debito: {debitor.Debito}");
            }
        }

        private void btnSegreteria_Click(object sender, EventArgs e) //SOCI APPARTENENTI ALLA SEGRETERIA
        {
            List<Socio> segreteriaSoci = soci.Where(s => s.Segreteria).ToList();

            list.Items.Clear();
            foreach (Socio segreteriaSocio in segreteriaSoci)
            {
                list.Items.Add($"{segreteriaSocio.Cognome}, {segreteriaSocio.Nome} - Tel: {segreteriaSocio.Telefono}");
            }
        }

        private void btnOrdinaPrestazioni_Click(object sender, EventArgs e) //VISUALIZZAZIONE PRESTAZIONI
        {
            List<Prestazione> prestazioniOrdinate = prestazioni.OrderByDescending(p => p.Ore).ToList();

            list.Items.Clear();
            foreach (Prestazione prestazione in prestazioniOrdinate)
            {
                list.Items.Add($"{prestazione.Erogatore.Cognome}, {prestazione.Erogatore.Nome} -> {prestazione.Ricevente.Cognome}, {prestazione.Ricevente.Nome} - {prestazione.Ore} ore di {prestazione.Tipo}");
            }
        }

        private void btnSoci_Click(object sender, EventArgs e) //STAMPA TUTTI I SOCI
        {
            list.Items.Clear();
            foreach (Socio socio in soci)
            {
                list.Items.Add($"{socio.Cognome}, {socio.Nome} - Tel: {socio.Telefono}");
            }
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            LoadData();
        }

        private void btnAggiungi_Click(object sender, EventArgs e) //AGGIUNGI SOCIO
        {
            bool done = true;
            double newphone;
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                done = false;
                MessageBox.Show("Cognome non valido");
            }
            if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                done = false;
                MessageBox.Show("Nome non valido");
            }
            if (String.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text.Length != 10)
            {
                try
                {
                    newphone = double.Parse(textBox3.Text);
                }
                catch
                {
                    done = false;
                    MessageBox.Show("Telefono non valido");
                }
            }
            if (comboBox1.Text == string.Empty)
            {
                done = false;
                MessageBox.Show("Zona non valida");
            }
            if (done)
            {
                Socio nuovo = new Socio(textBox1.Text, textBox2.Text, double.Parse(textBox3.Text), comboBox1.Text, 0, false);
                AggiungiSocio(nuovo);
                MessageBox.Show("Aggiunta eseguita con SUCCESSO");
            }
        }

        public static void AggiungiSocio(Socio nuovo)
        {
            var N = new FileStream(@"soci.json", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            N.Close();
            StreamReader sr = new StreamReader(@"soci.json");
            StreamWriter sw = new StreamWriter(@"./soci2.json");

            string line = "";
            int i = 0;

            while (!sr.EndOfStream || i != 1)
            {
                line = sr.ReadLine();

                if (line != null && i == 0 && line != "]")
                {
                    sw.WriteLine(line);
                }
                else if (line == "]")
                {
                    sw.WriteLine(",");
                    //aggiunta classe jsonata
                    string jsonString = JsonConvert.SerializeObject(nuovo, Formatting.None);
                    sw.WriteLine(jsonString);
                    sw.WriteLine("]");
                    i = 1;
                }
            }
            sr.Close();
            sw.Close();

            System.IO.File.Delete(@"soci.json");
            System.IO.File.Move(@"./soci2.json", @"soci.json");

        }
    }
}
