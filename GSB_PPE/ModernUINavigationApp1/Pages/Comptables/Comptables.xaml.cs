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

namespace ModernUINavigationApp1.Pages.Comptables
{
    /// <summary>
    /// Interaction logic for Comptables.xaml
    /// </summary>
    public partial class Comptables : UserControl
    {
        public Comptables()
        {


            var myDate = DateTime.Now;
            var newDate = myDate.AddYears(-1);


            //calendarPicker.DisplayDateStart = newDate;


            InitializeComponent();
        }
    }
}
