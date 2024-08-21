namespace NovelManagementSystem
{
    public class Thriller : Novel
    {
        public int Volumes { get; set; }

        public Thriller(int id, string publisher, int volumes)
            : base(id, publisher)
        {
            Volumes = volumes;
        }

        public override string ToString()
        {
            return base.ToString() + $", Volumes: {Volumes}";
        }
    }
}
