using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FreeMountainTest.Models
{
    [Table("CAMPAIGNS")]
    public partial class Campaign
    {
        [Key]
        [Column("MFID")]
        public string Mfid { get; set; }
        [Required]
        [Column("MFID_DESCRIPTION")]
        [StringLength(100)]
        public string MfidDescription { get; set; }
        [Required]
        [Column("PROMOTION")]
        [StringLength(9)]
        public string Promotion { get; set; }
        [Column("CLIENT")]
        [StringLength(10)]
        public string Client { get; set; }
        [Column("CHANNEL")]
        [StringLength(5)]
        public string Channel { get; set; }
        [Column("SEED_LIST")]
        public int? SeedList { get; set; }
        [Column("DTS_DATE", TypeName = "datetime")]
        public DateTime? DtsDate { get; set; }
        [Column("EXTRACT_DATE", TypeName = "datetime")]
        public DateTime? ExtractDate { get; set; }
        [Column("PRINT_VENDOR")]
        [StringLength(5)]
        public string PrintVendor { get; set; }
        [Column("WAVE")]
        [StringLength(20)]
        public string Wave { get; set; }
        [Column("EXTRACT_SQL")]
        public string ExtractSql { get; set; }
        [Column("AML_UNIVERSE")]
        [StringLength(10)]
        public string AmlUniverse { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("AV_REQUIRED")]
        [StringLength(1)]
        public string AvRequired { get; set; }
        [Column("ALLOW_RENTAL_LIST")]
        [StringLength(1)]
        public string AllowRentalList { get; set; }
        [Column("RECURRANCE")]
        [StringLength(1)]
        public string Recurrance { get; set; }
        [Column("ALERT_NUM")]
        [StringLength(20)]
        public string AlertNum { get; set; }
        [Column("REVISION_NUM")]
        [StringLength(20)]
        public string RevisionNum { get; set; }
        [Column("EXTRACT_VIEW")]
        [StringLength(255)]
        public string ExtractView { get; set; }
        [Column("HTML_LOCATION")]
        [StringLength(255)]
        public string HtmlLocation { get; set; }
        [Column("AMAZON_CODE")]
        [StringLength(1)]
        public string AmazonCode { get; set; }
        [Column("EMAIL_SUBJECT")]
        [StringLength(100)]
        public string EmailSubject { get; set; }
        [Column("ISCONSUMER")]
        [StringLength(1)]
        public string Isconsumer { get; set; }
        [Column("ISINFLUENCER")]
        [StringLength(1)]
        public string Isinfluencer { get; set; }
        [Column("WORK_FLOW")]
        [StringLength(1)]
        public string WorkFlow { get; set; }
        [Column("CUSTOMER_SEARCH")]
        [StringLength(1)]
        public string CustomerSearch { get; set; }
        [Column("SEQ_NUM")]
        public int SeqNum { get; set; }
    }
}