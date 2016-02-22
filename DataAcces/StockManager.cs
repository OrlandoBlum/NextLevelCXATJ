using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class StockManager
    {
        public static List<STOCK> GetAllStocks()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.STOCK.ToList();
        }

        public STOCK GetStockById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.STOCK)
            {
                if (a.STOCK_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.STOCK)
            {
                if (a.STOCK_ID == id)
                {
                    MaderaEntities.STOCK.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetStock(STOCK StockUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.STOCK.Add(StockUp);
            MaderaEntities.SaveChanges();
        }
    }
}
