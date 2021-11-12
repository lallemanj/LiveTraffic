using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveInfoTrafficProject
{
    public partial class LiveTraffic : Form
    {


        LiveTrafficData childForm = new LiveTrafficData();

        public LiveTraffic()
        {
            InitializeComponent();
            childForm.MdiParent = this.ParentForm;



        }



        public async Task toevoegenAsync(string response)
        {
            StringBuilder queryadress = new StringBuilder();
            StringBuilder queryadress2 = new StringBuilder();



            queryadress.Append("https://api.tomtom.com/traffic/map/4/tile/incidents/s0/12/1207/1539.png?t=-1&tileSize=512&key=hIQ7sERCrsAIdaBcD4I2inoY9sFjc7ms");
            webBrowser3.Navigate(queryadress.ToString());

            queryadress2.Append("https://api.tomtom.com/traffic/map/4/tile/flow/relative0/12/1207/1539.png?tileSize=512&key=hIQ7sERCrsAIdaBcD4I2inoY9sFjc7ms");
            webBrowser4.Navigate(queryadress2.ToString());

            response = await ApiHelper.GetAll();

            tbData.Text = ApiHelper.JsonMode(response);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LiveTrafficData data1 = new LiveTrafficData();

            data1.ShowDialog();
            if (data1.DialogResult == DialogResult.OK)
            {
                _ = toevoegenAsync(data1.ToString());
            }
        }
        private void btnToDatabank_Click_1(object sender, EventArgs e)
        {
            LiveTrafficDataBank livetrafficdatabank = new LiveTrafficDataBank();

            livetrafficdatabank.ShowDialog();
            if (livetrafficdatabank.DialogResult == DialogResult.OK)
            {
                livetrafficdatabank.Close();
            }
        }

        private void btnUitleg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programma live traffic: - Alles werkt zoals het moet. Alleen 3 dagen bezig geweest met het zoeken hoe je een web JSON code kunt toevoegen aan uw database, helaas niet gevonden desondanks alle nodige pogingen. API's gebruikt in deze programma's zijn: TOMTOM API TRAFFIC (Alleen regio Amsterdam kreeg ik) en extraatje Google Maps. Klik op het knop Start voor te beginnen. Veel plezier!");
        }
    }
}

