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
        private List<ExpenseReport> listExpenseReport;
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

            ExpenseReportBuild expenseReport = new ExpenseReportBuild();
            this.listExpenseReport = expenseReport.findAll();

            this.dataGridView2.DataSource = listExpenseReport;

            this.visitorComboBox.DataSource = listVisitor.Select(c => c.full_name).ToList();

            var months = new[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };
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
            AddVisitor addVisitor = new AddVisitor();
            addVisitor.Show();
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {
                int visitor_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                VisitorBuild visitor = new VisitorBuild();
                TextResult result = visitor.delete(visitor_id);

                dataGridView1.DataSource = null;
                this.listVisitor = visitor.findAll();
                this.dataGridView1.DataSource = listVisitor;
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Modifier"].Index && e.RowIndex >= 0)
            {
                int visitor_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                updateVisitor updateVisitor = new updateVisitor(visitor_id);
                updateVisitor.Show();
                this.Visible = false;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void visitorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filterFullName_TextChanged(object sender, EventArgs e)
        {
            List<Visitor> filtered = this.listVisitor.FindAll(x => x.full_name.Contains(filterFullName.Text));
            this.visitorComboBox.DataSource = filtered.Select(c => c.full_name).ToList();
        }
    }
}
