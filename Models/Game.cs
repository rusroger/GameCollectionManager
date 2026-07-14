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
        public List<string> Genres = ["Acción", "Disparos", "Carreras", "RPG"];
        public List<string> Genres2 = new List<string>()
{
    "Acción", "Disparos", "Carreras", "RPG"
};
        public List<string> Languages = ["Español", "Catalán", "Inglés", "Francés", "Alemán"];
        public List<string> Languages2 = new List<string>()
{
    "Español", "Catalán", "Inglés", "Francés", "Alemán"
};
        public int MetacriticScore { get; set; }
        public double SizeGB { get; set; }
        public int MaxPlayers { get; set; }
    }
}