namespace Main.Other.Hierarchy
{
    public class Person
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }

        public Person(int id, int parentId, string name, string company, string position)
        {
            Id = id;
            ParentId = parentId;
            Name = name;
            Company = company;
            Position = position;
        }
    }
}
