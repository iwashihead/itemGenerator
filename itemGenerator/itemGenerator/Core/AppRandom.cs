using System;

namespace itemGenerator
{
    public class AppRandom
    {
        private static AppRandom _instance;

        private AppRandom()
        {
            Random = new Random();
        }

        public static AppRandom Instance
        {
            get { return _instance ?? (_instance = new AppRandom()); }
        }

        public Random Random { get; }
    }
}