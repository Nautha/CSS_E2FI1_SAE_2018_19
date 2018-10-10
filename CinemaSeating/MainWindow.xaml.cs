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

namespace CinemaSeating
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int ROWS = 3;
        private const int COLUMNS = 4;

        public MainWindow() {
            InitializeComponent();
            createRoom();
        }

        public void createRoom() {

            for (int i = 0; i < ROWS + 2; i++) {
                _Room_Grid.RowDefinitions.Add(new RowDefinition());
            }

            for (int j = 0; j < COLUMNS + 2; j++) {
                _Room_Grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < ROWS; i++) {
                for (int j = 0; j < COLUMNS; j++) {
                    Seat s = new Seat();
                    s.Content = string.Format("Seat: {0}", (4 * i) + j + 1);
                    Grid.SetRow(s, i + 1);
                    Grid.SetColumn(s, j + 1);
                    _Room_Grid.Children.Add(s);
                }
            }
        }
    }
}
