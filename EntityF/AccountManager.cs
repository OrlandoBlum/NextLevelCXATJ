using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityF
{
    public class AccountManager
    {
        public List<ACCOUNT> GetAllAccounts()
        {
            MaderaEntities MonEntitéMadera = new MaderaEntities();
            return MonEntitéMadera.ACCOUNT.ToList();
        }

        public ACCOUNT GetAccountById(int id)
        {
            MaderaEntities MonEntitéMadera = new MaderaEntities();
            
            foreach(var a in MonEntitéMadera.ACCOUNT)
            {
                if(a.ACCOUNT_ID == id)
                {
                    return a;
                }
            }
            
            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MonEntitéMadera = new MaderaEntities();

            foreach (var a in MonEntitéMadera.ACCOUNT)
            {
                if (a.ACCOUNT_ID == id)
                {
                    MonEntitéMadera.ACCOUNT.Remove(a);
                    MonEntitéMadera.SaveChanges();
                }
            }
        }

        public void SetAccount(ACCOUNT AccountUp)
        {
            MaderaEntities MonEntitéMadera = new MaderaEntities();

            MonEntitéMadera.ACCOUNT.Add(AccountUp);
            MonEntitéMadera.SaveChanges();
        }
    }
}
