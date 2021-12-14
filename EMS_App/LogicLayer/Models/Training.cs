namespace LogicLayer.Models
{
    public class Training
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Training(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
