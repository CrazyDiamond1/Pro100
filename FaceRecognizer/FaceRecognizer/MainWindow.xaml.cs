using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfCap;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
<<<<<<< HEAD
using System.Drawing;
using Emgu.CV;
=======
using System.Threading;
>>>>>>> 293ce7235e35900cb4f43eecf4e00bfec45a1b40

namespace FaceRecognizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Result { get; set; }
        public double ProgressPercent { get; set; }
        public string Done { get; set; }
        public double Scalar = 502;
        public MainWindow()
        {

            InitializeComponent();
            Name = "person";
            Result = "You look like a " + Name;
            ReturnText.DataContext = this;
            ProgressPercent = .0 * Scalar;
            ProgressBar.DataContext = this;
        }



        private void TakePictureButton_Click(object sender, RoutedEventArgs e)
        
        {
<<<<<<< HEAD
            //VideoCapture capture = new VideoCapture();
            Bitmap image = new Bitmap("Icon\\Triangle.png");
            image.Save("..\\..\\..\\..\\Screenshots\\screen.png", System.Drawing.Imaging.ImageFormat.Png);
=======
            for (int i = 0; i < 101; i++)
            {
                ProgressPercent += .01 * Scalar;
                this.ProgressBar.Width = ProgressPercent;
            }
            if ((ProgressPercent / Scalar) >= 1) { Done = "Done"; ProgressBar.Content = Done; }

>>>>>>> 293ce7235e35900cb4f43eecf4e00bfec45a1b40
        }

        private void RetakeButton_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
