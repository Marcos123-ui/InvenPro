namespace InvenPro.Domain.Entities
{
    public class Suppliers
    {
        [key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public char Gender { get; set; }
    }
}
