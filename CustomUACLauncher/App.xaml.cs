using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Shapes;

namespace CustomUACLauncher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public static string AppPath = "";
        public static string PathToOpen = "";
        public static bool Contains(string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            string[] arguments = e.Args;
            if(arguments.Length > 0)
            {
                for(int i = 0; i < arguments.Length; i++)
                {
                    if (Contains(arguments[i], "-app", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            string tmp = arguments[i + 1];
                            //MessageBox.Show("App path: " + tmp);
                            AppPath = tmp;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("no value for arg provided");
                        }
                    }

                    if (Contains(arguments[i], "-path", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            string tmp = arguments[i + 1];
                            //MessageBox.Show("Path to launch in: " + tmp);
                            PathToOpen = tmp;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("no value for arg provided");
                        }
                    }
                }
                if(String.IsNullOrEmpty(AppPath))
                    return;
                
                if(String.IsNullOrEmpty(PathToOpen))
                    return;
                
                Process process = new Process();
                process.StartInfo.FileName = AppPath;
                process.StartInfo.Arguments = "\"" + PathToOpen + "\"";
                process.StartInfo.Verb = "runas";
                process.Start();
                
                
            }
            else
            {
                MessageBox.Show("No Arguments");
            }

            
        }
    }
}