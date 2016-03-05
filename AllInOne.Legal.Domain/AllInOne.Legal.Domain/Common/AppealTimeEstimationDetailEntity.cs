namespace AllInOne.Legal.Domain.Common
{
    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using System;

    /// <summary>Class which represents the entity 'Common.AppealTimeEstimationDetailEntity'</summary>
    public class AppealTimeEstimationDetailEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the AppealTimeEstimationDetailId field. </summary>
        public System.String AppealTimeEstimationDetailId
        {
            get;
            set;
        }

       
        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public System.String CaseInfoId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the item no.
        /// </summary>
        /// <value>The item no.</value>
        public Int32 ItemNo
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the type of the party.
        /// </summary>
        /// <value>The type of the party.</value>
        public String PartyType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the lawfirm or party.
        /// </summary>
        /// <value>The name of the lawfirm or party.</value>
        public String LawfirmOrPartyName
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the name of the solicitor.
        /// </summary>
        /// <value>The name of the solicitor.</value>
        public String SolicitorName
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the time needed.
        /// </summary>
        /// <value>The time needed.</value>
        public Int32 TimeNeeded
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
            if(obj == null)
            {
                return false;
            }
            AppealTimeEstimationDetailEntity toCompareWith = obj as AppealTimeEstimationDetailEntity;
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