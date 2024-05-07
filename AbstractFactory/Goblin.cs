using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Wizard
    {
        public abstract void DoMagic();
    }
    public class FireWizard : Wizard
    {
        public override void DoMagic()
        {
            Console.WriteLine("Do Fire Magic");
        }
    }

    public class WaterWizard : Wizard
    {
        public override void DoMagic()
        {
            Console.WriteLine("Do Water Magic");
        }
    }
    public abstract class Goblin
    {
        public abstract void DoDamage();
    }
    public class FireGoblin : Goblin
    {
        public override void DoDamage()
        {
            Console.WriteLine("Do Fire Damage");
        }
    }

    public class WaterGoblin : Goblin
    {
        public override void DoDamage()
        {
            Console.WriteLine("Do Water Damage");
        }
    }
    public abstract class CharacterFactory
    {
        public abstract Wizard CreateWizard();
        public abstract Goblin CreateGoblin();
    }
    public class WaterCharacter : CharacterFactory
    {
        public override Goblin CreateGoblin()
        {
            return new WaterGoblin();
        }
        public override Wizard CreateWizard()
        {
            return new WaterWizard();
        }
    }
    public class FireCharacter : CharacterFactory
    {
        public override Goblin CreateGoblin()
        {
            return new FireGoblin();
        }

        public override Wizard CreateWizard()
        {
            return new FireWizard();
        }
    }
   public class GameManager
    {
        public void Play(CharacterFactory characterFactory)
        {          
            characterFactory.CreateWizard();
            characterFactory.CreateGoblin();
        }
    }
}
