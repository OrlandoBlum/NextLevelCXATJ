using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class AdressManager
    {
        public static List<ADRESS> GetAllAdress()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.ADRESS.ToList();
        }

        public ADRESS GetAdressById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.ADRESS)
            {
                if (a.ADRESS_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.ADRESS)
            {
                if (a.ADRESS_ID == id)
                {
                    MaderaEntities.ADRESS.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetAdress(ADRESS AdressUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.ADRESS.Add(AdressUp);
            MaderaEntities.SaveChanges();
        }
    }
}
