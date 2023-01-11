using BuilderPattern2.Builders.Implementations;
using BuilderPattern2.Builders.Interfaces;
using BuilderPattern2.Directors;
using BuilderPattern2.Entity;

namespace BuilderPattern2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IDeveloper androidDeveloper = new AndroidDeveloper();

			IDeveloper iPhoneDeveloper = new IPhoneDeveloper();

			Director director = new Director(androidDeveloper);
			Phone samsung = director.MountOnlyPhone();
			Console.WriteLine(samsung.AboutPhone());
			director.SetDeveloper(iPhoneDeveloper);
			Phone iPhone = director.MountFullPhone();
			Console.WriteLine(iPhone.AboutPhone());
			Console.Read();

		}
	}
}