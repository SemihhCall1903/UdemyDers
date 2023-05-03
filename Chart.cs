using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdemyDersSinema
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            chart1.Series["Kitap"].Points.AddXY("Akdeniz", 5.7523);
            chart1.Series["Kitap"].Points.AddXY("İç Anadolu", 3.7523);
            chart1.Series["Kitap"].Points.AddXY("Ege", 8.324);
            chart1.Series["Kitap"].Points.AddXY("Marmara", 5.7523);
            chart1.Series["Kitap"].Points.AddXY("Doğu Anadolu", 12.7523);
            chart1.Series["Kitap"].Points.AddXY("Güney Doğu Anadolu", 52.7523);
            chart1.Series["Kitap"].Points.AddXY("Karadeniz", 15.7523);
        }
    }
}
