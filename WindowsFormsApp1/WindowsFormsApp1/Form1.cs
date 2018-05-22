using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        GMap.NET.WindowsForms.GMapOverlay markersOverlay = new GMap.NET.WindowsForms.GMapOverlay("marker");
        public Form1()
        {
            InitializeComponent();

        }

        public ComboBox.ObjectCollection LoadMarkerList(GMap.NET.WindowsForms.GMapControl gmap, ComboBox list)
        {
            list.Items.Clear();
            ComboBox.ObjectCollection a = new ComboBox.ObjectCollection(list);
            if (gmap.Overlays.Count > 0)
                foreach (GMap.NET.WindowsForms.GMapMarker m in gmap.Overlays[0].Markers)
                {
                    a.Add((object)m.ToolTipText);
                }

            return a;
        }
        // Database connection
        public bool Dbconnect()
        {
            String DbServer = "127.0.0.1";
            String UserName = "postgres";
            String UserPass = "130017";
            String DbName = "postgres";
            
            NpgsqlConnection conn = new Npgsql.NpgsqlConnection("Server=" + DbServer + ";User Id=" + UserName + ";Password=" + UserPass + ";Database=" + DbName + ";Encoding=UNICODE;");
        
          //  string sql = "текст запроса к базе данных";
            
          //  NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
            conn.Open(); //Открываем соединение.
         //   result = comm.ExecuteScalar().ToString(); //Выполняем нашу команду.
         //   conn.Close(); //Закрываем соединение.


            return true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login LoginForm = new Login();

            LoginForm.ShowDialog();
            if (LoginForm.DialogResult == DialogResult.OK)
            {


                //Настройки для компонента GMap.
                gMapControl1.Bearing = 0;

                //CanDragMap - Если параметр установлен в True,
                //пользователь может перетаскивать карту 
                ///с помощью правой кнопки мыши. 
                gMapControl1.CanDragMap = true;
                // Disable message on center
                gMapControl1.ShowCenter = false;


                //Указываем, что перетаскивание карты осуществляется с использованием левой клавишей мыши.
                //По умолчанию - правая.
                gMapControl1.DragButton = MouseButtons.Left;

                gMapControl1.GrayScaleMode = true;

                //MarkersEnabled - Если параметр установлен в True,
                //любые маркеры, заданные вручную будет показаны.
                //Если нет, они не появятся.
                gMapControl1.MarkersEnabled = true;

                //Указываем значение максимального приближения.
                gMapControl1.MaxZoom = 18;

                //Указываем значение минимального приближения.
                gMapControl1.MinZoom = 2;

                //Устанавливаем центр приближения/удаления
                //курсор мыши.
                gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

                //Отказываемся от негативного режима.
                gMapControl1.NegativeMode = false;

                //Разрешаем полигоны.
                gMapControl1.PolygonsEnabled = true;

                //Разрешаем маршруты
                gMapControl1.RoutesEnabled = true;

                //Скрываем внешнюю сетку карты с заголовками.
                gMapControl1.ShowTileGridLines = false;

                //Указываем, что при загрузке карты будет использоваться 
                //18ти кратное приближение.
                gMapControl1.Zoom =8;

                //Указываем что все края элемента управления
                //закрепляются у краев содержащего его элемента
                //управления(главной формы), а их размеры изменяются 
                //соответствующим образом.
                gMapControl1.Dock = DockStyle.Fill;

                //Указываем что будем использовать карты Google.
                gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
                gMapControl1.SetPositionByKeywords("Ukraine");

                //Если вы используете интернет через прокси сервер,
                //указываем свои учетные данные.
                //GMap.NET.MapProviders.GMapProvider.WebProxy =
                //    System.Net.WebRequest.GetSystemWebProxy();
                //GMap.NET.MapProviders.GMapProvider.WebProxy.Credentials =
                //    System.Net.CredentialCache.DefaultCredentials;
            }
            else
                this.Close();
        }
        // Добавление нового узла на карту
        private bool AddPoint(double x, double y, string name)
        {
            try
            {
                Bitmap image1 = new Bitmap(@"d:\222222.bmp", true);

              //  GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(x, y),  GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green);
                GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(x, y),image1);

                marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
                //Текст отображаемый при наведении на маркер
                //marker.ToolTipText = name;
                marker.ToolTipText = x.ToString()+"||"+y.ToString();
                
                //Добавляем в компонент, список маркеров 
                gMapControl1.Overlays.Add(markersOverlay);
                //Добавляем маркер в список маркеров
                markersOverlay.Markers.Add(marker);
                return true;
            }
            catch
            {
                MessageBox.Show("Виникла помилка");
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Создаем новый список маркеров, с указанием компонента 
            //в котором они будут использоваться и названием списка
         //   GMap.NET.WindowsForms.GMapOverlay markersOverlay = new GMap.NET.WindowsForms.GMapOverlay("marker");
            
           //Инициализация нового ЗЕЛЕНОГО маркера, с указанием его координат
           GMap.NET.WindowsForms.Markers.GMarkerGoogle marker =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(49.994507, 36.1457408),GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green );
            marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);

            //Текст отображаемый при наведении на маркер
            marker.ToolTipText = "Харьков";
            //Добавляем маркер в список маркеров
            markersOverlay.Markers.Add(marker);
            //Добавляем в компонент, список маркеров 
            gMapControl1.Overlays.Add(markersOverlay);

            GMap.NET.WindowsForms.Markers.GMarkerGoogle marker1 =
               new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(50.401699, 30.2525072), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green);
            marker1.ToolTip =
                new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker1);

            //Текст отображаемый при наведении на маркер
            marker1.ToolTipText = "Киев";
           
            //Добавляем маркер в список маркеров
            markersOverlay.Markers.Add(marker1);
            //markersOverlay.Markers.Remove(marker1); удаление маркера
            //Добавляем в компонент, список маркеров 
            //List<GMap.NET.PointLatLng> routePath = List<GMap.NET.PointLatLng>;
            //routePath.Add(new PointLatLng(Lat1, Lon1));

            //GMap.NET.WindowsForms.GMapRoute gMapRoute = new GMap.NET.WindowsForms.GMapRoute("12");
            //gMapRoute.Points.Add(new GMap.NET.PointLatLng(50.401699, 30.2525072));
            //gMapRoute.Points.Add(new GMap.NET.PointLatLng(49.994507, 36.1457408));


            GMap.NET.WindowsForms.GMapOverlay polygons = new GMap.NET.WindowsForms.GMapOverlay("polygons");
            List<GMap.NET.PointLatLng> points = new List<GMap.NET.PointLatLng>();
            points.Add(new GMap.NET.PointLatLng(50.401699, 30.2525072));
            points.Add(new GMap.NET.PointLatLng(49.994507, 36.1457408));
                        GMap.NET.WindowsForms.GMapPolygon polygon = new GMap.NET.WindowsForms.GMapPolygon(points, "Jardin des Tuileries");
            polygon.Stroke = new Pen(Color.Red, 2);
            
            polygons.Polygons.Add(polygon);
                      
