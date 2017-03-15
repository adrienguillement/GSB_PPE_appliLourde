using FirstFloor.ModernUI.Windows.Controls;
using Models.src.build;
using Models.src.metiers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class AddVisitor : UserControl
    {
        public List<Departement> listDepartement { get; set; }
        private String hiringDate, typeId, departement, address, firstName, lastName;

        public AddVisitor()
        {
            
            DepartementBuild departement = new DepartementBuild();
            this.listDepartement = departement.findAll();

            InitializeComponent();
            //for combobox
            DataContext = this;
        }
        /*
        private void cboDepartement_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string ID = this.cboDepartement.SelectedValue.ToString();
            MessageBox.Show(ID.ToString());
        }*/

        //On user select date store into attribut
        private void HiringDate_SelectedDateChanged(object sender,SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;
            DateTime? date = picker.SelectedDate;
            hiringDate = date.Value.ToShortDateString();
        }

        private void type_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            typeId = textBox.Text;
        }

        private void departement_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            departement = textBox.Text;
        }

        private void address_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            address = textBox.Text;
        }

        private void firstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            firstName = textBox.Text;
        }

        private void lastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            lastName = textBox.Text;
        }

        private void saveVisitor_Click(object sender, EventArgs e)
        {
            VisitorBuild visitor = new VisitorBuild();
            try
            {
                string[] dateSplit = hiringDate.Split('/');
                hiringDate = dateSplit[2] + "-" + dateSplit[1] + "-" + dateSplit[0];
            }
            catch { }

            departement = cboDepartement.SelectedValue.ToString();
            
            TextResult result = visitor.addOne(lastName, firstName, address, hiringDate, departement, typeId);

            if (result.message == "Success")
            {
                var dlg = new ModernDialog
                {
                    Title = "Succès",
                    Content = "Le visiteur à bien été inséré."
                };
                dlg.Buttons = new Button[] { dlg.OkButton, dlg.CancelButton };
                dlg.ShowDialog();
            }
            else
            {
                var dlg = new ModernDialog
                {
                    Title = "Erreur",
                    Content = "Une erreure est survenue, peut-être que le visiteur existe déjà."
                };
                dlg.Buttons = new Button[] { dlg.OkButton, dlg.CancelButton };
                dlg.ShowDialog();
            }
        }
    }
}
