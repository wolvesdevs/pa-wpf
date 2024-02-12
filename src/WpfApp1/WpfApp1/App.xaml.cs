using System.Configuration;
using System.Data;
using System.Windows;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string databaseName = "Customer.db";
        static string folderPath = @"C:\Project\Practice\PAnderson\WPF\pa-wpf\db";
        public static string databasePath = Path.Combine(folderPath, databaseName);
    }

}
