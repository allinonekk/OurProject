namespace AllInOne.Common.Library.File
{
    using System;
    using System.IO;

    using log4net;

    /// <summary>
    /// A convenience class to locate the config file based on some very well-established locations.
    /// </summary>
    public sealed class ConfigFileLocator
    {
        #region Fields

        /// <summary>
        /// Logging instance.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ConfigFileLocator));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method to retrieve the fully-qualified file path of the config file found in the same
        /// directory as the App.config or Web.config file.
        /// </summary>
        /// <param name="configFileName">Name of the config file.</param>
        /// <returns>Full path to the config file if it exists or null if it does not exist.</returns>
        /// <exception cref="ArgumentNullException">Thrown when either parameter is a null or empty string.</exception>
        public static FileInfo GetFromAppConfigLocation(string configFileName)
        {
            if (string.IsNullOrEmpty(configFileName))
            {
                const string msg = "Why is the config file name null or empty string when looking up in the app.config or web.config folder!";
                Logger.Error(msg);
                throw new ArgumentNullException(msg);
            }

            string configPath = GetConfigPath();
            if (Logger.IsDebugEnabled)
            {
                Logger.DebugFormat("Looking for config file {0} at the app.config or web.config folder location ({1})", configFileName, configPath);
            }
            FileInfo configFileInfo = new FileInfo(configPath + @"\" + configFileName);
            if (configFileInfo.Exists)
            {
                Logger.InfoFormat("Found {0} in the same folder as the app.config or web.config (i.e., {1})", configFileName, configPath);
            }
            else
            {
                Logger.InfoFormat("Unable to find {0} in the folder: {1}", configFileName, configPath);
                configFileInfo = null;
            }

            return configFileInfo;
        }

        /// <summary>
        /// Method to retrieve the fully-qualified file path of the config file found in the same
        /// directory as the App.config or Web.config file.
        /// </summary>
        /// <param name="relativeSubFolder">Sub folder relative to the folder containing the App.config or Web.config. 
        /// The relative must begin with a back slash (i.e., \) and must not have a trailing back-slash. 
        /// If a preceding backslash does not exist, it will be added. If a trailing backslash exists, 
        /// it will be removed.</param>
        /// <param name="configFileName">Name of the config file.</param>
        /// <returns>Full path to the config file.</returns>
        /// <exception cref="ArgumentNullException">Thrown when either parameter is a null or empty string.</exception>
        public static FileInfo GetFromAppConfigLocation(string relativeSubFolder, string configFileName)
        {
            FileInfo configFileInfo = CreateConfigFileInfo(relativeSubFolder, configFileName);

            if (configFileInfo.Exists)
            {
                Logger.InfoFormat("Found {0} in the folder (i.e., {1})", configFileName, configFileInfo.FullName);
            }
            else
            {
                Logger.InfoFormat("Cannot find {0}!!", configFileInfo.FullName);
            }

            return configFileInfo;
        }

        /// <summary>
        /// Creates the config file info.
        /// </summary>
        /// <param name="relativeSubFolder">The relative sub folder.</param>
        /// <param name="configFileName">Name of the config file.</param>
        /// <returns></returns>
        private static FileInfo CreateConfigFileInfo(string relativeSubFolder, string configFileName)
        {
            if (string.IsNullOrEmpty(relativeSubFolder))
            {
                const string msg = "Why is the relative subfolder null or empty string!";
                Logger.Error(msg);
                throw new ArgumentNullException(msg);
            }

            if (string.IsNullOrEmpty(configFileName))
            {
                string msg = string.Format("Why is the config file name null or empty string when looking up in the subfolder ({0})!", relativeSubFolder);
                Logger.Error(msg);
                throw new ArgumentNullException(msg);
            }

            string modifiedFolderPath = DoValidateRelativeFolder(relativeSubFolder);

            if (string.IsNullOrEmpty(modifiedFolderPath))
            {
                return null;
            }

            string configFilePath = GetConfigPath() + modifiedFolderPath + @"\" + configFileName;
            if (Logger.IsDebugEnabled)
            {
                Logger.DebugFormat("Fully qualified path to the config file: {0}", configFilePath);
            }

            return new FileInfo(configFilePath);
        }

        private static string DoValidateRelativeFolder(string relativeFolder)
        {
            string modifiedPathTrailingSlash = relativeFolder.Trim().Trim(char.Parse(@"\"));

            string modifiedPathPrecedingSlash = string.Empty;

            if (!modifiedPathTrailingSlash.StartsWith(@"\"))
            {
                modifiedPathPrecedingSlash = @"\" + modifiedPathTrailingSlash;
            }

            return modifiedPathPrecedingSlash;
        }

        /// <summary>
        /// Gets the folder path containing either the web.config (i.e., in a web application) or the app.config (i.e., in a console/client application)..
        /// </summary>
        /// <returns></returns>
        private static string GetConfigPath()
        {
            //Doing the following does not work at all!
            //try
            //{
            //     fileInfo = HttpContext.Current == null ?
            //        new FileInfo(ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).FilePath)
            //        : new FileInfo(WebConfigurationManager.OpenWebConfiguration("~").FilePath);
            //}
            //catch (Exception exception)
            //{
            //}

            FileInfo fileInfo = new FileInfo(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            return fileInfo.Directory.FullName;
        }

        #endregion Methods
    }
}