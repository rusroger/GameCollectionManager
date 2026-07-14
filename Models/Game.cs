using System;
using System.Collections.Generic;
using System.Text;

namespace GameCollectionManager.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Developer { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public List<string> Genres { get; set; } = [];
        public List<string> Languages { get; set; } = [];
        public int MetacriticScore { get; set; }
        public double SizeGB { get; set; }
        public int MaxPlayers { get; set; }
    }
}