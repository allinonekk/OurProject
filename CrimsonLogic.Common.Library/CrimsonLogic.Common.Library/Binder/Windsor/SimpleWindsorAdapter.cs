namespace AllInOne.Common.Library.Binder.Windsor
{
    using System.IO;

    using Castle.Windsor;

    /// <summary>
    /// This is the simplest adaptation of the Castle Windsor Dependency Injection container.
    /// </summary>
    public class SimpleWindsorAdapter : AbstractWindsorAdapter
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleWindsorAdapter"/> class.
        /// </summary>
        public SimpleWindsorAdapter()
        {
            DoInitialise();
        }

        #endregion Constructors

        #region Methods

        protected override FileInfo DoGetConfigFilePath()
        {
            // Get configuration from the web.config or app.config
            return null;
        }

        protected override void DoInstall(IWindsorContainer container)
        {
            //do nothing - get all the components from the configuration file.
        }

        #endregion Methods
    }
}