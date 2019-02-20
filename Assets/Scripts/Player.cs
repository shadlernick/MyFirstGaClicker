using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    struct Engine
    {
        public int level;
        public int minSpeed;
        public int maxSpeed;

        public int moneyForUpgrade;
        public int materialsForUpgrade;

        public void LevelUp(Player player)
        {
            if(player.Money >= moneyForUpgrade && player.Materials >= materialsForUpgrade)
            {
                player.Money -= moneyForUpgrade;
                player.Materials -= materialsForUpgrade;
                level++;
                minSpeed += minSpeed / 2;
                maxSpeed += maxSpeed / 2;
                moneyForUpgrade *= 2;
                materialsForUpgrade *= 2;
            }
        }
    }

    struct Borer
    {
        public int level;
        public int minPower;
        public int maxPower;

        public int moneyForUpgrade;
        public int materialsForUpgrade;

        public void LevelUp(Player player)
        {
            if (player.Money >= moneyForUpgrade && player.Materials >= materialsForUpgrade)
            {
                player.Money -= moneyForUpgrade;
                player.Materials -= materialsForUpgrade;
                level++;
                minPower += minPower / 2;
                maxPower += maxPower / 2;
                moneyForUpgrade *= 2;
                materialsForUpgrade *= 2;
            }
        }
    }

    public class Player
    {
        string name { get; set; } 
        int score { get; set; }
        int money { get; set; }
        int materials { get; set; }
        int speed { get; set; }
        Engine engine;
        Borer borer;

        public int Money
        {
            get { return money; }
            set
            {
                money = value;
            }
        }

        public int Materials
        {
            get { return materials; }
            set
            {
                materials = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public Player()
        {
            this.name = "name";
            this.score = 0;
            money = 0;
            materials = 0;

            engine.level = 1;
            engine.minSpeed = 10;
            speed = engine.minSpeed;
            engine.maxSpeed = 100;
            engine.moneyForUpgrade = 10;
            engine.materialsForUpgrade = 0;

            borer.level = 1;
            borer.minPower = 0;
            borer.maxPower = 0;
            borer.moneyForUpgrade = 10;
            borer.materialsForUpgrade = 0;
        }

        public int PlusScore()
        {
            return score++;
        }

        public int Score
        {
            get { return score; }
            set {
                score = value;
            }            
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                speed = value;
            }
        }

        public int SpeedDown()
        {
            if (Speed > engine.minSpeed)
            {
                Speed -= (int)Math.Pow(5, engine.level);
            }
            else if(Speed <= engine.minSpeed)
            {
                Speed = engine.minSpeed;
            }
            return speed;
        }

        public void PlusSpeed()
        {
            if(Speed < engine.maxSpeed)
                Speed += (int)Math.Pow(5, engine.level);
        }

        public void UpgradeEngine(Player player)
        {
            engine.LevelUp(player);
        }

        public void UpgradeBorer(Player player)
        {
            borer.LevelUp(player);
        }
    }
}
