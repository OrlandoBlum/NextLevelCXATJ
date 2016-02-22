using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class OrderDetailsManager
    {
        public static List<ORDERDETAILS> GetAllOrderDetails()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.ORDERDETAILS.ToList();
        }

        public ORDERDETAILS GetOrderDetailsById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.ORDERDETAILS)
            {
                if (a.ODERDETAILS_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.ORDERDETAILS)
            {
                if (a.ODERDETAILS_ID == id)
                {
                    MaderaEntities.ORDERDETAILS.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetOrderDetails(ORDERDETAILS OrderDetailsUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.ORDERDETAILS.Add(OrderDetailsUp);
            MaderaEntities.SaveChanges();
        }
    }
}
