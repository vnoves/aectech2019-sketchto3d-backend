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
using System.Drawing;
using Color = System.Drawing.Color;
using System.Windows.Forms;
using System.IO;
using MessageBox = System.Windows.MessageBox;

namespace WpfApp
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

        private void click_button(object sender, RoutedEventArgs e)
        {
            List<string> FileWritte = new List<string>();

            Bitmap HeatMapBitmap = new Bitmap(ExcelFileTxtBox.Text);
            Bitmap OrgnlPicBitmap = new Bitmap(ExcelFileTxtBox_Copy.Text);
            int n = HeatMapBitmap.Height;
            int m = HeatMapBitmap.Width;
            int[,,] arrayImg = new int[n, m, 3];
            for (int x = 0; x < HeatMapBitmap.Width; x++)
            {
                for (int y = 0; y < HeatMapBitmap.Height; y++)
                {
                    Color pixelColor = HeatMapBitmap.GetPixel(x, y);
                    Color pixelColorCopy = OrgnlPicBitmap.GetPixel(x, y);
                    float b = pixelColor.GetBrightness() * 3000;
                    FileWritte.Add( x.ToString() + "," + y.ToString() + "," + b.ToString()  +"," + pixelColorCopy.R.ToString() + "," + pixelColorCopy.G.ToString() + "," + pixelColorCopy.B.ToString() + "," + Environment.NewLine);
                    
                }
            }

            string combindedString = string.Join("-", FileWritte);
            string path = @"C:\Users\V. Noves\Downloads\Test.txt";
            File.AppendAllLines(path, new[] { combindedString });
            MessageBox.Show("Succes", "Success");
        }


        private void FindExcelFile_Click(object sender, RoutedEventArgs e)
        {
            // Fill a TextBox with the Path of the Excel file
            // Choosen by the user
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*png)|*.png";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                ExcelFileTxtBox.Text = ofd.FileName;
        }

        private void FindExcelFile_Click1(object sender, RoutedEventArgs e)
        {
            // Fill a TextBox with the Path of the Excel file
            // Choosen by the user
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*png)|*.png";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                ExcelFileTxtBox_Copy.Text = ofd.FileName;
        }

    }
}
