using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.src.build;
using Models.src.metiers;
using System.Diagnostics;

namespace GSB_PPE
{
    public partial class Form1 : Form
    {
        private List<Visitor> listVisitor;

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VisitorBuild visitor = new VisitorBuild();
            this.listVisitor = visitor.findAll();

            this.dataGridView1.DataSource = listVisitor;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void last_name_visitor_TextChanged_1(object sender, EventArgs e)
        {
            List<Visitor> filtered = this.listVisitor.FindAll(x => x.last_name.Contains(last_name_visitor.Text) && x.first_name.Contains(first_name_visitor.Text));
            this.dataGridView1.DataSource = filtered;
        }

        private void first_name_visitor_TextChanged(object sender, EventArgs e)
        {
            List<Visitor> filtered = this.listVisitor.FindAll(x => x.first_name.Contains(first_name_visitor.Text) && x.last_name.Contains(last_name_visitor.Text));
            this.dataGridView1.DataSource = filtered;
        }

        private void recruitment_date_TextChanged(object sender, EventArgs e)
        {
            List<Visitor> filtered = this.listVisitor.FindAll(x => x.recruitment_date.Contains(recruitment_date.Text) && x.first_name.Contains(first_name_visitor.Text) && x.last_name.Contains(last_name_visitor.Text));
            this.dataGridView1.DataSource = filtered;
        }

        private void newVisitorButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddVisitor addVisitor = new AddVisitor();
            addVisitor.Show();
        }
    }
}
