using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    class SysdiagramsManager
    {
        public static List<sysdiagrams> GetAllsysdiagrams()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.sysdiagrams.ToList();
        }

        public sysdiagrams GetsysdiagramsById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.sysdiagrams)
            {
                if (a.diagram_id == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.sysdiagrams)
            {
                if (a.diagram_id == id)
                {
                    MaderaEntities.sysdiagrams.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void Setsysdiagrams(sysdiagrams sysdiagramsUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.sysdiagrams.Add(sysdiagramsUp);
            MaderaEntities.SaveChanges();
        }
    }
}
