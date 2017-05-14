using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Lift
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public LiftClass lift; //экземпляр лифта
        Image imgDorsOpend = new Image();
        Image imgDorsClosed = new Image();

        public MainWindow(LiftClass lift)
        {
            InitializeComponent();
            this.lift = lift;
            imgDorsOpend.Source = new BitmapImage(new Uri("../Images/dors_opend.jpg", UriKind.RelativeOrAbsolute));
            imgDorsClosed.Source = new BitmapImage(new Uri("../Images/dors_closed.jpg", UriKind.RelativeOrAbsolute));
            AddFloors(lift.maxFloor);
            AddButtons(lift.maxFloor);
            var d = lift.maxFloor - 1;
            Canvas.SetTop(imLift, 10 + (d * Properties.Settings.Default.FloorHeight + 5 * d));
        }

        private void AddFloors(byte N)
        {
            for (int i=N; i>0; i--)
            {
                TextBlock newtB = new TextBlock();
                newtB.Text = i.ToString();
                Style style = this.FindResource("FloorStyle") as Style;
                newtB.Style = style;
                SPanel.Children.Add(newtB);
            }
        }

        private void AddButtons(byte N)
        {
            for (int i=1; i<=N; i++)
            {
                ToggleButton btn = new ToggleButton();
                btn.Tag = i;
                btn.Content = i;
                btn.ToolTip = "Этаж "+i;
                Style style = this.FindResource("BtnStyle") as Style;
                btn.Style = style;
                BtnPannel.Children.Add(btn);
                btn.Click += btn_Click;
           }
        }

        public void MoveToFloor(byte floor)
        {
            if (lift.currentFloor == floor || floor == 0)
            {
                return;
            }

            int dF3 = 1;
            if (lift.currentFloor > floor)
                dF3 = -1;
             MoveOneFloor(Convert.ToByte(lift.currentFloor + dF3));
        }

        public void MoveOneFloor(byte floor, Action completed = null)
        {
            var oldY = Canvas.GetTop(imLift);
            var dF = lift.maxFloor - floor;
            var newY = 10 + (dF * Properties.Settings.Default.FloorHeight + 5 * dF);
            DoubleAnimation anim = new DoubleAnimation(oldY, newY, TimeSpan.FromSeconds(lift.speedOneFloor));
            anim.Completed += anim_Complete;
            imLift.BeginAnimation(Canvas.TopProperty, anim);
            lift.currentFloor = floor;
            lift.targetFloor = lift.GetNextFloor();
        }

        public void OpenDors()
        {
            imLift.Source = imgDorsOpend.Source;
        }

        public void CloseDors()
        {
            imLift.Source = imgDorsClosed.Source;
        }

        async void anim_Complete(object sender, EventArgs e)
        {
            if (lift.targetFloor == lift.currentFloor)
            {
                foreach (ToggleButton Btn in BtnPannel.Children.OfType<ToggleButton>())
                    if (Convert.ToByte(Btn.Tag) == lift.currentFloor)
                        Btn.IsChecked = false;
                lift.CallList[lift.currentFloor - 1] = false;

                OpenDors();
                await Task.Delay(TimeSpan.FromSeconds(lift.doorsTime));
                CloseDors();

                lift.currentState = LiftClass.States.wait;

                if (lift.CallList.All(p => !p))
                    lift.currentState = LiftClass.States.wait;
                else
                    MoveToFloor(lift.GetNextFloor());
                return;
            }

            int dF3 = 1;
            if (lift.currentFloor > lift.targetFloor)
                dF3 = -1;
            MoveOneFloor(Convert.ToByte(lift.currentFloor + dF3));

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as ToggleButton;
            var selectedFloor = Convert.ToByte(btn.Tag);

            
            if (selectedFloor == lift.currentFloor)
            {
                btn.IsChecked = false;
                LiftDors();
                lift.currentState = LiftClass.States.wait;
                return;
            }

            if (lift.CallList.All(p => !p))
            {
                lift.CallList[selectedFloor - 1] = true;
                MoveToFloor(lift.GetNextFloor());
            }

            lift.CallList[selectedFloor - 1] = true;

            if (btn.IsChecked == false)
            {
                lift.CallList[selectedFloor - 1] = false;
            }
            
        }

        private async void LiftDors()
        {
            OpenDors();
            await Task.Delay(TimeSpan.FromSeconds(lift.doorsTime));
            CloseDors();
        }


    }
}
