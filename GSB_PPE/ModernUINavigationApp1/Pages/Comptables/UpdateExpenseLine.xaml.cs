using Models.src.build;
using ModernUINavigationApp1.src.build;
using ModernUINavigationApp1.src.metiers;
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
    /// Interaction logic for UpdateExpenseLine.xaml
    /// </summary>
    public partial class UpdateExpenseLine : UserControl
    {
        private string expenseLine_id, dateExpenseLine;
        private List<ExpenseLine> listExpenseLine;
        private TextResult textResultUpdate;

        public UpdateExpenseLine(string expenseLineID)
        {
            this.expenseLine_id = expenseLineID;

            //get all properties of expense line with get id in parameter
            ExpenseLineBuild expenseLine = new ExpenseLineBuild();
            this.listExpenseLine = expenseLine.findById(expenseLine_id);

            InitializeComponent();

            //fill form
            expenseLineName.Text = listExpenseLine[0].name;
            expenseLineAmount.Text = listExpenseLine[0].amount;
            dateExpenseLine = calendarPicker.SelectedDate.ToString();
        }

        //if user click on update button
        private void UpdateExpenseLine_Click(object sender, EventArgs e)
        {
            try
            {
                //update call method
                ExpenseLineBuild expenseLine = new ExpenseLineBuild();
                this.textResultUpdate = expenseLine.update(this.listExpenseLine[0].id, this.listExpenseLine[0].type,
                                                            expenseLineName.Text, calendarPicker.SelectedDate.ToString(),
                                                            expenseLineAmount.Text, this.listExpenseLine[0].expense_report_id);
                MessageBox.Show("La modification à bien été effectué.");
            }
            catch
            {
                MessageBox.Show("Une erreur est survenue.");
            }
            
        }
    }
}
