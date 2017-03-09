using FirstFloor.ModernUI.Windows.Controls;
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
        private String filterLastName, filterFirstName;

        public BasicPage()
        {
            VisitorBuild visitor = new VisitorBuild();
            try
            {
                this.listVisitor = visitor.findAll();
            }
            catch (Exception e)
            {
                MessageBox.Show("Problème de connexion à l'api, vérifiez le lien dans les paramètres de l'application.");

            }
            this.DataContext = listVisitor;

            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {

            MessageBoxResult messageBoxResult = MessageBox.Show("Vous êtes sur le point de supprimer le visiteur, voulez-vous continuer ?", "Supprimer ?", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                //Get row clicked and store id in visitor_id
                Visitor obj = ((FrameworkElement)sender).DataContext as Visitor;
                int visitor_id = Convert.ToInt32(obj.id);

                VisitorBuild visitor = new VisitorBuild();
                TextResult result = visitor.delete(visitor_id);

                //Refresh datagrid to not display deleted visitor
                this.DataContext = null;
                this.listVisitor = visitor.findAll();
                this.DataContext = listVisitor;
            }
                
        }

        //If user wants to update visitor
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //Get row clicked and store id in visitor_id
            Visitor obj = ((FrameworkElement)sender).DataContext as Visitor;
            int visitor_id = Convert.ToInt32(obj.id);

            MessageBox.Show("Actuellement en construction", "Soyez patient");
        }

        //user compete textBox for lastName to filter datagrid
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            List<Visitor> filtered = this.listVisitor.FindAll(x => x.last_name.Contains(textBox.Text) && x.first_name.Contains(filterFirstName));
            this.DataContext = filtered;
            filterLastName = textBox.Text;
        }

        //user compete textBox for firstName to filter datagrid
        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            List<Visitor> filtered = this.listVisitor.FindAll(x => x.first_name.Contains(textBox.Text) && x.last_name.Contains(filterLastName));
            this.DataContext = filtered;
            filterFirstName = textBox.Text;
        }

        private void AddVisitor_Click(object sender, EventArgs e)
        {
            //create and show new window to add new visitor
            AddVisitor visitor = new AddVisitor();
            var host = new Window();
            host.Content = visitor;
            host.Show();
        }
    }
}
