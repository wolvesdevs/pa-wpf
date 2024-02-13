using SQLite;

namespace WpfApp1.Domain.Entities
{
    public class CustomerEntity()
    {
        public CustomerEntity(string name) : this()
        {
            Name = name;
        }

        public CustomerEntity(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
