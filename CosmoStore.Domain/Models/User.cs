
using System.ComponentModel.DataAnnotations;


namespace CosmoStore.Domain.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        public string UserName { get; set; } = null!;

        public string DisplayName {  get; set; } = null!;

        public string EmailAddress { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;

        public string PSalt { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public ICollection<UserInventory> UserInverntories { get; set; } = new List<UserInventory>();
    }
}
