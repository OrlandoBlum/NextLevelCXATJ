using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    class ModuleManager
    {
        public static List<MODULE> GetAllModules()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.MODULE.ToList();
        }

        public MODULE GetModuleById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.MODULE)
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

            foreach (var a in MaderaEntities.MODULE)
            {
                if (a.MODULE_ID == id)
                {
                    MaderaEntities.MODULE.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetModule(MODULE ModuleUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.MODULE.Add(ModuleUp);
            MaderaEntities.SaveChanges();
        }
    }
}
