using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{


    //TODO THIS IS WORK IN PROGESS!!!!!!!!!!!!!


    public class Class1
    {

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
            throw new NotImplementedException();
        }
    }

    public class KarateBlueBelt : KarateStyle
    {
        public override void Battles(TaekwondoStyle taekwondoStyle)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    public class StrikingBattleGround : StrikingFactory
    {
        public override TaekwondoStyle CreateTaekwondoClub()
        {
            throw new NotImplementedException();
        }

        public override KarateStyle CreateKarateClub()
        {
            throw new NotImplementedException();
        }
    }
}