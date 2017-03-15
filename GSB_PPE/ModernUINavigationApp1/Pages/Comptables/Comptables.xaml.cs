using Models.src.build;
using Models.src.metiers;
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
    /// Interaction logic for Comptables.xaml
    /// </summary>
    public partial class Comptables : UserControl
    {
        public List<Visitor> listVisitor { get; set; }

        private List<ExpenseReport> listExpenseReport;
        private List<ExpenseLine> listExpenseLine;
        private TextResult textResult, expenseReportUpState;
        //expenseReportUpState is the statement update for expense report
        private String expenseReportId;

        private String dateInput, visitor_id;

        public Comptables()
        {
            VisitorBuild visitor = new VisitorBuild();
            this.listVisitor = visitor.findAll();

            InitializeComponent();

            datagridExpense.Visibility = Visibility.Hidden;
            btnRefresh.Visibility = Visibility.Hidden;
            btnValidate.Visibility = Visibility.Hidden;

            DataContext = this;
        }

        //btn onclick "rechercher"
        private void filterBtn_Click(object sender, EventArgs e)
        {
            //hide and show some components
            datagridExpense.Visibility = Visibility.Visible;
            btnRefresh.Visibility = Visibility.Visible;
            btnValidate.Visibility = Visibility.Visible;

            textBlock.Visibility = Visibility.Hidden;
            cboVisitor.Visibility = Visibility.Hidden;
            btnFilter.Visibility = Visibility.Hidden;
            txtboxSelectDate.Visibility = Visibility.Hidden;
            calendarPicker.Visibility = Visibility.Hidden;

            dateInput = calendarPicker.SelectedDate.ToString();
            visitor_id = cboVisitor.SelectedValue.ToString();

            ExpenseReportBuild expenseReport = new ExpenseReportBuild();
            this.listExpenseReport = expenseReport.findByDateVisitor(dateInput, visitor_id);

            ExpenseLineBuild expenseLine = new ExpenseLineBuild();
            this.listExpenseLine = expenseLine.findOne(listExpenseReport[0].id.ToString());
            expenseReportId = listExpenseReport[0].id.ToString();
            datagridExpense.DataContext = listExpenseLine;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ExpenseLine obj = ((FrameworkElement)sender).DataContext as ExpenseLine;

            if(obj.type == "forfaitaire")
            {
                //open new window for form
                UpdateExpenseLine update = new UpdateExpenseLine(obj.id);
                var host = new Window();
                host.Content = update;
                host.Show();
            }
            else
            {
                //TODO
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ExpenseLine obj = ((FrameworkElement)sender).DataContext as ExpenseLine;

            if (obj.type == "hors-forfait")
            {
                ExpenseLineBuild expenseLine = new ExpenseLineBuild();
                this.textResult = expenseLine.update(obj.id, "REFUSEE : " + obj.type, obj.name, obj.expense_date, obj.amount, obj.expense_report_id);

                //refresh datagrid
                this.listExpenseLine = expenseLine.findOne(this.expenseReportId);
                datagridExpense.DataContext = listExpenseLine;
            }
            else
            {
                //TODO
            }
        }

        //if user click on button to refresh the datagrid
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            ExpenseLineBuild expenseLine = new ExpenseLineBuild();
            this.listExpenseLine = expenseLine.findOne(this.expenseReportId);
            datagridExpense.DataContext = listExpenseLine;
        }


        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            FollowBuild follow = new FollowBuild();
            this.expenseReportUpState = follow.update(this.expenseReportId,);
        }
    }
}
