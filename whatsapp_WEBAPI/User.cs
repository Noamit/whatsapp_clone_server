using System.ComponentModel.DataAnnotations;

namespace whatsapp_WEBAPI
{
    public class User
    {
        [Key]
        [Required]
        public string Id { get; set; }

        public string? user { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string password { get; set; }

        //displayName
        public string? Name { get; set; }

    }
}
