// Paxton Proctor
// Program 5 C# 10/20/2022
///<summary>
/// Design an inheritance hierarchy for class Quadrilateral, Trapezoid,
/// Parallelogram, Rectangle, and Square.
/// Use abstract class Quadrilateral as the base class of the hierarchy.
/// Make the hierarchy as deep (i.e., as
/// many levels) as possible, but still make sense. The private data of 
/// Quadrilateral should be the x-y
/// coordinate pairs for the four endpoints of the Quadrilateral.
/// (HINT: Use a Point class with private data.)
/// </summary>

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbstractShapesLibrary;


namespace Program_5_Quadrilateral
{
    public partial class FormQuadrilateral : Form
    {
        #region member variables

        // String array for combobox
        private String[] quadDropDown = new string[4] { "Square", "Rectangle", "Parallelogram", "Trapezoid" };
        private ArrayList quadList = new ArrayList();
        private PictureBoxSizeMode T;

        #endregion

        public FormQuadrilateral()
        {
            InitializeComponent();

            // clears and fills combobox with string array
            comboBoxQuadrilateralSelection.Items.Clear();
            comboBoxQuadrilateralSelection.Items.AddRange(quadDropDown);

            // disabling everything till they use comboBox
            textBoxX1.Enabled = false;
            textBoxY1.Enabled = false;
            textBoxX2.Enabled = false;
            textBoxY2.Enabled = false;
            textBoxX3.Enabled = false;
            textBoxX4.Enabled = false;
            textBoxY3.Enabled = false;
            textBoxY4.Enabled = false;
            buttonShape.Enabled = false;

            // methods
            comboBoxQuadrilateralSelection.SelectedIndexChanged += ComboBoxQuadrilateralSelection_SelectedIndexChanged;
            buttonShape.Click += ButtonShape_Click;
            textBoxX1.KeyPress += TextBoxX1_KeyPress;
            textBoxX2.KeyPress += TextBoxX2_KeyPress;
            textBoxX3.KeyPress += TextBoxX3_KeyPress;
            textBoxX4.KeyPress += TextBoxX4_KeyPress;
            textBoxY1.KeyPress += TextBoxY1_KeyPress;
            textBoxY2.KeyPress += TextBoxY2_KeyPress;
            textBoxY3.KeyPress += TextBoxY3_KeyPress;
            textBoxY4.KeyPress += TextBoxY4_KeyPress;
        }

        #region comboBox Events

        /// <summary>
        /// This Event will allow the use to select something from combobox and will
        /// enable buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxQuadrilateralSelection_SelectedIndexChanged(object 
            sender, EventArgs e)
        {
            if(comboBoxQuadrilateralSelection.SelectedIndex == 0)
            {
                textBoxX1.Enabled = true;
                textBoxY1.Enabled = true;
                textBoxX2.Enabled = true;
                textBoxY2.Enabled = true;
                buttonShape.Enabled = true;
            }
            else if(comboBoxQuadrilateralSelection.SelectedIndex == 1)
            {
                textBoxX1.Enabled = true;
                textBoxY1.Enabled = true;
                textBoxX2.Enabled = true;
                textBoxY2.Enabled = true;
                textBoxX3.Enabled = true;
                textBoxY3.Enabled = true;
                buttonShape.Enabled = true;
            }
            else if(comboBoxQuadrilateralSelection.SelectedIndex == 2)
            {
                textBoxX1.Enabled = true;
                textBoxY1.Enabled = true;
                textBoxX2.Enabled = true;
                textBoxY2.Enabled = true;
                textBoxX3.Enabled = true;
                textBoxY3.Enabled = true;
                buttonShape.Enabled = true;
            }
            else if(comboBoxQuadrilateralSelection.SelectedIndex == 3)
            {
                textBoxX1.Enabled = true;
                textBoxY1.Enabled = true;
                textBoxX2.Enabled = true;
                textBoxY2.Enabled = true;
                textBoxX3.Enabled = true;
                textBoxY3.Enabled = true;
                textBoxX4.Enabled = true;
                textBoxY4.Enabled = true;
                buttonShape.Enabled = true;
            }
        }
        #endregion

        #region Button Event

