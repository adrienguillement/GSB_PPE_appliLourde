using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace ModernUINavigationApp1
{
    /// <summary>
    /// Interaction logic for LinkApi.xaml
    /// </summary>
    public partial class LinkApi : UserControl
    {
        private string pathAPI = ConfigurationManager.AppSettings.Get("path_API");

        public LinkApi()
        {
            InitializeComponent();
        }

        private void BtnLinkApi_Click(object sender, EventArgs e)
        {

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["path_API"].Value = pathAPI;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            System.Windows.Forms.Application.Restart();
            System.Windows.Application.Current.Shutdown();
        }

        //When user complete form
        private void TxtLinkApi_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            pathAPI = textBox.Text;
        }
    }
}
