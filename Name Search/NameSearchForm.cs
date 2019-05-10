using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Name_Search
{
    public partial class NameSearchForm : Form
    {
        public NameSearchForm()
        {
            InitializeComponent();
        }
        // Variable used to store boy's name from the text file.
        string[] boyNames = new string[200];

        // Variable used to store girl's name from the text file.
        string[] girlNames = new string[200];

        // Variable used for loop.
        int i = 0;
        int name = 0;
        int randBoy;
        int randGirl;

        Random rand = new Random();

        private void RandomBoyName()
        {
            randBoy = rand.Next(200);

            StreamReader ReadNames = File.OpenText("BoyNames.txt");
            for (int randBoy = 0; randBoy <boyNames.Length; randBoy++)
            {
                boyNames[randBoy] = ReadNames.ReadLine();
            }
            boyRandomNameLabel.Text = boyNames[randBoy];
            ReadNames.Close();
        }
        private void RandomGirlName()
        {
            randGirl = rand.Next(200);
            StreamReader ReadNames = File.OpenText("GirlNames.txt");
            for (int randGirl = 0; randGirl < girlNames.Length; randGirl++)
            {
                girlNames[randGirl] = ReadNames.ReadLine();
            }
            girlRandomNameLabel.Text = girlNames[randGirl];
            ReadNames.Close();
        }

        private string[] ReadNames(string fileName)
        {
            // Opens the text file.
            StreamReader input = File.OpenText(fileName);
            
            // Used to store the name.
            string[] names = new string[200];

            // reset i to 0
            i = 0;

            // Loop used to populate the array with baby names.
            while (!input.EndOfStream)
            {
                names[i] = input.ReadLine();
                i++;
            }

            // Close the file.
            input.Close();

            // return the name from the array.

            return names;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boyNames = ReadNames("BoyNames.txt");
            girlNames = ReadNames("GirlNames.txt");
        }

        // Method used to Search the names.
        private Boolean NameSearch(string names, string[] namesList)
        {
            // Looks to see if the name is in the nameList.
            for (int i = 0; i < namesList.Count(); i++)
            {
                if (namesList[i] == names)
                {
                    return true;
                }
               
            }
            return false;
        }

        private string Results (string name, Boolean found)
        {
            // If box is empty. 
            string answer = "";

            // Give the the results if name is found or not.
            if (found)
            {
                answer = name + " is a popular name on the list.";
            }
            else
            {
                answer = name + " is not found on the popular list.";
            }
            return answer;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clears the boysNameTextBox.
            boysNameTextBox.Clear();
            // Clears the girlsNameTextBox.
            girlsNameTextBox.Clear();
            // Clears the girlNameLabel.
            girlNameLabel.Text = "";
            // Clears the boyNameLabel.
            boyNameLabel.Text = "";
            // Clears the randomBoyLabel.
            boyRandomNameLabel.Text = "";
            // Clears the randomGirlLabel.
            girlRandomNameLabel.Text = "";
            // Sets the focus on the girlsNameTextBox.
            girlsNameTextBox.Focus();
        }

        private void checkNameButton_Click(object sender, EventArgs e)
        {
            // Variables used to store name for boysNameTextBox and girlsNameTextBox.
            string boy_name = "";
            string girl_name = "";
            bool boyCheck = false;
            bool girlCheck = false;

            // Checks the names in both the girlsNameTextBox and the boysNameTextBox.

            if (boysNameTextBox.Text != "" && girlsNameTextBox.Text != "")
            {
                // Gets the boys name from the boysNameTextBox.
                boy_name = boysNameTextBox.Text;

                // Gets the girls name from the girlsNameTextBox.
                girl_name = girlsNameTextBox.Text;

                // Uses the NameSearch method to check the boys names.
                boyCheck = NameSearch (boy_name, boyNames);

                // Uses teh NameSearch method to check the girls names.
                girlCheck = NameSearch(girl_name, girlNames);

                // Gets the inmformation from the Results method.
                boyNameLabel.Text = Results(boy_name, boyCheck);

                girlNameLabel.Text = Results(girl_name, girlCheck);


            }
            // Checks the name in the boysNameTextBox.
            else if (boysNameTextBox.Text != "")
                {
                boy_name = boysNameTextBox.Text;
                boyCheck = NameSearch(boy_name, boyNames);
                boyNameLabel.Text = Results(boy_name, boyCheck);
                }

            // Checks the name in the girlsNameTextBox.
            else if (girlsNameTextBox.Text != "")
            {
                girl_name = girlsNameTextBox.Text;
                girlCheck = NameSearch(girl_name, girlNames);
                girlNameLabel.Text = Results(girl_name, girlCheck);
            }
            //  Checks to see if both TextBoxs are empty and throw error if they are empty.
            else
            {
                 MessageBox.Show("Please enter a girl name or " + "boy name");
            }
            // Clears boyTextBox and girlTextBox and resets the focus.
            boysNameTextBox.Clear();
            girlsNameTextBox.Clear();
            girlsNameTextBox.Focus();
           


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit the program
            this.Close();
        }

        private void randomBoysButton_Click(object sender, EventArgs e)
        {
            RandomBoyName();
        }

        private void randomGirlsButton_Click(object sender, EventArgs e)
        {
            RandomGirlName();
        }
    }
}
