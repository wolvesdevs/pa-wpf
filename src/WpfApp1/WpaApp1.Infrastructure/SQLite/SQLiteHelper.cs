namespace WpfApp1.Infrastructure.SQLite
{
    public static class SQLiteHelper
    {
        static SQLiteHelper()
        {
            string databaseName = "Customer.db";
            string folderPath = @"C:\Project\Practice\PAnderson\WPF\pa-wpf\db";
            DatabasePath = Path.Combine(folderPath, databaseName);
        }

        public static string DatabasePath { get; }
    }
}
