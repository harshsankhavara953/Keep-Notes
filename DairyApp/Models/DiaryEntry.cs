using System.ComponentModel.DataAnnotations;

namespace DairyApp.Models
{
    public class DiaryEntry
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Title")]

        public string Title { get; set; }=string.Empty;
        [Required]
        [StringLength(100,MinimumLength =4,ErrorMessage = "Notes must be between 4 to 100 characters")]
        public string Content { get; set; }=string.Empty;   
        [Required]
        public DateTime Created{ get; set; }=DateTime.Now; 
    }
}
