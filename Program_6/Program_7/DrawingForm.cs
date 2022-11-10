// Paxton Proctor
// Program 7 C# 11/10/2022
///<summary>
/// Extend the Painter program (fig. 14.38) to include options for changing the size
/// and color of the lines drawn in a panel contained in a form. Create a GUI similar to
/// the one in the text at the end of chapter 14 (fig. 14.43). Use variables to keep track
/// of the currently selected size (int) and color(Color object). Change the values of
/// those variables in the event handlers for the radio buttons. Use one event handler for
/// each group of radio buttons. When responding to the mouse moves, simply use the
/// size and color variables to determine the proper size and color to draw with.
/// </summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_7
{
    public partial class DrawingForm : Form
    {
        #region member variables

        // bool to determine whether to draw or not
        bool shouldDraw { get; set; } = false;

        // pen color and size declaration
        Color pen = Color.Black;
        int pensize = 4;

        // creates a color wheel declaration
        ColorDialog colorDialog = new ColorDialog();
        #endregion
        public DrawingForm()
        {
            InitializeComponent();

            // mouse methods 
            drawingpanel.MouseDown += Drawingpanel_MouseDown;
            drawingpanel.MouseUp += Drawingpanel_MouseUp;
            drawingpanel.MouseMove += Drawingpanel_MouseMove;

            // default panel color
            drawingpanel.BackColor = Color.White;

            // menu methods
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            customizeColorToolStripMenuItem.Click += CustomizeColorToolStripMenuItem_Click;
            clearToolStripMenuItem.Click += ClearToolStripMenuItem_Click;

            // color pen method
            blackpenradioButton.CheckedChanged += new EventHandler(ColorPenRadioButton_CheckedChanged);
            whitepenradioButton.CheckedChanged += new EventHandler(ColorPenRadioButton_CheckedChanged);
            redpenradioButton.CheckedChanged += new EventHandler(ColorPenRadioButton_CheckedChanged);
            bluepenradioButton.CheckedChanged += new EventHandler(ColorPenRadioButton_CheckedChanged);
            greenpenradioButton.CheckedChanged += new EventHandler(ColorPenRadioButton_CheckedChanged);

            // size method
            sizetworadioButton.CheckedChanged += new EventHandler(SizePenRadioButton_CheckedChanged);
            sizefourradioButton.CheckedChanged += new EventHandler(SizePenRadioButton_CheckedChanged);
            sizesixradioButton.CheckedChanged += new EventHandler(SizePenRadioButton_CheckedChanged);
            sizeeightradioButton.CheckedChanged += new EventHandler(SizePenRadioButton_CheckedChanged);

            // color panel method
            blackpanelradioButton.CheckedChanged += new EventHandler(ColorPanelRadioButton_CheckedChanged);
            whitepanelradioButton.CheckedChanged += new EventHandler(ColorPanelRadioButton_CheckedChanged);
            darkgraypanelradioButton.CheckedChanged += new EventHandler(ColorPanelRadioButton_CheckedChanged);
            fuchsiapanelradioButton.CheckedChanged += new EventHandler(ColorPanelRadioButton_CheckedChanged);
        }

        #region radio button events
        /// <summary>
        /// change panel color method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorPanelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // using sender to determine which radiobutton we're using
            if (sender == blackpanelradioButton)
            {
                drawingpanel.BackColor = Color.Black;
            }
            else if (sender == whitepanelradioButton)
            {
                drawingpanel.BackColor = Color.White;
            }
            else if (sender == darkgraypanelradioButton)
            {
                drawingpanel.BackColor = Color.DarkGray;
            }
            else if (sender == fuchsiapanelradioButton)
            {
                drawingpanel.BackColor = Color.Fuchsia;
            }
        }

        /// <summary>
        /// this method uses the radiobuttons to change the size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SizePenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // using sender to determine which radiobutton we're using
            if (sender == sizetworadioButton)
            {
                pensize = 2;
            }
            else if (sender == sizefourradioButton)
            {
                pensize = 4;
            }
            else if (sender == sizesixradioButton)
            {
                pensize = 6;
            }
            else if (sender == sizeeightradioButton)
            {
                pensize = 8;
            }
        }

        /// <summary>
        /// this method uses the radiobuttons to change pen color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorPenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // using sender to determine which radiobutton we're using
            if (sender == blackpenradioButton)
            {
                pen = Color.Black; 
            }
            else if (sender == whitepenradioButton)
            {
                pen = Color.White;
            }
            else if(sender == redpenradioButton)
            {
                pen = Color.Red;
            }
            else if (sender == greenpenradioButton)
            {
                pen = Color.Green;
            }
            else if (sender == bluepenradioButton)
            {
                pen = Color.Blue;
            }
        }
        #endregion

        #region Menu Events
        /// <summary>
        /// clears the panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawingpanel.Refresh();
        }

        /// <summary>
        /// shows a color wheel and lets the user select whatever color they want for the pen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomizeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.AllowFullOpen = true;
            colorDialog.AnyColor = true;
            colorDialog.SolidColorOnly = true;
            colorDialog.ShowDialog();
            pen = colorDialog.Color;
        }

        /// <summary>
        /// exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region mouse events
        /// <summary>
        /// when the mouse moves draw
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Drawingpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldDraw) // check if mouse button is being pressed
            {
                // draw a circle where the mouse pointer is present
                using (Graphics graphics = drawingpanel.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(pen), e.X, e.Y, pensize, pensize);
                } // end
            }
        }

        /// <summary>
        /// if user isn't clicking the mouse don't draw
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Drawingpanel_MouseUp(object sender, MouseEventArgs e)
        {
            shouldDraw = false;
        }

        /// <summary>
        /// if user is clicking the mouse draw
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Drawingpanel_MouseDown(object sender, MouseEventArgs e)
        {
            shouldDraw = true;
        }
        #endregion
    }
}
