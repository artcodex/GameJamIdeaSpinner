using System;
using System.Collections.Generic;
using AppKit;
using Foundation;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace GameJamIdeaSpinner
{
	public partial class ViewController : NSViewController
	{
		private List<string> _subGenre = new List<string>() {
			//"1st person",
			//"3rd person",
			"Scrolling Horizontal",
			"Scrolling Vertical",
			"Scrolling",
			"Top Down"};

		private List<string> _perspective = new List<string>() {
			"2D" };
		//"3D",
		//"2.5D" };

		private List<string> _artstyle = new List<string>() {
			"Retro",
			"16-bit",
			"8-bit",
			//"Cell-shaded",
			"Limited Palette",
			//"Hi-Def AAA",
			"Vector graphics",
			"Low poly" };

		private List<string> _genres = new List<string>() {
			"Platform",
			"Shooter",
			"Fighting",
			"Stealth",
			"Survival",
			"Adventure",
			"Action RPG",
			"JRPG",
			"Tactical RPG",
			"Fantasy",
			"Simulation",
			"RTS Strategy",
			"Turn Based Strategy",
			"Sports",
			"Music",
			"Casual",
			"Party",
			"Trivia",
			"Board",
			"Infinite Horizontal",
			"Infinite Vertical",
			"ESport",
			"Educational" };

		private List<string> _gameJamTimeFrames = new List<string>() {
			"24 hrs",
			"48 hrs",
			"1 week" };

		private List<string> _speedCraftTimeFrames = new List<string>() {
			"2 weeks",
			"6 weeks",
			"1 month",
			"2 months" };

		private List<string> _engines = new List<string>() {
			"MonoGame",
			"C++ custom engine",
			"lwjgl3 engine",
			"Unity",
			"GameMaker"};

		private List<string> _platform = new List<string>() {
			"mobile",
			"desktop",
			"console" };
		//"tv",
		//"VR",
		//"AR" };

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Do any additional setup after loading the view.
		}

		partial void ClickHere(NSObject sender)
		{
			SetBox(genre, _genres);
			SetBox(subgenre, _subGenre);
			SetBox(perspective, _perspective);
			SetBox(artstyle, _artstyle);
			SetBox(engine, _engines);
			SetBox(platform, _platform);

			if (type.IndexOfSelectedItem == 0)
			{
				SetBox(timeframe, _gameJamTimeFrames);
			}
			else
			{
				SetBox(timeframe, _speedCraftTimeFrames);
			}

			pdfbtn.Enabled = true;
		}

		partial void CreatePDF(NSObject sender)
		{
			PrintToPDF();
		}

		private void PrintToPDF()
		{
			Document doc = new Document();
			string tempFile = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
			tempFile += ".pdf";

			using (var file = new FileStream(tempFile, FileMode.Create))
			{
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				Paragraph par = new Paragraph("Game details: ");
				PdfPTable table = new PdfPTable(2);
				Phrase headerAphrase = new Phrase("Item");
				Phrase headerBphrase = new Phrase("Value");
				headerAphrase.Font.SetStyle("bold");
				headerAphrase.Font.Size = 15.0f;
				headerBphrase.Font.SetStyle("bold");
				headerBphrase.Font.Size = 15.0f;

				PdfPCell headerA = new PdfPCell(headerAphrase);
				PdfPCell headerB = new PdfPCell(headerBphrase);

				par.SpacingAfter = 10.0f;

				table.AddCell(headerA);
				table.AddCell(headerB);

				table.AddCell("Type");
				table.AddCell(type.SelectedItem.Title);
				table.AddCell("Genre");
				table.AddCell(genre.StringValue);
				table.AddCell("Sub Genre");
				table.AddCell(subgenre.StringValue);
				table.AddCell("Perspective");
				table.AddCell(perspective.StringValue);
				table.AddCell("Art Style");
				table.AddCell(artstyle.StringValue);
				table.AddCell("Time Frame");
				table.AddCell(timeframe.StringValue);
				table.AddCell("Engine");
				table.AddCell(engine.StringValue);
				table.AddCell("Platform");
				table.AddCell(platform.StringValue);


				doc.Add(par);
				doc.Add(table);
				doc.Close();
			}

			Process.Start(tempFile);
		}


		partial void onArtStyle(NSObject sender)
		{
            SetBox(artstyle, _artstyle);
		}

		partial void onEngine(NSObject sender)
		{
            SetBox(engine, _engines);
		}

		partial void onGenre(NSObject sender)
		{
            SetBox(genre, _genres);
		}

		partial void onPerspective(NSObject sender)
		{
            SetBox(perspective, _perspective);
		}

		partial void onPlatform(NSObject sender)
		{
            SetBox(platform, _platform);
		}

		partial void onSubGenre(NSObject sender)
		{
            SetBox(subgenre, _subGenre);
		}

		partial void onTimeFrame(NSObject sender)
		{
			if (type.IndexOfSelectedItem == 0)
			{
                SetBox(timeframe, _gameJamTimeFrames);
			}
			else
			{
				SetBox(timeframe, _speedCraftTimeFrames);
			}
		}

		private void SetBox(NSTextField field, List<string> options)
		{
			Random rand = new Random();
			var index = rand.Next(options.Count);

			field.StringValue = options[index];
		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}
	}
}
