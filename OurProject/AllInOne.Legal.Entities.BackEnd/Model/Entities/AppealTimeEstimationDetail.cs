namespace AllInOne.Legal.Entities.BackEnd
{
    using System;
    
    /// <summary>Class which represents the entity 'Common.AppealTimeEstimationDetail'</summary>
    public class AppealTimeEstimationDetail : ICommon
    {
        #region Properties

        /// <summary>Gets or sets the AppealTimeEstimationDetailId field. </summary>
        public virtual String AppealTimeEstimationDetailId
        {
            get;
            set;
        }


        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public virtual Int64 CaseInfoId
        {
            get;
            set;
        }

        public virtual String SubmissionGroupId
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the item no.
        /// </summary>
        /// <value>The item no.</value>
        public virtual Int32 ItemNo
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the type of the party.
        /// </summary>
        /// <value>The type of the party.</value>
        public virtual String PartyType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the lawfirm or party.
        /// </summary>
        /// <value>The name of the lawfirm or party.</value>
        public virtual String LawfirmOrPartyName
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the name of the solicitor.
        /// </summary>
        /// <value>The name of the solicitor.</value>
        public virtual String SolicitorName
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the time needed.
        /// </summary>
        /// <value>The time needed.</value>
        public virtual Int32 TimeNeeded
        {
            get;
            set;
        }

        public virtual String LastModifiedBy
        {
            get;
            set;
        }

        public virtual DateTime LastModifiedDate
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
            AppealTimeEstimationDetail toCompareWith = obj as AppealTimeEstimationDetail;
            return toCompareWith == null ? false : ((this.AppealTimeEstimationDetailId == toCompareWith.AppealTimeEstimationDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AppealTimeEstimationDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}