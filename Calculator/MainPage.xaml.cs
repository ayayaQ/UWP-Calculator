using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        const int MAX_CHAR = 19;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            equationText.Text = "";
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            appendClick("0");
        }


        private async void buttonEqual_Click(object sender, RoutedEventArgs e)
        {
            DataTable dataTable = new DataTable();
            String resultText;
            try
            {
                var result = dataTable.Compute(equationText.Text, "");
                resultText = result.ToString();
            } catch(SyntaxErrorException error)
            {
                //var result = error.ToString(); Maybe add / do something with this later
                string result = "Invalid Equation";
                resultText = result.ToString();
            }

            if (resultText == "∞")
                resultText = "You can't divide by zero.";

            equationText.Text = resultText;
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            appendClick("-");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            appendClick("1");
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            appendClick("7");
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            appendClick("8");
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            appendClick("9");
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            appendClick("4");
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            appendClick("5");
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            appendClick("6");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            appendClick("2");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            appendClick("3");
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            appendClick("+");
        }

        private void buttonDecimal_Click(object sender, RoutedEventArgs e)
        {
            appendClick(".");
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            appendClick("/");
        }

        private void buttonTimes_Click(object sender, RoutedEventArgs e)
        {
            appendClick("*");
        }

        private void appendClick(String item)
        {
            if (equationText.Text.Length < MAX_CHAR)
                equationText.Text += item;
        }
    }
}
