using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class ProcessInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {  get; set; }
        public string Model { get; set; }   
        public string SerialNumber { get; set; }
        public string App { get; set; }
        public string Area { get; set; }
        public string Customer { get; set; }
        public DateTime InsertedOn { get; set; }
        public string InsertedBy { get; set; }
        public string Result { get; set; }
        public bool Active { get; set; }

        IEnumerable<ProcessInfoDetails> processInfosList { get;}
    }


    public class ProcessInfoDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKeyAttribute("ProcessInfoId")]
        public int ProcessInfoId { get; set; }
        public string Type { get; set; }
        public string ProcessName { get; set; } 
        public string Value { get; set; }
        public string Details { get; set; }    
    }
}
