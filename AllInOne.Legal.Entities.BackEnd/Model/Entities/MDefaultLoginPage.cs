
namespace AllInOne.Legal.Entities.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>Class which represents the entity 'Master.MDefaultLoginPage'</summary>
    public partial class MDefaultLoginPage : IMaster
    {

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MCourtType"/> class.</summary>
        public MDefaultLoginPage()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public virtual string LoginPageId { get; set; }
        public virtual string URL { get; set; }
        public virtual string Description { get; set; }
        public virtual string CourtID { get; set; }
        public virtual string ObsInd { get; set; }
        public virtual string LastModifiedBy { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }

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
            MDefaultLoginPage toCompareWith = obj as MDefaultLoginPage;
            return toCompareWith == null ? false : ((this.LoginPageId == toCompareWith.LoginPageId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LoginPageId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}