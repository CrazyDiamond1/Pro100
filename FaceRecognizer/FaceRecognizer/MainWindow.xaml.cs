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
using System.Drawing;
using Emgu.CV;

namespace FaceRecognizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Result { get; set; }
        public MainWindow()
        {

            InitializeComponent();
            Result = "TempText";
            ReturnText.DataContext = this;
        }

        private void TakePictureButton_Click(object sender, RoutedEventArgs e)
        {
            //VideoCapture capture = new VideoCapture();
            Bitmap image = new Bitmap("Icon\\Triangle.png");
            image.Save("..\\..\\..\\..\\Screenshots\\screen.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void RetakeButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
