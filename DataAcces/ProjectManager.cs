using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class ProjectManager
    {
        public static List<PROJECT> GetAllProjects()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.PROJECT.ToList();
        }

        public PROJECT GetProjectById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.PROJECT)
            {
                if (a.PROJECT_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.PROJECT)
            {
                if (a.PROJECT_ID == id)
                {
                    MaderaEntities.PROJECT.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetProject(PROJECT ProjectUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.PROJECT.Add(ProjectUp);
            MaderaEntities.SaveChanges();
        }
    }
}
