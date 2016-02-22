using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    class ComponentFamilyManager
    {
        public static List<COMPONENTFAMILY> GetAllCompenentFamilys()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.COMPONENTFAMILY.ToList();
        }

        public COMPONENTFAMILY GetCompenentFamilyById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.COMPONENTFAMILY)
            {
                if (a.FAMILY_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.COMPONENTFAMILY)
            {
                if (a.FAMILY_ID == id)
                {
                    MaderaEntities.COMPONENTFAMILY.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetCompenentFamily(COMPONENTFAMILY CompenentFamilyUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.COMPONENTFAMILY.Add(CompenentFamilyUp);
            MaderaEntities.SaveChanges();
        }
    }
}
