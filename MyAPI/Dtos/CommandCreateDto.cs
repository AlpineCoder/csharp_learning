using System.ComponentModel.DataAnnotations;

namespace MyAPI.Dtos
{
    public class CommandCreateDto
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
        // public string Platform { get; set; }
    }
}