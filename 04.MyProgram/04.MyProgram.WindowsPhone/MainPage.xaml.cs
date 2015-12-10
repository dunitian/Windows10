using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上提供

namespace _04.MyProgram
{
    /// <summary>
    /// 可独立使用或用于导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">描述如何访问此页的事件数据。
        /// 此参数通常用于配置页。</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Button btn = new Button();
            btn.Content = "巴松2号";//文本内容
            btn.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Right;//水平对齐方式
            btn.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center;//垂直对齐方式
            btn.Margin = new Thickness(0, 0, 10, 0);//margin
            btn.Click += btn_Click;//注册一个单击事件

            //把button添加到grid里面
            var grid = this.Content as Grid;
            if (grid != null)
            {
                grid.Children.Add(btn);
            }

        }

        /// <summary>
        /// 单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.Content += "@";
            }
        }
        
    }
}
