namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.Abstract;


    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class NumberOfJudgeAssignDetailEntity : AbstractCaseInfo, IBackEndSpecificEntity
    {
        #region Properties


        /// <summary>
        /// Gets or sets the number of judge assign detail id.
        /// </summary>
        /// <value>The number of judge assign detail id.</value>
        public string NumberOfJudgeAssignDetailId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the sub case info id.
        /// </summary>
        /// <value>The sub case info id.</value>
        public Int64? SubCaseInfoId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the item no.
        /// </summary>
        /// <value>The item no.</value>
        public Int64 ItemNo
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the number of judge count.
        /// </summary>
        /// <value>The number of judge count.</value>
        public Int64 NumberOfJudgeCount
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the assign status.
        /// </summary>
        /// <value>The assign status.</value>
        public JudgeAssignStatus AssignStatus
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>The created by.</value>
        public string CreatedBy
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>The created date.</value>
        public DateTime CreatedDate
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the confirmed by.
        /// </summary>
        /// <value>The confirmed by.</value>
        public string ConfirmedBy
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the confirmed date.
        /// </summary>
        /// <value>The confirmed date.</value>
        public DateTime? ConfirmedDate
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the workflow serial no.
        /// </summary>
        /// <value>The workflow serial no.</value>
        public string WorkflowSerialNo
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the remarks.
        /// </summary>
        /// <value>The remarks.</value>
        public string Remarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the track.
        /// </summary>
        /// <value>The track.</value>
        public Int64 Track
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the name of the JLC.
        /// </summary>
        /// <value>The name of the JLC.</value>
        public string JLCName
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the facts JLC.
        /// </summary>
        /// <value>The facts JLC.</value>
        public string FactsJLC
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the issues JLC.
        /// </summary>
        /// <value>The issues JLC.</value>
        public string IssuesJLC
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the proc hist JLC.
        /// </summary>
        /// <value>The proc hist JLC.</value>
        public string ProcHistJLC
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the is JLC.
        /// </summary>
        /// <value>The is JLC.</value>
        public YesNo IsJLC
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is heardby5 judge.
        /// </summary>
        /// <value>
        /// The is heardby5 judge.
        /// </value>
        public YesNo IsHeardby5Judge  
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
            NumberOfJudgeAssignDetailEntity toCompareWith = obj as NumberOfJudgeAssignDetailEntity;
            return toCompareWith == null ? false : ((this.NumberOfJudgeAssignDetailId == toCompareWith.NumberOfJudgeAssignDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NumberOfJudgeAssignDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}