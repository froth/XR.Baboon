
// This file has been generated by the GUI designer. Do not modify.
namespace covgtk
{
	public partial class SourcePage
	{
		private global::Gtk.VBox vbox2;
		private global::covgtk.SourceHeaderBlock header;
		private global::Gtk.ScrolledWindow scroller;
		private global::Gtk.Statusbar statusbar;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget covgtk.SourcePage
			global::Stetic.BinContainer.Attach (this);
			this.Name = "covgtk.SourcePage";
			// Container child covgtk.SourcePage.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.header = new global::covgtk.SourceHeaderBlock ();
			this.header.Events = ((global::Gdk.EventMask)(256));
			this.header.Name = "header";
			this.vbox2.Add (this.header);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.header]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.scroller = new global::Gtk.ScrolledWindow ();
			this.scroller.CanFocus = true;
			this.scroller.Name = "scroller";
			this.scroller.ShadowType = ((global::Gtk.ShadowType)(1));
			this.vbox2.Add (this.scroller);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.scroller]));
			w2.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.statusbar = new global::Gtk.Statusbar ();
			this.statusbar.Name = "statusbar";
			this.statusbar.Spacing = 6;
			this.vbox2.Add (this.statusbar);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.statusbar]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}