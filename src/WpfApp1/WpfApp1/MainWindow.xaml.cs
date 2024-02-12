using SQLite;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Objects;

namespace WpfApp1
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var customer = new Customer()
            {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
            };

            using(var connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }
        }

        private void ReadButton_Click(object sender, RoutedEventArgs e)
        {
            using (var connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Customer>();
                var customers = connection.Table<Customer>().ToList();
            }
        }
    }
}