

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CosmoStore.Domain.Models
{
    public class UserWishList
    {
        [Key]
        public Guid WhishlistId {  get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public User User { get; set; }

        public Product Product { get; set; }
    }
}
