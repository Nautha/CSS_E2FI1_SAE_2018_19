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

namespace Kopierkarte
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Copycard card;

        public MainWindow() {
            InitializeComponent();

            //_loginColumn.Width = new GridLength(0.0);
            //_copyColumn.Width = new GridLength(0.0);
            //cardlist = new List<Copycard>();
        }

        private bool isNumeric(string s) {
            int n;
            return int.TryParse(s, out n);
        }

        private void addCardButton(object sender, RoutedEventArgs e) {
            if (_newPinTextBox.Text == "") {
                card = new Copycard();
            } else {
                if (!(isNumeric(_newPinTextBox.Text) && isNumeric(_newCopiesTextBox.Text))) {
                    return;
                }
                card = new Copycard(
                        Int32.Parse(_newCopiesTextBox.Text),
                        Int32.Parse(_newPinTextBox.Text)
                    );
            }

            MessageBox.Show("Karte wurde erfolgreich erstellt.");

            //_initializeColumn.Width = new GridLength(0.0);
            //_loginColumn.Width = new GridLength(200.0);
        }

        private void createCopiesButton(object sender, RoutedEventArgs e) {
            if (isNumeric(_copyTextBox.Text)) {
                if (card.copy(int.Parse(_copyTextBox.Text))) {
                    MessageBox.Show("Kopien wurden erfolgreich erstellt.",
                        "OK",
                        MessageBoxButton.OK);
                } else {
                    MessageBox.Show("Nicht genug Kopien übrig.",
                        "OK",
                        MessageBoxButton.OK);
                }
            }
        }

        private void testPinButton(object sender, RoutedEventArgs e) {
            if (_testPinTextBox.Text != "") {
                if (card.isPinValid(Int32.Parse(_testPinTextBox.Text))) {
                    MessageBox.Show("Pin ist korrekt");
                } else {
                    MessageBox.Show("Pin falsch");
                }
            }
        }

        private void exitButton(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }
    }
}
