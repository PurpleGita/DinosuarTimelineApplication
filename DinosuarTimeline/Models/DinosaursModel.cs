using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DinosuarTimeline.Models
{
    public class DinosaursModel
    {

        public string name { get; set; }

        public string race { get; set; }

        public int firsApperaed { get; set; }

        public int lastApperaed { get; set; }

        public string description { get; set; }
        public string imageDescription { get; set; } = "a picture of a";

        public string imagePath { get; set; }

    }
}