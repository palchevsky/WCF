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

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool turn=true; //true = X turn, false = 0 turn;
        private int turnsCount = 0;

        public MainWindow()
        {
            InitializeComponent();
            //NewGame();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if(turn)
            {
                button.Content = "X";
            }
            else
            {
                button.Content = "O";
            }
            turn = !turn;
            turnsCount++;
            button.IsEnabled = false;
            CheckWinner();
        }

        private void CheckWinner()
        {
            bool winner = false;
            //horizontal
            if (ButtonA1.Content.Equals(ButtonA2.Content) && ButtonA2.Content.Equals(ButtonA3.Content) && !ButtonA1.IsEnabled)
            {
                winner = true;
            }
            else if (ButtonB1.Content.Equals(ButtonB2.Content) && ButtonB2.Content.Equals(ButtonB3.Content) && !ButtonB1.IsEnabled)
            {
                winner = true;
            }
            else if (ButtonC1.Content.Equals(ButtonC2.Content) && ButtonC2.Content.Equals(ButtonC3.Content) && !ButtonC1.IsEnabled)
            {
                winner = true;
            }
            //vertical
            if (ButtonA1.Content.Equals(ButtonB1.Content) && ButtonB1.Content.Equals(ButtonC1.Content) && !ButtonA1.IsEnabled)
            {
                winner = true;
            }
            else if (ButtonA2.Content.Equals(ButtonB2.Content) && ButtonB2.Content.Equals(ButtonC2.Content) && !ButtonA2.IsEnabled)
            {
                winner = true;
            }
            else if (ButtonA3.Content.Equals(ButtonB3.Content) && ButtonB3.Content.Equals(ButtonC3.Content) && !ButtonA3.IsEnabled)
            {
                winner = true;
            }
            //diagonal
            if (ButtonA1.Content.Equals(ButtonB2.Content) && ButtonB2.Content.Equals(ButtonC3.Content) && !ButtonA1.IsEnabled)
            {
                winner = true;
            }
            else if (ButtonA3.Content.Equals(ButtonB2.Content) && ButtonB2.Content.Equals(ButtonC1.Content) && !ButtonA3.IsEnabled)
            {
                winner = true;
            }

            if (winner)
            {
                DisableButtons();
                switch (turn)
                {
                    case true:
                        MessageBox.Show("O won!");
                        break;
                    case false:
                        MessageBox.Show("X won!");
                        break;
                }
            }
            else
            {
                if (turnsCount==9)
                {
                    MessageBox.Show("There is no winner!", "End of Game!");
                }
            }
        }

        private void DisableButtons()
        {
            IEnumerable<Button> Buttons = Field.Children.OfType<Button>();

            foreach (Button item in Buttons)
            {
                item.IsEnabled = false;
            }
        }
    }
}
