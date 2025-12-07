using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CosmoStore.Domain.Models
{
    public class UserInventory
    {
        [Key]
        public Guid ItemId { get; set; }

        public string ItemName { get; set; } = null!;

        [ForeignKey(nameof(Product))]
        public Guid ItemProduct {  get; set; }

        public string ItemDesc { get; set; } = null!;

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public User? User { get; set; }

        public Product Product { get; set; }
    }
}
