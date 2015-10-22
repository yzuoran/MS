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

namespace System1.currTab
{
    /// <summary>
    /// currTab1.xaml 的交互逻辑
    /// </summary>
    public partial class currTab1 : UserControl
    {
        public currTab1()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            currMain.Content = new currMain.currContent1();
        }

        private void tab_butn1_Click(object sender, RoutedEventArgs e)
        {
            currMain.Content = new currMain.currContent1();
        }

        private void tab_btn2_Click(object sender, RoutedEventArgs e)
        {
            currMain.Content = new currMain.currContent1_2();
        }
    }
}
