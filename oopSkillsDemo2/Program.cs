using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPDemo2Lib;

namespace oopSkillsDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Villain doctorEvil = new Villain();
            doctorEvil.setAlive(true);
            doctorEvil.setName("doctorEvil");
            doctorEvil.setVisibility(true);
            doctorEvil.setXLoc(50);
            doctorEvil.setYLoc(50);
            doctorEvil.setTeamName("evilEmpire");
            doctorEvil.setHeroesSlain(0);

            Hero captainUnderPants = new Hero();
            captainUnderPants.setAlive(true);
            captainUnderPants.setName("captainUnderPants");
            captainUnderPants.setVisibility(true);
            captainUnderPants.setXLoc(70);
            captainUnderPants.setYLoc(70);
            captainUnderPants.setTeamName("unlikelyVictors");
            captainUnderPants.setEnemiesSlain(0);

            Console.WriteLine("doctorEvil - Villain");
            Console.WriteLine(doctorEvil.getAlive());
            Console.WriteLine(doctorEvil.getName());
            Console.WriteLine(doctorEvil.getVisibility());
            Console.WriteLine(doctorEvil.getXLoc());
            Console.WriteLine(doctorEvil.getYLoc());
            Console.WriteLine(doctorEvil.getTeamName());
            Console.WriteLine(doctorEvil.getHeroesSlain() + "\n");
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("captainUnderPants - Hero");
            Console.WriteLine(captainUnderPants.getAlive());
            Console.WriteLine(captainUnderPants.getName());
            Console.WriteLine(captainUnderPants.getVisibility());
            Console.WriteLine(captainUnderPants.getXLoc());
            Console.WriteLine(captainUnderPants.getYLoc());
            Console.WriteLine(captainUnderPants.getTeamName());
            Console.WriteLine(captainUnderPants.getEnemiesSlain() + "\n");
            Console.WriteLine("----------------------------------------------------------");

            
            doctorEvil.jump();
            captainUnderPants.jump();
            Console.WriteLine("doctorEvils' X and Y location after jump : " + doctorEvil.getXLoc() + ", " + doctorEvil.getYLoc());
            Console.WriteLine("captainUnderPants' X and Y location after jump : " + captainUnderPants.getXLoc() + ", " + captainUnderPants.getYLoc() + "\n");
            Console.WriteLine("----------------------------------------------------------");

            doctorEvil.Attack();
            Console.WriteLine("doctorEvils' X and Y location after attack : " + doctorEvil.getXLoc() + ", " + doctorEvil.getYLoc() + "\n");
            Console.WriteLine("----------------------------------------------------------");

            captainUnderPants.retreat();
            Console.WriteLine("captainUnderPants' X and Y location after retreat : " + captainUnderPants.getXLoc() + ", " + captainUnderPants.getYLoc() + "\n");
            Console.WriteLine("----------------------------------------------------------");

            Vector HeroVect1 = new Vector(captainUnderPants.getXLoc(), captainUnderPants.getYLoc());
            Vector HeroVect2 = HeroVect1 * 5;
            HeroVect2.PrintDeets();
            Console.WriteLine("----------------------------------------------------------");

            Vector VillainVect1 = new Vector(doctorEvil.getXLoc(), doctorEvil.getYLoc());
            Vector HeroVect3 = HeroVect1 + HeroVect2;
            HeroVect3.PrintDeets();
            Console.WriteLine("----------------------------------------------------------");

        }
    }
}
