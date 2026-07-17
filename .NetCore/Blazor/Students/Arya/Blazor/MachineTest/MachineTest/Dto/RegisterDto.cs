    using System.ComponentModel.DataAnnotations;

    namespace MachineTest.Dto
    {
        public class RegisterDto
        {

     
            [Required]
            public string Email{ get; set; }

            [Required]
            public string StudentName { get; set; }

            [Required]
            public string Course { get; set; }

            [Required]
            public int Age { get; set; }
        }
    }