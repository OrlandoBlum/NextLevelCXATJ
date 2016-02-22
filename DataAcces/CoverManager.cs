using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class CoverManager
    {
        public static List<COVER> GetAllCovers()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.COVER.ToList();
        }

        public COVER GetCoverById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.COVER)
            {
                if (a.COVER_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.COVER)
            {
                if (a.COVER_ID == id)
                {
                    MaderaEntities.COVER.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetCover(COVER CoverUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.COVER.Add(CoverUp);
            MaderaEntities.SaveChanges();
        }
    }
}
