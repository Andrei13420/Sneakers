using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Shop.xaml
    /// </summary>
    public partial class Shop : Page
    {
        public Shop()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Launch browser to facebook...
            System.Diagnostics.Process.Start("https://www.schuh.ie/mens/nike-zoom-2k-white-and-red-trainers/3406011360/");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Launch browser to facebook...
            System.Diagnostics.Process.Start("https://www.flightclub.com/w-air-force-1-flyknit-low-black-black-team-red-clear-jade-800891");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Launch browser to facebook...
            System.Diagnostics.Process.Start("https://www.flightclub.com/nite-jogger-core-black-carbon-active-blue-806488");
        }
    }
}
