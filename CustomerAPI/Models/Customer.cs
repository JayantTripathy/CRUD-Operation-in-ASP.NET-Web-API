using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CustomerAPI.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int CustId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}