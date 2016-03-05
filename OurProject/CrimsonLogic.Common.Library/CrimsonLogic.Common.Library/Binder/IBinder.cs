namespace AllInOne.Common.Library.Binder
{
    /// <summary>
    /// Main interface for binding all the components together in the FrontEnd MOSS. 
    /// Components may have the following life-cycle methods: (1) initialisation, (2) start, 
    /// (3) stop and (4) cleanup.
    /// <br/>
    /// A similar open source library can be found at <a href="http://commonservicelocator.codeplex.com/">CodePlex</a>
    ///  but it was not adopted since there is a need to customize the interface for internal usage. 
    /// However, the idea and principles for IOC Container abstraction are still valid.
    /// </summary>
    public interface IBinder
    {
        #region Methods

        /// <summary>
        /// Cleans up or releases all the resources prior to application cessation.
        /// Default method used for invocation is 'Cleanup'.
        /// Methods must have this signature 'public void Cleanup()'.
        /// </summary>
        void Cleanup();

        /// <summary>
        /// Gets an instance of the supplied interface paramter.
        /// </summary>
        /// <typeparam name="T">Interface class.</typeparam>
        /// <returns>Instance of the interface class or null if the service was not configured/wired.</returns>
        /// <exception cref="BinderException">Exception will be thrown if problems are encountered during the resolution of the type indicated.</exception>
        T GetInstance<T>();

        /// <summary>
        /// Releases/ends an instance. Invoking this on singleton instance will not have any effect. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        void ReleaseInstance<T>(T Object);

        /// <summary>
        /// Initialises all the components.
        /// This method is anticipated to be rarely used since most components should suffice with a Start method invocation.
        /// However, there could be conceivable situations where a component must be initialised prior to any invocation of the Start method.
        /// Default method used for invocation is 'Init'.
        /// Methods must have this signature 'public void Init()'.
        /// </summary>
        void Init();

        /// <summary>
        /// Starts all the components.
        /// Default method used for invocation is 'Start'.
        /// Methods must have this signature 'public void Start()'.
        /// </summary>
        void Start();

        /// <summary>
        /// Stops all the components.
        /// Default method used for invocation is 'Stop'.
        /// Methods must have this signature 'public void Stop()'.
        /// </summary>
        void Stop();

        #endregion Methods
    }
}