using QuestRoomCatalog.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomCatalog.DataLayer.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly Model1 db;
        private bool disposed = false;

        Repository<T> _entityUowRepository;

        public Repository<T> EntityUowRepository
        {
            get
            {
                return _entityUowRepository == null ? new Repository<T>(db) : _entityUowRepository;
            }
        }

        public UnitOfWork()
        {
            db = new Model1();
        }

        public UnitOfWork(Model1 db)
        {
            this.db = db;
            db.Database.CommandTimeout = 180;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void BeginTransaction()
        {
            db.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            db.Database.CurrentTransaction.Commit();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                if (disposing)
                {
                    if (db != null)
                    {
                        db.Dispose();
                    }
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
