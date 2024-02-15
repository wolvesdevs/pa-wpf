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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpaApp1.Domain.Entities;

namespace WpfApp1.UI.Views
{
    /// <summary>
    /// ComboBox.xaml の相互作用ロジック
    /// </summary>
    public partial class ComboBox : Window
    {
        private ObservableCollection<Customer2Entity> _customers = new();

        public ComboBox()
        {
            InitializeComponent();

            _customers.Add(new Customer2Entity { Id = 1, Name = "Customer 1", Phone = "123-456-7890" });
            _customers.Add(new Customer2Entity { Id = 2, Name = "Customer 2", Phone = "123-456-7890" });
            _customers.Add(new Customer2Entity { Id = 3, Name = "Customer 3", Phone = "123-456-7890" });

            AComboBox.ItemsSource = _customers;

            AComboBox.Focus();
        }

        private void AButton_Click(object sender, RoutedEventArgs e)
        {
            var item = AComboBox.SelectedItem as Customer2Entity;
            if (item != null)
            {
                var sb = new StringBuilder();
                sb.AppendLine($"SelectedItem: {AComboBox.SelectedItem as Customer2Entity}");
                sb.AppendLine($"SelectedValuePath: {AComboBox.SelectedValuePath}");
                sb.AppendLine($"SelectedDisplayMemberPath: {AComboBox.DisplayMemberPath}");
                sb.AppendLine("-----------------------------");
                sb.AppendLine($"SelectedIndex: {AComboBox.SelectedIndex}");
                sb.AppendLine($"SelectedValue: {AComboBox.SelectedValue}");
                sb.AppendLine($"Text: {AComboBox.Text}");
                sb.AppendLine("-----------------------------");
                sb.AppendLine($"Id: {item.Id}");
                sb.AppendLine($"Name: {item.Name}");
                sb.AppendLine($"Phone: {item.Phone}");

                MessageBox.Show(sb.ToString());
            }
        }
    }
}
