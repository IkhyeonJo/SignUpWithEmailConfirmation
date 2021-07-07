using System.Collections.Generic;

namespace SignupWithMailConfirmation.Models
{
    public class Mail
    {
        //public string FromMailId { get; set; } = "javalised@gmail.com";
        public string FromMailId { get; set; } = "mylaboratorymailserver@gmail.com";
        public string FromMailIdPassword { get; set; } = "rnrmf12!@#";
        public List<string> ToMailIds { get; set; } = new List<string>();
        public string Subject { get; set; } = "";
        public string Body { get; set; } = "";
        public bool IsBodyHTML { get; set; } = true;
        public List<string> Attachments { get; set; } = new List<string>();
    }
}