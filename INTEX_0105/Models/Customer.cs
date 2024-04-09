using System.ComponentModel.DataAnnotations;

namespace INTEX_0105.Models
{
    public class Customer
    {
        [Key]
        public int customer_ID {  get; set; }
        public required string first_name { get; set; }
        public required string last_name { get; set;}
        public required string birth_date { get; set; }
        public required string country_of_residence { get; set; }
        public required string gender { get; set; }
        public int age { get; set; }
    }
}
