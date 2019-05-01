using CappaDia.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CappaDia.MODEL.Entities
{
    public class Tour:TourSpec
    {
       

        public decimal TourPrice { get; set; }

        public int Duration { get; set; }

        public string CoverImage { get; set; }

        public int TourCategoryID { get; set; }
        public int Likes { get; set; }

        public int Reviews { get; set; }

        public DateTime ReservationDate { get; set; }

        public List<string> GalleryImages { get; set; }

        


        //Relational Properties

        public virtual TourCategory TourCategory { get; set; }




        public virtual ProgramDetail ProgramDetail { get; set; }

    }
}
