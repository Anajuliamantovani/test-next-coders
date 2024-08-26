using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models 
{
    [Table("user")]
    public class User
    {
        [Key]
        [Column("id_user")]
        public long Id { get; set; }

        [Column("name")]
        [MaxLength(20)]
        public required string name { get; set; }

        [Column("Email")]
        [MaxLength(50)]
        public required string email { get; set; }
    }
}