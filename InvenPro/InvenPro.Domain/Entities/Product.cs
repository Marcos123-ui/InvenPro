using InvenPro.Domain.Core;

namespace InvenPro.Domain.Entities
{
    public class Product:BaseEntity
    {
        [key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SupplierId { get; set; }
        public Suppliers Suppliers { get; set; } 
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        
    }
}
