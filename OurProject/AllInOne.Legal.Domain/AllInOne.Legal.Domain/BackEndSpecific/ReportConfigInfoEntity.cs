#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for ReportConfigInfo.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   19/12/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: ReportConfigInfoEntity.cs
// Description: Represents a standard domain entity for ReportConfigInfo.
// </summary>
// <copyright file= "ReportConfigInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for ReportConfigInfo.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class ReportConfigInfoEntity : AbstractLastModified, IBackEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the BusinessRule field.
        /// </summary>
        /// <value>The business rule.</value>
        public String BusinessRule
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DayInTheMonth field.
        /// </summary>
        /// <value>The day in the month.</value>
        public Int32? DayInTheMonth
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DayInTheWeek field.
        /// </summary>
        /// <value>The day in the week.</value>
        public DayInTheWeek DayInTheWeek
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsNoEndDate field.
        /// </summary>
        /// <value>The is no end date.</value>
        public YesNo IsNoEndDate
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'BackEndSpecific.ReportConfigInfo.MSection - Master.MSection.ReportConfigInfos (m:1)'
        /// </summary>
        /// <value>The M section.</value>
        public MSectionEntity MSectionEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the obs ind.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ReportConfigInfoId field.
        /// </summary>
        /// <value>The report config info id.</value>
        public String ReportConfigInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ReportDescription field.
        /// </summary>
        /// <value>The report description.</value>
        public String ReportDescription
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ReportTitle field.
        /// </summary>
        /// <value>The report title.</value>
        public String ReportTitle
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ReportType field.
        /// </summary>
        /// <value>The type of the report.</value>
        public OnlineEnquiryReportType ReportType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SchedularEndDate field.
        /// </summary>
        /// <value>The schedular end date.</value>
        public DateTime? SchedularEndDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SchedulerInfo field.
        /// </summary>
        /// <value>The scheduler info.</value>
        public OnlineEnquirySchedulerInfo SchedulerInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SchedulerStartDate field.
        /// </summary>
        /// <value>The scheduler start date.</value>
        public DateTime SchedulerStartDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the URL field.
        /// </summary>
        /// <value>The URL.</value>
        public String URL
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
            ReportConfigInfoEntity toCompareWith = obj as ReportConfigInfoEntity;
            return toCompareWith == null ? false : ((this.ReportConfigInfoId == toCompareWith.ReportConfigInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ReportConfigInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}