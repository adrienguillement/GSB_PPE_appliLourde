using Models.src.build;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.src.metiers;

namespace GSB_PPE
{
    public partial class updateVisitor : Form
    {
        private Visitor listVisitor;
        private List<Departement> listDepartement;
        private int oneDepartement;

        public updateVisitor(int strTextBox)
        {
            InitializeComponent();
            int visitor_id = strTextBox;
            visitorIdUpdate.Text = Convert.ToString(strTextBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }

        private void lastNameUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateVisitor_Load(object sender, EventArgs e)
        {
            VisitorBuild visitor = new VisitorBuild();
            this.listVisitor = visitor.findOne(visitorIdUpdate.Text);
            lastNameUpdate.Text        = listVisitor.last_name;
            fisrtNameUpdate.Text       = listVisitor.first_name;
            adressUpdate.Text          = listVisitor.address;
            recrutementDateUpdate.Text = listVisitor.recruitment_date;

            DepartementBuild departement = new DepartementBuild();
            this.listDepartement = departement.findAll();
            this.comboBox1.DataSource = listDepartement.Select(c => c.name).ToList();
        }

        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            string departementName = comboBox1.Text;
            DepartementBuild departement = new DepartementBuild();
            this.oneDepartement = departement.findOneByName(departementName);

            VisitorBuild visitor = new VisitorBuild();
            TextResult result = visitor.update(Convert.ToInt32(visitorIdUpdate.Text), lastNameUpdate.Text, fisrtNameUpdate.Text, adressUpdate.Text, recrutementDateUpdate.Text,oneDepartement);

            if (result.message == "Success")
            {
                MessageBox.Show("Le visiteur à bien été modifié.", result.message,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Il y a une erreur.", "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
            }
        }
    }
}
