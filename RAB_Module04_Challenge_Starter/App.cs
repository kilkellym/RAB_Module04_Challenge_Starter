using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace RAB_Module04_Challenge_Starter
{
	internal class App : IExternalApplication
	{
		public Result OnStartup(UIControlledApplication app)
		{
			// 1. Create tab and panel
			string tabName = "Revit Add-in Bootcamp";
			string panelName = "Scavenger Hunt";

			app.CreateRibbonTab(tabName);
			RibbonPanel panel = app.CreateRibbonPanel(tabName, panelName);

			// 2. Create button data
			PushButtonData buttonData1 = new PushButtonData(
				"cmd1",
				"Tool 1",
				Assembly.GetExecutingAssembly().Location,
				"RAB_Module04_Challenge_Starter.cmd1"
			);

			PushButtonData buttonData2 = new PushButtonData(
				"cmd2",
				"Tool 2",
				Assembly.GetExecutingAssembly().Location,
				"RAB_Module04_Challenge_Starter.cmd2"
			);
			PushButtonData buttonData3 = new PushButtonData(
				"cmd3",
				"Tool 3",
				Assembly.GetExecutingAssembly().Location,
				"RAB_Module04_Challenge_Starter.cmd3"
			);
			PushButtonData buttonData4 = new PushButtonData(
				"cmd4",
				"Tool 4",
				Assembly.GetExecutingAssembly().Location,
				"RAB_Module04_Challenge_Starter.cmd4"
			);
			PushButtonData buttonData5 = new PushButtonData(
				"cmd5",
				"Tool 5",
				Assembly.GetExecutingAssembly().Location,
				"RAB_Module04_Challenge_Starter.cmd5"
			);
			PushButtonData buttonData6 = new PushButtonData(
				"cmd6",
				"Tool 6",
				Assembly.GetExecutingAssembly().Location,
				"RAB_Module04_Challenge_Starter.cmd6"
			);
			PushButtonData buttonData7 = new PushButtonData(
				"cmd7",
				"Tool 7",
				Assembly.GetExecutingAssembly().Location,
				"RAB_Module04_Challenge_Starter.cmd7"
			);
			PushButtonData buttonData8 = new PushButtonData(
				"cmd8",
				"Tool 8",
				Assembly.GetExecutingAssembly().Location,
				"RAB_Module04_Challenge_Starter.cmd8"
			);
			PushButtonData buttonData9 = new PushButtonData(
				"cmd9",
				"Tool 9",
				Assembly.GetExecutingAssembly().Location,
				"RAB_Module04_Challenge_Starter.cmd9"
			);
			PushButtonData buttonData10 = new PushButtonData(
				"cmd10",
				"Tool 10",
				Assembly.GetExecutingAssembly().Location,
				"RAB_Module04_Challenge_Starter.cmd10"
			);

			// 3a. Add images to large buttons
			buttonData1.LargeImage = ConvertToImageSource(Properties.Resources.Red_32);
			buttonData2.LargeImage = ConvertToImageSource(Properties.Resources.Blue_32);
			buttonData3.LargeImage = ConvertToImageSource(Properties.Resources.Yellow_32);
			buttonData4.LargeImage = ConvertToImageSource(Properties.Resources.Green_32);
			buttonData5.LargeImage = ConvertToImageSource(Properties.Resources.Red_32);
			buttonData6.LargeImage = ConvertToImageSource(Properties.Resources.Blue_32);
			buttonData7.LargeImage = ConvertToImageSource(Properties.Resources.Yellow_32);
			buttonData8.LargeImage = ConvertToImageSource(Properties.Resources.Green_32);
			buttonData9.LargeImage = ConvertToImageSource(Properties.Resources.Red_32);
			buttonData10.LargeImage = ConvertToImageSource(Properties.Resources.Yellow_32);

			// 3b. Add images to small buttons
			buttonData1.Image = ConvertToImageSource(Properties.Resources.Red_16);
			buttonData2.Image = ConvertToImageSource(Properties.Resources.Blue_16);
			buttonData3.Image = ConvertToImageSource(Properties.Resources.Yellow_16);
			buttonData4.Image = ConvertToImageSource(Properties.Resources.Green_16);
			buttonData5.Image = ConvertToImageSource(Properties.Resources.Red_16);
			buttonData6.Image = ConvertToImageSource(Properties.Resources.Blue_16);
			buttonData7.Image = ConvertToImageSource(Properties.Resources.Yellow_16);
			buttonData8.Image = ConvertToImageSource(Properties.Resources.Green_16);
			buttonData9.Image = ConvertToImageSource(Properties.Resources.Red_16);
			buttonData10.Image = ConvertToImageSource(Properties.Resources.Yellow_16);

			// 4. Create push buttons
			PushButton button1 = panel.AddItem(buttonData1) as PushButton;
			PushButton button2 = panel.AddItem(buttonData2) as PushButton;

			// 5. Add stackable buttons
			panel.AddStackedItems(buttonData3, buttonData4, buttonData5);

			// 6. Add split button
			SplitButtonData splitButtonData = new SplitButtonData("splitBtn", "Split Button");
			SplitButton splitButton = panel.AddItem(splitButtonData) as SplitButton;
			splitButton.AddPushButton(buttonData6);
			splitButton.AddPushButton(buttonData7);

			// 7. Add pull down button
			PulldownButtonData pulldownButtonData = new PulldownButtonData("pulldownBtn", "More Tools");
			PulldownButton pulldownButton = panel.AddItem(pulldownButtonData) as PulldownButton;
			pulldownButton.AddPushButton(buttonData8);
			pulldownButton.AddPushButton(buttonData9);
			pulldownButton.AddPushButton(buttonData10);

			return Result.Succeeded;
		}

		public Result OnShutdown(UIControlledApplication a)
		{
			return Result.Succeeded;
		}

		public BitmapImage ConvertToImageSource(byte[] imageData)
		{
			using (MemoryStream mem = new MemoryStream(imageData))
			{
				mem.Position = 0;
				BitmapImage bmi = new BitmapImage();
				bmi.BeginInit();
				bmi.StreamSource = mem;
				bmi.CacheOption = BitmapCacheOption.OnLoad;
				bmi.EndInit();

				return bmi;
			}
		}
	}

}
