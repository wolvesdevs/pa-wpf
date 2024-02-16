using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpaApp1.Domain.Entities;

namespace WpfApp1.UI.Views
{
    /// <summary>
    /// ListBoxView.xaml の相互作用ロジック
    /// </summary>
    public partial class ListBoxView : Window
    {
        private ObservableCollection<Dto> _dtos = new();

        public ListBoxView()
        {
            InitializeComponent();

            _dtos.Add(new Dto("/Images/A.jpeg", "Shinichi ONO"));
            _dtos.Add(new Dto("/Images/B.jpeg", "Jyunta INAMOTO"));
            _dtos.Add(new Dto("/Images/C.jpeg", "Naotaro TAKAHARA"));

            MyListBox.ItemsSource = _dtos;
            SingleRadioButton.IsChecked = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(SingleRadioButton.IsChecked == true)
            {
                MyListBox.SelectionMode = SelectionMode.Single;
            }
            else if(ExtendedRadioButton.IsChecked == true)
            {
                MyListBox.SelectionMode = SelectionMode.Extended;
            }
            else
            {
                MyListBox.SelectionMode = SelectionMode.Multiple;
            }
        }
    }
}
