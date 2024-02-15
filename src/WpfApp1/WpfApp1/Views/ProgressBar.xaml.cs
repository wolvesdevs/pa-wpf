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
using System.Windows.Shapes;

namespace WpfApp1.UI.Views
{
    /// <summary>
    /// ProgressBar.xaml の相互作用ロジック
    /// </summary>
    public partial class ProgressBar : Window
    {
        public ProgressBar()
        {
            InitializeComponent();
            ATextBlock.Text = $"{AProgressBar.Value} %";
            BTextBlock.Text = $"{BProgressBar.Value} %";
        }

        private void AProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ATextBlock.Text = $"{AProgressBar.Value} %";
        }

        private void AButton_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                for (int i = 0; i <= 10; i++)
                {
                    Dispatcher.Invoke(() =>
                    {
                        AProgressBar.Value += 10;
                    });
                    Thread.Sleep(500);
                }
            });
        }

        private void BProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BTextBlock.Text = $"{BProgressBar.Value} %";
        }

        private void BButton_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                for (int i = 0; i <= 10; i++)
                {
                    Dispatcher.Invoke(() =>
                    {
                        BProgressBar.Value += 10;
                    });
                    Thread.Sleep(500);
                }
            });
        }

        private void CProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void CButton_Click(object sender, RoutedEventArgs e)
        {
            CProgressBar.IsIndeterminate = true;
            CTextBlock.Text = "Now Loading...";
        }
    }
}
