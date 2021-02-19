using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeAPI.Models;

namespace AnimeAPI
{
    interface IMALRepo
    {
        public IEnumerable<Anime> GetAnimes(string title);
    }
}
