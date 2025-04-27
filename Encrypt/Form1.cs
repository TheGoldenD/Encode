using System;
using System.Linq;
using System.Windows.Forms;

namespace Encrypt
{
    public partial class Form1 : Form
    {
        // Declare class
        private string basetext;
        private string numberText;
        private char[] originalChars;  // Store all original characters
        private int[] originalCharCodes; // Store all original character codes
        private int[] newCharCodes;    // Store all processed character codes

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assign values to the class
            basetext = textBox1.Text;
            numberText = textBox3.Text;

            if (!int.TryParse(numberText, out int num))
            {
                MessageBox.Show("Please enter a valid number");
                textBox3.Clear();
                textBox3.Focus();
                return;
            }

            if (string.IsNullOrEmpty(basetext))
            {
                MessageBox.Show("Please enter text to encrypt");
                textBox1.Focus();
                return;
            }

            if (basetext.Length > 40)
            {
                MessageBox.Show("Too long, make sure the input is less than 40 letters");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }

            if (basetext.Any(char.IsLower))
            {
                MessageBox.Show("You must use Uppercase Letters only");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }

            if (num < -25 || num > 25)
            {
                MessageBox.Show("Number must be between -25 and 25");
                textBox3.Clear();
                textBox3.Focus();
                return;
            }
            originalChars = new char[basetext.Length];
            originalCharCodes = new int[basetext.Length];
            newCharCodes = new int[basetext.Length];

            // Perform the encoding
            char[] result = new char[basetext.Length];
            for (int i = 0; i < basetext.Length; i++)
            {
                originalChars[i] = basetext[i];
                originalCharCodes[i] = (int)basetext[i]; // Store ASCII code
                newCharCodes[i] = basetext[i] + num;

                if (newCharCodes[i] > 'Z')
                {
                    newCharCodes[i] -= 26;
                }
                else if (newCharCodes[i] < 'A')
                {
                    newCharCodes[i] += 26;
                }
                result[i] = (char)newCharCodes[i];
            }
            textBox2.Text = new string(result); //Printing the new ASCII code
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (originalCharCodes == null || originalCharCodes.Length == 0)
            {
                MessageBox.Show("No characters processed yet");
                return;
            }

            // Show all original character codes with their corresponding letters
            var codeInfo = originalCharCodes.Select(code =>
                $"{(char)code}({code})");

            textBox4.Text = $"Original Codes: {string.Join(", ", codeInfo)}";
            textBox4.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (newCharCodes == null || newCharCodes.Length == 0)
            {
                MessageBox.Show("No character codes processed yet");
                return;
            }

            // Show all new character codes with their corresponding letters
            var codeInfo = newCharCodes.Select(code =>
                $"{(char)code}({code})");

            textBox5.Text = $"New Codes: {string.Join(", ", codeInfo)}";
            textBox5.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (newCharCodes == null || newCharCodes.Length == 0)
            {
                MessageBox.Show("No character codes to sort");
                return;
            }

            // Sort the newCharCodes array
            Array.Sort(newCharCodes);

            // Create the sorted display string
            var sortedCodeInfo = newCharCodes.Select(code =>
                $"{(char)code}({code})");

            textBox6.Text = $"Sorted Codes: {string.Join(", ", sortedCodeInfo)}";
            textBox6.Focus();
        }
    }
}