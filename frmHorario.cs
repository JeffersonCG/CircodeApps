using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeApps
{
    public partial class frmHorario : Form
    {
        private readonly Dictionary<string, string> cityTimeZones = new Dictionary<string, string>
{
    { "Cairo", "Egypt Standard Time" },
    { "Nairobi", "E. Africa Standard Time" },
    { "New York", "Eastern Standard Time" },
    { "São Paulo", "E. South America Standard Time" },
    { "Tokyo", "Tokyo Standard Time" },
    { "Dubai", "Arabian Standard Time" },
    { "London", "GMT Standard Time" },
    { "Berlin", "W. Europe Standard Time" },
    { "Sydney", "AUS Eastern Standard Time" },
    { "Auckland", "New Zealand Standard Time" },
    { "Palmer Station", "Argentina Standard Time" },
    { "McMurdo Station", "New Zealand Standard Time" }
};
        public frmHorario()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParseExact(txtHorario.Text, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime inputTime))
            {
                MessageBox.Show("Formato inválido. Use HH:mm.");
                return;
            }

            DateTime inputUtc = DateTime.SpecifyKind(DateTime.Today.Add(inputTime.TimeOfDay), DateTimeKind.Local).ToUniversalTime();

            try
            {
                // África
                lblCairoMostrar.Text = ConverterHorario("Cairo", inputUtc);
                lblNairobiMostrar.Text = ConverterHorario("Nairobi", inputUtc);

                // América
                lblNewYorkMostrar.Text = ConverterHorario("New York", inputUtc);
                lblSaoPauloMostrar.Text = ConverterHorario("São Paulo", inputUtc);

                // Ásia
                lblTokyoMostrar.Text = ConverterHorario("Tokyo", inputUtc);
                lblDubaiMostrar.Text = ConverterHorario("Dubai", inputUtc);

                // Europa
                lblLondonMostrar.Text = ConverterHorario("London", inputUtc);
                lblBerlinMostrar.Text = ConverterHorario("Berlin", inputUtc);

                // Oceania
                lblSydneyMostrar.Text = ConverterHorario("Sydney", inputUtc);
                lblAucklandMostrar.Text = ConverterHorario("Auckland", inputUtc);

                // Antártida
                lblPalmerMostrar.Text = ConverterHorario("Palmer Station", inputUtc);
                lblMcMurdoMostrar.Text = ConverterHorario("McMurdo Station", inputUtc);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao converter horário: {ex.Message}");
            }
        }

        private string ConverterHorario(string cidade, DateTime utcTime)
        {
            try
            {
                TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById(cityTimeZones[cidade]);
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tz);
                return localTime.ToString("HH:mm");
            }
            catch
            {
                return "Erro";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
