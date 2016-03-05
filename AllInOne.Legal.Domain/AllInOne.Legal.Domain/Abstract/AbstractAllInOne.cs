using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllInOne.Legal.Domain.Abstract
{
  [Serializable]
    public abstract class AbstractAllInOne
    {

        #region Properties

        /// <summary>
        /// Gets or sets the LastModifiedBy field.
        /// </summary>
        /// <value>The last modified by.</value>
        public String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastModifiedDate field.
        /// </summary>
        /// <value>The last modified date.</value>
        public DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        #endregion Properties
    }
}
