using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeAPI.Models
{
    public class Anime
    {
        public string URL { get; set; }
        public string ImgURL { get; set; }
        public string Title { get; set; }
        public int Score { get; set; }
        public int MALID { get; set; }
    }
}