//gMapControl1.Overlays.Add(markersOverlay);
          gMapControl1.Overlays.Add(polygons);
            gMapControl1.ReloadMap();
            
        

            //GMap.NET.MapRoute route = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(start, end, false, false, 15);
            //GMap.NET.MapRoute r = new GMap.NET.MapRoute(route.Points, "My route");
            //GMap.NET.WindowsForms.GMapOverlay router = new GMap.NET.WindowsForms.GMapOverlay("ssssss");
            //router.Routes.Add(route);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool a = Dbconnect();
            gMapControl1.Manager.ExportToGMDB("d:\\Uk.map");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gMapControl1.Manager.ImportFromGMDB("d:\\Uk.map");
        }

        private void gMapControl1_OnPolygonClick(GMap.NET.WindowsForms.GMapPolygon item, MouseEventArgs e)
        {
          
        }

        private void gMapControl1_OnMarkerClick(GMap.NET.WindowsForms.GMapMarker item, MouseEventArgs e)
        {

            if (gMapControl1.Overlays.Count > 0)
                foreach (GMap.NET.WindowsForms.GMapMarker m in gMapControl1.Overlays[0].Markers)
                {
                    if (item.ToolTipText == m.ToolTipText) MessageBox.Show(gMapControl1.Overlays[0].Markers.IndexOf(m).ToString());
                }
            //.GMarkerGoogle marker1 = item.Overlay.Markers[]
            //item.Overlay.Markers.Remove(  
            //
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
           // Show form for adding Unit
            
            UnitM add = new UnitM
            {
                Text = (sender as ToolStripMenuItem).Text
            };
            
             add.ShowDialog();
            if  (add.DialogResult == DialogResult.OK)
            {
                AddPoint(UnitInfo.LocationX, UnitInfo.LocationY, UnitInfo.Name);
            }
            
            comboBox1.Items.Clear();
            comboBox1.Items.Add(LoadMarkerList(gMapControl1, comboBox1));
        }

        private void GMapControl1_Click(object sender, MouseEventArgs e)
        {
            //double X = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            //double Y = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
        }

        private void gMapControl1_MouseDown(object sender, MouseEventArgs e)
        {
            // определение координат по мышке для работы с узлами на карте   
            UnitInfo.LocationX = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            UnitInfo.LocationY = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
           
        }

        private void видалитиВузолToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            
            
            
            //foreach (GMap.NET.WindowsForms.GMapMarker m in gMapControl1.Overlays[0].Markers)
            //{
            //    if (item.ToolTipText == m.ToolTipText) MessageBox.Show(gMapControl1.Overlays[0].Markers.IndexOf(m).ToString());
            //}
        }

        private void gMapControl1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text ="X: "+ gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat.ToString();
            label2.Text ="Y: " + gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng.ToString();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Load tablenames from db
            string a1 = "127.0.0.1";
            string a2 = "postgres";
            string a3 = "130017";
            string a4 = "monik";
            NpgsqlConnection conn = new Npgsql.NpgsqlConnection("Server=" + a1 + ";User Id=" + a2 + ";Password=" + a3 + ";Database=" + a4 + ";Encoding=UNICODE;");
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT TABLE_NAME FROM information_schema.TABLES where table_schema='public'", conn);

            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               comboBox2.Items.Add(reader.GetString(0));
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Load tablenames from db
            string a1 = "127.0.0.1";
            string a2 = "postgres";
            string a3 = "130017";
            string a4 = "monik";
            NpgsqlConnection conn = new Npgsql.NpgsqlConnection("Server=" + a1 + ";User Id=" + a2 + ";Password=" + a3 + ";Database=" + a4 + ";Encoding=UNICODE;");
            conn.Open();
            string f = comboBox2.Items[comboBox2.SelectedIndex].ToString();
            //NpgsqlCommand command = new NpgsqlCommand("select * from brunch order by id_brunch", conn);

            //NpgsqlDataReader reader = command.ExecuteReader();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from "+f, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            conn.Close();

            

        }
    }
}
