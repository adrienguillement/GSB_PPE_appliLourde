using Models.src.build;
using Models.src.metiers;
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

namespace ModernUINavigationApp1.Pages
{
    /// <summary>
    /// Interaction logic for BasicPage.xaml
    /// </summary>
    public partial class BasicPage : UserControl
    {
        private List<Visitor> listVisitor;
        private String filterLastName;

        public BasicPage()
        {
            VisitorBuild visitor = new VisitorBuild();
            this.listVisitor = visitor.findAll();

            this.DataContext = listVisitor;
            
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Visitor obj = ((FrameworkElement)sender).DataContext as Visitor;
            int visitor_id = Convert.ToInt32(obj.id);

            VisitorBuild visitor = new VisitorBuild();
            TextResult result = visitor.delete(visitor_id);

            this.DataContext = null;
            this.listVisitor = visitor.findAll();
            this.DataContext = listVisitor;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            List<Visitor> filtered = this.listVisitor.FindAll(x => x.last_name.Contains(textBox.Text));
            this.DataContext = filtered;
            filterLastName = textBox.Text;
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            List<Visitor> filtered = this.listVisitor.FindAll(x => x.first_name.Contains(textBox.Text) && x.last_name.Contains(filterLastName));
            this.DataContext = filtered;

        }
    }
}
