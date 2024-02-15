namespace WpaApp1.Domain.Entities
{
    public class Dto(string fileName, string name)
    {
        public string FileName { get; set; } = fileName;
        public string Name { get; set; } = name;
    }
}
