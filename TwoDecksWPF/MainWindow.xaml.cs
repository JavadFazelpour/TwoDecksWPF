using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TwoDecksWPF
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
        private void MoveCard(bool leftToRight)
        {
            if ((Resources["rightDeck"] is Deck rightDeck) && (Resources["leftDeck"] is Deck leftDeck))
            {
                if (leftToRight)
                {
                    if (leftDeckListBox.SelectedItem is Card card)
                    {
                        leftDeck.Remove(card);
                        rightDeck.Add(card);
                    }
                }
                else
                {
                    if (rightDeckListBox.SelectedItem is Card card)
                    {
                        rightDeck.Remove(card);
                        leftDeck.Add(card);
                    }
                }
            }
        }

        private void shuffleLeftDeck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void clearRightDeck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void resetLeftDeck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sortRightDeck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void leftDeckListBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void leftDeckListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void rightDeckListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void rightDeckListBox_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}