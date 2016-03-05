namespace AllInOne.BootStrapper.BackEnd
{
    using System;
    using System.Web;

    using log4net;

    

    /// <summary>
    /// Method to track unhandled exception.
    /// </summary>
    public class ExceptionHandlerModule : IHttpModule
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static ILog logger = LogManager.GetLogger(typeof(ExceptionHandlerModule));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Disposes the object.
        /// </summary>
        public void Dispose()
        {
        }

        /// <summary>
        /// Initializes a module and prepares it to handle requests.
        /// </summary>
        /// <param name="context">An <see cref="T:System.Web.HttpApplication"/> that provides access to the methods, properties, and events common to all application objects within an ASP.NET application</param>
        public void Init(HttpApplication context)
        {
            context.Error += new EventHandler(OnUnhandledException);
        }

        /// <summary>
        /// Called when [unhandled exception].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        public void OnUnhandledException(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
            HttpContext context = HttpContext.Current;
           // SPContext spContext = SPContext.GetContext(context);
            Exception exception = context.Server.GetLastError().GetBaseException();

            logger.Error("Unhandled error occurred - ", exception);

           // HttpContext.Current.Session.Add("OffendingURL", context.Web.Url + context.Request.Path);
            HttpContext.Current.Session.Add("ErrorUnhandledException", exception);

           // context.Response.Redirect(spContext.Web.Url + "/_layouts/IELS/Error/Error.aspx");
            context.Server.ClearError();
            context.Response.Clear();
        }

        #endregion Methods
    }
}