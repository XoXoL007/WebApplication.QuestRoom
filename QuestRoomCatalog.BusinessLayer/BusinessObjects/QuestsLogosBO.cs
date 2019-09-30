namespace QuestRoomCatalog.BusinessLayer.BusinessObjects
{
    public class QuestsLogosBO
    {
        public int Id { get; set; }

        public int QuestRoomId { get; set; }
        [Required]
        public byte[] Image { get; set; }

        public bool IsLogo { get; set; }

        public QuestsRoomsBO QuestsRoomsBO { get; set; }
    }
}
