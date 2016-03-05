namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.PrintDocumentQueueDetailEntity'</summary>
    [Serializable]
    public class PrintDocumentQueueDetailEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the PrintDocumentQueueId field. </summary>
        public System.String PrintDocumentQueueId
        {
            get;
            set; 
        }

        /// <summary>Gets or sets the DocId field. </summary>
        public System.String DocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SequenceNo field. </summary>
        public System.Int32 SequenceNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PrintDocumentQueueDetailID field. </summary>
        public System.String PrintDocumentQueueDetailID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DocumentRemarks field. </summary>
        public System.String DocumentRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public YesNo ObsInd
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
            PrintDocumentQueueDetailEntity toCompareWith = obj as PrintDocumentQueueDetailEntity;
            return toCompareWith == null ? false : ((this.PrintDocumentQueueDetailID == toCompareWith.PrintDocumentQueueDetailID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PrintDocumentQueueDetailID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}