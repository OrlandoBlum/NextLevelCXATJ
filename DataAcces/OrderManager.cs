using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class OrderManager
    {
        public static List<ORDER> GetAllOrders()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.ORDER.ToList();
        }

        public ORDER GetOrderById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.ORDER)
            {
                if (a.ORDER_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.ORDER)
            {
                if (a.ORDER_ID == id)
                {
                    MaderaEntities.ORDER.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetOrder(ORDER OrderUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.ORDER.Add(OrderUp);
            MaderaEntities.SaveChanges();
        }
    }
}
