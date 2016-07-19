using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH_Repository.Models.Interface
{
    public interface IGMHCorpTabRepository
    {
        s_gmh_corp_tab_Result Get(string type, string corp_id);

        void SaveChanges();
    }
}
