using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EThompson_Currency_Converter
{
    public partial class Form1 : Form
    {
        public string toIn;
        public string fromIn;
        public double fromOut;
        public double toOut;
        public string fromCurrency;
        public string toCurrency;

        public Form1()
        {
            InitializeComponent();
        }

        private void flagTwo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void fromList_SelectedIndexChanged(object sender, EventArgs e)
        {
            setFromFlags();
        }

        private void goButton_Click(object sender, EventArgs e)
        {

            if (fromValue.Text.ToString() == "")
            {
                MessageBox.Show("Enter an amount to convert from.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (fromList.SelectedItem is null)
            {
                MessageBox.Show("Select the type of currency to convert from.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else if (toList.SelectedItem is null)
            {
                MessageBox.Show("Select the type of currency to convert to.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fromIn = fromValue.Text.ToString();
                fromOut = double.Parse(fromIn);
                fromValue.Text = fromOut.ToString("0.00");
                doCalculations();

                setOutText();
            }
        }
        public void setToFlags()
        {
            toCurrency = toList.SelectedItem.ToString();

            switch (toCurrency)
            {
                case "U.S. Dollar":
                    flagTwo.Image = EThompson_Currency_Converter.Properties.Resources.usa;
                    break;

                case "Euro":
                    flagTwo.Image = EThompson_Currency_Converter.Properties.Resources.uk;
                    break;

                case "Canadian Dollar":
                    flagTwo.Image = EThompson_Currency_Converter.Properties.Resources.canada;
                    break;

                case "Japanese Yen":
                    flagTwo.Image = EThompson_Currency_Converter.Properties.Resources.japan;
                    break;

                case "Argentine Peso":
                    flagTwo.Image = EThompson_Currency_Converter.Properties.Resources.argentina;
                    break;
            }

        }


        public void setFromFlags()
        {
            fromCurrency = fromList.SelectedItem.ToString();
           



            switch(fromCurrency)
            {
                case "U.S. Dollar":
                    flagOne.Image = EThompson_Currency_Converter.Properties.Resources.usa;
                    break;

                case "Euro":
                    flagOne.Image = EThompson_Currency_Converter.Properties.Resources.uk;
                    break;

                case "Canadian Dollar":
                    flagOne.Image = EThompson_Currency_Converter.Properties.Resources.canada;
                    break;

                case "Japanese Yen":
                    flagOne.Image = EThompson_Currency_Converter.Properties.Resources.japan;
                    break;

                case "Argentine Peso":
                    flagOne.Image = EThompson_Currency_Converter.Properties.Resources.argentina;
                    break;
            }

            
        }

        public double doCalculations()
        {
            fromCurrency = fromList.SelectedItem.ToString();
            toCurrency = toList.SelectedItem.ToString();

            fromOut = double.Parse(fromIn);

            if (fromCurrency is "U.S. Dollar")
            {
                switch (toCurrency)
                {
                    case "U.S. Dollar":
                        toOut = fromOut;
                        break;

                    case "Euro":
                        toOut = fromOut * 0.93;
                        break;

                    case "Canadian Dollar":
                        toOut = fromOut * 1.34;
                        break;

                    case "Japanese Yen":
                        toOut = fromOut * 132.51;
                        break;

                    case "Argentine Peso":
                        toOut = fromOut * 189.08;
                        break;
                }
            }else if(fromCurrency is "Euro")
            {
                switch (toCurrency)
                {
                    case "Euro":
                        toOut = fromOut;
                        break;

                    case "U.S. Dollar":
                        toOut = fromOut / 0.93;
                        break;

                    case "Canadian Dollar":
                        toOut = fromOut * 1.44;
                        break;

                    case "Japanese Yen":
                        toOut = fromOut * 140.58;
                        break;

                    case "Argentine Peso":
                        toOut = fromOut * 202.41;
                        break;
                }
            }
            else if (fromCurrency is "Canadian Dollar")
            {
                switch (toCurrency)
                {
                    case "Canadian Dollar":
                        toOut = fromOut;
                        break;

                    case "U.S. Dollar":
                        toOut = fromOut / 1.34;
                        break;

                    case "Euro":
                        toOut = fromOut * .70;
                        break;

                    case "Japanese Yen":
                        toOut = fromOut * 97.65;
                        break;

                    case "Argentine Peso":
                        toOut = fromOut * 141;
                        break;
                }
            }
            else if (fromCurrency is "Japanese Yen")
            {
                switch (toCurrency)
                {
                    case "Japanese Yen":
                        toOut = fromOut;
                        break;

                    case "U.S. Dollar":
                        toOut = fromOut * .0076;
                        break;

                    case "Canadian Dollar":
                        toOut = fromOut * 0.010;
                        break;

                    case "Euro":
                        toOut = fromOut * 0.0071;
                        break;

                    case "Argentine Peso":
                        toOut = fromOut * 1.44;
                        break;
                }
            }
            else if (fromCurrency is "Argentine Peso")
            {
                switch (toCurrency)
                {
                    case "Argentine Peso":
                        toOut = fromOut;
                        break;

                    case "U.S. Dollar":
                        toOut = fromOut * 0.0053;
                        break;

                    case "Canadian Dollar":
                        toOut = fromOut * 0.0071;
                        break;

                    case "Japanese Yen":
                        toOut = fromOut * 140.58;
                        break;

                    case "Euro":
                        toOut = fromOut * 0.0049;
                        break;
                }
            }

            return toOut;
        }

        public void setOutText()
        {
            toValue.Text = toOut.ToString("0.00");
            fromValue.Text = fromOut.ToString("0.00");
        }

        private void toList_SelectedIndexChanged(object sender, EventArgs e)
        {
            setToFlags();
        }
    }
}
