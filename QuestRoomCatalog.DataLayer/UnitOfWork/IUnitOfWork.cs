using QuestRoomCatalog.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomCatalog.DataLayer.UnitOfWork
{
    public interface IUnitOfWork<T> : IDisposable where T : class
    {
        Repository<T> EntityUowRepository { get; }

        void Save();
        void BeginTransaction();
        void CommitTransaction();

    }
}
