using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    class FillManager
    {
        public static List<FILL> GetAllFills()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.FILL.ToList();
        }

        public FILL GetFillById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.FILL)
            {
                if (a.FILL_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.FILL)
            {
                if (a.FILL_ID == id)
                {
                    MaderaEntities.FILL.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetFill(FILL FillUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.FILL.Add(FillUp);
            MaderaEntities.SaveChanges();
        }
    }
}
