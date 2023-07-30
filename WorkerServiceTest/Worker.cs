using System.Diagnostics;

namespace WorkerServiceTest
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string sFile = System.IO.Path.Combine(sCurrentDirectory, @Config.Config.GetInstance().TriggerAppPath);
                string appPath = Path.GetFullPath(sFile);
                var appPathSplitted = appPath.Split('\\');
                var appName = appPathSplitted[appPathSplitted.Length - 1].Split('.')[0];
                var runningProcessByName = Process.GetProcessesByName(appName);
                if (runningProcessByName.Length == 0)
                {
                    Process.Start(appPath);
                    _logger.LogInformation("{appName} started at: {time}", appName , DateTime.Now);
                }    
                                
                await Task.Delay(Config.Config.GetInstance().TriggerApplicationTime, stoppingToken);
            }
        }
    }
}