using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    class OrderStatusManager
    {
        public static List<ORDERSTATUS> GetAllOrderStatus()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.ORDERSTATUS.ToList();
        }

        public ORDERSTATUS GetOrderStatusById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.ORDERSTATUS)
            {
                if (a.STATUS_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.ORDERSTATUS)
            {
                if (a.STATUS_ID == id)
                {
                    MaderaEntities.ORDERSTATUS.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetOrderStatus(ORDERSTATUS OrderStatusUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.ORDERSTATUS.Add(OrderStatusUp);
            MaderaEntities.SaveChanges();
        }
    }
}
