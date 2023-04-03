using System.Linq;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        private WeatherDatabase _weather;

        public WeatherForm()
        {
            InitializeComponent();

            _weather = new WeatherDatabase();
            _weather.Initialize();

            WeatherDataGrid.DataSource = _weather.WeatherList.ToList();
        }


        WeatherDatabase WDB = new WeatherDatabase();
        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            string InputText = textBox1.Text;
            WeatherDataGrid.DataSource = WDB.searchWeathers(WDB.WeatherList, InputText);


/*
            string inputText = textBox1.Text;
            var IText = WDB.WeatherList.Where(T => T.CityName == inputText)
                                    .Select(T => T)
                                    .ToList();
*/
                           // WeatherDataGrid.DataSource = IText.ToList();

        }
    }
}