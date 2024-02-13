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

namespace WpfApp1.UI
{
    /// <summary>
    /// RadioButtonView.xaml の相互作用ロジック
    /// </summary>
    public partial class RadioButtonView : Window
    {
        public RadioButtonView()
        {
            InitializeComponent();
        }

        private void ARadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton == CRadioButton)
            {

            }
            else if (radioButton == DRadioButton)
            {

            }
        }
    }
}
