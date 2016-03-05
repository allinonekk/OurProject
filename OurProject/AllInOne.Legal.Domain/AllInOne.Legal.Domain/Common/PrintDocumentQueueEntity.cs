namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.PrintDocumentQueueEntity'</summary>
    [Serializable]
    public class PrintDocumentQueueEntity : AbstractSubmissionGroup, ICommonEntity
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

        /// <summary>Gets or sets the FilePath field. </summary>
        public System.String FilePath
        {
            get;
            set;
        }

        /// <summary>Gets or sets the JobType field. </summary>
        public System.String JobType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TargetPrinterName field. </summary>
        public System.String TargetPrinterName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Status field. </summary>
        public PrintStatus Status
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PrintRemarks field. </summary>
        public System.String PrintRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DocConversionRemarks field. </summary>
        public System.String DocConversionRemarks
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
            PrintDocumentQueueEntity toCompareWith = obj as PrintDocumentQueueEntity;
            return toCompareWith == null ? false : ((this.PrintDocumentQueueId == toCompareWith.PrintDocumentQueueId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PrintDocumentQueueId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}