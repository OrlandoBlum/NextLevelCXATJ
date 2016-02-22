using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class FinishingManager
    {
        public static List<FINISHING> GetAllFinishings()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.FINISHING.ToList();
        }

        public FINISHING GetFinishingById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.FINISHING)
            {
                if (a.FINISHING_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.FINISHING)
            {
                if (a.FINISHING_ID == id)
                {
                    MaderaEntities.FINISHING.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetFinishing(FINISHING FinishingUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.FINISHING.Add(FinishingUp);
            MaderaEntities.SaveChanges();
        }
    }
}
