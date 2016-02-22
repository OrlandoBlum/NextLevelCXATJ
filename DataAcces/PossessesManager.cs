using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class PossessesManager
    {
        public static List<POSSESSES> GetAllPossesses()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.POSSESSES.ToList();
        }

        public POSSESSES GetPossessesByRangeId(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.POSSESSES)
            {
                if (a.RANGE_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public POSSESSES GetPossessesByCoverId(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.POSSESSES)
            {
                if (a.COVER_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public POSSESSES GetPossessesByFinishingId(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.POSSESSES)
            {
                if (a.FINISHING_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public POSSESSES GetPossessesByFillId(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.POSSESSES)
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

            foreach (var a in MaderaEntities.POSSESSES)
            {
                if (a.RANGE_ID == id)
                {
                    MaderaEntities.POSSESSES.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetPossesses(POSSESSES PossessesUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.POSSESSES.Add(PossessesUp);
            MaderaEntities.SaveChanges();
        }
    }
}
