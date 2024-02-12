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
        private List<Customer> _customers = new();

        public MainWindow()
        {
            InitializeComponent();

            _customers.Add(new Customer { Id = 1, Name = "name1", Phone = "phone1" });
            _customers.Add(new Customer { Id = 2, Name = "name2", Phone = "phone2" });
            _customers.Add(new Customer { Id = 3, Name = "name3", Phone = "phone3" });

            CustomerListView.ItemsSource = _customers;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void SaveButton_Click(object sender, RoutedEventArgs e)
        //{
        //    var customer = new Customer()
        //    {
        //        Name = NameTextBox.Text,
        //        Phone = PhoneTextBox.Text,
        //    };

        //    using(var connection = new SQLiteConnection(App.databasePath))
        //    {
        //        connection.CreateTable<Customer>();
        //        connection.Insert(customer);
        //    }
        //}

        //private void ReadButton_Click(object sender, RoutedEventArgs e)
        //{
        //    using (var connection = new SQLiteConnection(App.databasePath))
        //    {
        //        connection.CreateTable<Customer>();
        //        var customers = connection.Table<Customer>().ToList();
        //    }
        //}
    }
}