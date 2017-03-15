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

        private String dateInput, visitor_id;

        public Comptables()
        {
            VisitorBuild visitor = new VisitorBuild();
            this.listVisitor = visitor.findAll();

            InitializeComponent();

            datagridExpense.Visibility = Visibility.Hidden;
            DataContext = this;
        }

        //btn onclick "rechercher"
        private void filterBtn_Click(object sender, EventArgs e)
        {
            //hide and show some components
            datagridExpense.Visibility = Visibility.Visible;
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
            datagridExpense.DataContext = listExpenseLine;
        }
    }
}
