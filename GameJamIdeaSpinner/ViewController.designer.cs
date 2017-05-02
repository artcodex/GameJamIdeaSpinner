// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace GameJamIdeaSpinner
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField artstyle { get; set; }

		[Outlet]
		AppKit.NSTextField engine { get; set; }

		[Outlet]
		AppKit.NSTextField genre { get; set; }

		[Outlet]
		AppKit.NSButton pdfbtn { get; set; }

		[Outlet]
		AppKit.NSTextField perspective { get; set; }

		[Outlet]
		AppKit.NSTextField platform { get; set; }

		[Outlet]
		AppKit.NSTextField subgenre { get; set; }

		[Outlet]
		AppKit.NSTextField timeframe { get; set; }

		[Outlet]
		AppKit.NSPopUpButton type { get; set; }

		[Action ("ClickHere:")]
		partial void ClickHere (Foundation.NSObject sender);

		[Action ("CreatePDF:")]
		partial void CreatePDF (Foundation.NSObject sender);

		[Action ("onArtStyle:")]
		partial void onArtStyle (Foundation.NSObject sender);

		[Action ("onEngine:")]
		partial void onEngine (Foundation.NSObject sender);

		[Action ("onGenre:")]
		partial void onGenre (Foundation.NSObject sender);

		[Action ("onPerspective:")]
		partial void onPerspective (Foundation.NSObject sender);

		[Action ("onPlatform:")]
		partial void onPlatform (Foundation.NSObject sender);

		[Action ("onSubGenre:")]
		partial void onSubGenre (Foundation.NSObject sender);

		[Action ("onTimeFrame:")]
		partial void onTimeFrame (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (artstyle != null) {
				artstyle.Dispose ();
				artstyle = null;
			}

			if (engine != null) {
				engine.Dispose ();
				engine = null;
			}

			if (genre != null) {
				genre.Dispose ();
				genre = null;
			}

			if (perspective != null) {
				perspective.Dispose ();
				perspective = null;
			}

			if (platform != null) {
				platform.Dispose ();
				platform = null;
			}

			if (subgenre != null) {
				subgenre.Dispose ();
				subgenre = null;
			}

			if (timeframe != null) {
				timeframe.Dispose ();
				timeframe = null;
			}

			if (type != null) {
				type.Dispose ();
				type = null;
			}

			if (pdfbtn != null) {
				pdfbtn.Dispose ();
				pdfbtn = null;
			}
		}
	}
}
