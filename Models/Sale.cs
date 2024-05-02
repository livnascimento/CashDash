namespace CashDash.Models
{
    public class Sale
    {
        public int SaleID { get; set; }
        public DateTime SaleDateTime { get; set; } = DateTime.Now;
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}
