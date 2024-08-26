using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Models 
{
    public enum TasksStatus
    {
        Pendente,
        Concluida,
        Cancelada
    }


    [Table("tasks")]
    public class TaskModel
    {
        [JsonIgnore]
        [Key]
        [Column("id_task")]
        public long Id {get; set;}

        [Column("Title")]
        [MaxLength(30)]
        public required string Title {get; set;}

        [Column("Description")]
        [MaxLength(200)]
        public required string Description {get; set;}

        [Column("Status")]
        public string Status {get; set;}

        [Column("Creation_date")]
        public DateTime CreationDate {get; set;} = DateTime.Now;

        [Column("Conclusion_date")]
        public DateTime? ConclusionDate {get; set;}

        [Column("id_user")]
        public long IdUser {get; set;}

        public User User {get; set;}
    }
}