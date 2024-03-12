using MessagePack;
using System.ComponentModel;

namespace InAndOut.Models
{
    public class ExpenseType
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [DisplayName("Expense")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    }
}
