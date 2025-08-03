using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Platform
{
    internal class Villain:Anime
    {
        int evilscore;
        string finalBattleOutcome;

        public Villain() { }
        public Villain(string cn, string Cid, string an,  int evilscore, string finalBattleOutcome):base(cn, Cid, an)
        {
            this.evilscore = evilscore;
            this.finalBattleOutcome = finalBattleOutcome;
        }

        public int EvilScore
        {
            get {  return evilscore; }
            set { evilscore = value; }
        }

        public string FinalBattleOutcome
        {
            get { return finalBattleOutcome; }
            set { finalBattleOutcome = value; }
        }

        public void checkpopularity()
        {
            if (evilscore < 80 || finalBattleOutcome == "Lost")
            {
                Console.WriteLine("Unpopular Character");
                return;
            }
            else
            {
                Console.WriteLine("Popular Character");
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Evil Score  : {evilscore}");
            Console.WriteLine($"Final Result : {finalBattleOutcome}");

            checkpopularity();
        }
    }
}
