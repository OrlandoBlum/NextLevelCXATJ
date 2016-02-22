using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    class CurrencyManager
    {
        public static List<CURRENCY> GetAllCurrencys()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.CURRENCY.ToList();
        }

        public CURRENCY GetCurrencyById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.CURRENCY)
            {
                if (a.CURRENCY_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.CURRENCY)
            {
                if (a.CURRENCY_ID == id)
                {
                    MaderaEntities.CURRENCY.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetCurrency(CURRENCY CurrencyUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.CURRENCY.Add(CurrencyUp);
            MaderaEntities.SaveChanges();
        }
    }
}