        /// <summary>
        /// Click has a switch that creates the shapes and uses them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShape_Click(object sender, EventArgs e)
        {
            int selection = comboBoxQuadrilateralSelection.SelectedIndex;

            T = PictureBoxSizeMode.StretchImage;

            // gets users selected index and does the following
            switch (selection)
            {
                case 0:
                    // Create Points for Rectangle and display them
                    int XS1 = int.Parse(textBoxX1.Text);
                    int YS1 = int.Parse(textBoxY1.Text);
                    int XS2 = int.Parse(textBoxX2.Text);
                    int YS2 = int.Parse(textBoxY2.Text);
                    PointLib PS1 = new PointLib(XS1, YS1);
                    PointLib PS2 = new PointLib(XS2, YS2);
                    PointLib PS3 = new PointLib(YS2, YS2);
                    PointLib PS4 = new PointLib(YS2, YS1);
                    labelC1.Text = PS1.ToString();
                    labelC2.Text = PS2.ToString();
                    labelC3.Text = PS3.ToString();
                    labelC4.Text = PS4.ToString();


                    // Getting the base,sides, and height
                    int Side = XS1 + YS2;

                    // Create a square
                    SquareLib square = new SquareLib(XS1, YS1, XS2, YS2, Side);

                    // show the square attributes
                    labelDescription.Text = "You Chose Square.\n" +
                        "Square Area is: " + square.Area().ToString() +
                        "\nSquare Perimeter is: " +
                        square.Perimeter().ToString() +
                        "\nSquare String Representation:" + square.ToString() +
                        "; P3 = " + PS3 + "; P4 = " + PS4;

                    quadList.Add(square);
                    labelobj.Text = quadList.Count.ToString();

                    try
                    {
                        // Display Image of Square
                        pictureBoxQuadrilateral.Image = new Bitmap("C:/Users" +
                            "/paxpr/source/repos/" +
                            "Program_5_Quadrilateral/bin/Square.png");
                        pictureBoxQuadrilateral.SizeMode = T;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Could Not Find Picture of Square," +
                            " try again", "Picture Not Found"
                            ,MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    break;
                case 1:
                    // Create Points for Rectangle and display them
                    int XR1 = int.Parse(textBoxX1.Text);
                    int YR1 = int.Parse(textBoxY1.Text);
                    int XR2 = int.Parse(textBoxX2.Text);
                    int YR2 = int.Parse(textBoxY2.Text);
                    int XR3 = int.Parse(textBoxX3.Text);
                    int YR3 = int.Parse(textBoxY3.Text);

                    PointLib PR1 = new PointLib(XR1, YR1);
                    PointLib PR2 = new PointLib(XR2, YR2);
                    PointLib PR3 = new PointLib(XR3, YR3);
                    PointLib PR4 = new PointLib(XR3, YR1);
                    labelC1.Text = PR1.ToString();
                    labelC2.Text = PR2.ToString();
                    labelC3.Text = PR3.ToString();
                    labelC4.Text = PR4.ToString();


                    // Getting the base,sides, and height
                    int Length = XR1 + YR2;
                    int Width = YR3 + XR2;

                    // Create a Rectangle
                    RectangleLib rectangle = new RectangleLib(XR1, YR1, 
                        XR2, YR2, XR3, YR3, Length, Width);

                    // show the Rectangle attributes
                    labelDescription.Text = "You Chose Rectangle.\n" +
                        "Rectangle Area is: " + rectangle.Area().ToString() +
                        "\nRectangle Perimeter is: " +
                        rectangle.Perimeter().ToString() +
                        "\nRectangle String" +
                        " Representation:" + rectangle.ToString() +
                        "; P4 = " + PR4;

                    quadList.Add(rectangle);
                    labelobj.Text = quadList.Count.ToString();

                    try
                    {
                        // Display Image of Rectangle
                        pictureBoxQuadrilateral.Image = new Bitmap("C:/Users" +
                            "/paxpr/source/repos/" +
                            "Program_5_Quadrilateral/bin/Rectangle.png");
                        pictureBoxQuadrilateral.SizeMode = T;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Could Not Find Picture of Rectangle," +
                            " try again", "Picture Not Found"
                            , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }

                    break;
                case 2:
                    //Create Parallelogram Points and display them
                    int XP1 = int.Parse(textBoxX1.Text);
                    int YP1 = int.Parse(textBoxY1.Text);
                    int XP2 = int.Parse(textBoxX2.Text);
                    int YP2 = int.Parse(textBoxY2.Text);
                    int XP3 = int.Parse(textBoxX3.Text);
                    int YP3 = int.Parse(textBoxY3.Text);
                    PointLib PP1 = new PointLib(XP1, YP1);
                    PointLib PP2 = new PointLib(XP2, YP2);
                    PointLib PP3 = new PointLib(XP3, YP3);
                    PointLib PP4 = new PointLib(YP3, XP3);
                    labelC1.Text = PP1.ToString();
                    labelC2.Text = PP2.ToString();
                    labelC3.Text = PP3.ToString();
                    labelC4.Text = PP4.ToString();


                    // Getting the base,sides, and height
                    int BaseParallelogram = XP1 + YP2;
                    int sideParallelogram = YP3 + XP2;
                    int HeightParallelogram = YP1 + YP2;

                    // Create a Parallelogram
                    ParallelogramLib parallelogram = new ParallelogramLib(XP1,
                        YP1, XP2, YP2, XP3, YP3, BaseParallelogram
                        , sideParallelogram, HeightParallelogram);

                    // show the Parallelogram attributes
                    labelDescription.Text = "You Chose Parallelogram.\n" +
                        "Parallelogram Area" +
                        " is: " + parallelogram.Area().ToString() +
                        "\nParallelogram Perimeter is: " +
                        parallelogram.Perimeter().ToString() +
                        "\nParallelogram " +
                        "String Representation:" + parallelogram.ToString() +
                        "; P4 = " + PP4;

                    quadList.Add(parallelogram);
                    labelobj.Text = quadList.Count.ToString();

                    // Display Image of Parallelogram
                    try
                    {
                        pictureBoxQuadrilateral.Image = new Bitmap("C:/Users" +
                            "/paxpr/source/repos/Program_5_Quadrilateral" +
                            "/bin/Parallelogram.png");
                        pictureBoxQuadrilateral.SizeMode = T;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(
                            "Could Not Find Picture of Parallelogram," +
                            " try again", "Picture Not Found"
                            , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }

                    break;
                case 3:
                    // create points for a trapezoid
                    int XT1 = int.Parse(textBoxX1.Text);
                    int YT1 = int.Parse(textBoxY1.Text);
                    int XT2 = int.Parse(textBoxX2.Text);
                    int YT2 = int.Parse(textBoxY2.Text);
                    int XT3 = int.Parse(textBoxX3.Text);
                    int YT3 = int.Parse(textBoxY3.Text);
                    int XT4 = int.Parse(textBoxX4.Text);
                    int YT4 = int.Parse(textBoxY4.Text);
                    PointLib c1 = new PointLib(XT1, YT1);
                    PointLib c2 = new PointLib(XT2, YT2);
                    PointLib c3 = new PointLib(XT3, YT3);
                    PointLib c4 = new PointLib(XT4, YT4);
                    labelC1.Text = c1.ToString();
                    labelC2.Text = c2.ToString();
                    labelC3.Text = c3.ToString();
                    labelC4.Text = c4.ToString();

                    // Getting the base,sides, and height
                    int BaseTrapezoidA = XT1 + XT4;
                    int BaseTrapezoidB = XT2 + XT3;
                    int sideTrapezoidC = YT1 + YT2;
                    int sideTrapezoidD = YT4 + YT3;
                    int HeightTrapezoid = YT1 + YT2;

                    // created a new trapezoid
                    TrapezoidLib trapezoid = new TrapezoidLib(XT1
                        , YT1, XT2, YT2, XT3, YT3, XT4, YT4
                        , BaseTrapezoidA, BaseTrapezoidB, HeightTrapezoid
                        , sideTrapezoidC, sideTrapezoidD);

                    // show the trapezoids attributes
                    labelDescription.Text = "You Chose Trapezoid.\n" +
                        "Trapezoid Area is: " + trapezoid.Area().ToString() +
                        "\nTrapezoid Perimeter is: " +
                        trapezoid.Perimeter().ToString() +
                        "\nTrapezoid String" +
                        " Representation:" + trapezoid.ToString();

                    quadList.Add(trapezoid);
                    labelobj.Text = "obj Count:" + quadList.Count.ToString();

                    try
                    {
                        // Display Image of Rectangle
                        pictureBoxQuadrilateral.Image = new Bitmap("C:/Users" +
                            "/paxpr/source/repos/" +
                            "Program_5_Quadrilateral/bin/Trapezoid.png");
                        pictureBoxQuadrilateral.SizeMode = T;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Could Not Find Picture of Trapezoid," +
                            " try again", "Picture Not Found"
                            , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Textbox Events
        private void TextBoxY4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers and backspace
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBoxY3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers and backspace
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBoxY2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers and backspace
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBoxY1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers and backspace
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBoxX4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers and backspace
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBoxX3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers and backspace
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBoxX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers and backspace
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TextBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers and backspace
            if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
