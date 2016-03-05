namespace AllInOne.Legal.Binder.BackEnd.Custom
{
    using System;
    using log4net;
   

    internal class AppDomainHandler
    {
        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(AppDomainHandler));

        #endregion Fields

        #region Constructors

        private AppDomainHandler()
        {
            //do nothing
        }

        #endregion Constructors

        #region Methods

        public static void Init(IBinder binder)
        {
            try
            {
                //First put in the IDocServices into the AppDomain
                //This is used by the IELS.AllInOne.EForms
                IDocServices docServices = binder.GetInstance<IDocServices>();
                if (Logger.IsDebugEnabled)
                {
                    Logger.DebugFormat("IDocServices instance: {0}", docServices);
                }

                AppDomain.CurrentDomain.SetData("IDocServices", docServices);

                //This is used by the IELS.AllInOne.CaseParty
                IFilingBrokerBackEnd filingBrokerBackEnd = binder.GetInstance<IFilingBrokerBackEnd>();

                if (Logger.IsDebugEnabled)
                {
                    Logger.DebugFormat("IFilingBrokerBackEnd instance: {0}", filingBrokerBackEnd);
                }
                AppDomain.CurrentDomain.SetData("IFilingBrokerBackEnd", filingBrokerBackEnd);

                //IOutgoingCorrespondence outgoingCorrespondence = binder.GetInstance<OutgoingCorrespondenceImpl>();

                //if (Logger.IsDebugEnabled)
                //{
                //    Logger.DebugFormat("IOutgoingCorrespondence 123 instance: {0}", outgoingCorrespondence);
                //}

                //AppDomain.CurrentDomain.SetData("IOutgoingCorrespondence", outgoingCorrespondence);
            }
            catch (Exception exception)
            {
                Logger.Error("Unknown problem encountered during AppDomain handling!", exception);
            }
        }

        #endregion Methods
    }
}