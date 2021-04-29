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
using Soft_AEATE.Codes;

namespace Soft_AEATE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ButSel_Click(object sender, RoutedEventArgs e)
        {
            Employee Chad = new Employee
               ("Чад", "GayBar12Street", 25, "Dancer", 15, 1591);
            TestTex.Text = Chad.Name + " Salary is " +  Chad.Salary;
        }
    }
}
