using System;
using System.ComponentModel.DataAnnotations;

namespace chatbot.ViewModels.Account
{
    public class DeleteUserViewModel
    {
        [Required]
        [DataType("Password")]
        public string ValidationCode { get; set; }
    }
}
