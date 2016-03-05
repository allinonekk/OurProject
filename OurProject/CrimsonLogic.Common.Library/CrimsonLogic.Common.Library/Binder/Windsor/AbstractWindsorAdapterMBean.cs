namespace AllInOne.Common.Library.Binder.Windsor
{
    /// <summary>
    /// Standard MBean implementation.
    /// </summary>
    public interface AbstractWindsorAdapterMBean
    {
        #region Properties

        /// <summary>
        /// Gets the component instance count.
        /// </summary>
        /// <value>The component instance count.</value>
        int ComponentInstanceCount
        {
            get;
        }

        #endregion Properties
    }
}