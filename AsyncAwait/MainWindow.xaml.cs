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
using System.IO;
using System.Threading;

namespace AsyncAwait
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

        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader sr = new StreamReader("Data.txt"))
            {
                string content = sr.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }

            return count;
        }

        // Using Async-Await

        private async void ProcessFile_Click(object sender, RoutedEventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();
            lblCount.Content = "Processing File. Please wait...";

            int count = await task;
            lblCount.Content = count;
        }

        // using Threads

        //private void ProcessFile_Click(object sender, RoutedEventArgs e)
        //{
        //    int count = 0;

        //    Thread t = new Thread(() =>
        //    {
        //        count = CountCharacters();
        //        Action action = () => lblCount.Content = count;
        //        Dispatcher.BeginInvoke(action);
        //    });
        //    t.Start();

        //    lblCount.Content = "Processing File. Please wait...";
        //}

    }
}
