namespace NovelManagementSystem
{
    public class Fantasy : Novel
    {
        public string Author { get; set; }
        public int Pages { get; set; }

        public Fantasy(int id, string publisher, string author, int pages)
            : base(id, publisher)
        {
            Author = author;
            Pages = pages;
        }

        public override string ToString()
        {
            return base.ToString() + $", Author: {Author}, Pages: {Pages}";
        }
    }
}
