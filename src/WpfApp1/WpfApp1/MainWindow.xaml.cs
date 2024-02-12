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
        public MainWindow()
        {
            InitializeComponent();
            ReadDatabase();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var f = new SaveView(null);
            f.ShowDialog();
            ReadDatabase();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //var filterList = _customer.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            //CustomerListView.ItemsSource = filterList;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null)
            {
                MessageBox.Show("名前を選択してください。");
                return;
            }

            var f = new SaveView(item);
            f.ShowDialog();
            ReadDatabase();
        }

        private void DelteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReadDatabase()
        {
            using (var connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Customer>();
                CustomerListView.ItemsSource = connection.Table<Customer>().ToList();
            }
        }
    }
}