namespace AllInOne.Common.Library.Object
{
    using System;
    using System.Reflection;

    using log4net;

    /// <summary>
    /// Manages the lifecycle of the instance with the following stages:
    /// <li>
    /// <ol>Init - initialises the object with the appropriate resources.</ol>
    /// <ol>Start - starts any services that the object is maintaining.</ol>
    /// <ol>Stop - stops any services that the object is maintaining.</ol>
    /// <ol>Cleanup - releases any resources that the object is holding onto.</ol>
    /// </li>
    /// </summary>
    public sealed class ObjectLifeCycler
    {
        #region Fields

        private static readonly string[] CleanupMethods = new []{ "Cleanup" };
        private static readonly string[] InitMethods = new[] { "Init" };

        /// <summary>
        /// Logging instance.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ObjectLifeCycler));
        private static readonly string[] StartMethods = new[] { "Start" };
        private static readonly string[] StopMethods = new[] { "Stop" };

        #endregion Fields

        #region Methods

        /// <summary>
        /// Cleanups the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public void Cleanup(object instance)
        {
            if (instance == null)
            {
                return;
            }

            foreach (string cleanupMethod in CleanupMethods)
            {
                MethodInfo methodInfo = instance.GetType().GetMethod(cleanupMethod);
                if (methodInfo == null)
                {
                    continue;
                }

                try
                {
                    if (Logger.IsDebugEnabled)
                    {
                        Logger.DebugFormat("Invoking {0} method on instance ({1})", cleanupMethod, instance);
                    }
                    methodInfo.Invoke(instance, new object[] { });
                }
                catch (Exception ex)
                {
                    Logger.Error("Problem invoking cleanup method (" + cleanupMethod + ") on instance-" + instance, ex);
                }
                break;
            }
        }

        /// <summary>
        /// Inits the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public void Init(object instance)
        {
            if (instance == null)
            {
                return;
            }

            foreach (string initMethod in InitMethods)
            {
                MethodInfo methodInfo = instance.GetType().GetMethod(initMethod);
                if (methodInfo == null)
                {
                    continue;
                }

                try
                {
                    if (Logger.IsDebugEnabled)
                    {
                        Logger.DebugFormat("Invoking {0} method on instance ({1})", initMethod, instance);
                    }
                    methodInfo.Invoke(instance, new object[] { });
                }
                catch (Exception ex)
                {
                    Logger.Error("Problem invoking init method (" + initMethod + ") on instance-" + instance, ex);
                }
                break;
            }
        }

        /// <summary>
        /// Starts the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public void Start(object instance)
        {
            if (instance == null)
            {
                return;
            }

            foreach (string startMethod in StartMethods)
            {
                MethodInfo methodInfo = instance.GetType().GetMethod(startMethod);
                if (methodInfo == null)
                {
                    continue;
                }

                try
                {
                    if (Logger.IsDebugEnabled)
                    {
                        Logger.DebugFormat("Invoking {0} method on instance ({1})", startMethod, instance);
                    }
                    methodInfo.Invoke(instance, new object[] { });
                }
                catch (Exception ex)
                {
                    Logger.Error("Problem invoking start method (" + startMethod + ") on instance-" + instance, ex);
                }
                break;
            }
        }

        /// <summary>
        /// Stops the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public void Stop(object instance)
        {
            if (instance == null)
            {
                return;
            }

            foreach (string stopMethod in StopMethods)
            {
                MethodInfo methodInfo = instance.GetType().GetMethod(stopMethod);
                if (methodInfo == null)
                {
                    continue;
                }

                try
                {
                    if (Logger.IsDebugEnabled)
                    {
                        Logger.DebugFormat("Invoking {0} method on instance ({1})", stopMethod, instance);
                    }
                    methodInfo.Invoke(instance, new object[] { });
                }
                catch (Exception ex)
                {
                    Logger.Error("Problem invoking stop method (" + stopMethod + ") on instance-" + instance, ex);
                }
                break;
            }
        }

        #endregion Methods
    }
}