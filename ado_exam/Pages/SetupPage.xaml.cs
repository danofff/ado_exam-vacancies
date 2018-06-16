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

namespace ado_exam.Pages
{
    /// <summary>
    /// Interaction logic for SetupPage.xaml
    /// </summary>
    public partial class SetupPage : Page
    {
        public SetupPage()
        {
            InitializeComponent();
            vacancies.Content = MainWindow.db.Vacancies.Count();
            categories.Content = MainWindow.db.Categories.Count();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.db.Database.ExecuteSqlCommand("delete from vacancies");
            MainWindow.db.Database.ExecuteSqlCommand("delete from categories");     
        }
    }
}