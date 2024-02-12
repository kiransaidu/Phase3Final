using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phase3Final.Models
{
    public class DeptMaster
    {
        public int DeptCode { get; set; }
        public string? DeptName { get; set; }
        [StringLength(100)]
        [ForeignKey("DeptCode")]
        public virtual ICollection<EmpProfile>EmpProfiles{ get; set; }
    }
}
