namespace CRUD_Operation.Models.Entities
{
    public class Student
    {
        internal Guid id;

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool Subscribed { get; set; }  

    }
}
