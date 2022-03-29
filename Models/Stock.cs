using System.ComponentModel.DataAnnotations;
namespace radzure.Models
{
    public class Stock
    {
      [Key]
      public int ItemNo { get; set; }
      public string Description { get; set; } = string.Empty;
      public int Quantity { get; set; }
    }
}
