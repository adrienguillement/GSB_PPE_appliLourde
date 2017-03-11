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

namespace ModernUINavigationApp1
{
    /// <summary>
    /// Interaction logic for UpdateVisitor.xaml
    /// </summary>
    public partial class UpdateVisitor : UserControl
    {
        private string visitor_id;
        private Visitor listVisitor;
        public List<Departement> listDepartement { get; set; }
        private String hiringDateText, typeId, departement, address, firstName, lastName;

        public UpdateVisitor(int id)
        {
            DepartementBuild departement = new DepartementBuild();
            this.listDepartement = departement.findAll();

            InitializeComponent();
            DataContext = this;

            //Get visitor id of clicked row
            this.visitor_id = Convert.ToString(id);

            VisitorBuild visitor = new VisitorBuild();
            this.listVisitor = visitor.findOne(visitor_id);

            formVisitorId.Text        = visitor_id;
            formVisitorLastName.Text = this.listVisitor.last_name;
            formVisitorFirstName.Text = this.listVisitor.first_name;
            formVisitorAddress.Text = this.listVisitor.address;

            hiringDate.SelectedDate = DateTime.Parse(this.listVisitor.recruitment_date);
            

        }

        private void updateVisitor_Click(object sender, EventArgs e)
        {
            VisitorBuild visitor = new VisitorBuild();
            
            try
            {
                DateTime? date = hiringDate.SelectedDate;
                hiringDateText = date.Value.ToShortDateString();

                string[] dateSplit = hiringDateText.Split('/');
                hiringDateText = dateSplit[2] + "-" + dateSplit[1] + "-" + dateSplit[0];

                lastName = formVisitorLastName.Text;
                firstName = formVisitorFirstName.Text;
                address = formVisitorAddress.Text;
                departement = cboDepartement.SelectedValue.ToString();
                typeId = formVisitorMemberId.Text;
            }
            catch { }

            departement = cboDepartement.SelectedValue.ToString();

            TextResult result = visitor.update(visitor_id, lastName, firstName, address, hiringDateText, departement, typeId);

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
