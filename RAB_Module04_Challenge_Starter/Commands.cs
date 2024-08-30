using System.Text;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Diagnostics;
using TaskDialog = Autodesk.Revit.UI.TaskDialog;

namespace RAB_Module04_Challenge_Starter
{
	[Transaction(TransactionMode.Manual)]
	public class cmd4 : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			Message.SetMessage(" Keep");
			return Result.Succeeded;
		}
	}
	[Transaction(TransactionMode.Manual)]
	public class cmd2 : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			Message.SetMessage(" did");
			return Result.Succeeded;
		}
	}
	[Transaction(TransactionMode.Manual)]
	public class cmd10 : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			Message.SetMessage(" tools!");
			return Result.Succeeded;
		}
	}
	[Transaction(TransactionMode.Manual)]
	public class cmd8 : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			Message.SetMessage(" great");
			return Result.Succeeded;
		}
	}
	[Transaction(TransactionMode.Manual)]
	public class cmd1 : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			Message.SetMessage("You ");
			return Result.Succeeded;
		}
	}
	[Transaction(TransactionMode.Manual)]
	public class cmd7 : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			Message.SetMessage(" creating");
			return Result.Succeeded;
		}
	}
	[Transaction(TransactionMode.Manual)]
	public class cmd5 : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			Message.SetMessage(" coding");
			return Result.Succeeded;
		}
	}
	[Transaction(TransactionMode.Manual)]
	public class cmd3 : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			Message.SetMessage(" it!");
			return Result.Succeeded;
		}
	}
	[Transaction(TransactionMode.Manual)]
	public class cmd9 : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			Message.SetMessage(" Revit");
			return Result.Succeeded;
		}
	}
	[Transaction(TransactionMode.Manual)]
	public class cmd6 : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			Message.SetMessage(" and");
			return Result.Succeeded;
		}
	}
	public static class Message
	{
		public static string HiddenMessage;
		public static int counter = 0;
		public static void SetMessage(string word)
		{
			counter++;
			HiddenMessage += word;

			string message = "";
			if(counter == 10)
				message = "You found the hidden message! Message = " + HiddenMessage;
			else
				message = "You found word number " + counter.ToString();
			
			TaskDialog.Show("Scavenger Hunt!", message);
		}
	}


}
