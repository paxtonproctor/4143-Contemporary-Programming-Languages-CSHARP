// Paxton and Edgar
// Program 4 C# 9/26/2022
///<summary>
/// To develop a windows application that implements an interactive game; to
/// use a variety of GUI components; to use a message box; 
/// to write a program using
/// more than one class; to use two dimensional arrays and array methods; to use
/// Random class; to use a for loop and a do-while loop; 
/// and to use the ? operator.
/// Remember you will be graded on applying the concepts learned in class.
/// </summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_4
{
    public partial class FormGame : Form
    {
        // global var
        int Row = 0;
        int Col = 0;
        byte rowGuess = 0;
        byte columnGuess = 0;
        int guesscount = 0;

        ClassGameMechanics game;

        public FormGame()
        {
            InitializeComponent();

            // disable all actions except menu when starting
            labelCol.Enabled = false;
            labelRow.Enabled = false;
            labelGameMap.Enabled = false;
            groupBoxGame.Enabled = false;
            groupBoxActions.Enabled = false;
            buttonAction.Enabled = false;
            buttonStart.Enabled = false;
            textBoxRow.Enabled = false;
            textBoxCol.Enabled = false;

            // buttons
            buttonClose.Click += ButtonClose_Click;
            buttonSettings.Click += ButtonSettings_Click;
            buttonStart.Click += ButtonStart_Click;
            buttonAction.Click += ButtonAction_Click;

            // textbox
            textBoxCol.KeyPress += TextBoxCol_KeyPress;
            textBoxRow.KeyPress += TextBoxRow_KeyPress;
            textBoxCol.TextChanged += TextBoxCol_TextChanged;
            textBoxRow.TextChanged += TextBoxRow_TextChanged;

        }

        #region textbox Events
        private void TextBoxRow_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers and backspace
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBoxCol_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers and backspace
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// TextChanged events just make it where the 
        /// user can't put a unrealistic value in the box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxRow_TextChanged(object sender, EventArgs e)
        {
            string value = textBoxRow.Text;
            if (textBoxRow.Text != "")
            {
                if (int.Parse(value) >= 15)
                {
                    textBoxRow.Text = "15";
                }
            }
        }

        private void TextBoxCol_TextChanged(object sender, EventArgs e)
        {
            string value = textBoxCol.Text;
            if (textBoxCol.Text != "")
            {
                if (int.Parse(value) >= 15)
                {
                    textBoxCol.Text = "15";
                }
            }
        }
        #endregion

        #region button Events

        /// <summary>
        /// button start will enable everything except settings
        /// and will start count of guesses and map updating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            #region Enablers
            labelCol.Enabled = true;
            labelRow.Enabled = true;
            labelGameMap.Enabled = true;
            groupBoxGame.Enabled = true;
            groupBoxActions.Enabled = true;
            buttonAction.Enabled = true;
            textBoxRow.Enabled = true;
            textBoxCol.Enabled = true;
            buttonSettings.Enabled = false;
            #endregion


            labelDescription.Text = "Type a row and column value and" +
                " click Guess to see if you found the treasure.\n";
            labelDescription.Text += "The letter 'I' will mean" +
                " you found the island.\n";
            labelDescription.Text += "The letter 'N' means that " +
                "the island is north\n";
            labelDescription.Text += "The letter 'S' means that " +
                "the island is south\n";
            labelDescription.Text += "The letter 'E' means that " +
                "the island is east\n";
            labelDescription.Text += "The letter 'W' means that " +
                "the island is west\n";
            labelDescription.Text += "The letter 'R' means correct " +
                "row and 'C' means correct column\n";

            // reset the number of guesses after every game
            guesscount = 0;


        }

        /// <summary>
        /// changes the size of the map
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            #region Enablers
            groupBoxActions.Enabled = true;
            buttonAction.Enabled = true;
            textBoxRow.Enabled = true;
            textBoxCol.Enabled = true;
            labelCol.Enabled = true;
            labelRow.Enabled = true;
            buttonStart.Enabled = false;
            #endregion

            labelDescription.Text = "To change the size of the map type" +
                " in the row and column then click change.";
            buttonAction.Text = "Change";
        }


        /// <summary>
        /// Button closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// main button gets info from the user and will call classgamemechanics
        /// in order to get the games info.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAction_Click(object sender, EventArgs e)
        {

            // prevents empty textbox issue
            try
            {

                // decides whether it is a guess or a change
                if (buttonAction.Text == "Guess")
                {
                    // gets the user guess and compares it to the size
                    columnGuess = (byte)Convert.ToInt32(textBoxCol.Text);
                    rowGuess = (byte)Convert.ToInt32(textBoxRow.Text);
                    if (rowGuess < Row || columnGuess < Col)
                    {
                        // clear the map
                        labelGameMap.Text = "";

                        // update the map
                        labelGameMap.Text = game.GuessMap(rowGuess, columnGuess);

                        // resetting the buttons for a new game
                        buttonSettings.Enabled = true;
                        buttonStart.Enabled = false;

                        // get the total count
                        guesscount++;

                        // print the total number of guesses
                        labelDescription.Text = "";
                        labelDescription.Text += "\n" + "Total number of Guesses: "
                            + guesscount.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Sorry but your guess must be within "
                            + Row.ToString() + "X" + Col.ToString() +
                        " Try again\n", "Map guess error",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                // if its a change in size map then they can't put in 0
                else if (Convert.ToInt32(textBoxRow.Text) != 0 ||
                Convert.ToInt32(textBoxCol.Text) != 0)
                {
                    // probably a unnecessary check but it doesn't hurt to make sure
                    if (buttonAction.Text == "Change")
                    {
                        // clear map
                        labelGameMap.Text = "";

                        // get users input for the change in size
                        Row = Convert.ToInt32(textBoxRow.Text);
                        Col = Convert.ToInt32(textBoxCol.Text);

                        // create the map
                        game = new ClassGameMechanics(Row, Col);
                        labelGameMap.Enabled = true;
                        // print the map
                        labelGameMap.Text = game.PrintMap();

                        // allow the game to start
                        buttonAction.Text = "Guess";
                        buttonStart.Enabled = true;
                        buttonAction.Enabled = false;

                        // makes it where the user isn't automatically
                        // typing a out of bounds array.
                        int temprow = 0;
                        temprow = Row - 1;
                        int tempcol = 0;
                        tempcol = Col - 1;
                        textBoxRow.Text = temprow.ToString();
                        textBoxCol.Text = tempcol.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Sorry but the map must be at least a " +
                        "1x1 Try again\n", "Map Size error",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry but the map must be at least a " +
                    "1x1 Try again\n", "Map Size error",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}
