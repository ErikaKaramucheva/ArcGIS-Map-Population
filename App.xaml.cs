using System.Configuration;
using System.Data;
using System.Windows;

namespace ArcGISMap
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Esri.ArcGISRuntime.ArcGISRuntimeEnvironment.ApiKey = "AAPTxy8BH1VEsoebNVZXo8HurNGhKSq4YwbtCpzff9VKuNAipFWZbqToTnvSHJNAVIjoorMAjRFzpTtwYGOC425jbSM-43_yqYkkk_kCiIQfWKdFUM5LPpX8c-qF4_MtqB3nHk5WQFsrCW2fLyodZzWaW7yjd91StcO1IwiBlFLqyvxV0rNonBf8m_FFGu_gl9SJVdBDhLAeWfdBqdxSwT1ONPEhgmqmndMhlYJf3DBdNLM.AT1_HbjMNBgs";
        }
    }

}
