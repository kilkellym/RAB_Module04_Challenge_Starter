using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace RAB_Module04_Challenge_Starter
{
	internal class App : IExternalApplication
	{
		public Result OnStartup(UIControlledApplication app)
		{
			// write your ribbon code here

			return Result.Succeeded;
		}

		public Result OnShutdown(UIControlledApplication a)
		{
			return Result.Succeeded;
		}
	}

}
