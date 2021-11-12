using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LiveInfoTrafficProject
{
    public partial class LiveTrafficData : Form
    {
        DataTable table = new DataTable("table");

        SqlConnection conn = new SqlConnection();
        private string connectionString; public string ConnectionString

        {

            get { return connectionString; }
            set { connectionString = value; }

        }

        public LiveTrafficData()
        {
            InitializeComponent();
            wbmapsG.ScriptErrorsSuppressed = true;

        }

        LiveTrafficDataSetTableAdapters.PropertiesTableAdapter information = new LiveTrafficDataSetTableAdapters.PropertiesTableAdapter();
        

        public string APIKey = "hIQ7sERCrsAIdaBcD4I2inoY9sFjc7ms";
        //private void btnSearch_Click(object sender, EventArgs e)
        private void krijgLiveTrafficToolStripMenuItem_Click(object sender, EventArgs e)
        {


            getTraffic();
            string streetto = ttt2.Text;
            string streetfrom = ttt.Text;


            StringBuilder queryadress = new StringBuilder();


            queryadress.Append("https://www.google.com/maps?q=");



            if (streetfrom != string.Empty)
            {
                queryadress.Append(streetfrom + "," + "+");
            }
            if (streetto != string.Empty)
            {
                queryadress.Append(streetto + "," + "+");
            }


            wbmapsG.Navigate(queryadress.ToString());



            void getTraffic()
            {
                using (WebClient web = new WebClient())
                {


                    string url = string.Format("https://api.tomtom.com/traffic/services/{0}/incidentDetails?bbox=4.8854592519716675%2C52.36934334773164%2C4.897883244144765%2C52.37496348620152&fields=%7Bincidents%7Btype%2Cgeometry%7Btype%2Ccoordinates%7D%2Cproperties%7Bid%2CiconCategory%2CmagnitudeOfDelay%2Cevents%7Bdescription%2Ccode%7D%2CstartTime%2CendTime%2Cfrom%2Cto%2Clength%2Cdelay%2CroadNumbers%2CtimeValidity%2Caci%7BprobabilityOfOccurrence%2CnumberOfReports%2ClastReportTime%7D%2Ctmc%7BcountryCode%2CtableNumber%2CtableVersion%2Cdirection%2Cpoints%7Blocation%2Coffset%7D%7D%7D%7D%7D&language=en-GB&timeValidityFilter=present&key={1}", toolStripTextBox1.Text, APIKey);
                    var json = web.DownloadString(url);
                    Api.Rootobject info = JsonConvert.DeserializeObject<Api.Rootobject>(json);

                    //length.Text = info.incidents[0].type;
                    tbStreetFrom.Text = info.incidents[0].properties.From;
                    tbStreetTo.Text = info.incidents[0].properties.To;
                    ttt.Text = info.incidents[0].properties.From;
                    ttt2.Text = info.incidents[0].properties.To;
                    tbstartTime.Text = info.incidents[0].properties.StartTime.ToString();

                    if (info.incidents[0].properties.EndTime == null)
                    {
                        tbendTime.Text = null;
                    }
                    else
                    {
                        tbendTime.Text = info.incidents[0].properties.EndTime.ToString();
                    }
                    tbLength.Text = info.incidents[0].properties.Length.ToString();
                    if (info.incidents[0].properties.Delay == int.Parse("0"))
                    {
                        tbDelay.Text = "Geen vertraging";
                    }
                    else
                    {
                        tbDelay.Text = info.incidents[0].properties.Delay.ToString();
                    }
                    tbStatus.Text = info.incidents[0].properties.TimeValidity;

                    if (info.incidents[0].properties.Events[0].Description == "Closed")
                    {
                        tbEventsBeschrijving.Text = "Weg gesloten";
                    }
                    else
                    {
                        tbEventsBeschrijving.Text = info.incidents[0].properties.Events[0].Description.ToString();
                    }

                    tbtet.Text = info.incidents[0].geometry.Coordinates[0][0].ToString() + "/" + info.incidents[0].geometry.Coordinates[0][1].ToString() + "\n" + info.incidents[0].geometry.Coordinates[1][0].ToString() + "/" + info.incidents[0].geometry.Coordinates[1][1].ToString();



                    switch (info.incidents[0].properties.IconCategory)
                    {
                        case 0:
                            iconCategoryTextBox.Text = "Unknown";
                            break;
                        case 1:
                            iconCategoryTextBox.Text = "Accident";
                            break;
                        case 2:
                            iconCategoryTextBox.Text = "Fog";
                            break;
                        case 3:
                            iconCategoryTextBox.Text = "DangerousConditions";
                            break;
                        case 4:
                            iconCategoryTextBox.Text = "Rain";
                            break;
                        case 5:
                            iconCategoryTextBox.Text = "Ice";
                            break;
                        case 6:
                            iconCategoryTextBox.Text = "Jam";
                            break;
                        case 7:
                            iconCategoryTextBox.Text = "LaneClosed";
                            break;
                        case 8:
                            iconCategoryTextBox.Text = "Roadclosed";
                            break;
                        case 9:
                            iconCategoryTextBox.Text = "RoadWorks";
                            break;
                        case 10:
                            iconCategoryTextBox.Text = "Wind";
                            break;
                        case 11:
                            iconCategoryTextBox.Text = "Flooding";
                            break;
                        case 14:
                            iconCategoryTextBox.Text = "BrokenDownVehicle";
                            break;
                    }


               
                }
            }

        }
        void getNext()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.tomtom.com/traffic/services/{0}/incidentDetails?bbox=4.8854592519716675%2C52.36934334773164%2C4.897883244144765%2C52.37496348620152&fields=%7Bincidents%7Btype%2Cgeometry%7Btype%2Ccoordinates%7D%2Cproperties%7Bid%2CiconCategory%2CmagnitudeOfDelay%2Cevents%7Bdescription%2Ccode%7D%2CstartTime%2CendTime%2Cfrom%2Cto%2Clength%2Cdelay%2CroadNumbers%2CtimeValidity%2Caci%7BprobabilityOfOccurrence%2CnumberOfReports%2ClastReportTime%7D%2Ctmc%7BcountryCode%2CtableNumber%2CtableVersion%2Cdirection%2Cpoints%7Blocation%2Coffset%7D%7D%7D%7D%7D&language=en-GB&timeValidityFilter=present&key={1}", toolStripTextBox1.Text, APIKey);
                var json = web.DownloadString(url);
                Api.Rootobject info = JsonConvert.DeserializeObject<Api.Rootobject>(json);

                
                    foreach (var items in info.incidents)
                    {
                    //length.Text = info.incidents[0].type;
                    textBox1.AppendText($"{"\n ~~~~~~~~ Van: " + items.properties.From}: {"\n Naar: " + items.properties.To}: {"\n Start datum: " + items.properties.StartTime}");
                    //textBox1.AppendText($"{"Reden: " + items.properties.IconCategory}");
                    switch (items.properties.IconCategory)
                    {
                        case 0:
                            textBox1.AppendText($"{"\n Reden: Unknow"}");
                            break;
                        case 1:
                            textBox1.AppendText($"{"\n Reden: Accident"}");
                            break;
                        case 2:
                           textBox1.AppendText($"{"\n Reden: Fog"}");
                            break;
                        case 3:
                            textBox1.AppendText($"{"\n Reden: DangerousConditions"}");
                            break;
                        case 4:
                            textBox1.AppendText($"{"\n Reden: Rain"}");
                            break;
                        case 5:
                            textBox1.AppendText($"{"\n Reden: Ice"}");
                            break;
                        case 6:
                            textBox1.AppendText($"{"\n Reden: Jam"}");
                            break;
                        case 7:
                            textBox1.AppendText($"{"\n Reden: LaneClosed"}");
                            break;
                        case 8:
                            textBox1.AppendText($"{"\n Reden: Road Cloased"}");
                            break;
                        case 9:
                           textBox1.AppendText($"{"\n Reden: RoadWorks"}");
                            break;
                        case 10:
                            textBox1.AppendText($"{"\n Reden: Wind"}");
                            break;
                        case 11:
                            textBox1.AppendText($"{"\n Reden: Flooding"}");
                            break;
                        case 14:
                            textBox1.AppendText($"{"\n Reden: BrokenDownVehicle"}");
                            break;
                        }
                    }
                }
            }
        
        private void nextToolStripMenuItem_Click(object sender, EventArgs e)

        {
            getNext();
        }

        private void extraInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.tomtom.com/traffic/services/{0}/incidentDetails?bbox=4.8854592519716675%2C52.36934334773164%2C4.897883244144765%2C52.37496348620152&fields=%7Bincidents%7Btype%2Cgeometry%7Btype%2Ccoordinates%7D%2Cproperties%7Bid%2CiconCategory%2CmagnitudeOfDelay%2Cevents%7Bdescription%2Ccode%7D%2CstartTime%2CendTime%2Cfrom%2Cto%2Clength%2Cdelay%2CroadNumbers%2CtimeValidity%2Caci%7BprobabilityOfOccurrence%2CnumberOfReports%2ClastReportTime%7D%2Ctmc%7BcountryCode%2CtableNumber%2CtableVersion%2Cdirection%2Cpoints%7Blocation%2Coffset%7D%7D%7D%7D%7D&language=en-GB&timeValidityFilter=present&key={1}", toolStripTextBox1.Text, APIKey);
                var json = web.DownloadString(url);
                Api.Rootobject info = JsonConvert.DeserializeObject<Api.Rootobject>(json);

                string test = info.incidents.Count().ToString();
                MessageBox.Show("Er zijn in totaal: " + test + ", incidenten details gevonden");


                
            }
        }
        private void tbLinq_Click(object sender, EventArgs e)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.tomtom.com/traffic/services/{0}/incidentDetails?bbox=4.8854592519716675%2C52.36934334773164%2C4.897883244144765%2C52.37496348620152&fields=%7Bincidents%7Btype%2Cgeometry%7Btype%2Ccoordinates%7D%2Cproperties%7Bid%2CiconCategory%2CmagnitudeOfDelay%2Cevents%7Bdescription%2Ccode%7D%2CstartTime%2CendTime%2Cfrom%2Cto%2Clength%2Cdelay%2CroadNumbers%2CtimeValidity%2Caci%7BprobabilityOfOccurrence%2CnumberOfReports%2ClastReportTime%7D%2Ctmc%7BcountryCode%2CtableNumber%2CtableVersion%2Cdirection%2Cpoints%7Blocation%2Coffset%7D%7D%7D%7D%7D&language=en-GB&timeValidityFilter=present&key={1}", toolStripTextBox1.Text, APIKey);
                var json = web.DownloadString(url);
                Api.Rootobject info = JsonConvert.DeserializeObject<Api.Rootobject>(json);

                foreach (var items in info.incidents)
                {
                    List<Api.Incident.Properties> portef = new List<Api.Incident.Properties>()

               {

            new Api.Incident.Properties() {From = items.properties.From, To = items.properties.To } };

                    IEnumerable<Api.Incident.Properties> portefVs = portef.Where(a => a.From == "Raadhuisstraat");
                    MessageBox.Show("Boolean loop x incidents with streetname from: 'Raadhuisstraat': False");

                }

                    
            }

            //string insertQuery = "INSERT INTO [dbo].[Properties] ([IconCategory], [MagnitudeOfDelay], [StartTime], [EndTime], [From], [To], [Length], [TimeValidity], [EventsId]) VALUES (@IconCategory, @MagnitudeOfDelay, @StartTime, @EndTime, @From, @To, @Length, @TimeValidity, @EventsId)";
            //conn.Open();
            //SqlCommand cmd = new SqlCommand(insertQuery);
            //if (cmd.ExecuteNonQuery() == 1)
            //{
            //    MessageBox.Show("Data inserted");
            //}
            //else
            //{
            //    MessageBox.Show("Data not inserted");
            //}

            //conn.Close();


            //information.Insert(int.Parse(iconCategoryTextBox.Text), int.Parse(tbDelay.Text), DateTime.Parse(tbstartTime.Text), DateTime.Parse(tbendTime.Text), tbStreetFrom.Text, tbStreetTo.Text, double.Parse(tbLength.Text), tbStatus.Text, int.Parse(eventsIdTextBox.Text));
            //foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            //propertiesDataGridView.DataSource = information.List2();
            //Api api = new Api();
            //new.

            //Api.Rootobject rt = new Api.Rootobject();
            //MessageBox.Show(rt.incidents[0].ToString());

        }

        private void LiveTrafficData_Load(object sender, EventArgs e)
        {
          
            propertiesDataGridView.DataSource = information.List2();
            // TODO: This line of code loads data into the 'liveTrafficDataSet.Properties' table. You can move, or remove it, as needed.
            this.propertiesTableAdapter.Fill(this.liveTrafficDataSet.Properties);
            // TODO: This line of code loads data into the 'liveTrafficDataSet.Incidents' table. You can move, or remove it, as needed.
            this.incidentsTableAdapter.Fill(this.liveTrafficDataSet.Incidents);

        }
    }
 }

