using System; 
using Xamarin.Forms;
namespace App1

{
    public partial class MainPage : ContentPage 
    {
        private double a, b; 
        private int count; 

        public MainPage() 
        {
            InitializeComponent();
            Mainlabel.Text = "0"; 
        }

        private void Button_ClickedRAVNO(object sender, EventArgs e )
        {

            switch (count)  
            {
                    case 1:
                        b = a + double.Parse(Mainlabel.Text); 
                        break;
                    case 2:
                        b = a / double.Parse(Mainlabel.Text);
                        break;
                    case 3:
                        b = a - double.Parse(Mainlabel.Text);
                        break;
                    case 4:
                        b = a * double.Parse(Mainlabel.Text);
                        break ; 

                }
                Mainlabel.Text = b.ToString();

        }

            private void MainLabel(string symbol)
            {
            if (Mainlabel.Text == "0")
                return;
            else
                Mainlabel.Text += symbol;
            }

        private void Button_ClickedSeven(object sender, EventArgs e)
        {
            MainLabel("7");
        }

        private void Button_ClickedEight(object sender, EventArgs e)
        {
            MainLabel("8");
        }

        private void Button_ClickedNine(object sender, EventArgs e)
        {
            MainLabel("9");
        }

        private void Button_ClickedFour(object sender, EventArgs e)
        {
            MainLabel("4");
        }

        private void Button_ClickedFive(object sender, EventArgs e)
        {
            MainLabel("5");
        }

        private void Button_ClickedSix(object sender, EventArgs e)
        {
            MainLabel("6");
        }

        private void Button_ClickedOne(object sender, EventArgs e)
        {
            MainLabel("1");
        }

        private void Button_ClickedTwo(object sender, EventArgs e)
        {
            MainLabel("2");
        }

        private void Button_ClickedThree(object sender, EventArgs e)
        {
            MainLabel("3");
        }

        private void Button_ClickedZero(object sender, EventArgs e)
        {
        MainLabel("0");
        }

        private void Button_ClickedPoint(object sender, EventArgs e)
        {
            if (!Mainlabel.Text.Contains("."))
                Mainlabel.Text += ".";
        }

        private void Button_ClickedPlus(object sender, EventArgs e)
        {
            if (Mainlabel.Text.Length == 0 || Mainlabel.Text.EndsWith(".") || Mainlabel.Text.EndsWith("/") || Mainlabel.Text.EndsWith("x") || Mainlabel.Text.EndsWith("+") || Mainlabel.Text.EndsWith("-"))
            {
                return; 
            }
            a = double.Parse(Mainlabel.Text);
            count = 1;
            Storylabel.Text = Mainlabel.Text + "+";
            Mainlabel.Text = "0";
        }

        private void Button_ClickedMinus(object sender, EventArgs e)
        {
            if (Mainlabel.Text.Length == 0 || Mainlabel.Text.EndsWith(".") || Mainlabel.Text.EndsWith("/") || Mainlabel.Text.EndsWith("x") || Mainlabel.Text.EndsWith("+") || Mainlabel.Text.EndsWith("-"))
            {
                return;
            }
            a = double.Parse(Mainlabel.Text);
            count = 3;
            Storylabel.Text = Mainlabel.Text + "-";
            Mainlabel.Text = "0";
        }

        private void Button_ClickedUmnohit(object sender, EventArgs e)
        {
            if (Mainlabel.Text.Length == 0 || Mainlabel.Text.EndsWith(".") || Mainlabel.Text.EndsWith("/") || Mainlabel.Text.EndsWith("x") || Mainlabel.Text.EndsWith("+") || Mainlabel.Text.EndsWith("-") )
            {
                return;
            }
            a = double.Parse(Mainlabel.Text);
            count = 4;
            Storylabel.Text = Mainlabel.Text + "*";
            Mainlabel.Text = "0";
        }

        private void Button_ClickedDelenie(object sender, EventArgs e)
        {
            if (Mainlabel.Text.Length == 0 || Mainlabel.Text.EndsWith(".") || Mainlabel.Text.EndsWith("/") || Mainlabel.Text.EndsWith("x") || Mainlabel.Text.EndsWith("+") || Mainlabel.Text.EndsWith("-") )
            {
                return;
            }
            a = double.Parse(Mainlabel.Text);
            count = 2;
            Storylabel.Text = Mainlabel.Text + "/";
            Mainlabel.Text = "0";
        }

        private void Button_ClickedProcent(object sender, EventArgs e)
        {
            if (Mainlabel.Text.EndsWith(".") || Mainlabel.Text.EndsWith("/") || Mainlabel.Text.EndsWith("x") || Mainlabel.Text.EndsWith("+") || Mainlabel.Text.EndsWith("-") || Mainlabel.Text.EndsWith("%"))
            {
                return;
            }
            if(Mainlabel.Text == "0")
            {
                return;
            }
            double s = 0;
            double d = 0;
            if (!string.IsNullOrEmpty(Storylabel.Text))
            {
                s = double.Parse(Storylabel.Text.Remove(Storylabel.Text.Length - 1));
                d = double.Parse(Mainlabel.Text);
                d = s * d / 100;

            }
            else
            {
                d = double.Parse(Mainlabel.Text);
                d = d * d / 100;
                
            }
            Mainlabel.Text = d.ToString();

        }

        private void Button_ClickedClear(object sender, EventArgs e)
        {
            if (Mainlabel.Text == "0")
            {
                Storylabel.Text = "";
            }
            Mainlabel.Text = "0";
            a = 0;
            b = 0;
        }

        private void Button_ClickedCoreni(object sender, EventArgs e)
        {
            if (Mainlabel.Text.Length == 0 || Mainlabel.Text.EndsWith("√") || Mainlabel.Text.EndsWith("/") || Mainlabel.Text.EndsWith("x") || Mainlabel.Text.EndsWith("+") || Mainlabel.Text.EndsWith("-"))
            {
                return;
            }
            a = double.Parse(Mainlabel.Text);
            count = 5;
            Storylabel.Text = Mainlabel.Text + "√";
            b = Math.Sqrt(a);
            Mainlabel.Text = b.ToString();
        }

        private void Button_ClickedBack(object sender, EventArgs e)
        {
            if (Mainlabel.Text.Length > 0)
            {
                Mainlabel.Text = Mainlabel.Text.Remove(Mainlabel.Text.Length - 1);
                if (Mainlabel.Text.Length <= 0)
                {
                    Mainlabel.Text = "0";
                }
            }
        }
    }
}
