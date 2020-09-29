using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterLibrary
{
    public class CharacterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public int HP { get; set; }
        public int STR { get; set; }
        public int DEX { get; set; }
        public int INT { get; set; }
        public int CON { get; set; }
        public int WIS { get; set; }
        public int CHA { get; set; }

        public CharacterModel()
        {

        }

        public CharacterModel(string charName, string charRace, string charClass, string hp1, string str1, string dex1, string con1, string int1, string wis1, string cha1)
        {
            Name = charName;
            Race = charRace;
            Class = charClass;

            int hpNumValue = 0;
            int.TryParse(hp1, out hpNumValue);
            HP = hpNumValue;

            int strNumValue = 0;
            int.TryParse(str1, out strNumValue);
            STR = strNumValue;

            int dexNumValue = 0;
            int.TryParse(dex1, out dexNumValue);
            DEX = dexNumValue;

            int conNumValue = 0;
            int.TryParse(con1, out conNumValue);
            CON = conNumValue;

            int intNumValue = 0;
            int.TryParse(int1, out intNumValue);
            INT = intNumValue;

            int wisNumValue = 0;
            int.TryParse(wis1, out wisNumValue);
            WIS = wisNumValue;

            int chaNumValue = 0;
            int.TryParse(cha1, out chaNumValue);
            CHA = chaNumValue;
        }
    }
}
