using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InAndOut.Models
{
    public class Expense
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [DisplayName("Expense")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ExpenseName { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [Range(1, int.MaxValue, ErrorMessage ="Amount must be greater than 0!")]
        public int Amount { get; set; }

    }
}
