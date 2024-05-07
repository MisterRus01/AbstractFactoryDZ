using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            CharacterFactory waterCharacter = new WaterCharacter();
            gameManager.Play(waterCharacter);
            waterCharacter.CreateWizard().DoMagic();
            waterCharacter.CreateGoblin().DoDamage();
            CharacterFactory fireCharacter = new FireCharacter();
            gameManager.Play(fireCharacter);
            fireCharacter.CreateWizard().DoMagic();
            fireCharacter.CreateGoblin().DoDamage();
        }
    }
}
