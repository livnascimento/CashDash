using System.ComponentModel.DataAnnotations;

namespace CashDash.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        [StringLength(8, MinimumLength = 8, ErrorMessage = "O código postal deve ter exatamente 8 caracteres.")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
        [DataType(DataType.Date)]
        public DateOnly RegisterDate { get; set; }
        public bool IsActive { get; set; }
    }
}
