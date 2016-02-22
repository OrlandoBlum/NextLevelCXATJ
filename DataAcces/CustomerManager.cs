using System.Collections.Generic;
using System.Linq;
using EntityF;

namespace DataAccess
{
    class CustomerManager
    {
        public static List<CUSTOMER> GetAllCustomers()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.CUSTOMER.ToList();
        }

        public CUSTOMER GetCustomersById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.CUSTOMER)
            {
                if (a.CLIENT_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.CUSTOMER)
            {
                if (a.CLIENT_ID == id)
                {
                    MaderaEntities.CUSTOMER.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetCustomers(CUSTOMER CustomersUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.CUSTOMER.Add(CustomersUp);
            MaderaEntities.SaveChanges();
        }
    }
}
