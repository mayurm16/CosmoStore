using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CosmoStore.Domain.Models
{
    public class Studio
    {
        [Key]
        public Guid Id {  get; set; }

        public string StudioName { get; set; } = null!;

        [ForeignKey(nameof(ParentStudio))]
        public Guid? parentStudioID { get; set; }
        
        public string About { get; set; } = null!;

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public Studio? ParentStudio { get; set; }


    }
}
