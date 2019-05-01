using CappaDia.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CappaDia.MODEL.Entities
{
   public class Gallery:TourSpec
    {

        public int GalleryCategoryID { get; set; }


        public List<string> Images { get; set; }

        public virtual GalleryCategory GalleryCategory { get; set; }



    }
}
