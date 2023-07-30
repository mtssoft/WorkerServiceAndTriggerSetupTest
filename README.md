# WorkerServiceAndTriggerSetupTest
2 Triggered Each Other Worker Applications and Implementation Sample Of This Two Apps Setup Wizard .Net6

Hi; Here is sample of 2 triggered application and creation setup wizard for this two apps in .Net6.

What's we do in here?

We implemented 2 Worker application under the same solution. This application check each other is running or not. If the other app isn't running, this app start the other.

The apps read the other app location from appsettings.json file.

After the development and development tests we need to create setup wizard for these apps. This setup wizard has to set installation folders of two apps and set these apps to start when windows start.

We created a setup project with visual studio(Right click on the solution=> Add=> New Project => Setup Project (If you couldn't find you should go to Extension and install Windows Installer extension to you Visual Studio)).

We set the installation folder and start app when windows start and that app triggered another one. It worked properly.

Happy coding.
