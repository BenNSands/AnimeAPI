using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeAPI.Models;

namespace AnimeAPI
{
    public interface IMALRepo
    {
        public IEnumerable<Anime> GetAnime(string title);
    }
}
