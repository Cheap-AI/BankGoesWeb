using System;
using System.ComponentModel.DataAnnotations;

namespace BankGoesWebModel
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Max 50 characters")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Max 50 characters")]
        public string LastName { get; set; }

        public int NumAccounts { get; set; }

        public Customer()
        {

        }
    }
}
