using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class UsersManager
    {
        public static List<USERS> GetAllUsers()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.USERS.ToList();
        }

        public USERS GetUsersById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.USERS)
            {
                if (a.USER_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.USERS)
            {
                if (a.USER_ID == id)
                {
                    MaderaEntities.USERS.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetUsers(USERS UsersUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.USERS.Add(UsersUp);
            MaderaEntities.SaveChanges();
        }
    }
}
