using System.Xml;
using System.IO;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json;


namespace Form1.cs {

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetUserLocation();
        }

        private void GetUserLocation()
        {
            try
            {
                string url = "http://ip-api.com/json"; 
                WebClient client = new WebClient();
                string json = client.DownloadString(url);
                dynamic result = JsonConvert.DeserializeObject(json);

                string city = result.city;
                string country = result.country;

                
                textBox1.Text = "" + city + ", " + country;
            }
            catch (Exception ex)
            {
                textBox1.Text = "Location Not Found!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string city;
            city = txtcity.Text;
            string uri = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=e5f0ca7a695546ac87f04248250303&q={0}&days=1&aqi=no&alerts=no", city);
            XDocument doc = XDocument.Load(uri);
            string iconUri = (string)doc.Descendants("icon").FirstOrDefault();
            WebClient client = new WebClient();
            byte[] image = client.DownloadData("http:" + iconUri);

            MemoryStream stream = new MemoryStream(image);



            Bitmap newBitMap = new Bitmap(stream);
            string hsymbol = "%";
            string maxtemp = (string)doc.Descendants("maxtemp_c").FirstOrDefault();
            string mintemp = (string)doc.Descendants("mintemp_c").FirstOrDefault();

            string maxwindm = (string)doc.Descendants("wind_mph").FirstOrDefault();
            string maxwindk = (string)doc.Descendants("wind_kph").FirstOrDefault();
            string humidity = (string)doc.Descendants("humidity").FirstOrDefault();


            string country = (string)doc.Descendants("country").FirstOrDefault();

            string cloud = (string)doc.Descendants("text").FirstOrDefault();

            Bitmap icon = newBitMap;


            double maxtempCValue = double.Parse(maxtemp);
            double mintempCValue = double.Parse(mintemp);

            double maxtempFValue = (maxtempCValue * 9 / 5) + 32;
            double mintempFValue = (mintempCValue * 9 / 5) + 32;

            txtmaxtemp.Text = $"{maxtemp}°C / {maxtempFValue:0.##}°F";
            txtmintemp.Text = $"{mintemp}°C / {mintempFValue:0.##}°F";

            txtwindm.Text = maxwindm;
            txtwindk.Text = maxwindk;

            txthumidity.Text = humidity + hsymbol;

            label7.Text = cloud;
            txtcountry.Text = country;
            pictureBox1.Image = icon;









        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
