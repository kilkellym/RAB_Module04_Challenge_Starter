namespace RAB_Module04_Challenge_Starter
{
	internal class App : IExternalApplication
	{
		public Result OnStartup(UIControlledApplication app)
		{

			return Result.Succeeded;
		}

		public Result OnShutdown(UIControlledApplication a)
		{

			return Result.Succeeded;
		}
	}

}
