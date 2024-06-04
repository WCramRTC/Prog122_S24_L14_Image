using Microsoft.Win32;
using System;
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

namespace Prog122_S24_L14_Image
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FillComboBox();

            imgDisplay.Source = ConvertToImage("C:\\School\\Classes\\Programming_122\\S_24\\Inclass\\Prog122_S24_L14_Image\\Images\\CoolApe.jpg");


        } // MainWindow()

        public BitmapImage ConvertToImage(string filePath)
        {
            string imgPath = filePath;

            // Uniform Resource Identifier
            Uri convertPath = new Uri(imgPath);

            BitmapImage bitmap = new BitmapImage(convertPath);

            return bitmap;
        }

        public void FillComboBox()
        {
            Art nighthawks = new Art("Nighthawks", Art.STYLE.Impressionism);

            runDisplay.Text = nighthawks.ToString();

            cmbStyles.ItemsSource = Enum.GetValues<Art.STYLE>().Cast<Art.STYLE>().ToList();

        }

        private void btnLoadImage_Click(object sender, RoutedEventArgs e)
        {
            // Step 1
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Filter
            // What displays in drop down box
            string displayFilter = "Image files (*.png;*.jpeg;*.jpg)";
            // Used to filter results in file explorer
            string filterBy = "*.png;*.jpeg;*.jpg";
            // Full String needed
            // MUST HAVE PIPE BETWEEN DISPLAY AND FILTER
            string fullFilter = $"{displayFilter}|{filterBy}";
            // Pass to filter
            openFileDialog.Filter = fullFilter;

            //openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";

            // Opens the dialog and returns true if a image is selected
            if (openFileDialog.ShowDialog() == true)
            {
                string returnedFilePath = openFileDialog.FileName;
                imgDisplay.Source = ConvertToImage(returnedFilePath);
            }
        }
    }
}