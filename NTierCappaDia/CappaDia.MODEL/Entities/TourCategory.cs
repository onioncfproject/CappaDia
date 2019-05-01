using CappaDia.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CappaDia.MODEL.Entities
{
    public class TourCategory:TourSpec
    {
        //Relational Properties

        public virtual IEnumerable<Tour> Tours { get; set; }


    }
}
