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
    public partial class LiveTrafficDataBank : Form
    {
        //private object PAGE = 1;
        //private Request request;
        public LiveTrafficDataBank()
        {
            InitializeComponent();
            LiveTrafficDataSet db = new LiveTrafficDataSet();
            //var st = db.Incidents

        }



        private void LiveTrafficDataBank_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'liveTrafficDataSet.Properties' table. You can move, or remove it, as needed.
            this.propertiesTableAdapter.Fill(this.liveTrafficDataSet.Properties);
            // TODO: This line of code loads data into the 'liveTrafficDataSet.Geometry' table. You can move, or remove it, as needed.
            this.geometryTableAdapter.Fill(this.liveTrafficDataSet.Geometry);
            // TODO: This line of code loads data into the 'liveTrafficDataSet.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.liveTrafficDataSet.Events);
            // TODO: This line of code loads data into the 'liveTrafficDataSet.Incidents' table. You can move, or remove it, as needed.
            this.incidentsTableAdapter.Fill(this.liveTrafficDataSet.Incidents);


        }
    }
}
