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
            if (equationText.Text.Length < 19)
                equationText.Text += "0";
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

            equationText.Text = resultText;
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (equationText.Text.Length < 19)
                equationText.Text += "-";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (equationText.Text.Length < 19)
                equationText.Text += "1";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (equationText.Text.Length < 19)
                equationText.Text += "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (equationText.Text.Length < 19)
                equationText.Text += "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (equationText.Text.Length < 19)
                equationText.Text += "9";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (equationText.Text.Length < 19)
                equationText.Text += "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (equationText.Text.Length < 19)
                equationText.Text += "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (equationText.Text.Length < 19)
                equationText.Text += "6";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (equationText.Text.Length < 19)
                equationText.Text += "2";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (equationText.Text.Length < 19)
                equationText.Text += "3";
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (equationText.Text.Length < 19)
                equationText.Text += "+";
        }

        private void buttonDecimal_Click(object sender, RoutedEventArgs e)
        {
            if(equationText.Text.Length < 19)
                equationText.Text += ".";
        }
    }
}
