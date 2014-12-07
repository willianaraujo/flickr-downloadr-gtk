
// This file has been generated by the GUI designer. Do not modify.
namespace FloydPink.Flickr.Downloadr.UI.Windows
{
	public partial class BrowserWindow
	{
		private global::Gtk.VBox vboxRoot;
		
		private global::Gtk.HBox hboxSpinner;
		
		private global::Gtk.HBox hbox6;
		
		private global::Gtk.ScrolledWindow scrolledwindowPhotos;
		
		private global::Gtk.VBox vboxPhotos;
		
		private global::Gtk.HBox hboxBottom;
		
		private global::Gtk.HBox hboxButtons;
		
		private global::Gtk.HBox hboxLeft;
		
		private global::Gtk.Button buttonBack;
		
		private global::Gtk.ToggleButton togglebuttonShowAllPhotos;
		
		private global::Gtk.HBox hbox5;
		
		private global::Gtk.Button buttonSelectAll;
		
		private global::Gtk.Button buttonUnSelectAll;
		
		private global::Gtk.Alignment alignment1;
		
		private global::Gtk.HBox hboxCenter;
		
		private global::Gtk.Button buttonFirstPage;
		
		private global::Gtk.Button buttonPreviousPage;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Label labelPhotos;
		
		private global::Gtk.Label labelPages;
		
		private global::Gtk.ComboBox comboboxPage;
		
		private global::Gtk.Button buttonNextPage;
		
		private global::Gtk.Button buttonLastPage;
		
		private global::Gtk.HBox hboxRight;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Button buttonDownloadSelection;
		
		private global::Gtk.Button buttonDownloadThisPage;
		
