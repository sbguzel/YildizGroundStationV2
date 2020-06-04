using System;
using System.Drawing;
using System.Windows.Forms;
using LiveCharts;
using System.Windows.Media;
using LiveCharts.Wpf;
using LiveCharts.Configurations;
using Point = System.Windows.Point;
using System.Device.Location;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security.Permissions;
using AForge.Video.DirectShow;
using AForge.Video;
// Teyhan
// burak

//burak2

//teyhan 2

namespace YildizGroundStation
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisible(true)]

    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        VideoCaptureDevice frame;
        FilterInfoCollection Devices;
        string output;

        public static string[] LatLng = new string[2];
        public HtmlElement LatLngClick;
        public HtmlElement LatLngSend;
        public HtmlElement latitude;
        public HtmlElement longitude;
        public HtmlElement accuracy;
        public HtmlElement altitude;

        double minY = 0;
        double maxY = 1000;
        int x = 0;
        int current_value = 0;

        public class MeasureModel
        {
            public System.DateTime DateTime { get; set; }
            public double Value { get; set; }
        }

        public ChartValues<MeasureModel> ChartValues { get; set; }
        public Timer Timer { get; set; }
        private void SetAxisLimits(System.DateTime now)
        {
            //cartesianChart1.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart1.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(10).Ticks; //we only care about the last 8 seconds
        }

        public Form1()
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager1;

            var gradientBrush = new LinearGradientBrush
            {
                StartPoint = new System.Windows.Point(0, 0),
                EndPoint = new Point(0, 1)
            };
            gradientBrush.GradientStops.Add(new GradientStop(System.Windows.Media.Color.FromRgb(33, 148, 241), 0));
            gradientBrush.GradientStops.Add(new GradientStop(Colors.Transparent, 1));

            var mapper = Mappers.Xy<MeasureModel>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<MeasureModel>(mapper);

            //the ChartValues property will store our values array
            ChartValues = new ChartValues<MeasureModel>();

            cartesianChart1.Series.Add(new LineSeries
            {
                Values = ChartValues,

                Fill = gradientBrush,
                StrokeThickness = 1,
                PointGeometry = null
            });

            //cartesianChart1.Zoom = ZoomingOptions.X;
            cartesianChart1.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 40, 50));
            //cartesianChart1.Hoverable = false;
            cartesianChart1.AxisX.Add(new Axis
            {
                //IsMerged = true,
                //LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                LabelFormatter = value => "",

                Separator = new Separator
                {
                    //StrokeThickness = 1.5,
                    //StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 4 }),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86)),
                    Step = TimeSpan.FromMilliseconds(1000).Ticks
                }

            });

            SetAxisLimits(System.DateTime.Now);

            cartesianChart1.AxisY.Add(new Axis
            {

                FontSize = 15,
                MinValue = minY,
                MaxValue = maxY,
                LabelFormatter = val => val + " cm",
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 1.5,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 4 }),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });

            cartesianChart1.DisableAnimations = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("YildizGroundStation.Resources.Map.Maps.htm"));
            webBrowser1.DocumentText = reader.ReadToEnd();
            webBrowser1.AllowWebBrowserDrop = true;
            webBrowser1.IsWebBrowserContextMenuEnabled = true;
            webBrowser1.WebBrowserShortcutsEnabled = true;
            webBrowser1.ObjectForScripting = this;
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            watcher.MovementThreshold = 0.1;
            watcher.PositionChanged += GeoLocationChanged;
            watcher.Start();
            // Uncomment the following line when you are finished debugging.
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void GeoLocationChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            latitude = SubmitForm("com_lat");
            longitude = SubmitForm("com_lng");
            altitude = SubmitForm("com_alt");
            accuracy = SubmitForm("com_acc");

            latitude.SetAttribute("value", e.Position.Location.Latitude.ToString("0.00000000", CultureInfo.InvariantCulture));
            longitude.SetAttribute("value", e.Position.Location.Longitude.ToString("0.00000000", CultureInfo.InvariantCulture));
            altitude.SetAttribute("value", e.Position.Location.Altitude.ToString("0.00", CultureInfo.InvariantCulture));
            accuracy.SetAttribute("value", e.Position.Location.HorizontalAccuracy.ToString());
            webBrowser1.Document.InvokeScript("onLocationFound");
        }
     
        public void GetCoordinates()
        {

            LatLngClick = SubmitForm("LatLngClick");

            LatLng = LatLngClick.GetAttribute("value").Remove(0, 7).Split(',');
            LatLng[1] = LatLng[1].Remove(LatLng[1].Length - 1, 1).Trim();
            //textBoxLat.Text = LatLng[0];
            //textBoxLng.Text = LatLng[1];
        }
        private HtmlElement SubmitForm(String formName)
        {
            HtmlElementCollection elems = null;
            HtmlElement elem = null;

            if (webBrowser1.Document != null)
            {
                HtmlDocument doc = webBrowser1.Document;
                elems = doc.All.GetElementsByName(formName);
                if (elems != null && elems.Count > 0)
                    elem = elems[0];

            }
            return elem;
        }

        private void webBrowser1_ProgressChanged_1(object sender, WebBrowserProgressChangedEventArgs e)
        {
            LatLngClick = SubmitForm("LatLngClick");
            if (LatLngClick != null)
                // button2.Enabled = true;
                LatLng = LatLngClick.GetAttribute("value").Remove(0, 7).Split(',');
            LatLng[1] = LatLng[1].Remove(LatLng[1].Length - 1, 1).Trim();
        }

        private void timer_livechart_Tick(object sender, EventArgs e)
        {
            current_value += 1;
            if (current_value > 200) current_value = 0;
            //solidGauge1.Value = current_value;

            x += 1;
            var now = System.DateTime.Now;

            ChartValues.Add(new MeasureModel
            {
                DateTime = now,
                Value = metroScrollBar1.Value + Math.Cos(current_value * 0.0174533) + Math.Cos(current_value * 0.0174533) + 2 * Math.Sin(current_value * 0.0174533 * 8) + 10//+ current_value

            }); ;

            SetAxisLimits(now);

            //lets only use the last 30 values

            if (ChartValues.Count > 205) ChartValues.RemoveAt(0);
        }
        void Start_cam()
        {
            Devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            frame = new VideoCaptureDevice(Devices[0].MonikerString);
            frame.NewFrame += new AForge.Video.NewFrameEventHandler(NewFrame_event);
            frame.Start();
        }
        void NewFrame_event(object send, NewFrameEventArgs e)
        {
            try
            {
                pictureBox1.Image = (Image)e.Frame.Clone();
            }
            catch (Exception ex) { }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Start_cam();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            //textBox1.Text = folderBrowserDialog1.SelectedPath;
            output = folderBrowserDialog1.SelectedPath;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (output != "" && pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(output + "\\Image.png");
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            frame.Stop();
            pictureBox1.Image = null;
        }

        private void heading_Scroll(object sender, ScrollEventArgs e)
        {
            headingIndicatorInstrumentControl1.SetHeadingIndicatorParameters(heading.Value);
        }

        private void trackPitchAngle_Scroll(object sender, EventArgs e)
        {
            attitudeIndicatorInstrumentControl1.SetAttitudeIndicatorParameters(PitchAngle.Value, RollAngle.Value);
        }

        private void RollAngle_Scroll(object sender, EventArgs e)
        {
            attitudeIndicatorInstrumentControl1.SetAttitudeIndicatorParameters(PitchAngle.Value, RollAngle.Value);
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.White;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Brown;
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Pink;
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Magenta;
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
        }

        private void metroTile14_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow;
        }
    }
}
