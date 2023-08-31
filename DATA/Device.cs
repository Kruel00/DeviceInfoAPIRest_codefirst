using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace DeviceInfoAPI
{
    public class Device
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int IndexNumber { get; set; }
        public string FriendlyName {get; set;}
        public string SerialNumber {get; set;}
        public string Manufacturer {get; set;}
        public string HealthStatus { get; set;}
        public bool OperationalStatus { get; set;}
        public string MediaType { get; set;}
        public long TotalSizePartition { get; set;}
        public bool   Enabled {get; set;}
        public string? FileTableType {get; set;}

        public virtual ICollection<Partition>? Partitions {get; set;}

    }

    public class Partition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("DeviceId")]
        public int DeviceId { get; set; }
        public float Size { get; set; }
        public string FileSystem{get; set;}

        public virtual Device device { get; set;}
    }
}

