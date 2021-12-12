namespace LogicLayer.Models
{
    public class Specialization
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Specialization(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
