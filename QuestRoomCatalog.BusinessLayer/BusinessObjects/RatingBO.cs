using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomCatalog.BusinessLayer.BusinessObjects
{
    public class RatingBO
    {
        public int Id { get; set; }

        public int QuestRoomId { get; set; }

        public int RatingLevel { get; set; }

        public QuestsRoomsBO QuestsRooms { get; set; }
    }
}
