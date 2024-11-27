using BOOKS.Views;
using Microsoft.Extensions.DependencyInjection;
using static BOOKS.View_Model.BookViewModel;
using BOOKS.View_Model;

namespace BOOKS.View_Model
{
	public static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var services = new ServiceCollection();
			ConfigureServices(services);

			var serviceProvider = services.BuildServiceProvider();
			Application.Run(serviceProvider.GetRequiredService<MainForm>()); }
		private static void ConfigureServices (IServiceCollection services)
		{
			services.AddSingleton<IBookViewModel, BookViewModel>();
			services.AddTransient<MainForm>();

		}
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			
		}
	}
