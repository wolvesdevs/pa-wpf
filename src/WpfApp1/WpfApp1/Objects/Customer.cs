using SQLite;

namespace WpfApp1.Objects
{
    public class Customer()
    {
        public Customer(string name) : this()
        {
            Name = name;
        }

        public Customer(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
