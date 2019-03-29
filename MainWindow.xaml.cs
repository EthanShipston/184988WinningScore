/*Ethan Shipston
 * 29/3/2019
 * A program which calculates which basketball team won based on number of shots given.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _184988WinningScore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Logic.
        /// </summary>
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int[] scores = new int[6];
            string temp = txtInputs.Text;
            for (int i = 0; i < 5; i++)
            {
                int.TryParse(temp.Substring(0, txtInputs.Text.IndexOf("\n")), out scores[i]);
                temp = temp.Remove(0, temp.IndexOf("\n") + 1);
            }
            int.TryParse(temp, out scores[5]);

            int A = (scores[0] * 3) + (scores[1] * 2) + scores[2];
            int B = (scores[3] * 3) + (scores[4] * 2) + scores[5];

            if (A < B)
            {
                lblOutput.Content = "B";
            }
            else if (A == B)
            {
                lblOutput.Content = "T";
            }
            else if (A > B)
            {
                lblOutput.Content = "A";
            }
        }
    }
}
