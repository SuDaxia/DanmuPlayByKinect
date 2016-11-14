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

using System.Windows.Annotations;
using System.Windows.Annotations.Storage;

namespace DanmuPlay
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mediaElement.Play();
        }

        private void fileOpenPicker_click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = @"视频文件(*.wmv)|*.wmv|视频文件(*.wav)|*.wav|视频文件(*.mp3)|*.mp3|视频文件(*.AVI)|*.avi|视频文件(*.mpg)|*.mpg|所有文件(*.*)|*.*";//支持mp3 wma wmv AVI 但是好像不支持mp4 wav
            openFileDialog.InitialDirectory = "C:\\Users\\Sudaxia\\Videos";//设置打开的默认目录
            openFileDialog.RestoreDirectory = true;//是否记录保持当前路径
            if (openFileDialog.ShowDialog() == false) ;//WPF中是可空的true or false；在winform中才可以用OK Cancel
            {
                return;
            }
            mediaElement.Source = new Uri(openFileDialog.FileName,UriKind.Absolute);
            Console.WriteLine("Source==" + mediaElement.Source.ToString());
            mediaElement.Play();
        }
    }
}
