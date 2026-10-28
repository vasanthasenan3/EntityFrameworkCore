using System.ComponentModel.DataAnnotations;

namespace Asp.netpractice.Models
{
    public class Students
    {
    
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter the Name")]
        public string Name { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter the Department")]
        public string Department { get; set; }

        [DataType(DataType.Text)]
        [EmailAddress(ErrorMessage = "Please enter the valid Email")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]

        public string PhoneNo { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter the FeePending")]
        public int FeePending { get; set; }
      

    }
}
