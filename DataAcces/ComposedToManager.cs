using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class ComposedToManager
    {
        public static List<COMPOSED_TO> GetAllComposed_To()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.COMPOSED_TO.ToList();
        }

        public COMPOSED_TO GetComposed_ToByModuleId(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.COMPOSED_TO)
            {
                if (a.MODULE_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.COMPOSED_TO)
            {
                if (a.MODULE_ID == id)
                {
                    MaderaEntities.COMPOSED_TO.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetComposed_To(COMPOSED_TO Composed_ToUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.COMPOSED_TO.Add(Composed_ToUp);
            MaderaEntities.SaveChanges();
        }
    }
}
