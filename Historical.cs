namespace NovelManagementSystem
{
    public class Historical : Novel
    {
        public string Type { get; set; }
        public int Year { get; set; }

        public Historical(int id, string publisher, string type, int year)
            : base(id, publisher)
        {
            Type = type;
            Year = year;
        }

        public override string ToString()
        {
            return base.ToString() + $", Type: {Type}, Year: {Year}";
        }
    }
}
