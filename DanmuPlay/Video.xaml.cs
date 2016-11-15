using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Diagnostics;

namespace DanmuPlay
{
    /// <summary>
    /// Video.xaml 的交互逻辑
    /// </summary>
    public partial class Video : Window
    {
        public Video()
        {
            InitializeComponent();
            Uri uri = new Uri("G:/CloudMusic/MV/Gary - 没关系.mp4", UriKind.Absolute);
            Process.Start(uri.ToString());//使用电脑上自带的解码播放器来播放视频，不是嵌入式的
        }
    }
}
