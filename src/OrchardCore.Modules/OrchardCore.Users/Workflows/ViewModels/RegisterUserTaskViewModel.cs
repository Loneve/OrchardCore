using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrchardCore.Users.Workflows.ViewModels
{
    public class RegisterUserTaskViewModel
    {
        public bool SendConfirmationEmail { get; set; }

        [Required]
        public string ConfirmationEmailTemplate { get; set; }
    }
}
