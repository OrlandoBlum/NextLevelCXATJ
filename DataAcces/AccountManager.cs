using EntityF;
using System.Collections.Generic;
using System.Linq;

namespace DataAcces
{
    public class AccountManager
    {
        public static List<ACCOUNT> GetAllAccounts()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.ACCOUNT.ToList();
        }

        public ACCOUNT GetAccountById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.ACCOUNT)
            {
                if (a.ACCOUNT_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.ACCOUNT)
            {
                if (a.ACCOUNT_ID == id)
                {
                    MaderaEntities.ACCOUNT.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetAccount(ACCOUNT AccountUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.ACCOUNT.Add(AccountUp);
            MaderaEntities.SaveChanges();
        }
    }
}
