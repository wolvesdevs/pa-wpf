using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp1.UI
{
    /// <summary>
    /// SubWindow1.xaml の相互作用ロジック
    /// </summary>
    public partial class SubWindow1 : Window
    {
        public SubWindow1()
        {
            InitializeComponent();
        }

        private void NormalButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NormalButton is clicked!!");
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")} RepeatButton");
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"toggle button click {ToggleButton.IsChecked}");
        }
    }
}
