using System.ComponentModel.DataAnnotations;

namespace Naxxum.Enlightenment.User.Domain;

    // Register DTO
    public class RegisterDTO
    {


  
        [Required]
      public string Role { get; set; } = null!;


        [Required]
     public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;



    }