		private global::Gtk.Button buttonDownloadAllPages;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget FloydPink.Flickr.Downloadr.UI.Windows.BrowserWindow
			this.HeightRequest = 600;
			this.Name = "FloydPink.Flickr.Downloadr.UI.Windows.BrowserWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Photo Browser - flickr downloadr");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource ("FloydPink.Flickr.Downloadr.UI.Assets.icon.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.Resizable = false;
			this.AllowGrow = false;
			// Container child FloydPink.Flickr.Downloadr.UI.Windows.BrowserWindow.Gtk.Container+ContainerChild
			this.vboxRoot = new global::Gtk.VBox ();
			this.vboxRoot.Name = "vboxRoot";
			this.vboxRoot.Spacing = 6;
			this.vboxRoot.BorderWidth = ((uint)(10));
			// Container child vboxRoot.Gtk.Box+BoxChild
			this.hboxSpinner = new global::Gtk.HBox ();
			this.hboxSpinner.Name = "hboxSpinner";
			this.hboxSpinner.Spacing = 6;
			this.vboxRoot.Add (this.hboxSpinner);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vboxRoot [this.hboxSpinner]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vboxRoot.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.scrolledwindowPhotos = new global::Gtk.ScrolledWindow ();
			this.scrolledwindowPhotos.CanFocus = true;
			this.scrolledwindowPhotos.Name = "scrolledwindowPhotos";
			this.scrolledwindowPhotos.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindowPhotos.Gtk.Container+ContainerChild
			global::Gtk.Viewport w2 = new global::Gtk.Viewport ();
			w2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.vboxPhotos = new global::Gtk.VBox ();
			this.vboxPhotos.Name = "vboxPhotos";
			this.vboxPhotos.Homogeneous = true;
			this.vboxPhotos.Spacing = 6;
			w2.Add (this.vboxPhotos);
			this.scrolledwindowPhotos.Add (w2);
			this.hbox6.Add (this.scrolledwindowPhotos);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.scrolledwindowPhotos]));
			w5.Position = 0;
			this.vboxRoot.Add (this.hbox6);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vboxRoot [this.hbox6]));
			w6.Position = 1;
			// Container child vboxRoot.Gtk.Box+BoxChild
			this.hboxBottom = new global::Gtk.HBox ();
			this.hboxBottom.Name = "hboxBottom";
			this.hboxBottom.Spacing = 6;
			// Container child hboxBottom.Gtk.Box+BoxChild
			this.hboxButtons = new global::Gtk.HBox ();
			this.hboxButtons.Name = "hboxButtons";
			this.hboxButtons.Homogeneous = true;
			this.hboxButtons.Spacing = 6;
			// Container child hboxButtons.Gtk.Box+BoxChild
			this.hboxLeft = new global::Gtk.HBox ();
			this.hboxLeft.Name = "hboxLeft";
			this.hboxLeft.Spacing = 6;
			// Container child hboxLeft.Gtk.Box+BoxChild
			this.buttonBack = new global::Gtk.Button ();
			this.buttonBack.WidthRequest = 65;
			this.buttonBack.CanFocus = true;
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.UseUnderline = true;
			this.buttonBack.Label = global::Mono.Unix.Catalog.GetString ("Back");
			this.hboxLeft.Add (this.buttonBack);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hboxLeft [this.buttonBack]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hboxLeft.Gtk.Box+BoxChild
			this.togglebuttonShowAllPhotos = new global::Gtk.ToggleButton ();
			this.togglebuttonShowAllPhotos.WidthRequest = 185;
			this.togglebuttonShowAllPhotos.CanFocus = true;
			this.togglebuttonShowAllPhotos.Name = "togglebuttonShowAllPhotos";
			this.togglebuttonShowAllPhotos.UseUnderline = true;
			this.togglebuttonShowAllPhotos.FocusOnClick = false;
			this.togglebuttonShowAllPhotos.Label = global::Mono.Unix.Catalog.GetString ("Show All Photos");
			this.hboxLeft.Add (this.togglebuttonShowAllPhotos);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hboxLeft [this.togglebuttonShowAllPhotos]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hboxLeft.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.buttonSelectAll = new global::Gtk.Button ();
			this.buttonSelectAll.WidthRequest = 35;
			this.buttonSelectAll.CanFocus = true;
			this.buttonSelectAll.Name = "buttonSelectAll";
			this.buttonSelectAll.UseUnderline = true;
			this.buttonSelectAll.FocusOnClick = false;
			this.buttonSelectAll.Label = global::Mono.Unix.Catalog.GetString ("✓");
			this.hbox5.Add (this.buttonSelectAll);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.buttonSelectAll]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.buttonUnSelectAll = new global::Gtk.Button ();
			this.buttonUnSelectAll.WidthRequest = 35;
			this.buttonUnSelectAll.Sensitive = false;
			this.buttonUnSelectAll.CanFocus = true;
			this.buttonUnSelectAll.Name = "buttonUnSelectAll";
			this.buttonUnSelectAll.UseUnderline = true;
			this.buttonUnSelectAll.FocusOnClick = false;
			this.buttonUnSelectAll.Label = global::Mono.Unix.Catalog.GetString ("X");
			this.hbox5.Add (this.buttonUnSelectAll);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.buttonUnSelectAll]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.hbox5.Add (this.alignment1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.alignment1]));
			w11.Position = 2;
			this.hboxLeft.Add (this.hbox5);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hboxLeft [this.hbox5]));
			w12.Position = 2;
			this.hboxButtons.Add (this.hboxLeft);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hboxButtons [this.hboxLeft]));
			w13.Position = 0;
			// Container child hboxButtons.Gtk.Box+BoxChild
			this.hboxCenter = new global::Gtk.HBox ();
			this.hboxCenter.Name = "hboxCenter";
			this.hboxCenter.Spacing = 6;
			// Container child hboxCenter.Gtk.Box+BoxChild
			this.buttonFirstPage = new global::Gtk.Button ();
			this.buttonFirstPage.WidthRequest = 35;
			this.buttonFirstPage.CanFocus = true;
			this.buttonFirstPage.Name = "buttonFirstPage";
			this.buttonFirstPage.UseUnderline = true;
			this.buttonFirstPage.FocusOnClick = false;
			this.buttonFirstPage.Label = global::Mono.Unix.Catalog.GetString ("|<<");
			this.hboxCenter.Add (this.buttonFirstPage);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hboxCenter [this.buttonFirstPage]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hboxCenter.Gtk.Box+BoxChild
			this.buttonPreviousPage = new global::Gtk.Button ();
			this.buttonPreviousPage.WidthRequest = 35;
			this.buttonPreviousPage.CanFocus = true;
			this.buttonPreviousPage.Name = "buttonPreviousPage";
			this.buttonPreviousPage.UseUnderline = true;
			this.buttonPreviousPage.FocusOnClick = false;
			this.buttonPreviousPage.Label = global::Mono.Unix.Catalog.GetString ("<");
			this.hboxCenter.Add (this.buttonPreviousPage);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hboxCenter [this.buttonPreviousPage]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hboxCenter.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelPhotos = new global::Gtk.Label ();
			this.labelPhotos.Name = "labelPhotos";
			this.labelPhotos.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>                       </small>");
			this.labelPhotos.UseMarkup = true;
			this.vbox2.Add (this.labelPhotos);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelPhotos]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelPages = new global::Gtk.Label ();
			this.labelPages.Name = "labelPages";
			this.labelPages.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>                       </small>");
			this.labelPages.UseMarkup = true;
			this.vbox2.Add (this.labelPages);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelPages]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.hbox2.Add (this.vbox2);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox2]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.comboboxPage = global::Gtk.ComboBox.NewText ();
			this.comboboxPage.AppendText (global::Mono.Unix.Catalog.GetString ("1"));
			this.comboboxPage.Name = "comboboxPage";
			this.comboboxPage.Active = 0;
			this.hbox2.Add (this.comboboxPage);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.comboboxPage]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			this.hboxCenter.Add (this.hbox2);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hboxCenter [this.hbox2]));
			w20.Position = 2;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hboxCenter.Gtk.Box+BoxChild
			this.buttonNextPage = new global::Gtk.Button ();
			this.buttonNextPage.WidthRequest = 35;
			this.buttonNextPage.CanFocus = true;
			this.buttonNextPage.Name = "buttonNextPage";
			this.buttonNextPage.UseUnderline = true;
			this.buttonNextPage.FocusOnClick = false;
			this.buttonNextPage.Label = global::Mono.Unix.Catalog.GetString (">");
			this.hboxCenter.Add (this.buttonNextPage);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hboxCenter [this.buttonNextPage]));
			w21.Position = 3;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hboxCenter.Gtk.Box+BoxChild
			this.buttonLastPage = new global::Gtk.Button ();
			this.buttonLastPage.WidthRequest = 35;
			this.buttonLastPage.CanFocus = true;
			this.buttonLastPage.Name = "buttonLastPage";
			this.buttonLastPage.UseUnderline = true;
			this.buttonLastPage.FocusOnClick = false;
			this.buttonLastPage.Label = global::Mono.Unix.Catalog.GetString (">>|");
			this.hboxCenter.Add (this.buttonLastPage);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hboxCenter [this.buttonLastPage]));
			w22.Position = 4;
			w22.Expand = false;
			w22.Fill = false;
			this.hboxButtons.Add (this.hboxCenter);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hboxButtons [this.hboxCenter]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hboxButtons.Gtk.Box+BoxChild
			this.hboxRight = new global::Gtk.HBox ();
			this.hboxRight.Name = "hboxRight";
			this.hboxRight.Spacing = 6;
			// Container child hboxRight.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Download</b>");
			this.label1.UseMarkup = true;
			this.hboxRight.Add (this.label1);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hboxRight [this.label1]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hboxRight.Gtk.Box+BoxChild
			this.buttonDownloadSelection = new global::Gtk.Button ();
			this.buttonDownloadSelection.WidthRequest = 125;
			this.buttonDownloadSelection.CanFocus = true;
			this.buttonDownloadSelection.Name = "buttonDownloadSelection";
			this.buttonDownloadSelection.UseUnderline = true;
			this.buttonDownloadSelection.FocusOnClick = false;
			this.buttonDownloadSelection.Label = global::Mono.Unix.Catalog.GetString ("Selection");
			this.hboxRight.Add (this.buttonDownloadSelection);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hboxRight [this.buttonDownloadSelection]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hboxRight.Gtk.Box+BoxChild
			this.buttonDownloadThisPage = new global::Gtk.Button ();
			this.buttonDownloadThisPage.WidthRequest = 76;
			this.buttonDownloadThisPage.CanFocus = true;
			this.buttonDownloadThisPage.Name = "buttonDownloadThisPage";
			this.buttonDownloadThisPage.UseUnderline = true;
			this.buttonDownloadThisPage.FocusOnClick = false;
			this.buttonDownloadThisPage.Label = global::Mono.Unix.Catalog.GetString ("This Page");
			this.hboxRight.Add (this.buttonDownloadThisPage);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hboxRight [this.buttonDownloadThisPage]));
			w26.Position = 2;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hboxRight.Gtk.Box+BoxChild
			this.buttonDownloadAllPages = new global::Gtk.Button ();
			this.buttonDownloadAllPages.WidthRequest = 75;
			this.buttonDownloadAllPages.CanFocus = true;
			this.buttonDownloadAllPages.Name = "buttonDownloadAllPages";
			this.buttonDownloadAllPages.UseUnderline = true;
			this.buttonDownloadAllPages.FocusOnClick = false;
			this.buttonDownloadAllPages.Label = global::Mono.Unix.Catalog.GetString ("All Pages");
			this.hboxRight.Add (this.buttonDownloadAllPages);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hboxRight [this.buttonDownloadAllPages]));
			w27.Position = 3;
			w27.Expand = false;
			w27.Fill = false;
			this.hboxButtons.Add (this.hboxRight);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hboxButtons [this.hboxRight]));
			w28.Position = 2;
			w28.Fill = false;
			this.hboxBottom.Add (this.hboxButtons);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hboxBottom [this.hboxButtons]));
			w29.Position = 0;
			this.vboxRoot.Add (this.hboxBottom);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vboxRoot [this.hboxBottom]));
			w30.Position = 2;
			w30.Expand = false;
			w30.Fill = false;
			this.Add (this.vboxRoot);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 1119;
			this.DefaultHeight = 600;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.buttonBack.Clicked += new global::System.EventHandler (this.buttonBackClick);
			this.togglebuttonShowAllPhotos.Clicked += new global::System.EventHandler (this.togglebuttonShowAllPhotosClick);
			this.buttonSelectAll.Clicked += new global::System.EventHandler (this.buttonSelectAllClick);
			this.buttonUnSelectAll.Clicked += new global::System.EventHandler (this.buttonUnSelectAllClick);
			this.buttonFirstPage.Clicked += new global::System.EventHandler (this.buttonFirstPageClick);
			this.buttonPreviousPage.Clicked += new global::System.EventHandler (this.buttonPreviousPageClick);
			this.comboboxPage.Changed += new global::System.EventHandler (this.comboboxPageChange);
			this.buttonNextPage.Clicked += new global::System.EventHandler (this.buttonNextPageClick);
			this.buttonLastPage.Clicked += new global::System.EventHandler (this.buttonLastPageClick);
			this.buttonDownloadSelection.Clicked += new global::System.EventHandler (this.buttonDownloadSelectionClick);
			this.buttonDownloadThisPage.Clicked += new global::System.EventHandler (this.buttonDownloadThisPageClick);
			this.buttonDownloadAllPages.Clicked += new global::System.EventHandler (this.buttonDownloadAllPagesClick);
		}
	}
}
