[assembly:Xamarin.Forms.Dependency(typeof(HelloWorld.Droid.MyDependencyProvider))]
namespace HelloWorld.Droid
{
	public class MyDependencyProvider : IMyDependecyProvider
	{
		public MyDependencyProvider()
		{
		}

		public string GetName()
		{
			return "Android";
		}
	}
}
