using System.ComponentModel.DataAnnotations;

namespace CashDash.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int EmployeeTypeID { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Date)]
        public DateOnly AdmissionDate { get; set; }
        public bool IsActive { get; set; }
    }
}
