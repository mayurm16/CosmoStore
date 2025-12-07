
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CosmoStore.Domain.Models
{
    public class Product
    {

        [Key]
        public Guid Id { get; set; }

        public string? ProductUniqueName { get; set; }

        public string? ProductPublicName { get; set; }

        public DateTime ProductReleaseDate {  get; set; }

        public Decimal ProductVersion { get; set; }

        public bool ProductEarlyAccess { get; set; }

        public string ProductBasicDesc { get; set; } = null!;

        public string AboutProduct { get; set; } = null!;

        [ForeignKey(nameof(Developer))]
        public Guid ProductDeveloper { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        [ForeignKey(nameof(Publisher))]
        public Guid ProductPublisher { get; set; }

        public Studio Developer { get; set; }

        public Studio Publisher { get; set; }
    }
}
