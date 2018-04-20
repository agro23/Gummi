using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummiList.Models
{
    [Table("GummiUsers")]
    public class GummiUser
    {
        [Key]
        public int GummiUserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public string Rating { get; set; }
        //public string Comment { get; set; }
    }
}