using System.ComponentModel.DataAnnotations;

namespace INTEX_0105.Models
{
    public class Order
    {
        [Key]
        public int transaction_ID { get; set; }
        public int customer_ID { get; set; }
        public DateTime date {  get; set; }
        public required string day_of_week { get; set; }
        public int time {  get; set; }
        public required string entry_mode { get; set; }
        public int amount { get; set; }
        public required string type_of_transaction { get; set; }
        public required string country_of_transaction { get; set; }
        public required string shipping_address { get; set; }
        public required string bank {  get; set; }
        public required string type_of_card { get; set; }
        public int fraud {  get; set; }
    }
}
