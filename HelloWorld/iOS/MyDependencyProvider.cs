[assembly: Xamarin.Forms.Dependency(typeof(HelloWorld.iOS.MyDependencyProvider))]
namespace HelloWorld.iOS
{
	public class MyDependencyProvider : IMyDependecyProvider
	{
		public MyDependencyProvider()
		{
		}

		public string GetName()
		{
			return "iOS";
		}
	}
}
