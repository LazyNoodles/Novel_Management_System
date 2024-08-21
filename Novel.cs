namespace NovelManagementSystem
{
    public abstract class Novel
    {
        public int ID { get; set; }
        public string Publisher { get; set; }

        protected Novel(int id, string publisher)
        {
            ID = id;
            Publisher = publisher;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Publisher: {Publisher}";
        }
    }
}
