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
using AdaptiveTriggers.Win10.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AdaptiveTriggers.Win10
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            GridViewItemViewer.ItemsSource = InitCatList();
        }
        #region init
        private List<CatModel> InitCatList()
        {
            var cats = new List<CatModel>();

            cats.Add(new CatModel() { Title = "Cat	1", ThumbnailUri = new Uri("https://i.ytimg.com/vi/tntOCGkgt98/maxresdefault.jpg") });
            cats.Add(new CatModel() { Title = "Cat	2", ThumbnailUri = new Uri("https://i.ytimg.com/vi/icqDxNab3Do/maxresdefault.jpg") });
            cats.Add(new CatModel() { Title = "Cat	3", ThumbnailUri = new Uri("http://londonbeep.com/wp-content/uploads/2015/03/cat-funny-3.jpg") });
            cats.Add(new CatModel() { Title = "Cat	4", ThumbnailUri = new Uri("http://beforeitsnews.com/contributor/upload/486248/images/11-10-12-caturday-funny-cat-photos3.jpg_pagespeed_ce__IIaUv8H4OOpSp5X-7Rkr.jpg") });
            cats.Add(new CatModel() { Title = "Cat	5", ThumbnailUri = new Uri("http://www.lolcats.com/images/u/07/32/lolcatsdotcomclu5vrpst727hzii.jpg") });
            cats.Add(new CatModel() { Title = "Cat	6", ThumbnailUri = new Uri("http://www.funnypica.com/wp-content/uploads/2014/08/Funny-Cats-1.jpg") });
            cats.Add(new CatModel() { Title = "Cat	7", ThumbnailUri = new Uri("http://petsfans.com/wp-content/uploads/2014/11/edfsaf.jpg") });
            cats.Add(new CatModel() { Title = "Cat	8", ThumbnailUri = new Uri("http://images1.fanpop.com/images/image_uploads/Funny-Cat-Pictures-cats-935656_500_375.jpg") });
            cats.Add(new CatModel() { Title = "Cat	9", ThumbnailUri = new Uri("https://i.ytimg.com/vi/QAgy9r331v0/hqdefault.jpg") });
            cats.Add(new CatModel() { Title = "Cat	1", ThumbnailUri = new Uri("http://www.bajiroo.com/wp-content/uploads/2014/06/funny-cats-bathroom-sinktt1.jpg") });
            cats.Add(new CatModel() { Title = "Cat	1", ThumbnailUri = new Uri("http://www.parkproductions.net/wp-content/uploads/2013/09/funny_cat_pictures_103_Funny_Cats-s400x300-52903-580.jpg") });
            cats.Add(new CatModel() { Title = "Cat	1", ThumbnailUri = new Uri("http://www.funny-animalpictures.com/media/content/items/images/funnycats0052_O.jpg") });




            return cats;
        }
        #endregion
    }
}
