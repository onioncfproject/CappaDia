using CappaDia.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CappaDia.MODEL.Entities
{
   public class ProgramDetail:CoreEntity    
    {
        //Bu kısımda program detayındaki saat - acıklama ikilisi icin Dictionary kullanılması uygun görülmüştür.

        public Dictionary<string,string> DetailDescription { get; set; }

        //RelationalProperties

        public virtual Tour Tour { get; set; }



    }
}
