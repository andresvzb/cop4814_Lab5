using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Adding a comment to show Step 7 from the github Lab


//This is another change at 2:35

namespace Games
{
    public class Game
    {
        public String Team1 { get; set; }
        public String Team2 { get; set; }
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }     //FORMAT: YYYYMMDD
    

        public Game()
        {

        }

        public Game(string team1, string team2, int team1score, int team2score)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.Team1Score = team1score;
            this.Team2Score = team2score;
        }


        public override string ToString()
        {
            return Team1 + "   " + "(" + Team1Score + ")" + "   -   " + Team2 + "   " + "(" + Team2Score + ")";

        }


    }

}
