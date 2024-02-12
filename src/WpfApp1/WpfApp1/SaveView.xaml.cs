using SQLite;
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
using WpfApp1.Objects;

namespace WpfApp1
{
    /// <summary>
    /// SaveView.xaml の相互作用ロジック
    /// </summary>
    public partial class SaveView : Window
    {
        private Customer _customer;

        public SaveView(Customer customer)
        {
            InitializeComponent();
            NameTextBox.Focus();

            _customer = customer;
            if (_customer != null)
            {
                NameTextBox.Text = _customer.Name;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if(NameTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("名前を入力してください。");
                return;
            }

            using(var connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Customer>();
                if (_customer == null)
                {
                    connection.Insert(new Customer(NameTextBox.Text));
                    this.Close();
                }
                else
                {
                    connection.Update(new Customer(_customer.Id, NameTextBox.Text));
                    this.Close();
                }
            }
        }
    }
}
