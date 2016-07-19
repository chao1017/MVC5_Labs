using MH_Repository.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MH_Repository.Models
{
    public class GMHCorpTabRepository : IGMHCorpTabRepository, IDisposable
    {
        protected CTCI_MH_DBEntities db
        {
            get;
            private set;
        }

        public GMHCorpTabRepository()
        {
            this.db = new CTCI_MH_DBEntities();
        }

        public s_gmh_corp_tab_Result Get(string type, string corp_id)
        {
            s_gmh_corp_tab_Result result = null;

            using (var ctx = new CTCI_MH_DBEntities())
            {
                var r = ctx.s_gmh_corp_tab("1", "9933");
            }

            return result;
        }

        public void SaveChanges()
        {
            this.db.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.db != null)
                {
                    this.db.Dispose();
                    this.db = null;
                }
            }
        }
    }
}