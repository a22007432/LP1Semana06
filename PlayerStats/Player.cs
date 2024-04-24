using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames;

        //private string name{get;};

        private float winRate;

        public string Name { get;}

        public Player(string name)
        {
            Name = name;
            playedGames = 0;
            wonGames = 0;
            highScore = 0;
        }

        public float HighScore
        {   
            get => highScore;
            set 
            { 
             
             if (value > highScore)
             {
                highScore = value;
             }
            }
        }

        public float WinRate
        {
            get
            {
                if (playedGames == 0)
                {
                    return 0;
                }
                return (float)wonGames/playedGames;
            }
           
            
        }

        public void PlayGame(bool win)
        {
            playedGames +=1;

            if (win == true)
            {
                wonGames +=1;
            } 
        }

        
    }
}