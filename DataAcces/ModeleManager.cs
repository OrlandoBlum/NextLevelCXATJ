using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class ModeleManager
    {
        public static List<MODELE> GetAllModeles()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.MODELE.ToList();
        }

        public MODELE GetModelesById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.MODELE)
            {
                if (a.MODELE_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.MODELE)
            {
                if (a.MODELE_ID == id)
                {
                    MaderaEntities.MODELE.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetModeles(MODELE ModelesUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.MODELE.Add(ModelesUp);
            MaderaEntities.SaveChanges();
        }
    }
}
