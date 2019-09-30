using QuestRoomCatalog.BusinessLayer.BusinessObjects;
using QuestRoomCatalog.DataLayer;
using QuestRoomCatalog.DataLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomCatalog.BusinessLayer.Helpers
{
    public class QuestLogosHelper
    {
        IUnitOfWork<QuestsLogos> Db { get; set; }

        public QuestLogosHelper(UnitOfWork<QuestsLogos> uow)
        {
            Db = uow;
        }
        public void Create(QuestsLogosBO bo)
        {
            if(bo.Id == 0)
            {
                QuestsLogos questLogos = AutoMapper<QuestsLogosBO, QuestsLogos>.Map(bo);
                Db.EntityUowRepository.Add(questLogos);
                Db.Save();
            }
        }
    }
}
