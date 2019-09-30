using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class QuestsLogosViewModel
    {
        public int Id { get; set; }

        public int QuestRoomId { get; set; }

        [Required]
        public byte[] Image { get; set; }

        public bool IsLogo { get; set; }
    }
}