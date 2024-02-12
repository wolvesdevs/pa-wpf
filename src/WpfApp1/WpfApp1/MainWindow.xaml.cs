using SQLite;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Customer> _customers = new();
        private int _index = 0;

        public MainWindow()
        {
            InitializeComponent();

            _customers.Add(new Customer { Id = ++_index, Name = $"name{_index}", Phone = $"phone{_index}" });
            _customers.Add(new Customer { Id = ++_index, Name = $"name{_index}", Phone = $"phone{_index}" });
            _customers.Add(new Customer { Id = ++_index, Name = $"name{_index}", Phone = $"phone{_index}" });

            CustomerListView.ItemsSource = _customers;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            _customers.Add(new Customer { Id = ++_index, Name = $"name{_index}", Phone = $"phone{_index}" });
            CustomerListView.ItemsSource = _customers;
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