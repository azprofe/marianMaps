/*
 * Creado por enoldor
 **/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using mapas.Clases;
using mapas.Formularios;
using Newtonsoft.Json;

namespace mapas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		GMapControl MainMap;
		GMapOverlay overlayColegios;
		GMapOverlay overlayRutas;
		IList<Jornada> jornadas;
		PointLatLng zgz;
		bool ubicacion = false;
		Preferencias pref;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			zgz = new PointLatLng(41.65, -0.883333);
			pref = new Preferencias();
			MainMap = new GMapControl();
			jornadas = new List<Jornada>();
			jornadas.Add(new Jornada(0,"Jornada Completa"));
			jornadas.Add(new Jornada(1,"1/2 jornada"));
			jornadas.Add(new Jornada(2,"1/3 jornada"));
			pref.DistMedia = 50;
			pref.DistLarga = 125;
			try
			{
				System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.es");
			}
			catch
			{
				MainMap.Manager.Mode = AccessMode.CacheOnly;
				MessageBox.Show("No hay conexión a Internet, mapas en modo Cache.");
			}
//			MainMap.MapProvider = GMapProviders.GoogleMap;
			MainMap.MapProvider = GMapProviders.BingMap;
			Resize += new EventHandler(MainForm_OnResize);
			MainMap.Parent = panelMap;
			MainMap.Width = panelMap.Width;
			MainMap.Height = panelMap.Height;
			MainMap.CanDragMap = true;
			MainMap.DragButton = MouseButtons.Left;
			MainMap.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
			MainMap.MinZoom = 3;
			MainMap.MaxZoom = 17;
			MainMap.CenterPen.Color = Color.Transparent;
			MainMap.Zoom = 10;
			MainMap.Manager.Mode = AccessMode.ServerAndCache;
			overlayColegios = new GMapOverlay("Colegios");
			overlayRutas = new GMapOverlay("Rutas");
			MainMap.OnMarkerClick += new MarkerClick(MainMap_OnMarkerClick);
			MainMap.ContextMenuStrip = MapaCMS;
			MainMap.Overlays.Add(overlayColegios);
			MainMap.Overlays.Add(overlayRutas);
			MainMap.MouseDoubleClick += PanelMapMouseDoubleClick;
			MainMap.OnMarkerEnter += MainMap_OnMarkerEnter;
			MainMap.Position = new PointLatLng(41.65, -0.883333);
			ResumeLayout(true);
		}

		void MainForm_OnResize(object sender, EventArgs e)
		{
			MainMap.Height = Height;
			MainMap.Width = Width;
		}
		void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
		{
			var other = item as Marcador;
			var frm = new ColegioForm(other.cole,jornadas);
			if (frm.ShowDialog()==DialogResult.Abort) {
				overlayRutas.Routes.Remove(other.cole.ruta);
				overlayColegios.Markers.Remove(other);
			}
		}

		void MainMap_OnMarkerEnter(GMapMarker item)
		{
			var other = item as Marcador;
			if (!string.IsNullOrEmpty(other.cole.nombre)) {
				other.ToolTipText = other.cole.nombre+" :: "+other.cole.posicion;
			}
			
		}

		void MapaTSClick(object sender, EventArgs e)
		{
			MainMap.MapProvider = GMapProviders.BingMap;
		}
		void HibridoTSClick(object sender, EventArgs e)
		{
			MainMap.MapProvider = GMapProviders.BingHybridMap;
		}
		void SateliteTSClick(object sender, EventArgs e)
		{
			MainMap.MapProvider = GMapProviders.BingSatelliteMap;
		}
		void PanelMapMouseDoubleClick(object sender, MouseEventArgs e)
		{
			try {
			var point =  MainMap.FromLocalToLatLng(e.X, e.Y);
			if (ubicacion) {
				zgz = point;
				MessageBox.Show("Ubicación inicial establecida con exito");
				ubicacion = false;
				return;
			}
//			MapRoute route = GMapProviders.GoogleMap.GetRoute(
//				point, zgz, false, false, 15);
			
			MapRoute route = GMapProviders.BingMap.GetRoute(point, zgz, false, false, 15);
			Marcador aa= new Marcador(point,GMarkerGoogleType.blue);
			
			if (route.Distance>pref.DistLarga) {
				aa = new Marcador(point,GMarkerGoogleType.red);
				//overlayColegios.Markers.Add(aa);
			}
//			if (route.Distance<=125 && route.Distance>50) {
//				 aa = new GMarkerGoogle(point,GMarkerGoogleType.yellow);
//				//overlayColegios.Markers.Add(aa);
//			}
			if (route.Distance<=pref.DistMedia) {
				aa = new Marcador(point,GMarkerGoogleType.green);
				
			}
			var ts = new TimeSpan(0,Convert.ToInt32(route.Distance/1.5),0);
			aa.cole.distancia = ts.ToString();
			aa.cole.km = route.Distance;
			var gruta = new GMapRoute(route.Points,route.Name);
			aa.cole.ruta = gruta;
			overlayColegios.Markers.Add(aa);
			gruta.Stroke = new Pen(randomColor(),3);
			overlayRutas.Routes.Add(gruta);
			ResumeLayout(true);
			} catch (Exception) {
				
				MessageBox.Show("Se ha producido un error al intentar encontrar la ruta, intentelo de nuevo");
			}
		}
		
		public  PointLatLng GetCoordinates(string region)
		{
			string start = region;
			string end = "Zaragoza";
			try {
				MapRoute route = GMapProviders.GoogleMap.GetRoute(
					start, end, false, false, 15);
				return (PointLatLng)route.From;
			} catch (Exception ex) {
				System.Diagnostics.Debug.WriteLine(ex);
				return new PointLatLng(0,0);
			}
			
		}
		void Button1Click(object sender, EventArgs e)
		{
//			MainMap.Position = GetCoordinates(tbBusqueda.Text);
			var direccion = new Adress();
			direccion.Address = tbBusqueda.Text;
			direccion.GeoCode();
			MainMap.Position = new PointLatLng(direccion.Latitude,direccion.Longitude);
			MainMap.Zoom = 14;
		}
		
		Color randomColor(){
			System.Random rdm = new Random();
			int red = rdm.Next(0,255);
			int green = rdm.Next(0,255);
			int blue = rdm.Next(0,255);
			
			return Color.FromArgb(red,green,blue);
			
		}
		void BListarClick(object sender, EventArgs e)
		{
			var frm = new ListadoDeColesForm(getColes(),jornadas);
			frm.ShowDialog();
		}
		void BnClick(object sender, EventArgs e)
		{
			//GoogleMapProvider.Instance.GetRoute
			//var zgz = new PointLatLng(41.65, -0.883333);
			var zgz2 = new PointLatLng(41.65, -0.99);
			MapRoute route = GMapProviders.BingMap.GetRoute(
				zgz, zgz2, false, false, 15);
//			MapRoute route = GMapProviders.GoogleMap.GetRoute(
//				zgz, zgz2, false, false, 15);
			var gruta = new GMapRoute(route.Points,route.Name);
			gruta.Stroke = new Pen(randomColor(),3);
			overlayRutas.Routes.Add(gruta);
			ResumeLayout(true);
			
		}
		void GuardarToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (DialogGuardar.ShowDialog()== DialogResult.OK) {
				IList<Colegio> listac = getColes();
				string json = JsonConvert.SerializeObject(listac);
				System.IO.File.WriteAllText(DialogGuardar.FileName,json);
				
				
			}
			
		}
		
		
		IList<Colegio> getColes()
		{
			IList<Colegio> listadoColes = new List<Colegio>();
			foreach (GMapMarker m in overlayColegios.Markers) {
				var other = m as Marcador;
				listadoColes.Add(other.cole);
			}
			return listadoColes;
		}
		void CargarToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			if (DialogAbrir.ShowDialog()== DialogResult.OK) {
				this.Cursor = Cursors.WaitCursor;
				IList<Colegio> listac = getColes();
				string json = System.IO.File.ReadAllText(DialogAbrir.FileName);
				listac =(IList<Colegio>) JsonConvert.DeserializeObject<IList<Colegio>>(json);
				overlayRutas.Routes.Clear();
				overlayColegios.Markers.Clear();
				foreach (Colegio c in listac) {
					var point =  c.localizacion;
					//var zgz = new PointLatLng(41.65, -0.883333);
					MapRoute route = GMapProviders.BingMap.GetRoute(point, zgz, false, false, 15);
					Marcador aa= new Marcador(point,GMarkerGoogleType.blue);
					
					if (route.Distance>125) {
						aa = new Marcador(point,GMarkerGoogleType.red);
					}
					if (route.Distance<=50) {
						aa = new Marcador(point,GMarkerGoogleType.green);
					}
					aa.cole = c;
					overlayColegios.Markers.Add(aa);
					var gruta = new GMapRoute(route.Points,route.Name);
					aa.cole.ruta = gruta;
					gruta.Stroke = new Pen(randomColor(),3);
					overlayRutas.Routes.Add(gruta);
					ResumeLayout(true);
				}
				Cursor = Cursors.Default;
			}
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void CambiarUbicaciónInicialToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Haga doble click en el mapa donde desee establecer la ubicación inicial");
			ubicacion = true;
		}
		
		void PreferenciasToolStripMenuItemClick(object sender, EventArgs e)
		{
			var frm = new PreferenciasForm(pref);
			frm.ShowDialog();
		}
		void BOrdenarClick(object sender, EventArgs e)
		{
			var frm = new OrdenarForm(getColes());
			frm.ShowDialog();
		}
	}
}
