﻿using System;
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
using System.Windows.Shapes;

namespace System1.currMain
{
    /// <summary>
    /// apartmentSignEdit.xaml 的交互逻辑
    /// </summary>
    public partial class apartmentSignEdit : Window
    {
        public apartmentSignEdit()
        {
            InitializeComponent();
        }

        private void doSignEdit_Click(object sender, RoutedEventArgs e)
        {
            //早点到信息修改操作
            Close();
        }

        private void doCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
