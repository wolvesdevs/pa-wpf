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
    /// Slider.xaml の相互作用ロジック
    /// </summary>
    public partial class Slider : Window
    {
        public Slider()
        {
            InitializeComponent();
        }

        private void ASlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ASlider.Text = e.NewValue.ToString();
        }

        private void BSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BSlider.Text = Math.Round(e.NewValue, 0).ToString();
        }

    }
}
