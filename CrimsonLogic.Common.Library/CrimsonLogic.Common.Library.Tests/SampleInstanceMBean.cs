namespace CrimsonLogic.Common.Library.Tests
{
    using System;
    using System.ComponentModel;

    using NetMX;

    public interface ValidInstanceMBean
    {
        #region Events

        [Description("Raised when counter value gets changed")]
        [MBeanNotification("sample.counter")]
        event EventHandler<NotificationEventArgs> CounterChanged;

        #endregion Events

        #region Properties

        [Description("Counter value")]
        int Counter
        {
            get; set;
        }

        #endregion Properties

        #region Methods

        [Description("Adds specified value to value of the counter")]
        void AddAmount(int amount);

        [Description("Sets counter value to 0")]
        void ResetCounter();

        #endregion Methods
    }

    public class ValidInstance : ValidInstanceMBean
    {
        #region Fields

        private int counter;
        private long sequenceNumber;

        #endregion Fields

        #region Events

        public event EventHandler<NotificationEventArgs> CounterChanged;

        #endregion Events

        #region Properties

        public int Counter
        {
            get
             {
            return counter;
             }
             set
             {
            counter = value;
            OnCounterChanged();
             }
        }

        #endregion Properties

        #region Methods

        public void AddAmount(int amount)
        {
            counter += amount;
             OnCounterChanged();
        }

        public void ResetCounter()
        {
            counter = 0;
             OnCounterChanged();
        }

        private void OnCounterChanged()
        {
            if (CounterChanged != null)
             {
            CounterChanged(this, new NotificationEventArgs("Counter changed", counter));
            sequenceNumber++;
             }
        }

        #endregion Methods
    }
}