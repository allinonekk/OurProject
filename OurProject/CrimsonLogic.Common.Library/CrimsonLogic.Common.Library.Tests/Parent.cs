namespace CrimsonLogic.Common.Library.Tests
{
    using System;

    [Serializable]
    class Parent
    {
        #region Properties

        public Child Child
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        #endregion Properties
    }
}