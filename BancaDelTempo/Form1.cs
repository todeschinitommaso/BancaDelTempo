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
            Update();
        }

        private void LoadData()
        {
            // Caricare dati da file JSON
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

        private void Update()
        {
            // Aggiornare la visualizzazione dei dati nell'interfaccia grafica
            lstSoci.Items.Clear();
            foreach (Socio socio in soci)
            {
                lstSoci.Items.Add($"{socio.Cognome}, {socio.Nome} - Tel: {socio.Telefono}");
            }
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {

        }

        private void btnSegreteria_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdinaPrestazioni_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }
    }
}
