namespace CrimsonLogic.Common.Library.Tests
{
    using System;

    [Serializable]
    class Stranger
    {
        #region Properties

        public string Name
        {
            get; set;
        }

        public Orphan Orphan
        {
            get; set;
        }

        #endregion Properties
    }
}