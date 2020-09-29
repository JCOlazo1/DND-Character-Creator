using CharacterLibrary;
using CharacterLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatorUI
{
    public partial class CharacterMakerUI : Form
    {
        int HP, STR, DEX, CON, INT, WIS, CHA;

        Random rng = new Random();
        public CharacterMakerUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                CharacterModel model = new CharacterModel(
                    nameValue.Text, 
                    raceValue.Text, 
                    classValue.Text, 
                    hpValue.Text, 
                    strValue.Text, 
                    dexValue.Text, 
                    conValue.Text, 
                    intValue.Text, 
                    wisValue.Text, 
                    chaValue.Text);

                // Creates a model based on the info above.
                foreach(IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateCharacter(model);
                }

                MessageBox.Show("Character created successfully!");

            }
            else
            {
                MessageBox.Show("Please fill in all the fields properly.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            // Number validation check:

            // HP
            int hpNumber = 0;
            bool hpNumberLegit = int.TryParse(hpValue.Text, out hpNumber);

            if (!hpNumberLegit)
            {
                output = false;
            }

            if (hpNumber < 1)
            {
                output = false;
            }

            // STR
            int strNumber = 0;
            bool strNumberLegit = int.TryParse(strValue.Text, out strNumber);

            if(!strNumberLegit)
            {
                output = false;
            }

            if(strNumber < 1)
            {
                output = false;
            }

            // DEX
            int dexNumber = 0;
            bool dexNumberLegit = int.TryParse(dexValue.Text, out dexNumber);

            if(!dexNumberLegit)
            {
                output = false;
            }

            if(dexNumber < 1)
            {
                output = false;
            }

            // CON
            int conNumber = 0;
            bool conNumberLegit = int.TryParse(conValue.Text, out conNumber);

            if(!conNumberLegit)
            {
                output = false;
            }

            if(conNumber < 1)
            {
                output = false;
            }

            // INT
            int intNumber = 0;
            bool intNumberLegit = int.TryParse(intValue.Text, out intNumber);

            if(!intNumberLegit)
            {
                output = false;
            } 

            if(intNumber < 1)
            {
                output = false;
            }

            // WIS
            int wisNumber = 0;
            bool wisNumberLegit = int.TryParse(wisValue.Text, out wisNumber);

            if(!wisNumberLegit)
            {
                output = false;
            }

            if(wisNumber < 1)
            {
                output = false;
            }

            // CHA
            int chaNumber = 0;
            bool chaNumberLegit = int.TryParse(chaValue.Text, out chaNumber);

            if(!chaNumberLegit)
            {
                output = false;
            }

            if(chaNumber < 1)
            {
                output = false;
            }

            // Text validation check:

            // Character Name
            if(nameValue.Text.Length == 0)
            {
                output = false;
            }

            // Character Race
            if(raceValue.Text.Length == 0)
            {
                output = false;
            }

            // Character Class
            if(classValue.Text.Length == 0)
            {
                output = false;
            }
          

            return output;
        }

        private void hpRollButton_Click(object sender, EventArgs e)
        {
            HP = rng.Next(1, 21) + 10;
            hpValue.Text = HP.ToString();
        }

        private void strRollButton_Click(object sender, EventArgs e)
        {
            STR = rng.Next(1, 21);
            strValue.Text = STR.ToString();
        }

        private void dexRollButton_Click(object sender, EventArgs e)
        {
            DEX = rng.Next(1, 21);
            dexValue.Text = DEX.ToString();
        }

        private void conRollButton_Click(object sender, EventArgs e)
        {
            CON = rng.Next(1, 21);
            conValue.Text = CON.ToString();
        }

        private void intButtonRoll_Click(object sender, EventArgs e)
        {
            INT = rng.Next(1, 21);
            intValue.Text = INT.ToString();
        }

        private void wisRollButton_Click(object sender, EventArgs e)
        {
            WIS = rng.Next(1, 21);
            wisValue.Text = WIS.ToString();
        }

        private void chaRollButton_Click(object sender, EventArgs e)
        {
            CHA = rng.Next(1, 21);
            chaValue.Text = CHA.ToString();
        }

        private void rollAllButton_Click(object sender, EventArgs e)
        {
            HP = rng.Next(1, 21) + 10;
            hpValue.Text = HP.ToString();

            STR = rng.Next(1, 21);
            strValue.Text = STR.ToString();

            DEX = rng.Next(1, 21);
            dexValue.Text = DEX.ToString();

            CON = rng.Next(1, 21);
            conValue.Text = CON.ToString();

            INT = rng.Next(1, 21);
            intValue.Text = INT.ToString();

            WIS = rng.Next(1, 21);
            wisValue.Text = WIS.ToString();

            CHA = rng.Next(1, 21);
            chaValue.Text = CHA.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hpValue.Text = "";
            strValue.Text = "";
            dexValue.Text = "";
            conValue.Text = "";
            intValue.Text = "";
            wisValue.Text = "";
            chaValue.Text = "";
        }
    }
}
