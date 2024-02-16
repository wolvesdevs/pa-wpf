using System.Collections.ObjectModel;

namespace WpaApp1.Domain.Entities
{
    public class Dto(string name)
    {
        public Dto(string fileName, string name) : this(name)
        {
            FileName = fileName;
        }

        public string FileName { get; set; }
        public string Name { get; set; } = name;
        public List<Dto> Dtos { get; set; } = new();
    }
}
