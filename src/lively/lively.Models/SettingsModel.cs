using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

namespace lively.Models
{

    [Serializable]
    public class SettingsModel
    {
        public string AppVersion { get; set; }
        public string Language { get; set; }
        public bool Startup { get; set; }
        public bool IsFirstRun { get; set; }

        public SettingsModel()
        {
            AppVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            IsFirstRun = false;
            Startup = false;

            try
            {
                Language = CultureInfo.CurrentCulture.Name;
            }
            catch (ArgumentNullException)
            {
                Language = "en";
            }
        }
    }
}
