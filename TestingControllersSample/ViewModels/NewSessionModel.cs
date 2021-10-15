using System.ComponentModel.DataAnnotations;

namespace TestingControllersSample.ViewModels
{
    public class NewSessionModel
    {
        [Required]
        public string SessionName { get; set; }
    }
}
