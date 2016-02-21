using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    class ComponentsManager
    {
        public static List<COMPONENTS> GetAllCompenents()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.COMPONENTS.ToList();
        }

        public COMPONENTS GetCompenentById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.COMPONENTS)
            {
                if (a.COMPONENT_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.COMPONENTS)
            {
                if (a.COMPONENT_ID == id)
                {
                    MaderaEntities.COMPONENTS.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetCompenent(COMPONENTS CompenentUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.COMPONENTS.Add(CompenentUp);
            MaderaEntities.SaveChanges();
        }
    }
}
