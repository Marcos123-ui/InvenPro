namespace InvenPro.Web.Models.Entities
{
    public class Suppliers
    {
        [key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Emai { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public char Gender { get; set; }
    }
}
