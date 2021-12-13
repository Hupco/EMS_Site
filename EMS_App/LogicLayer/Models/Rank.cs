namespace LogicLayer.Models
{
    public class Rank
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Rank(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
