using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AllInOne.Legal.Domain.Abstract;

namespace AllInOne.Legal.Domain.Hospital
{
    [Serializable]
    public class PatientInfoEntity : AbstractAllInOne
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CannotCaneInd field.
        /// </summary>
        /// <value>The cannot cane ind.</value>
        public string PatientId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CapitalCaseInd field.
        /// </summary>
        /// <value>The CapitalCaseInd .</value>
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the EmailId field.
        /// </summary>
        /// <value>email Id.</value>
        public String EmailId
        {
            get;
            set;
        }
        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            PatientInfoEntity toCompareWith = obj as PatientInfoEntity;
            return toCompareWith == null ? false : ((this.PatientId == toCompareWith.PatientId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PatientId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}
