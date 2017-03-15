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

namespace ModernUINavigationApp1.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        private List<Member> listMember;

        public Login()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            MemberBuild member = new MemberBuild();
            //try
            //{
                this.listMember = member.connect(mailTxtBox.Text, passwordTxtBox.Password);
                if (this.listMember[0].groupe_id == "3")
                {
                    //open new window
                    Comptables.Comptables comptables = new Comptables.Comptables();
                    var host = new Window();
                    host.Content = comptables;
                    host.Show();
                }
                else
                {
                    infoConnect.Text = "Vous n'avez pas l'autorisation de continuer.";
                }
            //}
            //catch
            //{
            //   infoConnect.Text = "Mauvais identifiants.";
            //}
        }
    }
}