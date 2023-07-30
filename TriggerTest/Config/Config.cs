
namespace TriggerTest.Config
{
    public class Config
    {
        #region Singleton Pattern

        static Config instance;

        public static Config GetInstance()
        {
            if (instance == null)
            {
                instance = new Config();
            }

            return instance;
        }
        #endregion


        public string TriggerAppPath { get; set; }

        public int TriggerApplicationTime { get; set; }

    }
}
