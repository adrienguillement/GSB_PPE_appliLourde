using Models.src.build;
using Models.src.metiers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_PPE
{
    public partial class AddVisitor : Form
    {
        private List<Visitor> listVisitor;

        public AddVisitor()
        {
            InitializeComponent();
        }

        private void AddVisitor_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisitorBuild visitor = new VisitorBuild();
            TextResult result = visitor.addOne(last_name.Text,first_name.Text,address.Text,recruitmentDate.Text,departementId.Text,typeId.Text);

            if(result.message == "Success")
            {
                MessageBox.Show("Le visiteur à bien été inséré.", result.message,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Le visiteur existe déjà.", result.message,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
            }
            

        }
    }
}
