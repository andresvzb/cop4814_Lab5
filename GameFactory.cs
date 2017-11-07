using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Games
{
    public class GameFactory
    {
        public string FilePath;
        public List<Game> listGame;
        StreamWriter sw;
        XmlSerializer serial;

        public void CreateGameList()
        {
            listGame = new List<Game>();
            Game G = new Game("Caracas", "Maracaibo", 2, 10);
            listGame.Add(G);
            G = new Game("Valencia", "Merida", 1, 5);
            listGame.Add(G);
            G = new Game("La Urbina", "Higuerote", 21, 40);
            listGame.Add(G);
            G = new Game("Anzoategui", "Bolivar", 58, 19);
            listGame.Add(G);
            G = new Game("Florida", "Mariperez", 96, 54);
            listGame.Add(G);
            G = new Game("Maracay", "Falcon", 37, 85);
            listGame.Add(G);
            G = new Game("Carabobo", "Amazonas", 7, 9);
            listGame.Add(G);
            G = new Game("Barinas", "Apure", 60, 21);
            listGame.Add(G);
            G = new Game("San Cristobal", "Coro", 12, 0);
            listGame.Add(G);
            G = new Game("Monagas", "La Guaira", 65, 43);
            listGame.Add(G);
            G = new Game("Margarita", "Los Roques", 137, 45);
            listGame.Add(G);

        }

        public Boolean SerializeGameList()
        {

            serial = new XmlSerializer(listGame.GetType());

            sw = new StreamWriter(FilePath);
            serial.Serialize(sw, listGame);
            sw.Close();
            return true;
        }

        public List<Game> DeserializeGameList()
        {
            listGame = new List<Game>();
            StreamReader sr = new StreamReader(FilePath);
            serial = new XmlSerializer(listGame.GetType());
            listGame = (List<Game>)serial.Deserialize(sr);
            sr.Close();
            return listGame;
              
        }
    }
}
