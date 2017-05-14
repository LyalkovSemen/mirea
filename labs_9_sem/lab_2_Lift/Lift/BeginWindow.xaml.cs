using System;
using System.Windows;

namespace Lift
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BeginWindow : Window
    {
        public BeginWindow()
        {
            InitializeComponent();
            btnOk.Focus();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            byte floorsCount;
            double speedOneFloor;
            double dorsTime;
            Byte.TryParse(InputFloors.Text, out floorsCount);
            Double.TryParse(InputTimeFloor.Text.Replace(".", ","), out speedOneFloor);
            Double.TryParse(InputTimeDors.Text.Replace(".", ","), out dorsTime);
            var lift = new LiftClass("ottis",600, 1, floorsCount, speedOneFloor, dorsTime);
            MainWindow main = new MainWindow(lift);
            main.Show();
            this.Close();
        }

    }
}
