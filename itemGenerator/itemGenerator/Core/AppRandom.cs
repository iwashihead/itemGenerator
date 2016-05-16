using System;

namespace itemGenerator
{
	public class AppRandom
	{
		private static AppRandom _instance = null;
		public static AppRandom Instance
		{
			get { return _instance ?? (_instance = new AppRandom()); }
		}

		private AppRandom ()
		{
			_rand = new Random();
		}

		private Random _rand;
		public Random Random
		{
			get{ return _rand; }
		}
	}
}

