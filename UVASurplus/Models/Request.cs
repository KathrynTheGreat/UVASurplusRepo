using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UVASurplus.Models;

namespace UVASurplus.Models
{
    public class Request
    {

        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Full Name")]
        public string? RequesterName { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "Computing ID")]
        public string ComputingID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Email")]
        public string? RequesterEmail { get; set; }

        public string? RequesterDepartment { get; set; }
        public string? RequesterPhoneNumber { get; set; }
        public string? RequesterBuilding { get; set; }
        public string? RequesterRoom { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Desired Date")]
        public DateTime? DesiredDate { get; set; }
        public string? AdditionalComments { get; set; }
        public bool NeedPickup { get; set; }
        public int? OProject { get; set; }
        public int? OTask { get; set; }
        public int? OAward { get; set; }
        public int? OOrg { get; set; }
        public bool TaggedAssets { get; set; }
        public bool HealthFunds { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Request Date")]
        public DateTime RequestDate { get; set; }
        public bool AdditionalReviewer { get; set; }
        public string? AdditionalReviewerCompID { get; set; }
        public string? RequestStatus { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
