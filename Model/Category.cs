using System.ComponentModel.DataAnnotations;
/*SQL SERVER NAME: (localdb)\MSSQLLocalDB*/

namespace DavidWeb.Model
{
    public class Category
    {
        /*Sets the primary key to Id*/
        [Key]
        public int Id { get; set; }
        /*Makes the Name category required*/
        [Required]
        public string Name { get; set; }
        [Display(Name="Display Order")]
        [Range(1,100,ErrorMessage="Display order must be between 1-100!")]
        public int DisplayOrder { get; set; }
    }
}
