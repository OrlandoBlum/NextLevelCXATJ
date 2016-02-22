using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class RangeManager
    {
        public static List<RANGE> GetAllRanges()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.RANGE.ToList();
        }

        public RANGE GetRangesById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.RANGE)
            {
                if (a.RANGE_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.RANGE)
            {
                if (a.RANGE_ID == id)
                {
                    MaderaEntities.RANGE.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetRange(RANGE RangeUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.RANGE.Add(RangeUp);
            MaderaEntities.SaveChanges();
        }
    }
}
