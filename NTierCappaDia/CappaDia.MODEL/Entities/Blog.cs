using CappaDia.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CappaDia.MODEL.Entities
{
    public class Blog:CoreEntity
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string CoverImage { get; set; }


    }
}
