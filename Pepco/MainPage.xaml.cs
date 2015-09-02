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
using Pepco;
using Windows.UI.Popups;
using Windows.ApplicationModel.DataTransfer;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Pepco
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string Test = "a";
        int Total = 0;
        string GL1 = "0", GL2 = "0", GL3 = "0", GL4 = "0", GL5 = "0", GL6 = "0", GL7 = "0";
        string GL11 = "0", GL22 = "0", GL33 = "0", GL44 = "0", GL55 = "0", GL66 = "0", GL77 = "0";
        TextBox GL111, GL222, GL333, GL444, GL555, GL666, GL777;

        string HA1 = "0", HA2 = "0", HA3 = "0", HA4 = "0";
        string HA11 = "0", HA22 = "0", HA33 = "0", HA44 = "0";
        TextBox HA111, HA222, HA333, HA444;

        string CA1 = "0", CA2 = "0", CA3 = "0", CA4 = "0", CA5 = "0", CA6 = "0", CA7 = "0";
        string CA11 = "0", CA22 = "0", CA33 = "0", CA44 = "0", CA55 = "0", CA66 = "0", CA77 = "0";
        TextBox CA111, CA222, CA333, CA444, CA555, CA666, CA777;

        string OI1 = "0", OI2 = "0", OI3 = "0", OI4 = "0", OI5 = "0", OI6 = "0", OI7 = "0", OI8 = "0";
        string OI11 = "0", OI22 = "0", OI33 = "0", OI44 = "0", OI55 = "0", OI66 = "0", OI77 = "0", OI88 = "0";
        TextBox OI111, OI222, OI333, OI444, OI555, OI666, OI777, OI888;
        public MainPage()
        {
            
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            DataTransferManager dtm = DataTransferManager.GetForCurrentView();
            dtm.DataRequested += dtm_DataRequested;
        }

        void dtm_DataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            args.Request.Data.Properties.Title = "Pepco";
            args.Request.Data.SetHtmlFormat(HtmlFormatHelper.CreateHtmlFormat("Hey there! This is an interesting app, get it from Windows Store!"));
            args.Request.Data.SetText("Indeed awesome game");
            DataRequestDeferral d = args.Request.GetDeferral();
            args.Request.Data.SetUri(new Uri("http://windows.microsoft.com/en-US/windows-8/apps"));
            d.Complete();
        }

        private void GL1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            GL1 = Txt.Text;
            double a, b, a1;
            double c = 1.2;
            double.TryParse(GL1, out a);
            double.TryParse(GL11, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            GL111.Text = a1.ToString();
            int f = 0;
            int.TryParse(GL111.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void GL11_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            GL11 = Txt.Text;
            double a, b, a1;
            double c = 1.2;
            double.TryParse(GL1, out a);
            double.TryParse(GL11, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            GL111.Text = a1.ToString();
            int f = 0;
            int.TryParse(GL111.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }


        private void GL111_Loaded(object sender, RoutedEventArgs e)
        {
            GL111 = (TextBox)sender;
        }

        private void GL2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            GL2 = Txt.Text;
            double a, b, a1;
            double c = 1.8;
            double.TryParse(GL2, out a);
            double.TryParse(GL22, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            GL222.Text = a1.ToString();
            int f = 0;
            int.TryParse(GL222.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void GL22_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            GL22 = Txt.Text;
            double a, b, a1;
            double c = 1.8;
            double.TryParse(GL2, out a);
            double.TryParse(GL22, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            GL222.Text = a1.ToString();
            int f = 0;
            int.TryParse(GL222.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void GL222_Loaded(object sender, RoutedEventArgs e)
        {
            GL222 = (TextBox)sender;
        }

        private void GL3_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            GL3 = Txt.Text;
            double a, b, a1;
            double c = 1.2;
            double.TryParse(GL3, out a);
            double.TryParse(GL33, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            GL333.Text = a1.ToString();

            int f = 0;
            int.TryParse(GL333.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void GL33_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            GL33 = Txt.Text;
            double a, b, a1;
            double c = 3;
            double.TryParse(GL3, out a);
            double.TryParse(GL33, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            GL333.Text = a1.ToString();

            int f = 0;
            int.TryParse(GL333.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void GL333_Loaded(object sender, RoutedEventArgs e)
        {
            GL333 = (TextBox)sender;
        }

        private void GL4_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            GL4 = Txt.Text;
            double a, b, a1;
            double c = 0.4;
            double.TryParse(GL4, out a);
            double.TryParse(GL44, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            GL444.Text = a1.ToString();
            int f = 0;
            int.TryParse(GL444.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void GL44_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            GL44 = Txt.Text;
            double a, b, a1;
            double c = 0.4;
            double.TryParse(GL4, out a);
            double.TryParse(GL44, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            GL444.Text = a1.ToString();
            int f = 0;
            int.TryParse(GL444.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void GL444_Loaded(object sender, RoutedEventArgs e)
        {
            GL444 = (TextBox)sender;
        }

        private void GL5_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            GL5 = Txt.Text;
            double a, b, a1;
            double c = 0.66;
            double.TryParse(GL5, out a);
            double.TryParse(GL55, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            GL555.Text = a1.ToString();
            int f = 0;
            int.TryParse(GL555.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void GL55_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            GL55 = Txt.Text;
            double a, b, a1;
            double c = 0.66;
            double.TryParse(GL5, out a);
            double.TryParse(GL55, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            GL555.Text = a1.ToString();
            int f = 0;
            int.TryParse(GL555.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void GL555_Loaded(object sender, RoutedEventArgs e)
        {
            GL555 = (TextBox)sender;
        }

        private void GL6_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            GL6 = Txt.Text;
            double a, b, a1;
            double c = 1.196;
            double.TryParse(GL6, out a);
            double.TryParse(GL66, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            GL666.Text = a1.ToString();
            int f = 0;
            int.TryParse(GL666.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void GL66_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            GL66 = Txt.Text;
            double a, b, a1;
            double c = 1.196;
            double.TryParse(GL6, out a);
            double.TryParse(GL66, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            GL666.Text = a1.ToString();
            int f = 0;
            int.TryParse(GL666.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void GL666_Loaded(object sender, RoutedEventArgs e)
        {
            GL666 = (TextBox)sender;
        }

        private void GL7_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            GL7 = Txt.Text;
            double a, b, a1;
            double c = 1.6;
            double.TryParse(GL7, out a);
            double.TryParse(GL77, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            GL777.Text = a1.ToString();
            int f = 0;
            int.TryParse(GL777.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void GL77_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            GL77 = Txt.Text;
            double a, b, a1;
            double c = 1.6;
            double.TryParse(GL7, out a);
            double.TryParse(GL77, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            GL777.Text = a1.ToString();
            int f = 0;
            int.TryParse(GL777.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void GL777_Loaded(object sender, RoutedEventArgs e)
        {
            GL777 = (TextBox)sender;
        }

        private void HA1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            HA1 = Txt.Text;
            double a, b, a1;
            double c = 30;
            double.TryParse(HA1, out a);
            double.TryParse(HA11, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            HA111.Text = a1.ToString();
            int f = 0;
            int.TryParse(HA111.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void HA11_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            HA11 = Txt.Text;
            double a, b, a1;
            double c = 30;
            double.TryParse(HA1, out a);
            double.TryParse(HA11, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            HA111.Text = a1.ToString();
            int f = 0;
            int.TryParse(HA111.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void HA111_Loaded(object sender, RoutedEventArgs e)
        {
            HA111 = (TextBox)sender;
        }

        private void HA2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            HA2 = Txt.Text;
            double a, b, a1;
            double c = 45;
            double.TryParse(HA2, out a);
            double.TryParse(HA22, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            HA222.Text = a1.ToString();
            int f = 0;
            int.TryParse(HA222.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void HA22_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            HA22 = Txt.Text;
            double a, b, a1;
            double c = 45;
            double.TryParse(HA2, out a);
            double.TryParse(HA22, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            HA222.Text = a1.ToString();
            int f = 0;
            int.TryParse(HA222.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void HA222_Loaded(object sender, RoutedEventArgs e)
        {
            HA222 = (TextBox)sender;
        }

        private void HA3_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            HA3 = Txt.Text;
            double a, b, a1;
            double c = 60;
            double.TryParse(HA3, out a);
            double.TryParse(HA33, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            HA333.Text = a1.ToString();
            int f = 0;
            int.TryParse(HA333.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void HA33_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            HA33 = Txt.Text;
            double a, b, a1;
            double c = 60;
            double.TryParse(HA3, out a);
            double.TryParse(HA33, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            HA333.Text = a1.ToString();
            int f = 0;
            int.TryParse(HA333.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void HA333_Loaded(object sender, RoutedEventArgs e)
        {
            HA333 = (TextBox)sender;
        }

        private void HA4_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            HA4 = Txt.Text;
            double a, b, a1;
            double c = 22.5;
            double.TryParse(HA4, out a);
            double.TryParse(HA44, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            HA444.Text = a1.ToString();
            int f = 0;
            int.TryParse(HA444.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void HA44_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            HA44 = Txt.Text;
            double a, b, a1;
            double c = 22.5;
            double.TryParse(HA4, out a);
            double.TryParse(HA44, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            HA444.Text = a1.ToString();
            int f = 0;
            int.TryParse(HA444.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void HA444_Loaded(object sender, RoutedEventArgs e)
        {
            HA444 = (TextBox)sender;
        }

        private void CA1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            CA1 = Txt.Text;
            double a, b, a1;
            double c = 6;
            double.TryParse(CA1, out a);
            double.TryParse(CA11, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            CA111.Text = a1.ToString();
            int f = 0;
            int.TryParse(CA111.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void CA11_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            CA11 = Txt.Text;
            double a, b, a1;
            double c = 6;
            double.TryParse(CA1, out a);
            double.TryParse(CA11, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            CA111.Text = a1.ToString();
            int f = 0;
            int.TryParse(CA111.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void CA111_Loaded(object sender, RoutedEventArgs e)
        {
            CA111 = (TextBox)sender;
        }

        private void CA2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            CA2 = Txt.Text;
            double a, b, a1;
            double c = 60;
            double.TryParse(CA2, out a);
            double.TryParse(CA22, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            CA222.Text = a1.ToString();
            int f = 0;
            int.TryParse(CA222.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void CA22_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            CA22 = Txt.Text;
            double a, b, a1;
            double c = 60;
            double.TryParse(CA2, out a);
            double.TryParse(CA22, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            CA222.Text = a1.ToString();
            int f = 0;
            int.TryParse(CA222.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void CA222_Loaded(object sender, RoutedEventArgs e)
        {
            CA222 = (TextBox)sender;
        }

        private void CA3_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            CA3 = Txt.Text;
            double a, b, a1;
            double c = 50;
            double.TryParse(CA3, out a);
            double.TryParse(CA33, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            CA333.Text = a1.ToString();
            int f = 0;
            int.TryParse(CA333.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void CA33_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            CA33 = Txt.Text;
            double a, b, a1;
            double c = 50;
            double.TryParse(CA3, out a);
            double.TryParse(CA33, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            CA333.Text = a1.ToString();
            int f = 0;
            int.TryParse(CA333.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void CA333_Loaded(object sender, RoutedEventArgs e)
        {
            CA333 = (TextBox)sender;
        }

        private void CA4_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            CA4 = Txt.Text;
            double a, b, a1;
            double c = 6;
            double.TryParse(CA4, out a);
            double.TryParse(CA44, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            CA444.Text = a1.ToString();
            int f = 0;
            int.TryParse(CA444.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void CA44_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            CA44 = Txt.Text;
            double a, b, a1;
            double c = 6;
            double.TryParse(CA4, out a);
            double.TryParse(CA44, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            CA444.Text = a1.ToString();
            int f = 0;
            int.TryParse(CA444.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void CA444_Loaded(object sender, RoutedEventArgs e)
        {
            CA444 = (TextBox)sender;
        }

        private void CA5_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            CA5 = Txt.Text;
            double a, b, a1;
            double c = 3;
            double.TryParse(CA5, out a);
            double.TryParse(CA55, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            CA555.Text = a1.ToString();
            int f = 0;
            int.TryParse(CA555.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void CA55_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            CA55 = Txt.Text;
            double a, b, a1;
            double c = 3;
            double.TryParse(CA5, out a);
            double.TryParse(CA55, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            CA555.Text = a1.ToString();
            int f = 0;
            int.TryParse(CA555.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void CA555_Loaded(object sender, RoutedEventArgs e)
        {
            CA555 = (TextBox)sender;
        }

        private void CA6_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            CA6 = Txt.Text;
            double a, b, a1;
            double c = 2.3928;
            double.TryParse(CA6, out a);
            double.TryParse(CA66, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            CA666.Text = a1.ToString();
            int f = 0;
            int.TryParse(CA666.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void CA66_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            CA66 = Txt.Text;
            double a, b, a1;
            double c = 2.3928;
            double.TryParse(CA6, out a);
            double.TryParse(CA66, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            CA666.Text = a1.ToString();
            int f = 0;
            int.TryParse(CA666.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void CA666_Loaded(object sender, RoutedEventArgs e)
        {
            CA666 = (TextBox)sender;
        }

        private void CA7_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            CA7 = Txt.Text;
            double a, b, a1;
            double c = 4.5;
            double.TryParse(CA7, out a);
            double.TryParse(CA77, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            CA777.Text = a1.ToString();
            int f = 0;
            int.TryParse(CA777.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void CA77_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            CA77 = Txt.Text;
            double a, b, a1;
            double c = 4.5;
            double.TryParse(CA7, out a);
            double.TryParse(CA77, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            CA777.Text = a1.ToString();
            int f = 0;
            int.TryParse(CA777.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void CA777_Loaded(object sender, RoutedEventArgs e)
        {
            CA777 = (TextBox)sender;
        }

        private void OI1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI1 = Txt.Text;
            double a, b, a1;
            double c = 21.0;
            double.TryParse(OI1, out a);
            double.TryParse(OI11, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI111.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI111.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void OI11_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI11 = Txt.Text;
            double a, b, a1;
            double c = 21;
            double.TryParse(OI1, out a);
            double.TryParse(OI11, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI111.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI111.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }


        private void OI2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI2 = Txt.Text;
            double a, b, a1;
            double c = 1.1964;
            double.TryParse(OI2, out a);
            double.TryParse(OI22, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI222.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI222.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void OI22_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI22 = Txt.Text;
            double a, b, a1;
            double c = 1.1964;
            double.TryParse(OI2, out a);
            double.TryParse(OI22, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI222.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI222.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void OI222_Loaded(object sender, RoutedEventArgs e)
        {
            OI222 = (TextBox)sender;
        }

        private void OI3_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI3 = Txt.Text;
            double a, b, a1;
            double c = 6;
            double.TryParse(OI3, out a);
            double.TryParse(OI33, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI333.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI333.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void OI33_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI33 = Txt.Text;
            double a, b, a1;
            double c = 6;
            double.TryParse(OI3, out a);
            double.TryParse(OI33, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI333.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI333.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void OI333_Loaded(object sender, RoutedEventArgs e)
        {
            OI333 = (TextBox)sender;
        }

        private void OI4_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI4 = Txt.Text;
            double a, b, a1;
            double c = 6;
            double.TryParse(OI4, out a);
            double.TryParse(OI44, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI444.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI444.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void OI44_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI44 = Txt.Text;
            double a, b, a1;
            double c = 6;
            double.TryParse(OI4, out a);
            double.TryParse(OI44, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI444.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI444.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void OI444_Loaded(object sender, RoutedEventArgs e)
        {
            OI444 = (TextBox)sender;
        }

        private void OI5_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI5 = Txt.Text;
            double a, b, a1;
            double c = 6;
            double.TryParse(OI5, out a);
            double.TryParse(OI55, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI555.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI555.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void OI55_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI55 = Txt.Text;
            double a, b, a1;
            double c = 6;
            double.TryParse(OI5, out a);
            double.TryParse(OI55, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI555.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI555.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void OI555_Loaded(object sender, RoutedEventArgs e)
        {
            OI555 = (TextBox)sender;
        }

        private void OI6_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI6 = Txt.Text;
            double a, b, a1;
            double c = 11;
            double.TryParse(OI6, out a);
            double.TryParse(OI66, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI666.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI666.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void OI66_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI66 = Txt.Text;
            double a, b, a1;
            double c = 11;
            double.TryParse(OI6, out a);
            double.TryParse(OI66, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI666.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI666.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void OI666_Loaded(object sender, RoutedEventArgs e)
        {
            OI666 = (TextBox)sender;
        }

        private void OI7_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI7 = Txt.Text;
            double a, b, a1;
            double c = 22;
            double.TryParse(OI7, out a);
            double.TryParse(OI77, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI777.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI777.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void OI77_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI77 = Txt.Text;
            double a, b, a1;
            double c = 22;
            double.TryParse(OI7, out a);
            double.TryParse(OI77, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI777.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI777.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void OI777_Loaded(object sender, RoutedEventArgs e)
        {
            OI777 = (TextBox)sender;
        }

        private void OI8_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI8 = Txt.Text;
            double a, b, a1;
            double c = 33;
            double.TryParse(OI8, out a);
            double.TryParse(OI88, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI888.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI888.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void OI88_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Txt = (TextBox)sender;
            OI88 = Txt.Text;
            double a, b, a1;
            double c = 33;
            double.TryParse(OI8, out a);
            double.TryParse(OI88, out b);
            a1 = a * b * c;
            a1 = Math.Round(a1, MidpointRounding.AwayFromZero);
            OI888.Text = a1.ToString();
            int f = 0;
            int.TryParse(OI888.Text, out f);
            Total += f;
            total.Text = Total.ToString();
        }

        private void OI888_Loaded(object sender, RoutedEventArgs e)
        {
            OI888 = (TextBox)sender;
        }

        private void OI111_Loaded(object sender, RoutedEventArgs e)
        {
            OI111 = (TextBox)sender;
        }

        public bool _hasDecimal { get; set; }

        private void GL1_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = GL1;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void HandleKey(KeyRoutedEventArgs e)
        {
            if (Test.Contains(".") != true)
            {
                _hasDecimal = false;
            }
            
            switch (e.Key)
            {
                // allow digits
                // TODO: keypad numeric digits here
                case Windows.System.VirtualKey.Number0:
                case Windows.System.VirtualKey.Number1:
                case Windows.System.VirtualKey.Number2:
                case Windows.System.VirtualKey.Number3:
                case Windows.System.VirtualKey.Number4:
                case Windows.System.VirtualKey.Number5:
                case Windows.System.VirtualKey.Number6:
                case Windows.System.VirtualKey.Number7:
                case Windows.System.VirtualKey.Number8:
                case Windows.System.VirtualKey.Number9:
                    e.Handled = false;
                    break;

                // only allow one decimal
                // TODO: handle deletion of decimal...

                case (Windows.System.VirtualKey)190:    // decimal (next to comma)
                case Windows.System.VirtualKey.Decimal: // decimal on key pad
                    e.Handled = (_hasDecimal == true);
                    _hasDecimal = true;
                    break;

                // pass various control keys to base
                case Windows.System.VirtualKey.Up:
                case Windows.System.VirtualKey.Down:
                case Windows.System.VirtualKey.Left:
                case Windows.System.VirtualKey.Right:
                case Windows.System.VirtualKey.Delete:
                case Windows.System.VirtualKey.Back:
                case Windows.System.VirtualKey.Tab:
                    e.Handled = false;
                    break;

                default:
                    // default is to not pass key to base
                    e.Handled = true;
                    break;
            }


        }

        private void GL11_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = GL11;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void GL2_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = GL2;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void GL22_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = GL22;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void GL3_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = GL3;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void GL33_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = GL33;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void GL4_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = GL4;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void GL44_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = GL44;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void GL5_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = GL5;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void GL55_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = GL55;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void GL6_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = GL6;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void GL66_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = GL66;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void GL7_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = GL7;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void GL77_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = GL77;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void HA1_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = HA1;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void HA11_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = HA11;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void HA2_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = HA2;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void HA22_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = HA22;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void HA3_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = HA3;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void HA33_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = HA33;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void HA4_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = HA4;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void HA44_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = HA44;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void CA1_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = CA1;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void CA11_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = CA11;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void CA2_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = CA2;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void CA22_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = CA22;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void CA3_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = CA33;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void CA33_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = CA33;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void CA4_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = CA4;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void CA44_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = CA44;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void CA5_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = CA5;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void CA55_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = CA55;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void CA6_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = CA6;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void CA66_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = CA66;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void CA7_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = CA7;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void CA77_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = CA77;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI1_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI1;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI11_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI11;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI2_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI2;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI22_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI22;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI3_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI3;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI33_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI33;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI4_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI4;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI44_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI44;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI5_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI5;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI55_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI55;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI6_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI6;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI66_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI66;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI7_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI7;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI77_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI77;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI8_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI8;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

        private void OI88_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Test = OI88;
            HandleKey(e);

            if (!e.Handled)
                base.OnKeyDown(e);
        }

      

    }
}
