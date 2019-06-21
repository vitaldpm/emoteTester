using Microsoft.Win32;
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

namespace emoteTester
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

        private void BtnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                imgDynamic.Source = new BitmapImage(fileUri);
                imgDynamic2.Source = new BitmapImage(fileUri);
                imgDynamic3.Source = new BitmapImage(fileUri);
                imgDynamic4.Source = new BitmapImage(fileUri);
            }


        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Name1.Text = nameUpdate.Text;
            Name2.Text = nameUpdate.Text;
            Name3.Text = nameUpdate.Text;
            Name4.Text = nameUpdate.Text;
            nameUpdate.Text = "";

        }
        private void BtnTextUpdate_Click(object sender, RoutedEventArgs e)
        {
            Text1.Text = textUpdate.Text;
            Text2.Text = textUpdate.Text;
            Text3.Text = textUpdate.Text;
            Text4.Text = textUpdate.Text;
            textUpdate.Text = "";
        }
    }
}
