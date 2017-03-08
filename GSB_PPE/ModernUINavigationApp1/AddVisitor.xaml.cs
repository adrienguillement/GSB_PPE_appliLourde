using FirstFloor.ModernUI.Windows.Controls;
using Models.src.build;
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

namespace ModernUINavigationApp1
{
    public partial class AddVisitor : UserControl
    {
        private String hiringDate, typeId, departement, address, firstName, lastName;

        public AddVisitor()
        {
            InitializeComponent();
        }

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
