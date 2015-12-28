using System;

namespace AbstractFactory
{
    class Program
    {
        public static void Main()
        {
            // Create and run the battleGround
            StrikingBattleGroundFactory battleGroundFactory = new StrikingBattleGroundFactory();
            KarateStyle karateStyle = battleGroundFactory.CreateKarateClub();
            TaekwondoStyle taekwondoStyle = battleGroundFactory.CreateTaekwondoClub();

            karateStyle.Battles(taekwondoStyle);
        }
    }

    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    public abstract class StrikingFactory
    {
        public abstract TaekwondoStyle CreateTaekwondoClub();
        public abstract KarateStyle CreateKarateClub();
    }

    /// <summary>
    /// The 'TaekwondoFighter' abstract class
    /// </summary>
    public abstract class TaekwondoStyle
    {
        public abstract void Battles(KarateStyle karateFighter);
    }

    /// <summary>
    /// The 'KarateFighter' abstract class
    /// </summary>
    public abstract class KarateStyle
    {
        public abstract void Battles(TaekwondoStyle taekwondoStyle);
    }

    /// <summary>
    /// The 'TaekwondoBlackBelt' class
    /// </summary>
    public class TaekwondoBlackBelt : TaekwondoStyle
    {
        public override void Battles(KarateStyle karateFighter)
        {
            Console.WriteLine(this.GetType().Name +" battles " + karateFighter.GetType().Name);
        }
    }

    /// <summary>
    /// The 'KarateBlueBelt' class
    /// </summary>
    public class KarateBlueBelt : KarateStyle
    {
        public override void Battles(TaekwondoStyle taekwondoStyle)
        {
            Console.WriteLine(this.GetType().Name + " battles " + taekwondoStyle.GetType().Name);
        }
    }


    public class StrikingBattleGroundFactory : StrikingFactory
    {
        public override TaekwondoStyle CreateTaekwondoClub()
        {
            return new TaekwondoBlackBelt();
        }

        public override KarateStyle CreateKarateClub()
        {
            return new KarateBlueBelt();
        }
    }
}