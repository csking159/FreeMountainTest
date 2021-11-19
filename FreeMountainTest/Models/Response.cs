using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FreeMountainTest.Models
{
    [Table("RESPONSES")]
    public class Response
    {
        [Key]
        [Required]
        [StringLength(12, ErrorMessage = "Response Code is a required field.")]
        [DisplayName("Response Code")]
        [Column("RESPONSE_CODE")]
        public string ResponseCode { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Response Description is a required field.")]
        [DisplayName("Response Description")]
        [Column("RESPONSE_DESCRIPTION")]
        public string ResponseDescription { get; set; }
        [Column("RESPONSE_TYPE")]
        [StringLength(20)]
        [DisplayName("Response Type")]
        public string ResponseType { get; set; }
        [Column("PROMOTION")]
        [StringLength(20)]
        public string Promotion { get; set; }
        [Column("CHANNEL")]
        [StringLength(5)]
        public string Channel { get; set; }
        [Column("START_DATE", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("END_DATE", TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column("LAST_UPDATE_DATE", TypeName = "datetime")]
        public DateTime? LastUpdateDate { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
    }
}