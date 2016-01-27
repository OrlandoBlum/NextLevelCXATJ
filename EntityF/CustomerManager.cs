using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityF
{
    public class CustomerManager
    {
        public static List<CUSTOMER> GetAllCustomers()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.CUSTOMER.ToList();
        }
    }
}
