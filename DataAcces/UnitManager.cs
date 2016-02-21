using EntityF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    class UnitManager
    {
        public static List<UNIT> GetAllUnits()
        {
            MaderaEntities MaderaEntities = new MaderaEntities();
            return MaderaEntities.UNIT.ToList();
        }

        public UNIT GetUnitById(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.UNIT)
            {
                if (a.UNIT_ID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Delete(int id)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            foreach (var a in MaderaEntities.UNIT)
            {
                if (a.UNIT_ID == id)
                {
                    MaderaEntities.UNIT.Remove(a);
                    MaderaEntities.SaveChanges();
                }
            }
        }

        public void SetUnit(UNIT UnitUp)
        {
            MaderaEntities MaderaEntities = new MaderaEntities();

            MaderaEntities.UNIT.Add(UnitUp);
            MaderaEntities.SaveChanges();
        }
    }
}
