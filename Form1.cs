using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatorwinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object txt_Result { get; private set; }
        // Add function to add 2 numbers. This function accept two sring type parameters and string type parameters and srtring return value

        static String Add(String FirstNumber, String SecondNumber)
        {
            int First_Number = int.Parse(FirstNumber);
            int Second_Number = int.Parse(SecondNumber);
            int Result = First_Number + Second_Number;
            return Result.ToString();
        }

        // Sub function to perform subtraction operation. This function accept two string type parameters and string type return value
        static String Sub(String FirstNumber, String SecondNumber)
        {
            int First_Number = int.Parse(FirstNumber);
            int Second_Number = int.Parse(SecondNumber);
            int Result = First_Number - Second_Number;
            return Result.ToString();
        }

        // Mult function to perform multiplication operation. This function accept two string type parameters and string type return value
        static String Mul(String FirstNumber, String SecondNumber)
        {
            int First_Number = int.Parse(FirstNumber);
            int Second_Number = int.Parse(SecondNumber);
            int Result = First_Number * Second_Number;
            return Result.ToString();
        }

        // Div function to perform Division operation. This function accept two string type parameters and string type return value
        static String Div(String FirstNumber, String SecondNumber)
        {
            int First_Number = int.Parse(FirstNumber);
            int Second_Number = int.Parse(SecondNumber);
            int Result = First_Number / Second_Number;
            return Result.ToString();
        }


        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Add(Txt_FirstNumber.Text, Txt_SecondNumber.Text);
        }

        private void Btn_Sub_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Sub(Txt_FirstNumber.Text, Txt_SecondNumber.Text);
        }

        private void Btn_Mul_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Mul(Txt_FirstNumber.Text, Txt_SecondNumber.Text);
        }

        private void Btn_Div_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Div(Txt_FirstNumber.Text, Txt_SecondNumber.Text);
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
