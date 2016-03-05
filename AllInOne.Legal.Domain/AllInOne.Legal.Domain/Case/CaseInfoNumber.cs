#region Header

/*****************************************************************************************************
 * Description : This file represents a standard CaseInfoNumber entity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			        Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 01/Oct/2014               Yan Nai             	Created
 *****************************************************************************************************/

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'CaseInfo.CaseInfoNumber'</summary>
    [Serializable]
    public class CaseInfoNumberEntity : AbstractCaseInfo, ICaseEntity
    {
        #region Properties

        /// <summary>Gets or sets the Domain field. </summary>
        public System.String Domain
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
    }
}