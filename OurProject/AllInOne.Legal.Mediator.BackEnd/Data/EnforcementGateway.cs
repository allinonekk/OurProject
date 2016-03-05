#region Header

/*****************************************************************************************************
* Description : This file handles calls to all the Mapping DTOs to Domain entities
* and Repository for database transaction.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			            Description
*-----------------------------------------------------------------------------------------------------
*   04/11/2010   		        Yan Nai                	 	Created
*****************************************************************************************************/
// <summary>
// File: EnforcementGateway.cs
// Description: This file handles calls to all the Mapping DTOs to Domain entities
// and Repository for database transaction.
// </summary>
// <copyright file= "EnforcementGateway.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data;
    using System.Data.SqlClient;
    using System.Configuration;

    using AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper;
    using AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.LAP;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.CaseSpecific;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.Enforcement;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.LawFirm;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.SubCase;
    using AllInOne.Legal.Domain.SubCaseSpecific;
    using AllInOne.Legal.Domain.Subsequent;
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Repositories.BackEnd;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;

    public static class EnforcementGatewayExtension
    {
        #region Methods

        /// <summary>
        /// Get the list which contain the Unique vlaue on specified field.
        /// </summary>
        /// <typeparam name="TSource">The type of the collection.</typeparam>
        /// <typeparam name="VSource">The type of the selector.</typeparam>
        /// <param name="collection">A sequence in which to check to have unque values only.</param>        
        /// <param name="selector">A selector to be used while check of uniquness.</param>
        /// <returns>Collection of <typeparamref name="TSource"/></returns>
        public static IEnumerable<TSource> FilterUniqueByValue<TSource, VSource>(this IEnumerable<TSource> collection, Func<TSource, VSource> selector)
            where TSource : class
        {
            if (!collection.HasContent())
                return new List<TSource>();
            else
            {
                List<TSource> newList = new List<TSource>();
                VSource pKey;
                foreach (TSource t in collection)
                {
                    pKey = selector(t);
                    if (pKey != null && (!newList.HasContent() || newList.Where(newObj => selector(newObj).Equals(pKey)).Count() == 0))
                        newList.Add(t);
                }
                return newList;
            }
        }

        /// <summary>
        /// Determin if the IEnumerable is null or zero in Count.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="genericList">A sequence in which to check if there is at least a value.</param>
        /// <returns>bool</returns>
        public static Boolean HasContent<TSource>(this IEnumerable<TSource> genericList)
        {
            if (genericList == null || genericList.Count() < 1)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Determine if a type is implementing the interface
        /// </summary>
        /// <param name="type">base type to be checked.</param>
        /// <param name="interfaceType">interface type to check against.</param>
        /// <returns>true if implementing, otherwise false.</returns>
        public static bool IsInterfaceImplementOf(this Type type, Type interfaceType)
        {
            return type.GetInterfaces().Any(interfaceType.Equals);
        }

        #endregion Methods
    }

    internal class EnforcementGateway : AbstractGateway
    {
        #region Constructors

        internal EnforcementGateway(ISession session)
            : base(session)
        {
        }

        internal EnforcementGateway()
            : base()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Get DataTable base on passed SQL Stored Procedure.
        /// </summary>
        /// <param name="dataRetrievalSqlQuery">SQL Query</param>
        /// <returns></returns>
        public DataTable GetDataOnSQLQuery(string dataRetrievalSqlQuery)
        {
            return this.GetDataOnSQLQuery(dataRetrievalSqlQuery, CommandType.Text);
        }

        /// <summary>
        /// Get DataTable base on passed SQL Query.
        /// </summary>
        /// <param name="dataRetrievalSqlQuery">SQL Query</param>
        /// <returns></returns>
        public DataTable GetDataOnSQLQuery(string dataRetrievalSqlQuery, CommandType commandType)
        {//BUG-ENFUAT-2013082002 - Mantis:0010073
            //string connString = "Server=192.168.32.105; Initial Catalog=IELSSUV12; Trusted_Connection=false; User Id=sqluser; Password=Pass1234"; //;this.applicationSession.Connection.ConnectionString;
            string connStringName = "IELS";
            string connString = ConfigurationManager.ConnectionStrings[connStringName].ConnectionString;
            if (string.IsNullOrEmpty(connString))
            {
                throw new ArgumentNullException("connectionString should not be null.");
            }

            if (string.IsNullOrEmpty(dataRetrievalSqlQuery))
            {
                throw new ArgumentNullException("dataRetrievalSqlQuery should not be null.");
            }

            // Populate the DataTable based on the sql query.
            var dataTable = new DataTable();

            using (var connection = new SqlConnection(connString))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = dataRetrievalSqlQuery;
                    command.CommandType = commandType;

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        /// <summary>
        /// Add Grouping to the existing DetachedCriteria.
        /// </summary>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="fieldName">The name of the field.</param>
        /// <param name="direction">Indicate ASC or DESC.</param>
        /// <returns>DetachedCriteria associated with Order By.</returns>
        internal void AddGroupBy(DetachedCriteria detachedCriteria, List<string> fieldNames)
        {
            if (detachedCriteria == null || !fieldNames.HasContent())
                return;

            ProjectionList projectList = Projections.ProjectionList();
            // group by
            projectList.Add(Projections.GroupProperty(fieldNames.First()));
            // alias of the column head
            projectList.Add(Projections.Alias(Projections.RowCount(), "count"));

            detachedCriteria.SetProjection(projectList);
        }

        /// <summary>
        /// Add Sorting to the existing DetachedCriteria.
        /// </summary>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="fieldName">The name of the field.</param>
        /// <param name="direction">Indicate ASC or DESC.</param>
        /// <returns>DetachedCriteria associated with Order By.</returns>
        internal void AddOrderBy(DetachedCriteria detachedCriteria, string fieldName, SortingDirection direction)
        {
            if (detachedCriteria == null || string.IsNullOrEmpty(fieldName) || direction == SortingDirection.Null)
                return;

            if (direction == SortingDirection.ASC) //default to ASC
                detachedCriteria.AddOrder(Order.Asc(fieldName));
            else if (direction == SortingDirection.DESC)
                detachedCriteria.AddOrder(Order.Desc(fieldName));
        }

        /// <summary>
        /// Add Paging to the existing DetachedCriteria.
        /// </summary>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="rows">Number of rows to retrieve.</param>
        /// <param name="pageIndex">Current page index.</param>
        internal void AddPaging(DetachedCriteria detachedCriteria, int rows, int pageIndex)
        {
            if (detachedCriteria == null)
                return;

            detachedCriteria.SetFirstResult(rows * pageIndex)
                            .SetMaxResults(rows);
        }

        /// <summary>
        /// Add to filter not fetching data if ObsInd Y.
        /// </summary>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="value">value.</param> 
        internal void AddObsInd(DetachedCriteria detachedCriteria, string value)
        {
            if (detachedCriteria == null)
                return;

            detachedCriteria.Add(Expression.Eq("ObsInd", "N"));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="apptType"></param>
        /// <param name="bailiffId"></param>
        /// <param name="team"></param>
        /// <param name="isNoAppt"></param>
        /// <param name="currentPageNo"></param>
        /// <param name="pageRecordsCount"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        internal List<object> BindAssignBailiffsGrid(string fromDate, string toDate, string apptType, string bailiffId, string team, bool isNoAppt, int currentPageNo, int pageRecordsCount, out int count)
        {
           return BindAssignBailiffsGrid(fromDate, toDate, apptType, bailiffId, team, isNoAppt, currentPageNo, pageRecordsCount, string.Empty, out count);        
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="apptType"></param>
        /// <param name="bailiffId"></param>
        /// <param name="team"></param>
        /// <param name="isNoAppt"></param>
        /// <param name="currentPageNo"></param>
        /// <param name="pageRecordsCount"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        internal List<object> BindAssignBailiffsGrid(string fromDate, string toDate, string apptType, string bailiffId, string team, bool isNoAppt, int currentPageNo, int pageRecordsCount, string courtId, out int count)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"SELECT
                        EA.EMSAppointmentId, EA.ApptDateTime , EA.ApptTypeCode ,
                        M.Description , S.SubCaseNo, S.SubCaseInfoId ,
                        C.CaseNo , C.CaseInfoId , U.UserName , max(MS.sectionName) as sectionName , U.UserId, C.CaseType, S.SubCaseType                      
                        FROM EMSAppointment EA
                        JOIN EMSAccount A on EA.EMSAccountId = A.EMSAccountId ");
            sb.Append(this.GetForumBaseCaseInfo(courtId));
            sb.Append(@"LEFT OUTER JOIN SubCaseInfo S On A.SubCaseInfoId = S.SubCaseInfoId
                        LEFT OUTER JOIN MEMSApptType M  On M.EMSApptTypeCode = EA.ApptTypeCode
                        LEFT OUTER JOIN Users U on U.UserId = EA.BailiffId
                        LEFT OUTER JOIN RUserRoleSection R On R.UserId = EA.BailiffId
                        LEFT OUTER JOIN MSections MS On MS.SectionCode = R.SectionCode
                        WHERE A.ObsInd = 'N' And EA.ObsInd = 'N' AND EA.ApptOutcomeCode IS NULL AND EA.IsHidden ='N'
                        AND R.RoleCode IN ('RENF1','RENF2','RENF3')
                        AND (MS.SectionDescription IN ('EMSBailiffSupervisorGroup','EMSBailiffTeamGroup','EMSFinanceGroup') OR
                        EA.BailiffId IS NULL)");

            if (!isNoAppt)
            {
                if (!string.IsNullOrEmpty(fromDate) && !string.IsNullOrEmpty(toDate))
                {
                    sb.Append(" And EA.ApptDateTime between '" + fromDate + @"' and '" + toDate + @"' ");
                }
                else //if date is not entered, then search records from current date onwards.
                {
                    sb.Append(" And EA.ApptDateTime between '" + DateTime.Today.ToShortDateString() + @"' and '" + DateTime.MaxValue.ToShortDateString() + @"' ");
                }
            }

            if (!string.IsNullOrEmpty(apptType))
            {
                sb.Append(" And EA.ApptTypeCode = '" + apptType + @"' ");
            }
            if (!string.IsNullOrEmpty(bailiffId))
            {
                sb.Append(" And EA.BailiffId = '" + bailiffId + @"' ");
            }
            if (!string.IsNullOrEmpty(team))
            {
                sb.Append(" And MS.SectionCode = '" + team + @"' ");
            }
            if (!isNoAppt)
            {
                sb.Append(" And EA.ApptDateTime is not null ");
            }
            else
            {
                sb.Append(" And EA.ApptDateTime is null ");
            }

            sb.Append(@" GROUP BY  EA.EMSAppointmentId, EA.ApptDateTime , EA.ApptTypeCode, M.Description , S.SubCaseNo, S.SubCaseInfoId ,
                        C.CaseNo , C.CaseInfoId , U.UserName , U.UserId, C.CaseType, S.SubCaseType  ");
            sb.Append(" Order by EA.ApptDateTime Desc");

            IQuery queryCount = applicationSession.CreateSQLQuery(sb.ToString());
            count = queryCount.List().Count;
            IQuery query = applicationSession.CreateSQLQuery(sb.ToString()).SetFirstResult((currentPageNo - 1) * pageRecordsCount)
                             .SetMaxResults(pageRecordsCount);

            List<object> listPagedResult = query.List<object>().ToList();
            if (listPagedResult.Count > 0 && listPagedResult != null)
            {
                return listPagedResult;
            }
            else
                return null;
        }

        /// <summary>
        /// To return FORUM base CaseInfo for existing implementation and new FJC implementation
        /// </summary>
        /// <param name="courtId"></param>
        /// <returns></returns>
        private string GetForumBaseCaseInfo(string courtId)
        {
            if (string.IsNullOrEmpty(courtId))
                return "JOIN CaseInfo C ON A.CaseInfoId = C.CaseInfoId ";
            else
                return string.Format("JOIN CaseInfo C ON A.CaseInfoId = C.CaseInfoId AND C.ForumId in (SELECT ForumId FROM MForumType Where CourtId = '{0}') ", courtId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="caseInfoId"></param>
        /// <param name="currentPageNo"></param>
        /// <param name="pageRecordsCount"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        internal List<object> GetNOADetails(string caseInfoId, int currentPageNo, int pageRecordsCount, out int count)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"Select  NatureOfApplication.NatureOfApplicationId,NatureOfApplication.CaseInfoID,  NatureOfApplication.SubCaseInfoID, CaseInfo.CaseNo, SubCaseInfo.SubCaseNo,  MNOACode.Description as NatureOfApp
                        from NatureOfApplication 
                        INNER JOIN CaseInfo on CaseInfo.CaseInfoID = NatureOfApplication.CaseInfoID
                        INNER JOIN SubCaseInfo on SubCaseInfo.SubCaseInfoID = NatureOfApplication.SubCaseInfoID
                        INNER JOIN MNOACode on MNOACode.NOACode = NatureOfApplication.NOACode
                        where NatureOfApplication.NOACode in ('SUMPAYINS','SUMSEJO') ");            
            sb.Append(" AND NatureOfApplication.CaseInfoID = '" + caseInfoId + @"' ");
            sb.Append(" order by CaseInfoID desc ");

            IQuery queryCount = applicationSession.CreateSQLQuery(sb.ToString());
            count = queryCount.List().Count;
            IQuery query = applicationSession.CreateSQLQuery(sb.ToString()).SetFirstResult((currentPageNo - 1) * pageRecordsCount)
                             .SetMaxResults(pageRecordsCount);

            List<object> listPagedResult = query.List<object>().ToList();
            if (listPagedResult.Count > 0 && listPagedResult != null)
            {
                return listPagedResult;
            }
            else
                return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subCaseInfoId"></param>
        /// <param name="currentPageNo"></param>
        /// <param name="pageRecordsCount"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        internal List<object> GetExecutionAddressDetails(string subCaseInfoId, int currentPageNo, int pageRecordsCount, out int count)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@" Select WOE.WOECaseExecutionAddressId,WOE.Address,WOE.CaseInfoId,WOE.SubCaseInfoId,CaseInfo.CaseNo,SubCaseInfo.SubCaseNo 
                            from WOECaseExecutionAddress WOE 
                            JOIN  WOECaseExecutionAddress EA on WOE.PostalCode = EA.PostalCode
                            JOIN CaseInfo on WOE.CaseInfoId=CaseInfo.CaseInfoID
                            LEFT OUTER JOIN SubCaseInfo on WOE.SubCaseInfoId=SubCaseInfo.SubCaseInfoID
                            Where EA.ItemNo='1' ");
            sb.Append(" And EA.SubCaseInfoId= '" + subCaseInfoId + @"' ");
            sb.Append(" And WOE.SubCaseInfoId != '" + subCaseInfoId + @"' ");
            sb.Append(" order by CaseInfo.CaseInfoID, SubCaseInfo.SubCaseInfoID  ");

            IQuery queryCount = applicationSession.CreateSQLQuery(sb.ToString());
            count = queryCount.List().Count;
            IQuery query = applicationSession.CreateSQLQuery(sb.ToString()).SetFirstResult((currentPageNo - 1) * pageRecordsCount)
                             .SetMaxResults(pageRecordsCount);

            List<object> listPagedResult = query.List<object>().ToList();
            if (listPagedResult.Count > 0 && listPagedResult != null)
            {
                return listPagedResult;
            }
            else
                return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="caseInfoId"></param>
        /// <param name="subCaseInfoId"></param>
        /// <param name="currentPageNo"></param>
        /// <param name="pageRecordsCount"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        internal List<object> GetEnquiryDetails(string key, string caseInfoId, string subCaseInfoId, int currentPageNo, int pageRecordsCount, out int count, List<string> ISSubCaseIds)
        {
            StringBuilder sb = new StringBuilder();
            switch (key)
            {
                case "subcaseinfo":
                    {
                        if (!string.IsNullOrEmpty(subCaseInfoId))
                        {
                            sb.Append(@"SELECT SubCaseInfo.SubCaseNo, SubCaseInfo.SubCaseYear, isNull(Convert(Varchar(30),DocumentInfo.FilingDateTime), 'NA') as FilingDateTime,
                                     max(case when SubCaseParty.SubCasePartyTypeCode='EC' then 
                                    Case When (CaseParty.FullName is NOT null AND  CaseParty.FullName != '' ) then CaseParty.FullName  
                                    When (CaseParty.FullName is null OR  CaseParty.FullName = '' ) then CaseParty.CompanyName  end
                                    else '' end ) as EC,
                                    max(case when SubCaseParty.SubCasePartyTypeCode='ED' then 
                                     Case When (CaseParty.FullName is NOT null AND  CaseParty.FullName != '' ) then CaseParty.FullName  
                                    When (CaseParty.FullName is null OR  CaseParty.FullName = '' ) then CaseParty.CompanyName  end
                                     else '' end ) as ED,
                                    Users.UserName as Bailiff, EMSAppointment.ApptDateTime
                                    from SubCaseInfo   
                                    INNER JOIN CaseInfo on CaseInfo.CaseInfoID=SubCaseInfo.CaseInfoID  
                                    INNER JOIN DocumentInfo on DocumentInfo.SubCaseInfoId=SubCaseInfo.SubCaseInfoID and CaseInfo.CaseInfoID = DocumentInfo.CaseInfoId  
                                    INNER JOIN SubCaseParty on SubCaseParty.SubCaseInfoID = SubCaseInfo.SubCaseInfoID 
                                    INNER JOIN CaseParty on CaseParty.CasePartyID = SubCaseParty.CasePartyID
                                    INNER JOIN EMSAccount on EMSAccount.SubCaseInfoId =  SubCaseInfo.SubCaseInfoID and EMSAccount.CaseInfoId = CaseInfo.CaseInfoID
                                    INNER JOIN EMSAppointment on EMSAppointment.EMSAccountId = EMSAccount.EMSAccountId AND EMSAppointment.DocId = DocumentInfo.DOCID
                                    LEFT OUTER JOIN Users on Users.UserId = EMSAppointment.BailiffId
                                    WHERE DocumentInfo.ObsInd='N' AND EMSAppointment.IsHidden!='Y' 
                                    AND SubCaseParty.SubCasePartyTypeCode IN ('EC','ED') ");


                            sb.Append(" AND SubCaseInfo.SubCaseInfoID= '" + subCaseInfoId + @"' ");
                            sb.Append(@" GROUP BY SubCaseInfo.SubCaseNo ,SubCaseInfo.SubCaseYear,DocumentInfo.FilingDateTime,
                                    Users.UserName,  EMSAppointment.ApptDateTime
                                    ORDER BY DocumentInfo.FilingDateTime ");
                        }

                        else
                        {
                            sb.Append(@"SELECT CaseInfo.CaseNo, CaseInfo.CaseYear, isNull(Convert(Varchar(30),DocumentInfo.FilingDateTime), 'NA'),
                                max(case when CaseParty.PartyTypeCode='EC' then COALESCE(CaseParty.FullName,CaseParty.CompanyName) else '' end ) as EC,
                                max(case when CaseParty.PartyTypeCode='ED' then COALESCE(CaseParty.FullName,CaseParty.CompanyName) else '' end ) as ED,
                                max(case when CaseParty.PartyTypeCode='SUTY' then COALESCE(CaseParty.FullName,CaseParty.CompanyName) else '' end ) as SUTY,
                                Users.UserName as Bailiff, EMSAppointment.ApptDateTime
                                 from CaseInfo   
                                 INNER JOIN DocumentInfo on  DocumentInfo.CaseInfoId   = CaseInfo.CaseInfoID  
                                 INNER JOIN CaseParty on CaseParty.CaseInfoID= CaseInfo.CaseInfoID
                                 INNER JOIN EMSAccount on EMSAccount.CaseInfoId = CaseInfo.CaseInfoID
                                 INNER JOIN EMSAppointment on EMSAppointment.EMSAccountId = EMSAccount.EMSAccountId AND EMSAppointment.DocId = DocumentInfo.DOCID
                                 LEFT OUTER JOIN Users on Users.UserId = EMSAppointment.BailiffId
                                 WHERE DocumentInfo.ObsInd='N' AND EMSAppointment.IsHidden!='Y' 
                                 AND CaseParty.PartyTypeCode IN ('EC','ED','SUTY') ");


                            sb.Append(" AND  CaseInfo.CaseInfoID = '" + caseInfoId + @"' ");
                            sb.Append(@" GROUP BY CaseInfo.CaseNo ,CaseInfo.CaseYear,DocumentInfo.FilingDateTime,
                                        Users.UserName,  EMSAppointment.ApptDateTime
                                        ORDER BY DocumentInfo.FilingDateTime ");
                        }
                        break;
                    }
                case "appointment":
                    {
                        if (!string.IsNullOrEmpty(subCaseInfoId))
                        {
                            sb.Append(@"SELECT MEMSApptType.Description as ApptType, Convert(Varchar(30),EMSAppointment.ApptDateTime) as ApptDateTime, EMSAppointment.ExecAddress as Address, 
                                   MEMSApptOutcome.Description as ApptOutCome,MEMSApptReason.Description as ApptReason, 
                                    Convert(Varchar(30),EMSCivCrmSeizure.EstValue) as Amount, EMSCivCrmSeizure.ItemsSeized as NoItemsSeized 
                                   FROM SubCaseInfo
                                   INNER JOIN EMSAccount on EMSAccount.SubCaseInfoId = SubCaseInfo.SubCaseInfoID
                                   INNER JOIN EMSAppointment on EMSAppointment.EMSAccountId = EMSAccount.EMSAccountId
                                   INNER JOIN WOECaseExecutionAddress on WOECaseExecutionAddress.SubCaseInfoId = SubCaseInfo.SubCaseInfoID
                                   LEFT OUTER JOIN MEMSApptType on MEMSApptType.EMSApptTypeCode = EMSAppointment.ApptTypeCode
                                   LEFT OUTER JOIN MEMSApptOutcome on MEMSApptOutcome.EMSApptOutcomeCode = EMSAppointment.ApptOutcomeCode
                                   LEFT OUTER JOIN MEMSApptReason on MEMSApptReason.EMSApptReasonCode = EMSAppointment.ApptReasonCode 
                                   LEFT OUTER JOIN EMSCivCrmSeizure on EMSCivCrmSeizure.EMSAppointmentId = EMSAppointment.EMSAppointmentId 
                                   WHERE EMSAppointment.IsHidden !='Y'  AND EMSAppointment.ObsInd='N' ");


                            sb.Append(" AND SubCaseInfo.SubCaseInfoID = '" + subCaseInfoId + @"' ");
                            sb.Append(@" GROUP BY MEMSApptType.Description, EMSAppointment.ApptDateTime, EMSAppointment.ExecAddress, 
                                    MEMSApptOutcome.Description,MEMSApptReason.Description, EMSCivCrmSeizure.EstValue,EMSCivCrmSeizure.ItemsSeized
                                    ORDER BY EMSAppointment.ApptDateTime ");
                        }
                        else
                        {
                            sb.Append(@"SELECT MEMSApptType.Description as ApptType, Convert(Varchar(30),EMSAppointment.ApptDateTime) as ApptDateTime, EMSAppointment.ExecAddress as Address, 
                                       MEMSApptOutcome.Description as ApptOutCome,MEMSApptReason.Description ApptReason
                                       FROM CaseInfo
                                       INNER JOIN EMSAccount on EMSAccount.CaseInfoId = CaseInfo.CaseInfoID
                                       INNER JOIN EMSAppointment on EMSAppointment.EMSAccountId = EMSAccount.EMSAccountId
                                       INNER JOIN WOECaseExecutionAddress on WOECaseExecutionAddress.CaseInfoId = CaseInfo.CaseInfoID
                                       LEFT OUTER JOIN MEMSApptType on MEMSApptType.EMSApptTypeCode = EMSAppointment.ApptTypeCode
                                       LEFT OUTER JOIN MEMSApptOutcome on MEMSApptOutcome.EMSApptOutcomeCode = EMSAppointment.ApptOutcomeCode
                                       LEFT OUTER JOIN MEMSApptReason on MEMSApptReason.EMSApptReasonCode = EMSAppointment.ApptReasonCode
                                       WHERE EMSAppointment.IsHidden !='Y' AND EMSAppointment.ObsInd='N'
                                       ");


                            sb.Append(" AND CaseInfo.CaseInfoID= '" + caseInfoId + @"' ");
                            sb.Append(@" GROUP BY MEMSApptType.Description, EMSAppointment.ApptDateTime, EMSAppointment.ExecAddress, 
                                       MEMSApptOutcome.Description,MEMSApptReason.Description 
                                        ORDER BY EMSAppointment.ApptDateTime ");

                        }


                        break;
                    }
                case "sale":
                    {
                        if (!string.IsNullOrEmpty(subCaseInfoId))
                        {
                            //BUG-ENFUAT-2013071112 - Mantis:0009672 : Comment below and re-factor to support new design of EMS Sale Auctioneer.
                            /*sb.Append(@"SELECT  Convert(Varchar(30),EMSSale.SaleDateTime) as SaleDateTime, WOECaseExecutionAddress.Address, 
                                       MEMSApptOutcome.Description as ApptOutCome, 
                                       max(case when EMSSale.ConductedBy='B' then Users.UserName else MEMSAuctioneer.AuctioneerName end ) as BailiffAuctioneer   
                                       FROM EMSSale   
                                       INNER JOIN EMSAppointment on EMSAppointment.EMSAppointmentId= EMSSale.EMSAppointmentId
                                       INNER JOIN EMSAccount on EMSAccount.EMSAccountId = EMSSale.EMSAccountId
                                       INNER JOIN SubCaseInfo on SubCaseInfo.SubCaseInfoID = EMSAccount.SubCaseInfoId
                                       INNER JOIN WOECaseExecutionAddress on WOECaseExecutionAddress.SubCaseInfoId = SubCaseInfo.SubCaseInfoID   
                                       LEFT OUTER JOIN MEMSApptOutcome on MEMSApptOutcome.EMSApptOutcomeCode = EMSAppointment.ApptOutcomeCode
                                       LEFT OUTER JOIN MEMSAuctioneer on MEMSAuctioneer.EMSAuctioneerCode = EMSSale.Auctioneer
                                       LEFT OUTER JOIN Users on Users.UserId= EMSAppointment.BailiffId 
                                       WHERE EMSAppointment.IsHidden !='Y' 
                                       AND EMSAppointment.ObsInd='N' and EMSSale.ObsInd = 'N' ");


                            sb.Append(" AND SubCaseInfo.SubCaseInfoID = '" + subCaseInfoId + @"' ");
                            sb.Append(@" GROUP BY  EMSSale.SaleDateTime, WOECaseExecutionAddress.Address, MEMSApptOutcome.Description 
                                        ORDER BY EMSSale.SaleDateTime ");*/
                            sb.Append(@" SELECT Result.SaleDateTime, Result.Address,Result.ApptOutCome,
                                        max(case when Result.ConductedBy='B' then Result.UserName else Result.TBailiffAuctioneer end ) as BailiffAuctioneer
                                        FROM (
                                            SELECT Convert(Varchar(30),EMSSale.SaleDateTime) as SaleDateTime, WOECaseExecutionAddress.Address, 
                                            MEMSApptOutcome.Description as ApptOutCome,  
                                            stuff( 
                                                (SELECT  ', '+ a.AuctioneerName 
                                                   FROM EMSSale s
                                                   INNER JOIN EMSAppointment ap 
                                                   on ap.EMSAppointmentId= s.EMSAppointmentId
                                                      and ap.IsHidden != 'Y' 
                                                      and ap.ObsInd = 'N'
                                                   LEFT OUTER JOIN EMSSaleAuctioneer sa on s.EMSSaleId = sa.EMSSaleId
                                                   LEFT OUTER JOIN MEMSAuctioneer a on a.EMSAuctioneerCode = sa.Auctioneer
                                                   WHERE s.SaleDateTime = EMSSale.SaleDateTime
                                                   ORDER BY AuctioneerName
                                                   FOR XML PATH(''), TYPE).value('.', 'varchar(max)')
                                                ,1,7,'') 
                                            as TBailiffAuctioneer,
                                            max(case when EMSSale.ConductedBy='B' then Users.UserName else '' end ) as UserName,
                                            max(case when EMSSale.ConductedBy='B' then EMSSale.ConductedBy else '' end ) as ConductedBy 
                                            FROM EMSSale   
                                            INNER JOIN EMSAppointment on EMSAppointment.EMSAppointmentId= EMSSale.EMSAppointmentId
                                            INNER JOIN EMSAccount on EMSAccount.EMSAccountId = EMSSale.EMSAccountId
                                            INNER JOIN SubCaseInfo on SubCaseInfo.SubCaseInfoID = EMSAccount.SubCaseInfoId
                                            INNER JOIN WOECaseExecutionAddress on WOECaseExecutionAddress.SubCaseInfoId = SubCaseInfo.SubCaseInfoID   
                                            LEFT OUTER JOIN MEMSApptOutcome on MEMSApptOutcome.EMSApptOutcomeCode = EMSAppointment.ApptOutcomeCode
                                            --LEFT OUTER JOIN EMSSaleAuctioneer on EMSSale.EMSSaleId = EMSSaleAuctioneer.EMSSaleId
                                            --LEFT OUTER JOIN MEMSAuctioneer on MEMSAuctioneer.EMSAuctioneerCode = EMSSaleAuctioneer.Auctioneer
                                            LEFT OUTER JOIN Users on Users.UserId= EMSAppointment.BailiffId 
                                            WHERE 
                                            EMSAppointment.IsHidden != 'Y' 
                                            AND EMSAppointment.ObsInd='N' 
                                            and EMSSale.ObsInd = 'N'
                                            AND SubCaseInfo.SubCaseInfoID = '" + subCaseInfoId + @"' 
                                            GROUP BY  EMSSale.SaleDateTime, WOECaseExecutionAddress.Address, MEMSApptOutcome.Description
                                        )as Result
                                        GROUP BY  Result.SaleDateTime, Result.Address, Result.ApptOutCome
                                        ORDER BY Result.SaleDateTime ");
                        }
                        else
                        {
                            //BUG-ENFUAT-2013071112 - Mantis:0009672 : Comment below and re-factor to support new design of EMS Sale Auctioneer.
                            /*sb.Append(@"SELECT Convert(Varchar(30), EMSSale.SaleDateTime) as SaleDateTime, WOECaseExecutionAddress.Address, 
                                        MEMSApptOutcome.Description as ApptOutCome, 
                                        max(case when EMSSale.ConductedBy='B' then Users.UserName else MEMSAuctioneer.AuctioneerName end ) as BailiffAuctioneer   
                                        FROM EMSSale   
                                        INNER JOIN EMSAppointment on EMSAppointment.EMSAppointmentId= EMSSale.EMSAppointmentId
                                        INNER JOIN EMSAccount on EMSAccount.EMSAccountId = EMSSale.EMSAccountId
                                        INNER JOIN CaseInfo on CaseInfo.CaseInfoID = EMSAccount.CaseInfoId
                                        INNER JOIN WOECaseExecutionAddress on WOECaseExecutionAddress.CaseInfoId = CaseInfo.CaseInfoID   
                                        LEFT OUTER JOIN MEMSApptOutcome on MEMSApptOutcome.EMSApptOutcomeCode = EMSAppointment.ApptOutcomeCode
                                        LEFT OUTER JOIN MEMSAuctioneer on MEMSAuctioneer.EMSAuctioneerCode = EMSSale.Auctioneer
                                        LEFT OUTER JOIN Users on Users.UserId= EMSAppointment.BailiffId 
                                        WHERE EMSAppointment.IsHidden !='Y' 
                                        AND EMSAppointment.ObsInd='N' and EMSSale.ObsInd = 'N'
                                        ");


                            sb.Append(" AND CaseInfo.CaseInfoID= '" + caseInfoId + @"' ");
                            sb.Append(@" GROUP BY  EMSSale.SaleDateTime, WOECaseExecutionAddress.Address, MEMSApptOutcome.Description 
                                        ORDER BY EMSSale.SaleDateTime ");*/

                            sb.Append(@" SELECT Result.SaleDateTime, Result.Address,Result.ApptOutCome,
                                        max(case when Result.ConductedBy='B' then Result.UserName else Result.TBailiffAuctioneer end ) as BailiffAuctioneer
                                        FROM (
                                            SELECT Convert(Varchar(30), EMSSale.SaleDateTime) as SaleDateTime, WOECaseExecutionAddress.Address, 
                                            MEMSApptOutcome.Description as ApptOutCome, 
                                            stuff( 
                                            (SELECT  ', '+ a.AuctioneerName 
                                               FROM EMSSale s
                                               INNER JOIN EMSAppointment ap 
                                               on ap.EMSAppointmentId= s.EMSAppointmentId
                                                  and ap.IsHidden != 'Y' 
                                                  and ap.ObsInd = 'N'
                                               LEFT OUTER JOIN EMSSaleAuctioneer sa on s.EMSSaleId = sa.EMSSaleId
                                               LEFT OUTER JOIN MEMSAuctioneer a on a.EMSAuctioneerCode = sa.Auctioneer
                                               WHERE s.SaleDateTime = EMSSale.SaleDateTime
                                               ORDER BY AuctioneerName
                                               FOR XML PATH(''), TYPE).value('.', 'varchar(max)')
                                            ,1,7,'') 
                                            as TBailiffAuctioneer,
                                            max(case when EMSSale.ConductedBy='B' then Users.UserName else '' end ) as UserName,
                                            max(case when EMSSale.ConductedBy='B' then EMSSale.ConductedBy else '' end ) as ConductedBy 
                                            FROM EMSSale   
                                            INNER JOIN EMSAppointment on EMSAppointment.EMSAppointmentId= EMSSale.EMSAppointmentId
                                            INNER JOIN EMSAccount on EMSAccount.EMSAccountId = EMSSale.EMSAccountId
                                            INNER JOIN CaseInfo on CaseInfo.CaseInfoID = EMSAccount.CaseInfoId
                                            INNER JOIN WOECaseExecutionAddress on WOECaseExecutionAddress.CaseInfoId = CaseInfo.CaseInfoID   
                                            LEFT OUTER JOIN MEMSApptOutcome on MEMSApptOutcome.EMSApptOutcomeCode = EMSAppointment.ApptOutcomeCode
                                            --LEFT OUTER JOIN MEMSAuctioneer on MEMSAuctioneer.EMSAuctioneerCode = EMSSale.Auctioneer
                                            LEFT OUTER JOIN Users on Users.UserId= EMSAppointment.BailiffId 
                                            WHERE EMSAppointment.IsHidden !='Y' 
                                            AND EMSAppointment.ObsInd='N' 
                                            AND EMSSale.ObsInd = 'N'
                                            AND CaseInfo.CaseInfoID= '" + caseInfoId + @"' 
                                            GROUP BY  EMSSale.SaleDateTime, WOECaseExecutionAddress.Address, MEMSApptOutcome.Description 
                                        )as Result
                                        GROUP BY  Result.SaleDateTime, Result.Address, Result.ApptOutCome
                                        ORDER BY Result.SaleDateTime ");
                        }
                        break;
                    }
                case "release":
                    {
                        if (!string.IsNullOrEmpty(subCaseInfoId))
                        {
                            sb.Append(@" SELECT Convert(Varchar(30), EMSCivCrmRelease.ReleaseDate) as ReleaseDate ,EMSCivCrmRelease.ReleaseTo,EMSCivCrmRelease.Remarks,   
                                           case when EMSCivCrmRelease.ReleaseType='F' then 'Full' else 'Partial' end as ReleaseType   
                                           from EMSCivCrmRelease
                                           INNER JOIN EMSAccount on EMSAccount.EMSAccountId = EMSCivCrmRelease.EMSAccountId
                                           INNER JOIN SubCaseInfo on SubCaseInfo.SubCaseInfoID = EMSAccount.SubCaseInfoId
                                           WHERE EMSCivCrmRelease.ObsInd='N' ");

                            sb.Append(" AND SubCaseInfo.SubCaseInfoID = '" + subCaseInfoId + @"' ");
                            sb.Append("ORDER BY EMSCivCrmRelease.ReleaseDate");
                        }
                        else
                        {
                            sb.Append(@"SELECT Convert(Varchar(30), EMSCivCrmRelease.ReleaseDate) as ReleaseDate ,EMSCivCrmRelease.ReleaseTo,EMSCivCrmRelease.Remarks,   
                                       case when EMSCivCrmRelease.ReleaseType='F' then 'Full' else 'Partial' end as ReleaseType   
                                       from EMSCivCrmRelease
                                       INNER JOIN EMSAccount on EMSAccount.EMSAccountId = EMSCivCrmRelease.EMSAccountId
                                       INNER JOIN CaseInfo on CaseInfo.CaseInfoID = EMSAccount.CaseInfoId
                                       WHERE EMSCivCrmRelease.ObsInd='N'");

                            sb.Append(" AND CaseInfo.CaseInfoID= '" + caseInfoId + @"' ");
                            sb.Append(" ORDER BY EMSCivCrmRelease.ReleaseDate ");
                        }
                        break;
                    }
                case "abort":
                    {
                        if (!string.IsNullOrEmpty(subCaseInfoId))
                        {
                            sb.Append(@" select  Convert(Varchar(30),EMSCivCaseAbort.AbortDirDate) as AbortDirDate,EMSCivCaseAbort.CaseAbortReason 
                                           FROM EMSCivCaseAbort
                                           INNER JOIN EMSAccount on EMSAccount.EMSAccountId=EMSCivCaseAbort.EMSAccountId
                                           INNER JOIN SubCaseInfo on SubCaseInfo.SubCaseInfoID = EMSAccount.SubCaseInfoId
                                           where EMSCivCaseAbort.ObsInd='N' ");

                            sb.Append(" AND SubCaseInfo.SubCaseInfoID = '" + subCaseInfoId + @"' ");
                            sb.Append(" ORDER BY EMSCivCaseAbort.AbortDirDate");
                        }
                        else
                        {
                            sb.Append(@" select  Convert(Varchar(30),EMSCivCaseAbort.AbortDirDate) as AbortDirDate,EMSCivCaseAbort.CaseAbortReason 
                                       FROM EMSCivCaseAbort
                                       INNER JOIN EMSAccount on EMSAccount.EMSAccountId=EMSCivCaseAbort.EMSAccountId
                                       INNER JOIN CaseInfo on CaseInfo.CaseInfoID = EMSAccount.CaseInfoId
                                       where  EMSCivCaseAbort.ObsInd='N' ");

                            sb.Append(" AND CaseInfo.CaseInfoID= '" + caseInfoId + @"' ");
                            sb.Append(" ORDER BY EMSCivCaseAbort.AbortDirDate");
                        }
                        break;
                    }
                case "settlement":
                    {
                        if (!string.IsNullOrEmpty(subCaseInfoId))
                        {
                            sb.Append(@"SELECT Convert(Varchar(30), EMSCivCrmSettlement.SettlementDateTime) as SettlementDateTime,Convert(Varchar(30),EMSCivCrmSettlement.AmountSettled ) as AmountSettled 
                                        FROM EMSCivCrmSettlement
                                        INNER JOIN EMSAccount on EMSAccount.EMSAccountId = EMSCivCrmSettlement.EMSAccountId
                                        INNER JOIN SubCaseInfo on EMSAccount.SubCaseInfoId = SubCaseInfo.SubCaseInfoID
                                        WHERE EMSCivCrmSettlement.ObsInd='N'  ");

                            sb.Append(" AND SubCaseInfo.SubCaseInfoID = '" + subCaseInfoId + @"' ");
                            sb.Append(" ORDER BY EMSCivCrmSettlement.SettlementDateTime");
                        }
                        else
                        {
                            sb.Append(@"SELECT Convert(Varchar(30), EMSCivCrmSettlement.SettlementDateTime) as SettlementDateTime, EMSCivCrmSettlement.AmountSettled ) as AmountSettled 
                                       FROM EMSCivCrmSettlement
                                       INNER JOIN EMSAccount on EMSAccount.EMSAccountId = EMSCivCrmSettlement.EMSAccountId
                                       INNER JOIN CaseInfo on EMSAccount.CaseInfoId = CaseInfo.CaseInfoID
                                       WHERE EMSCivCrmSettlement.ObsInd='N'  ");

                            sb.Append(" AND CaseInfo.CaseInfoID= '" + caseInfoId + @"' ");
                            sb.Append(" ORDER BY EMSCivCrmSettlement.SettlementDateTime");
                        }
                        break;
                    }
                case "missingdamageitems":
                    {
                        if (!string.IsNullOrEmpty(subCaseInfoId))
                        {
                            sb.Append(@"SELECT Convert(Varchar(30), EMSCivCrmMissing.MissingRptDate) as MissingRptDate, EMSCivCrmMissing.ItemMissing, Users.UserName as DRName,
                                        CASE WHEN EMSCivCrmMissing.IsMakeReport ='Y' then 'Yes' else 'No'  end as PoliceReport,
                                        Convert(Varchar(30), EMSCivCrmMissing.DecisionDate) as DecisionDate , EMSAppointment.ExecAddress as Address
                                        FROM EMSCivCrmMissing
                                        INNER JOIN EMSAccount on EMSAccount.EMSAccountId = EMSCivCrmMissing.EMSAccountId
                                        INNER JOIN SubCaseInfo on SubCaseInfo.SubCaseInfoID = EMSAccount.SubCaseInfoId
                                        INNER JOIN EMSCivCrmSeizure on EMSCivCrmSeizure.EMSCivCrmSeizureId = EMSCivCrmMissing.EMSCivCrmSeizureId AND EMSCivCrmSeizure.EMSAccountId=EMSAccount.EMSAccountId
                                        INNER JOIN EMSAppointment on EMSAppointment.EMSAppointmentId = EMSCivCrmSeizure.EMSAppointmentId
                                        LEFT OUTER JOIN Users on Users.UserId = EMSCivCrmMissing.DRId
                                        WHERE  EMSCivCrmMissing.ObsInd='N' ");

                            sb.Append(" AND SubCaseInfo.SubCaseInfoID = '" + subCaseInfoId + @"' ");
                            sb.Append(@" GROUP BY EMSCivCrmMissing.MissingRptDate, EMSCivCrmMissing.ItemMissing, Users.UserName,EMSCivCrmMissing.IsMakeReport,
                                        EMSCivCrmMissing.DecisionDate,EMSAppointment.ExecAddress
                                        ORDER BY EMSCivCrmMissing.MissingRptDate");
                        }
                        else
                        {
                            sb.Append(@"SELECT Convert(Varchar(30), EMSCivCrmMissing.MissingRptDate) as MissingRptDate, EMSCivCrmMissing.ItemMissing, Users.UserName as DRName,
                                        CASE WHEN EMSCivCrmMissing.IsMakeReport ='Y' then 'Yes' else 'No'  end as PoliceReport,
                                        Convert(Varchar(30), EMSCivCrmMissing.DecisionDate) as DecisionDate ,EMSAppointment.ExecAddress as Address
                                        FROM EMSCivCrmMissing
                                        INNER JOIN EMSAccount on EMSAccount.EMSAccountId = EMSCivCrmMissing.EMSAccountId
                                        INNER JOIN CaseInfo on CaseInfo.CaseInfoID = EMSAccount.CaseInfoId
                                        INNER JOIN EMSCivCrmSeizure on EMSCivCrmSeizure.EMSCivCrmSeizureId = EMSCivCrmMissing.EMSCivCrmSeizureId AND EMSCivCrmSeizure.EMSAccountId=EMSAccount.EMSAccountId
                                        INNER JOIN EMSAppointment on EMSAppointment.EMSAppointmentId = EMSCivCrmSeizure.EMSAppointmentId
                                        LEFT OUTER JOIN Users on Users.UserId = EMSCivCrmMissing.DRId
                                        WHERE  EMSCivCrmMissing.ObsInd='N'  ");

                            sb.Append(" AND CaseInfo.CaseInfoID= '" + caseInfoId + @"' ");
                            sb.Append(@" GROUP BY EMSCivCrmMissing.MissingRptDate, EMSCivCrmMissing.ItemMissing, Users.UserName,
                                        EMSCivCrmMissing.IsMakeReport , EMSCivCrmMissing.DecisionDate,EMSAppointment.ExecAddress 
                                        ORDER BY EMSCivCrmMissing.MissingRptDate ");
                        }
                        break;
                    }
                case "paymentvoucher":
                    {
                        if (!string.IsNullOrEmpty(subCaseInfoId))
                        {
                            sb.Append(@"SELECT EMSPaymentVoucher.PaymentVoucherNo, EMSPaymentVoucherFinal.PayeeName,Convert(Varchar(30),EMSPaymentVoucher.IssueDate) as IssueDate,Convert(Varchar(30),EMSPaymentVoucher.VettedDate) as VettedDate,  
                                       CASE EMSPaymentVoucher.[Status] when 'A' then 'Approved'  
                                        WHEN 'P' THEN 'Pending'  
                                        WHEN 'R' THEN 'Rejected'  
                                        WHEN 'V' THEN 'Vetted'  END as Status, Convert(Varchar(30),EMSCheque.PaymentDate) as PaymentDate,Users.UserName as Cashier  
	                                    FROM  EMSPaymentVoucher 	
                                       INNER JOIN EMSAccount on EMSAccount.EMSAccountId =EMSPaymentVoucher.EMSAccountId
                                       INNER JOIN SubCaseInfo on SubCaseInfo.SubCaseInfoID = EMSAccount.SubCaseInfoId   
                                       INNER JOIN EMSPaymentVoucherFinal on EMSPaymentVoucherFinal.EMSPaymentVoucherId = EMSPaymentVoucher.EMSPaymentVoucherId
                                       INNER JOIN EMSPayment on EMSPayment.PaymentVoucherId = EMSPaymentVoucher.EMSPaymentVoucherId
                                       INNER JOIN EMSPaymentCheque on EMSPaymentCheque.EMSPaymentId = EMSPayment.EMSPaymentId
                                       INNER JOIN EMSCheque on EMSCheque.EMSChequeId = EMSPaymentCheque.EMSChequeId
                                       INNER JOIN EMSReceipt on EMSReceipt.EMSAccountId = EMSAccount.EMSAccountId
                                       LEFT OUTER JOIN Users on Users.UserId= EMSReceipt.CashierId  
                                       where EMSPaymentVoucher.ObsInd='N' and EMSReceipt.ObsInd='N' ");

                            sb.Append(" AND SubCaseInfo.SubCaseInfoID = '" + subCaseInfoId + @"' ");
                            sb.Append(@" GROUP BY EMSPaymentVoucher.PaymentVoucherNo, EMSPaymentVoucherFinal.PayeeName,EMSPaymentVoucher.IssueDate,EMSPaymentVoucher.VettedDate,  
                                       EMSPaymentVoucher.[Status] , EMSCheque.PaymentDate,Users.UserName
                                       ORDER BY EMSPaymentVoucher.IssueDate");
                        }
                        else
                        {
                            sb.Append(@"SELECT EMSPaymentVoucher.PaymentVoucherNo, EMSPaymentVoucherFinal.PayeeName,Convert(Varchar(30),EMSPaymentVoucher.IssueDate) as IssueDate,Convert(Varchar(30),EMSPaymentVoucher.VettedDate) as VettedDate,  
                                       CASE EMSPaymentVoucher.[Status] when 'A' then 'Approved'  
                                        WHEN 'P' THEN 'Pending'  
                                        WHEN 'R' THEN 'Rejected'  
                                        WHEN 'V' THEN 'Vetted'  END as Status, Convert(Varchar(30),EMSCheque.PaymentDate) as PaymentDate,Users.UserName as Cashier  
	                                    FROM  EMSPaymentVoucher 		
                                       INNER JOIN EMSAccount on EMSAccount.EMSAccountId =EMSPaymentVoucher.EMSAccountId
                                       INNER JOIN CaseInfo on CaseInfo.CaseInfoID = EMSAccount.CaseInfoId   
                                       INNER JOIN EMSPaymentVoucherFinal on EMSPaymentVoucherFinal.EMSPaymentVoucherId = EMSPaymentVoucher.EMSPaymentVoucherId
                                       INNER JOIN EMSPayment on EMSPayment.PaymentVoucherId = EMSPaymentVoucher.EMSPaymentVoucherId
                                       INNER JOIN EMSPaymentCheque on EMSPaymentCheque.EMSPaymentId = EMSPayment.EMSPaymentId
                                       INNER JOIN EMSCheque on EMSCheque.EMSChequeId = EMSPaymentCheque.EMSChequeId
                                       INNER JOIN EMSReceipt on EMSReceipt.EMSAccountId = EMSAccount.EMSAccountId
                                       LEFT OUTER JOIN Users on Users.UserId= EMSReceipt.CashierId  
                                       where EMSPaymentVoucher.ObsInd='N' and EMSReceipt.ObsInd='N' ");

                            sb.Append(" AND CaseInfo.CaseInfoID = '" + caseInfoId + @"' ");
                            sb.Append(@" GROUP BY EMSPaymentVoucher.PaymentVoucherNo, EMSPaymentVoucherFinal.PayeeName,EMSPaymentVoucher.IssueDate,EMSPaymentVoucher.VettedDate,  
                                       EMSPaymentVoucher.[Status] , EMSCheque.PaymentDate,Users.UserName 
                                       ORDER BY EMSPaymentVoucher.IssueDate");
                        }
                        break;
                    }
                case "claim":
                    {
                        if (!string.IsNullOrEmpty(subCaseInfoId))
                        {
                            sb.Append(@" Select 
                                        Case When (CaseParty.FullName is NOT null AND  CaseParty.FullName != '' ) then CaseParty.FullName  When (CaseParty.FullName is null OR  CaseParty.FullName = '' ) then CaseParty.CompanyName  
                                        else '' end  as FullName, 
                                        Case WHEN CaseParty.EntityTypeCode = 'NP' then (Case When CaseParty.IDGroupCode in ('DNE','UNK') then CaseParty.IDRemarks WHEN CaseParty.IDGroupCode = 'IAF' then MIDType.Description + '-' + CaseParty.IDNumber end)
                                        WHEN (CaseParty.EntityTypeCode = 'CP') then CaseParty.UEN ELSE 'Unknown' END as EntityType,
                                        Convert(Varchar(30),DocumentInfo.FilingDateTime) as FilingDateTime,
                                        Case when WOENCPEInfo.ClaimObject = 'P' then 'Proceeds' else 'Items' end as SubjectMatterClaimed,   
                                        Case When WOENCPEInfo.ClaimObject = 'P' then Convert(varchar(20),WOENCPEInfo.AmountClaimed) else Convert(varchar(20),WOENCPEInfo.ItemClaimed) end as Amountclaimed 
                                        ,Case when WOENECPEInfo.ClaimStatus = 'A' then 'Admit' when WOENECPEInfo.ClaimStatus = 'D' then 'Dispute' else '' end as ClaimStatus 
                                        from SubCaseInfo 
                                        INNER JOIN CaseInfo on CaseInfo.CaseInfoID = SubCaseInfo.CaseInfoID 
                                        INNER JOIN CaseParty on CaseParty.CaseInfoID = CaseInfo.CaseInfoID 
                                        INNER JOIN DocumentInfo on DocumentInfo.SubCaseInfoId = SubCaseInfo.SubCaseInfoID
                                        INNER JOIN SubCaseParty on SubCaseParty.CasePartyID = CaseParty.CasePartyID  
                                        INNER JOIN RDocCaseParty on DocumentInfo.DOCID = RDocCaseParty.DocID   
                                        INNER JOIN DocCaseParty  ON RDocCaseParty.DCPID= DocCaseParty.DCPID  and  DocCaseParty.DCPID = CaseParty.CasePartyID                                         
                                        LEFT OUTER JOIN WOENCPEInfo on WOENCPEInfo.SubmissionGroupID=DocumentInfo.SubmissionGroupID 
                                        LEFT OUTER JOIN WOENECPEInfo on WOENECPEInfo.DocId=DocumentInfo.DOCID   
                                        LEFT OUTER JOIN MIDType on MIDType.IDTypeCode = DocCaseParty.PersonIDTypeCode 
                                        WHERE   CaseParty.ObsInd='N' and DocumentInfo.ObsInd='N' 
                                        AND DocumentInfo.DOCCode = 'WENCPE ' AND RDocCaseParty.UpdateInd='A' and DocCaseParty.FilingInd='Y' AND (SubCaseParty.SubCasePartyTypeCode='CLMT'OR CaseParty.PartyTypeCode='CLMT') ");

                            sb.Append(" AND SubCaseInfo.SubCaseInfoID = '" + subCaseInfoId + @"' ");
                            sb.Append(@" GROUP BY CaseParty.FullName,CaseParty.CompanyName,CaseParty.EntityTypeCode, CaseParty.IDGroupCode, CaseParty.IDRemarks , 
                                            CaseParty.IDGroupCode,MIDType.Description,CaseParty.IDNumber, CaseParty.UEN, DocumentInfo.FilingDateTime,WOENCPEInfo.ClaimObject, 
                                            WOENCPEInfo.AmountClaimed, WOENCPEInfo.ItemClaimed,WOENECPEInfo.ClaimStatus ");
                        }
                        break;
                    }
                case "interpleadersummons":
                    {
                        if (!string.IsNullOrEmpty(caseInfoId))
                        {
                            sb.Append(@"SELECT SubCaseInfo.SubCaseNo, Convert(Varchar(30),Hearing.HrgDateTime) as HrgDateTime, Convert(Varchar(30),DocumentInfo.FilingDateTime) as FilingDateTime,
                                        Case When (cp.FullName is NOT null AND  cp.FullName != '' ) then cp.FullName  
                                        When (cp.FullName is null OR  cp.FullName = '' ) then cp.CompanyName  
                                        else '' end   as FilingParty , Users.UserName as JOName,    
                                         MHRGOutCome.Description as HrgOutcome   
                                         from SubCaseInfo     
                                         INNER JOIN CaseInfo on CaseInfo.CaseInfoID=SubCaseInfo.CaseInfoID    
                                         INNER JOIN DocumentInfo on DocumentInfo.SubCaseInfoId=SubCaseInfo.SubCaseInfoID and CaseInfo.CaseInfoID = DocumentInfo.CaseInfoId    
                                         INNER JOIN Hearing on Hearing.SubCaseInfoId =SubCaseInfo.SubCaseInfoID and  CaseInfo.CaseInfoID = Hearing.CaseInfoId    
                                         
                                         inner join caseparty cp on cp.caseinfoid=CaseInfo.caseinfoid  
                                         inner join Subcaseparty scp on scp.caseinfoid=CaseInfo.caseinfoid and scp.SubCaseInfoID = SubCaseInfo.SubCaseInfoID   
                                         LEFT OUTER JOIN MHRGOutCome on MHRGOutCome.HRGOutComeCode = Hearing.HRGOutComeCode    
                                         
                                         LEFT OUTER JOIN MDocCode on MDocCode.DOCCode = DocumentInfo.DOCCode    
                                         LEFT OUTER JOIN Users ON users.UserId = Hearing.UserID    
                                         WHERE SubCaseInfo.SubCaseType='SUM' and DocCategoryCode ='SUM' 
                                         and SubCaseInfo.SubCaseInfoID >0 and DocumentInfo.ObsInd='N' and Hearing.ObsInd='N' And Hearing.HrgTypeCode ='IS' 
                                         and  scp.casepartyid = cp.casepartyid and scp.subcasepartytypecode = 'APL'  ");
                                        sb.Append(" AND SubCaseInfo.SubCaseInfoId IN ( '' ");
                                        if (ISSubCaseIds != null && ISSubCaseIds.Count > 0)
                                        {
                                            foreach (string ISIds in ISSubCaseIds)
                                            {
                                                sb.Append(", '" + ISIds + @"' ");
                                            }
                                        }
                                        sb.Append(" ) ");
                            sb.Append(@" GROUP BY SubCaseInfo.SubCaseNo ,Hearing.HrgDateTime,DocumentInfo.FilingDateTime,Users.UserName,    
                                         MHRGOutCome.Description, cp.FullName ,cp.CompanyName  
                                         ORDER BY DocumentInfo.FilingDateTime  ");
                        }

                        break;
                    }
                case "wasubcaseinfo":
                    {
                        if (!string.IsNullOrEmpty(subCaseInfoId))
                        {
                            sb.Append(@" Select SubCaseInfo.SubCaseNo as WASubCaseNo, Convert(Varchar(30),DocumentInfo.FilingDateTime) as FilingDateTime, CasePartyAICDetails.VesselName , 
                            Case When CasePartyAICDetails.VesselIDType = 'I' then CasePartyAICDetails.IMONumber else CasePartyAICDetails.RegistrationNumber end as VesselID,
                            CasePartyAICDetails.PortOfRegistration+','+CasePartyAICDetails.CountryOfRegistration as PlaceofReg,
                            Users.UserName as Sheriff, EMSAdmExec.ExecOutComeDesc
                            From SubCaseInfo 
                            INNER JOIN CaseInfo on CaseInfo.CaseInfoID = SubCaseInfo.CaseInfoID
                            INNER JOIN DocumentInfo On DocumentInfo.SubCaseInfoId=SubCaseInfo.SubCaseInfoID AND DocumentInfo.CaseInfoId=CaseInfo.CaseInfoID
                            INNER JOIN EMSAccount on SubCaseInfo.SubCaseInfoID=EMSAccount.SubCaseInfoId
                            INNER JOIN CaseParty on CaseParty.CaseInfoID=SubCaseInfo.CaseInfoID
                            INNER JOIN CasePartyAICDetails on CasePartyAICDetails.CasePartyID=CaseParty.CasePartyID 
                            LEFT OUTER JOIN EMSAdmExec on EMSAdmExec.EMSAccountId=EMSAccount.EMSAccountId
                            LEFT OUTER JOIN Users on Users.UserId=EMSAccount.BailiffId
                            WHERE DocumentInfo.DOCCode='ADMWOAVC' ");

                            sb.Append(" And SubCaseInfo.SubCaseInfoID = '" + subCaseInfoId + @"' ");
                            sb.Append(@" Group By SubCaseInfo.SubCaseNo, DocumentInfo.FilingDateTime, DocumentInfo.FilingDateTime , CasePartyAICDetails.VesselName , CasePartyAICDetails.VesselIDType,
                                        CasePartyAICDetails.IMONumber, CasePartyAICDetails.RegistrationNumber, CasePartyAICDetails.PortOfRegistration, CasePartyAICDetails.CountryOfRegistration,
                                        Users.UserName,EMSAdmExec.ExecOutComeDesc
                                        Order by DocumentInfo.FilingDateTime ");
                        }                        
                        break;
                    }

                case "waexecution":
                    {
                        if (!string.IsNullOrEmpty(subCaseInfoId))
                        {
                            sb.Append(@" Select Convert(Varchar(30),EMSAdmExec.ArrestDateTime) as ArrestDateTime, COALESCE(CaseParty.FullName,CaseParty.CompanyName) as Name ,
                                        MEMSADMExecLocation.Description as Address
                                        from EMSAdmExec
                                        INNER JOIN EMSAccount on EMSAccount.EMSAccountId=EMSAdmExec.EMSAccountId
                                        INNER JOIN SubCaseInfo on SubCaseInfo.SubCaseInfoID=EMSAccount.SubCaseInfoId
                                        INNER JOIN CaseParty on CaseParty.CaseInfoID=SubCaseInfo.CaseInfoID
                                        LEFT OUTER JOIN MEMSADMExecLocation on MEMSADMExecLocation.EMSADMExecLocationCode=EMSAdmExec.EMSADMExecLocationCode
                                        WHERE CaseParty.PartyTypeCode='DF' ");

                            sb.Append(" And SubCaseInfo.SubCaseInfoID = '" + subCaseInfoId + @"' ");
                            sb.Append(@" GROUP BY EMSAdmExec.ArrestDateTime, CaseParty.FullName,CaseParty.CompanyName,MEMSADMExecLocation.Description
                                        Order by EMSAdmExec.ArrestDateTime ");
                        }
                        break;
                    }

                case "warelease":
                    {
                        if (!string.IsNullOrEmpty(subCaseInfoId))
                        {
                            sb.Append(@" Select Convert(Varchar(30),EMSAdmRelease.ReleaseDateTime) as ReleaseDateTime, 
                                        Case when EMSAdmRelease.ReleaseRequester = 'P' Then 'Plaintiff' when EMSAdmRelease.ReleaseRequester = 'D' Then 'Defendant' 
                                        when EMSAdmRelease.ReleaseRequester = 'O' Then EMSAdmRelease.ReleaseRequesterDesc end AS ReleaseBy,
                                        Case when EMSAdmPropertyList.PropertyType ='V' then 'Vessel' when EMSAdmPropertyList.PropertyType ='C' then 'Cargo'
                                        when EMSAdmPropertyList.PropertyType ='B' then 'Bunker' when EMSAdmPropertyList.PropertyType ='A' then 'Aircraft/ Others' end as PropertyType
                                        From EMSAdmRelease
                                        INNER JOIN EMSAccount on EMSAccount.EMSAccountId=EMSAdmRelease.EMSAccountId
                                        INNER JOIN SubCaseInfo on SubCaseInfo.SubCaseInfoID=EMSAccount.SubCaseInfoId
                                        INNER JOIN CaseParty on CaseParty.CaseInfoID=SubCaseInfo.CaseInfoID
                                        inner join EMSAdmPropertyList on EMSAdmPropertyList.EMSAdmPropertyId=EMSAdmRelease.EMSAdmPropertyId  ");

                            sb.Append(" WHERE SubCaseInfo.SubCaseInfoID = '" + subCaseInfoId + @"' ");
                            sb.Append(@"  GROUP BY EMSAdmRelease.ReleaseDateTime, EMSAdmRelease.ReleaseRequester, EMSAdmRelease.ReleaseRequesterDesc,
                                        EMSAdmPropertyList.PropertyType
                                        Order by EMSAdmRelease.ReleaseDateTime ");
                        }
                        break;
                    }

                case "wasale":
                    {
                        if (!string.IsNullOrEmpty(subCaseInfoId))
                        {
                            sb.Append(@" Select Convert(Varchar(30),EMSSale.SaleDateTime) as SaleDateTime ,EMSSaleBuyer.BuyerName,
                                             Case when EMSAdmPropertyList.PropertyType ='V' then 'Vessel' when EMSAdmPropertyList.PropertyType ='C' then 'Cargo'
	                                        when EMSAdmPropertyList.PropertyType ='B' then 'Bunker' when EMSAdmPropertyList.PropertyType ='A' then 'Aircraft/ Others' end as PropertyType
                                             From EMSSale
                                             Inner JOIN EMSAccount on EMSAccount.EMSAccountId=EMSSale.EMSAccountId
                                             INNER JOIN SubCaseInfo on SubCaseInfo.SubCaseInfoID=EMSAccount.SubCaseInfoId
                                             INNER JOIN EMSSaleBuyer on EMSSaleBuyer.EMSSaleId =  EMSSale.EMSSaleId
                                             INNER JOIN EMSAdmPropertyList on EMSAdmPropertyList.EMSAdmPropertyId=EMSSale.EMSAdmPropertyId ");

                            sb.Append(" WHERE SubCaseInfo.SubCaseInfoID = '" + subCaseInfoId + @"' ");
                            sb.Append(@"  Group By EMSSale.SaleDateTime, EMSSaleBuyer.BuyerName, EMSAdmPropertyList.PropertyType
                                        Order by EMSSale.SaleDateTime ");
                        }
                        break;
                    }

                case "documents":
                    {
                        if (!string.IsNullOrEmpty(subCaseInfoId))
                        {
                            sb.Append(@"Select DocStatusCode, DocId, 
                                        CASE WHEN Version >1 THEN DocTitle +' (Amendment No. '+ convert(varchar(max), Version-1) + ')'ELSE DocTitle END 
                                        as DocumentTitle, FilingDateTime as FilingDate, DisplayName from DocumentInfo ");
                            sb.Append(" WHERE  SubCaseInfoId IN ( '" + subCaseInfoId + @"' ");
                            if (ISSubCaseIds != null && ISSubCaseIds.Count > 0)
                            {
                                foreach (string ISIds in ISSubCaseIds)
                                {
                                    sb.Append(" , '" + ISIds + @"' ");
                                }
                            }
                            sb.Append(@" ) And DocStatusCode = 'A' ORDER by FilingDateTime desc ");
                        }
                        break;
                    }
                default:
                    break;
            }

            IQuery queryCount = applicationSession.CreateSQLQuery(sb.ToString());
            count = queryCount.List().Count;
            IQuery query = applicationSession.CreateSQLQuery(sb.ToString()).SetFirstResult((currentPageNo - 1) * pageRecordsCount)
                             .SetMaxResults(pageRecordsCount);

            List<object> listPagedResult = query.List<object>().ToList();
            if (listPagedResult.Count > 0 && listPagedResult != null)
            {
                return listPagedResult;
            }
            else
                return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <param name="currentPageNo"></param>
        /// <param name="pageRecordsCount"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        internal List<MOMRegisterViewEntity> BindMOMRegisterGrid(int year, int currentPageNo, int pageRecordsCount, out int count)
        {
            try
            {
                IQuery query = applicationSession.CreateSQLQuery(
                                @"select M.WOEMOMSCTInfoId,
                             D.FilingDateTime,D.DocId,
                             D.DocCode,M.MOMSCTCaseNo,
                            C.CaseInfoId,C.CaseNo ,D.DocTitle
                             from WOEMOMSCTInfo M join DocumentInfo D on
                             D.SubmissionGroupId = M.SubmissionGroupId Join CaseInfo C on C.CaseInfoId = D.CaseInfoId
                            WHERE YEAR(D.FilingDateTime) = '" + year.ToString() + @"'
                             Order By M.WOEMOMSCTInfoId")
                                 .SetFirstResult((currentPageNo - 1) * pageRecordsCount)
                                 .SetMaxResults(pageRecordsCount);

                IList list = applicationSession.CreateSQLQuery(
                                @"select count(*) as Count
                             from WOEMOMSCTInfo M join DocumentInfo D on
                             D.SubmissionGroupId = M.SubmissionGroupId Join CaseInfo C on C.CaseInfoId = D.CaseInfoId
                            WHERE YEAR(D.FilingDateTime) = '" + year.ToString() + @"'").List();

                count = Convert.ToInt32(list[0].ToString());

                //count = queryCount.List<object>().ToList().Count;

                List<object> listPagedResult = query.List<object>().ToList();
                if (listPagedResult != null && listPagedResult.Count > 0)
                {
                    return this.TransformToMOMRegisterView(listPagedResult);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at BindMOMRegisterGrid", ex);
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <param name="currentPageNo"></param>
        /// <param name="pageRecordsCount"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        internal List<object> BindMOMRegisterGridTemp(int year, int currentPageNo, int pageRecordsCount, out int count)
        {
            IQuery queryCount = applicationSession.CreateSQLQuery(
                @"select M.WOEMOMSCTInfoId,
                        D.FilingDateTime,D.DocId,
                        D.DocCode,M.MOMSCTCaseNo,
                        C.CaseInfoId,C.CaseNo , DI.DocTitle
                        from WOEMOMSCTInfo M
                        join DocumentInfo D on D.SubmissionGroupID = M.SubmissionGroupId
                        Join CaseInfo C on C.CaseInfoId = D.CaseInfoId
                        Join DocumentInfo DI on D.DocId = DI.RelatedDocId
                        WHERE D.DocCode = 'WEECLO' and D.DocStatusCode = 'A' and DI.DocCode = 'ROOOTCOL' AND D.obsInd = 'N' AND DI.obsInd = 'N'
                        and YEAR(D.FilingDateTime) = '" + year.ToString() + @"'
                        Order By C.CaseNo");
            count = queryCount.List().Count;
            IQuery query = applicationSession.CreateSQLQuery(
                            @"select M.WOEMOMSCTInfoId,
                                    D.FilingDateTime,D.DocId,
                                    D.DocCode,M.MOMSCTCaseNo,
                                    C.CaseInfoId,C.CaseNo,DI.DocTitle
                                    from WOEMOMSCTInfo M
                                    join DocumentInfo D on D.SubmissionGroupID = M.SubmissionGroupId
                                    Join CaseInfo C on C.CaseInfoId = D.CaseInfoId
                                    Join DocumentInfo DI on D.DocId = DI.RelatedDocId
                                    WHERE D.DocCode = 'WEECLO' and D.DocStatusCode = 'A' and DI.DocCode = 'ROOOTCOL' AND D.obsInd = 'N' AND DI.obsInd = 'N'
                                    and YEAR(D.FilingDateTime) = '" + year.ToString() + @"'
                                    Order By C.CaseNo")
                             .SetFirstResult((currentPageNo - 1) * pageRecordsCount)
                             .SetMaxResults(pageRecordsCount);

            List<object> listPagedResult = query.List<object>().ToList();
            if (listPagedResult.Count > 0 && listPagedResult != null)
            {
                return listPagedResult;
            }
            else
                return null;
        }

        /// <summary>
        /// Delete the entity base on the parameter values.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be deleted.</typeparam>
        /// <param name="listEntityToDelete">List of the entity.</param>
        /// <returns>Number of records deleted.</returns>
        internal int DeleteEntity<T>(DetachedCriteria detachedCriteria)
        {
            List<T> listEntityToDelete = this.GetEntity<T>(detachedCriteria);
            if (listEntityToDelete.Count > 0)
            {
                IRepository<T> iEnforcementRepository = new RepositoryImpl<T>(applicationSession);
                iEnforcementRepository.DeleteAll(listEntityToDelete);
            }
            return listEntityToDelete.Count;
        }

        /// <summary>
        /// Delete the entity base on the parameter values.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be deleted.</typeparam>
        /// <param name="entityToBeDeleted">The entity to be deleted.</param>
        /// <returns>Number of records deleted.</returns>
        internal void DeleteEntity<T>(T entityToBeDeleted)
        {
            if (entityToBeDeleted != null)
            {
                IRepository<T> iEnforcementRepository = new RepositoryImpl<T>(applicationSession);
                iEnforcementRepository.Delete(entityToBeDeleted);
            }
        }

        /// <summary>
        /// Delete the entity base on the parameter values.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be deleted.</typeparam>
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="iEnforcement">Type of the entity.</param>
        /// <param name="fieldName">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <returns>Number of records deleted.</returns>
        internal int DeleteEntity<T, V>(Type iEnforcement, string fieldName, V value)
        {
            List<T> listEntityToDelete = this.GetEntity<T, V>(iEnforcement, fieldName, value, false);
            if (listEntityToDelete.Count > 0)
            {
                IRepository<T> iEnforcementRepository = new RepositoryImpl<T>(applicationSession);
                iEnforcementRepository.DeleteAll(listEntityToDelete);
            }
            return listEntityToDelete.Count;
        }

        /// <summary>
        /// Delete the entity base on the parameter values.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be deleted.</typeparam>
        /// <typeparam name="V">Type of the first value.</typeparam>
        /// <typeparam name="V2">Type of the second value.</typeparam>
        /// <param name="iEnforcement">Type of the entity.</param>
        /// <param name="fieldName">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="secondFieldName">The name of the second field.</param>
        /// <param name="secondValue">The value of the second field.</param>
        /// <param name="logicalOperator">Indicator of 'AND' or 'OR'.</param>
        /// <returns>Number of records deleted.</returns>
        internal int DeleteEntity<T, V, V2>(Type iEnforcement, string fieldName, V value, string secondFieldName, V2 secondValue, LogicalOperator logicalOperator)
        {
            List<T> listEntityToDelete = this.GetEntity<T, V, V2>(iEnforcement, fieldName, value, secondFieldName, secondValue, logicalOperator, false);
            if (listEntityToDelete.Count > 0)
            {
                IRepository<T> iEnforcementRepository = new RepositoryImpl<T>(applicationSession);
                iEnforcementRepository.DeleteAll(listEntityToDelete);
            }
            return listEntityToDelete.Count;
        }

        /// <summary>
        /// Get detached criteria for specific type.
        /// </summary>
        /// <param name="iEnforcement">The corresponding type of the entity understood by NHibernate.</param>
        /// <returns>DetachedCriteria of passing Type.</returns>
        internal DetachedCriteria GetDetachedCriteriaOfSpecificType(Type iEnforcement)
        {
            return DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName));
        }

        /// <summary>
        /// Gets all data in the entity 
        /// </summary> 
        /// <returns>List<typeparamref name="T"/></returns>
        internal List<T> GetEntity<T>()
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);
            return iRepository.GetAll() as List<T>;
        }

        /// <summary>
        /// Passes the <paramref name="fieldName"/> and <paramref name="value"/>. Get the <typeparamref name="T"/> back.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be fetched.</typeparam>
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="fieldName">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="hasObsInd">True if to check ObsInd is N, otherwise false.</param>
        /// <returns>List of <typeparamref name="T"/></returns>
        internal override List<T> GetEntity<T, V>(string fieldName, V value, bool hasObsInd)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);
            return iRepository.GetAll(this.GetDetachedCriteria<T, V>(fieldName, value, hasObsInd)) as List<T>;
        }

        /// <summary>
        /// Gets all data in the entity 
        /// </summary> 
        /// <typeparam name="T">Type of the entity to be fetched.</typeparam>
        /// <param name="iNhibernateType">Corresponding type of the entity which is understand by NHibernate.</param>
        /// <param name="hasObsInd">True if to check ObsInd is N, otherwise false.</param>
        /// <returns>List<typeparamref name="T"/></returns>
        internal List<T> GetEntity<T>(Type iNhibernateType, bool hasObsInd)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);
            if (hasObsInd)
                return iRepository.GetAll(this.GetDetachedCriteria(iNhibernateType)) as List<T>;
            else
                return iRepository.GetAll(this.GetDetachedCriteriaWithouthFiltering(iNhibernateType)) as List<T>;
        }

        /// <summary>
        /// Get the <typeparamref name="T"/> base on parameters.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be fetched.</typeparam>
        /// <param name="detachedCriteria">A complete detached criteria object to retrieve records from database.</param>
        /// <param name="totalResult">To get back the total number of record.</param>
        /// <returns>List<typeparamref name="T"/></returns>
        internal List<T> GetEntity<T>(DetachedCriteria detachedCriteria, ref Int32 totalResult)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);

            List<T> finalResult = new List<T>();
            IList results = iRepository.GetAllWithPagingMultiCriteria(detachedCriteria);
            foreach (var result in (IList)results[0])
                finalResult.Add((T)result);
            totalResult = (Int32)((IList)results[1])[0];
            return finalResult;
        }

        /// <summary>
        /// Get the <typeparamref name="T"/> base on parameters.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be fetched.</typeparam>
        /// <param name="detachedCriteria">A complete detached criteria object to retrieve records from database.</param>
        /// <param name="totalResult">To get back the total number of record.</param>
        /// <returns>List<typeparamref name="T"/></returns>
        internal List<T> GetEntity<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);
            return iRepository.GetAll(detachedCriteria) as List<T>;
        }

        /// <summary>
        /// Get the <typeparamref name="T"/> base on parameters.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be fetched.</typeparam>
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="iNhibernateType">Corresponding type of the entity which is understand by NHibernate.</param>
        /// <param name="fieldName">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="hasObsInd">True if to check ObsInd is N, otherwise false.</param>
        /// <returns>List<typeparamref name="T"/></returns>
        internal List<T> GetEntity<T, V>(Type iNhibernateType, string fieldName, V value, bool hasObsInd)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);

            return iRepository.GetAll(this.GetDetachedCriteria<V>(iNhibernateType, fieldName, value, hasObsInd)) as List<T>;
        }

        /// <summary>
        /// Get the <typeparamref name="T"/> base on parameters.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be fetched.</typeparam>
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="iNhibernateType">Corresponding type of the entity which is understand by NHibernate.</param>
        /// <param name="fieldName">The name of the field.</param>
        /// <param name="valueFrom">The start value of the field.</param>
        /// <param name="valueTo">The end value of the field.</param>
        /// <param name="hasObsInd">True if to check ObsInd is N, otherwise false.</param>
        /// <returns>List<typeparamref name="T"/></returns>
        internal List<T> GetEntity<T, V>(Type iNhibernateType, string fieldName, V valueFrom, V valueTo, bool hasObsInd)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);

            return iRepository.GetAll(this.GetDetachedCriteria<V>(iNhibernateType, fieldName, valueFrom, valueTo, hasObsInd)) as List<T>;
        }

        /// <summary>
        /// Get the <typeparamref name="T"/> base on parameters.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be fetched.</typeparam>
        /// <typeparam name="V">Type of the first value.</typeparam>
        /// <typeparam name="V2">Type of the secondvalue.</typeparam>
        /// <param name="iNhibernateType">Corresponding type of the entity which is understand by NHibernate.</param>
        /// <param name="fieldName">The name of the first field.</param> 
        /// <param name="value">The end value of the first field.</param>
        /// <param name="secondFieldName">The name of the second field.</param>
        /// <param name="secondValue">The start value of the second field.</param>
        /// <param name="logicOperator">Indicator of 'AND' or 'OR'.</param>
        /// <param name="hasObsInd">True if to check ObsInd is N, otherwise false.</param>
        /// <returns>List<typeparamref name="T"/></returns>
        internal List<T> GetEntity<T, V, V2>(Type iNhibernateType, string fieldName, V value, string secondFieldName, V2 secondValue, LogicalOperator logicOperator, bool hasObsInd)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);

            return iRepository.GetAll(this.GetDetachedCriteria<V, V2>(iNhibernateType, fieldName, value, secondFieldName, secondValue, logicOperator, hasObsInd)) as List<T>;
        }

        /// <summary>
        /// Get the <typeparamref name="T"/> base on parameter.
        /// </summary>
        /// <typeparam name="T">Type of the entity to be fetched.</typeparam>
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="iNhibernateType">Corresponding type of the entity which is understand by NHibernate.</param>
        /// <param name="fieldName">The name of the field.</param> 
        /// <param name="value">The value of the field.</param>
        /// <param name="hasObsInd">True if to check ObsInd is N, otherwise false.</param>
        /// <returns>List<typeparamref name="T"/></returns>
        internal List<T> GetEntityIn<T, V>(Type iNhibernateType, string fieldName, List<V> value, bool hasObsInd)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);
            return iRepository.GetAll(this.GetDetachedCriteriaIn<T, V>(iNhibernateType, fieldName, value, hasObsInd)) as List<T>;
        }

        /// <summary>
        /// Get the <typeparamref name="T"/> base on parameter.
        /// </summary>
        /// <typeparam name="T">Type of the entity to retrieve.</typeparam>
        /// <param name="iNhibernateType">The type of the entity.</param>
        /// <param name="fieldName">The name of the filed to filter while retrieving objects.</param>
        /// <param name="fieldValue">The value of the filed to filter while retrieving objects.</param>
        /// <param name="hasObsInd">True if to check ObsInd is N, otherwise false.</param>
        /// <returns>List of <typeparamref name="T"/></returns>
        internal List<T> GetEntityLike<T>(Type iNhibernateType, string fieldName, string fieldValue, bool hasObsInd)
        {
            IRepository<T> iRepository = new RepositoryImpl<T>(applicationSession);
            return iRepository.GetAll(this.GetDetachedCriteriaLike(iNhibernateType, fieldName, fieldValue, hasObsInd)) as List<T>;
        }

        /// <summary>
        /// To check if the entity has ObsInd field.
        /// </summary>
        /// <param name="entityType">Type of Entity</param>
        /// <returns>True if the entity has ObsInd field. Otherwise false.</returns>
        internal bool HasObsInd(Type entityType)
        {
            //Enforcement Enities
            if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSAccount))
                return true;// typeof(EMSAccount).GetProperty("ObsInd")
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSAdmCharge))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSAdmCharges))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSAdmClaim))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSAttendanceFee))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSAdmExec))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSAdmProperty))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSAdmPropertyList))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSAdmRelease))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSAppointment))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSApptDateTime))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSApptDebtor))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSBailiffUnavailability))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSCashBookItem))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSCashBookReconcile))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSCheque))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSChequeHistory))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSCivCaseAbort))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSCivCrmMissing))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSCivCrmRelease))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSCivCrmSeizure))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSCivCrmSettlement))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSCourtCommission))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSCrmCase))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSCrmCaseExecAddr))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSCrmCaseWLDet))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSDisburseClaim))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSExecLedger))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSFileMovement))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSMiscClaim))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSOutstandingPayment))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSPayment))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSPaymentCheque))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSPaymentVoucher))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSPaymentVoucherAdm))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSPaymentVoucherCheque))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSPaymentVoucherFinal))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSPaymentVoucherFinalOther))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSRecapitDetails))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSRecapitulation))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSRecAudit))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSRecChequeAudit))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSReceipt))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSRecTrans))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSSale))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSSaleAdvert))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSSaleAgent))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSSaleAppraiser))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSSaleBuyer))
                return false;
            //else if (Type.GetType(iEnforcementEntity.AssemblyQualifiedName) == typeof(EMSSerialReceipt))
            //    return typeof(EMSSerialReceipt);
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSStateFund))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSTeamMgmt))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSTptClaim))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(Temp_EMSAppointment))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(EMSADMSaleOthers))
                return false;

            //Master Enforcement Enities
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSAdvertIn))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSAdvertiser))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSAppraiser))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSApptOutcome))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSApptReason))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSApptType))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSAttendanceFee))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSAuctioneer))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSCourtComm))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MExternalAgency))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSSecurityGuard))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MExternalAgencyAddress))
                return true;
            //else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSDisburseRate))
            //    return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSFileMoveDesc))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSLedger))
                return true;
            //else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSMarineAppraiser))
            //    return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSNatureOfPayment))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSParam))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSRecBank))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSRecTransMode))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSRecTransType))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSSalesAgent))
                return true;
            //else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSSecurityGuard))
            //    return true;
            //else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSShipAgent))
            //    return true;
            //else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSShippingUnit))
            //    return true;
            //else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSWritAppt))
            //    return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSDisburseRate))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSADMExecLocation))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MEMSCrmCasePrefix))
                return true;

            //Non Enforcement Enities 

            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(TaskList))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(WOEInfo))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(WOEExecutionAddress))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(RefOrderDetail))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(CaseInfo))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(SubCaseInfo))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(CaseParty))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(SubCaseParty))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(CasePartyAICDetail))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(DocumentInfo))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(RSubCaseSubmission))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(RUserRoleSection))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(RRoleFunctions))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MForumType))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MCourtType))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MSection))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MUserRole))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MPartyType))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(RCaseSubmission))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(JudicialUser))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(LawFirm))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(RCaseLawFirm))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(RCaseSubmission))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(CasePartyAddress))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(SerialNumber))
                return false;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MCountry))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(CasePartyAICDetail))
                return true;
            else if (Type.GetType(entityType.AssemblyQualifiedName) == typeof(MHoliday))
                return true;
            //else
            return false;
        }

        /// <summary>
        /// To map the NHibernate entity type to Domain entity type.
        /// </summary>
        /// <typeparam name="T">Interface of Domain Entity.</typeparam>
        /// <param name="listNHibernateEntity">A list of NHibernate Entity.</param>
        /// <returns>A collection of corresponding Domain entity.</returns>
        internal IEnumerable<T> MapToDomainObject<T>(List<object> listNHibernateEntity)
        {
            if (!listNHibernateEntity.HasContent())
                return new List<T>();

            if (typeof(T).IsInterfaceImplementOf(typeof(IEnforcementEntity)))
                return listNHibernateEntity.Select(iEnforcement => ((T)EnforcementMapperToDTO.GetEnforcement<object>(iEnforcement)));
            else if (typeof(T).IsInterfaceImplementOf(typeof(IMasterEntity)))
                return listNHibernateEntity.Select(iMaster =>
                    ((T)AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.MasterMapper.GetMasterEntity<object>(iMaster)));
            else if (typeof(T).IsInterfaceImplementOf(typeof(IBackEndSpecificEntity)))
                return listNHibernateEntity.Select(iBankEndSpecific =>
                    ((T)AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetBackEndSpecificEntity<object>(iBankEndSpecific)));
            else if (typeof(T).IsInterfaceImplementOf(typeof(ICaseEntity)))
                return listNHibernateEntity.Select(iCase =>
                        ((T)AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseMapper.GetCaseEntity<object>(iCase)));
            else if (typeof(T).IsInterfaceImplementOf(typeof(ISubCaseEntity)))
                return listNHibernateEntity.Select(iSubCase =>
                    ((T)AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseMapper.GetSubCaseEntity<object>(iSubCase)));
            else if (typeof(T).IsInterfaceImplementOf(typeof(ICommonEntity)))
                return listNHibernateEntity.Select(iCommon =>
                    ((T)AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CommonMapper.GetCommonEntity<object>(iCommon)));
            else if (typeof(T).IsInterfaceImplementOf(typeof(IDocumentEntity)))
                return listNHibernateEntity.Select(iDocument =>
                    ((T)AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.DocumentMapper.GetDocumentEntity<object>(iDocument)));
            else if (typeof(T).IsInterfaceImplementOf(typeof(ISubsequentEntity)))
                return listNHibernateEntity.Select(iSubSequence =>
                    ((T)AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubsequentMapper.GetSubsequentEntity<object>(iSubSequence)));
            else if (typeof(T) == typeof(JudicialUserEntity))
                return listNHibernateEntity.Select(iBankEndSpecific =>
                    ((T)AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.BackEndSpecificMapper.GetBackEndSpecificEntity<object>(iBankEndSpecific)));
            else if (typeof(T).IsInterfaceImplementOf(typeof(ISubCaseSpecificEntity)))
                return listNHibernateEntity.Select(iSubCaseSpecific =>
                    ((T)AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.SubCaseSpecificMapper.GetSubCaseSpecificEntity<object>(iSubCaseSpecific)));
            else if (typeof(T).IsInterfaceImplementOf(typeof(ICaseSpecificEntity)))
                return listNHibernateEntity.Select(iCaseSpecific =>
                    ((T)AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.CaseSpecificMapper.GetCaseSpecificEntity<object>(iCaseSpecific)));
            else if (typeof(T).IsInterfaceImplementOf(typeof(ILAPEntity)))
                return listNHibernateEntity.Select(iLAP =>
                    ((T)AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.LAPMapper.GetLAPEntity<object>(iLAP)));

            return null;
        }

        /// <summary>
        /// To map the Domain entity type to NHibernate entity type.
        /// </summary>
        /// <typeparam name="TSource">Interface of Domain Entity.</typeparam>
        /// <typeparam name="TReturn">Interface of NHibernate Entity.</typeparam>
        /// <param name="domainEntity">The Domain Entity to map.</param>
        /// <returns>An corresponding NHibernate Entity.</returns>
        internal TReturn MapToNHibernateObject<TSource, TReturn>(TSource domainEntity)
        {
            if (domainEntity == null)
                return default(TReturn);

            if (typeof(TSource).IsInterfaceImplementOf(typeof(IEnforcementEntity)))
                return ((TReturn)EnforcementMapperToDomain.GetEnforcementEntity<TSource>(domainEntity));
            else if (typeof(TSource).IsInterfaceImplementOf(typeof(IMasterEntity)))
                return ((TReturn)AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.MasterMapper.GetMasterEntity<TSource>(domainEntity));
            else if (typeof(TSource).IsInterfaceImplementOf(typeof(IBackEndSpecificEntity)))
                return ((TReturn)AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.BackEndSpecificMapper.GetBackEndSpecificEntity<TSource>(domainEntity));
            else if (typeof(TSource).IsInterfaceImplementOf(typeof(ICaseEntity)))
                return ((TReturn)AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CaseMapper.GetCaseEntity<TSource>(domainEntity));
            else if (typeof(TSource).IsInterfaceImplementOf(typeof(ISubCaseEntity)))
                return ((TReturn)AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.SubCaseMapper.GetSubCase<TSource>(domainEntity));
            else if (typeof(TSource).IsInterfaceImplementOf(typeof(IDocumentEntity)))
                return ((TReturn)AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.DocumentMapper.GetDocumentEntity<TSource>(domainEntity));
            else if (typeof(TSource).IsInterfaceImplementOf(typeof(ICommonEntity)))
                return ((TReturn)AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.CommonMapper.GetCommonEntity<TSource>(domainEntity));
            else if (typeof(TSource).IsInterfaceImplementOf(typeof(ILAPEntity)))
                return ((TReturn)AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper.LAPMapper.GetLAP<TSource>(domainEntity));
            
            return default(TReturn);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        internal Type TypeMapper<T>()
        {
            if (typeof(T) == typeof(EMSAccountEntity))
                return typeof(EMSAccount);
            //else if (typeof(T) == typeof(EMSAdmChargeEntity))
            //    return typeof(EMSAdmCharge);
            else if (typeof(T) == typeof(EMSAdmChargesEntity))
                return typeof(EMSAdmCharges);
            else if (typeof(T) == typeof(EMSAdmClaimEntity))
                return typeof(EMSAdmClaim);
            else if (typeof(T) == typeof(EMSAttendanceFeeEntity ))
                return typeof(EMSAttendanceFee);
            else if (typeof(T) == typeof(EMSAdmExecEntity))
                return typeof(EMSAdmExec);
            else if (typeof(T) == typeof(EMSAdmPropertyEntity))
                return typeof(EMSAdmProperty);
            else if (typeof(T) == typeof(EMSAdmPropertyListEntity))
                return typeof(EMSAdmPropertyList);
            else if (typeof(T) == typeof(EMSAdmReleaseEntity))
                return typeof(EMSAdmRelease);
            else if (typeof(T) == typeof(EMSAppointmentEntity))
                return typeof(EMSAppointment);
            else if (typeof(T) == typeof(EMSApptDateTimeEntity))
                return typeof(EMSApptDateTime);
            else if (typeof(T) == typeof(EMSApptDebtorEntity))
                return typeof(EMSApptDebtor);
            else if (typeof(T) == typeof(EMSBailiffUnavailabilityEntity))
                return typeof(EMSBailiffUnavailability);
            else if (typeof(T) == typeof(EMSCashBookItemEntity))
                return typeof(EMSCashBookItem);
            else if (typeof(T) == typeof(EMSCashBookReconcileEntity))
                return typeof(EMSCashBookReconcile);
            else if (typeof(T) == typeof(EMSChequeEntity))
                return typeof(EMSCheque);
            else if (typeof(T) == typeof(EMSChequeHistoryEntity))
                return typeof(EMSChequeHistory);
            else if (typeof(T) == typeof(EMSCivCaseAbortEntity))
                return typeof(EMSCivCaseAbort);
            else if (typeof(T) == typeof(EMSCivCrmMissingEntity))
                return typeof(EMSCivCrmMissing);
            else if (typeof(T) == typeof(EMSCivCrmReleaseEntity))
                return typeof(EMSCivCrmRelease);
            else if (typeof(T) == typeof(EMSCivCrmSeizureEntity))
                return typeof(EMSCivCrmSeizure);
            else if (typeof(T) == typeof(EMSCivCrmSettlementEntity))
                return typeof(EMSCivCrmSettlement);
            else if (typeof(T) == typeof(EMSCourtCommissionEntity))
                return typeof(EMSCourtCommission);
            else if (typeof(T) == typeof(EMSCrmCaseEntity))
                return typeof(EMSCrmCase);
            else if (typeof(T) == typeof(EMSCrmCaseExecAddrEntity))
                return typeof(EMSCrmCaseExecAddr);
            else if (typeof(T) == typeof(EMSCrmCaseWLDetEntity))
                return typeof(EMSCrmCaseWLDet);
            else if (typeof(T) == typeof(EMSDisburseClaimEntity))
                return typeof(EMSDisburseClaim);
            else if (typeof(T) == typeof(EMSExecLedgerEntity))
                return typeof(EMSExecLedger);
            else if (typeof(T) == typeof(EMSFileMovementEntity))
                return typeof(EMSFileMovement);
            else if (typeof(T) == typeof(EMSMiscClaimEntity))
                return typeof(EMSMiscClaim);
            else if (typeof(T) == typeof(EMSOutstandingPaymentEntity))
                return typeof(EMSOutstandingPayment);
            else if (typeof(T) == typeof(EMSPaymentEntity))
                return typeof(EMSPayment);
            else if (typeof(T) == typeof(EMSPaymentChequeEntity))
                return typeof(EMSPaymentCheque);
            else if (typeof(T) == typeof(EMSPaymentVoucherEntity))
                return typeof(EMSPaymentVoucher);
            else if (typeof(T) == typeof(EMSPaymentVoucherAdmEntity))
                return typeof(EMSPaymentVoucherAdm);
            else if (typeof(T) == typeof(EMSPaymentVoucherChequeEntity))
                return typeof(EMSPaymentVoucherCheque);
            else if (typeof(T) == typeof(EMSPaymentVoucherFinalEntity))
                return typeof(EMSPaymentVoucherFinal);
            else if (typeof(T) == typeof(EMSPaymentVoucherFinalOtherEntity))
                return typeof(EMSPaymentVoucherFinalOther);
            else if (typeof(T) == typeof(EMSPaymentVoucherMiscEntity))
                return typeof(EMSPaymentVoucherMisc);
            else if (typeof(T) == typeof(EMSRecapitDetailsEntity))
                return typeof(EMSRecapitDetails);
            else if (typeof(T) == typeof(EMSRecapitulationEntity))
                return typeof(EMSRecapitulation);
            else if (typeof(T) == typeof(EMSRecAuditEntity))
                return typeof(EMSRecAudit);
            else if (typeof(T) == typeof(EMSRecChequeAuditEntity))
                return typeof(EMSRecChequeAudit);
            else if (typeof(T) == typeof(EMSReceiptEntity))
                return typeof(EMSReceipt);
            else if (typeof(T) == typeof(EMSRecTransEntity))
                return typeof(EMSRecTrans);
            else if (typeof(T) == typeof(EMSSaleEntity))
                return typeof(EMSSale);
            else if (typeof(T) == typeof(EMSSaleAuctioneerEntity))
                return typeof(EMSSaleAuctioneer);
            else if (typeof(T) == typeof(EMSSaleAdvertEntity))
                return typeof(EMSSaleAdvert);
            else if (typeof(T) == typeof(EMSSaleAgentEntity))
                return typeof(EMSSaleAgent);
            else if (typeof(T) == typeof(EMSSaleAppraiserEntity))
                return typeof(EMSSaleAppraiser);
            else if (typeof(T) == typeof(EMSSaleBuyerEntity))
                return typeof(EMSSaleBuyer);
            else if (typeof(T) == typeof(EMSStateFundEntity))
                return typeof(EMSStateFund);
            else if (typeof(T) == typeof(EMSTeamMgmtEntity))
                return typeof(EMSTeamMgmt);
            else if (typeof(T) == typeof(EMSTptClaimEntity))
                return typeof(EMSTptClaim);
            else if (typeof(T) == typeof(Temp_EMSAppointmentEntity))
                return typeof(Temp_EMSAppointment);
            else if (typeof(T) == typeof(EMSADMSaleOthersEntity))
                return typeof(EMSADMSaleOthers);
            else if (typeof(T) == typeof(EMSRoundRobinAuctioneerEntity))
                return typeof(EMSRoundRobinAuctioneer);

            //MEMS related

            else if (typeof(T) == typeof(MEMSAdvertInEntity))
                return typeof(MEMSAdvertIn);
            else if (typeof(T) == typeof(MEMSAdvertiserEntity))
                return typeof(MEMSAdvertiser);
            else if (typeof(T) == typeof(MEMSAppraiserEntity))
                return typeof(MEMSAppraiser);
            else if (typeof(T) == typeof(MEMSApptOutcomeEntity))
                return typeof(MEMSApptOutcome);
            else if (typeof(T) == typeof(MEMSApptReasonEntity))
                return typeof(MEMSApptReason);
            else if (typeof(T) == typeof(MEMSApptTypeEntity))
                return typeof(MEMSApptType);
            else if (typeof(T) == typeof(MEMSAttendanceFeeEntity))
                return typeof(MEMSAttendanceFee);
            else if (typeof(T) == typeof(MEMSAuctioneerEntity))
                return typeof(MEMSAuctioneer);
            else if (typeof(T) == typeof(MEMSCourtCommEntity))
                return typeof(MEMSCourtComm);
            else if (typeof(T) == typeof(MEMSFileMoveDescEntity))
                return typeof(MEMSFileMoveDesc);
            else if (typeof(T) == typeof(MEMSLedgerEntity))
                return typeof(MEMSLedger);
            else if (typeof(T) == typeof(MEMSNatureOfPaymentEntity))
                return typeof(MEMSNatureOfPayment);
            else if (typeof(T) == typeof(MEMSRecBankEntity))
                return typeof(MEMSRecBank);
            else if (typeof(T) == typeof(MEMSRecTransModeEntity))
                return typeof(MEMSRecTransMode);
            else if (typeof(T) == typeof(MEMSRecTransTypeEntity))
                return typeof(MEMSRecTransType);
            else if (typeof(T) == typeof(MEMSSalesAgentEntity))
                return typeof(MEMSSalesAgent);
            else if (typeof(T) == typeof(MEMSParamEntity))
                return typeof(MEMSParam);
            else if (typeof(T) == typeof(MEMSDisburseRateEntity))
                return typeof(MEMSDisburseRate);
            else if (typeof(T) == typeof(MEMSSecurityGuardEntity))
                return typeof(MEMSSecurityGuard);
            else if (typeof(T) == typeof(MEMSADMExecLocationEntity))
                return typeof(MEMSADMExecLocation);
            else if (typeof(T) == typeof(MEMSCrmCasePrefixEntity))
                return typeof(MEMSCrmCasePrefix);

            //Non - EMS related

            else if (typeof(T) == typeof(JudicialUserEntity))
                return typeof(JudicialUser);
            else if (typeof(T) == typeof(SubCaseInfoEntity))
                return typeof(SubCaseInfo);
            else if (typeof(T) == typeof(CaseInfoEntity))
                return typeof(CaseInfo);
            else if (typeof(T) == typeof(CasePartyEntity))
                return typeof(CaseParty);
            else if (typeof(T) == typeof(SubCasePartyEntity))
                return typeof(SubCaseParty);
            else if (typeof(T) == typeof(DocumentInfoEntity))
                return typeof(DocumentInfo);
            else if (typeof(T) == typeof(LawFirmEntity))
                return typeof(LawFirm);
            else if (typeof(T) == typeof(CasePartyAddressEntity))
                return typeof(CasePartyAddress);
            else if (typeof(T) == typeof(RefOrderDetailEntity))
                return typeof(RefOrderDetail);
            else if (typeof(T) == typeof(WOEExecutionAddressEntity))
                return typeof(WOEExecutionAddress);
            else if (typeof(T) == typeof(WOECaseExecutionAddressEntity))
                return typeof(WOECaseExecutionAddress);
            else if (typeof(T) == typeof(WOEInfoEntity))
                return typeof(WOEInfo);
            else if (typeof(T) == typeof(WOERequestEntity))
                return typeof(WOERequest);
            else if (typeof(T) == typeof(WOENCPEInfoEntity))
                return typeof(WOENCPEInfo);
            else if (typeof(T) == typeof(WOENECPEInfoEntity))
                return typeof(WOENECPEInfo);
            else if (typeof(T) == typeof(CaseSolicitorEntity))
                return typeof(CaseSolicitor);
            else if (typeof(T) == typeof(TaskListEntity))
                return typeof(TaskList);
            else if (typeof(T) == typeof(ADMWAInfoEntity))
                return typeof(ADMWAInfo);
            else if (typeof(T) == typeof(ADMInfoEntity))
                return typeof(ADMInfo);
            else if (typeof(T) == typeof(CasePartyAICDetailsEntity))
                return typeof(CasePartyAICDetail);
            else if (typeof(T) == typeof(DocCasePartyAICDetailsEntity))
                return typeof(DocCasePartyAICDetail);
            else if (typeof(T) == typeof(RefSubCaseEntity))
                return typeof(RefSubCase);
            else if (typeof(T) == typeof(BizMonitoringInfoEntity))
                return typeof(BizMonitoringInfo);
            else if (typeof(T) == typeof(LACInfoEntity))
                return typeof(LACInfo);
            else if (typeof(T) == typeof(LACDocumentDetailEntity))
                return typeof(LACDocumentDetail);
            //Master Tables << This should be in Master Mediator after designing correctly >>

            else if (typeof(T) == typeof(RUserRoleSectionEntity))
                return typeof(RUserRoleSection);
            else if (typeof(T) == typeof(MUserRoleEntity))
                return typeof(MUserRole);
            else if (typeof(T) == typeof(MFunctionsEntity))
                return typeof(MFunctions);
            else if (typeof(T) == typeof(RRoleFunctionsEntity))
                return typeof(RRoleFunctions);
            else if (typeof(T) == typeof(MSectionEntity))
                return typeof(MSection);
            else if (typeof(T) == typeof(RSubCaseSubmissionEntity))
                return typeof(RSubCaseSubmission);
            else if (typeof(T) == typeof(RCaseSubmissionEntity))
                return typeof(RCaseSubmission);
            else if (typeof(T) == typeof(RDocCasePartyEntity))
                return typeof(RDocCaseParty);
            else if (typeof(T) == typeof(DocCasePartyEntity))
                return typeof(DocCaseParty);
            else if (typeof(T) == typeof(MExternalAgencyAddressEntity))
                return typeof(MExternalAgencyAddress);
            else if (typeof(T) == typeof(MExternalAgencyEntity))
                return typeof(MExternalAgency);
            else if (typeof(T) == typeof(MPartyTypeEntity))
                return typeof(MPartyType);
            else if (typeof(T) == typeof(SerialNumberEntity))
                return typeof(SerialNumber);
            else if (typeof(T) == typeof(MCountryEntity))
                return typeof(MCountry);
            else if (typeof(T) == typeof(MHolidayEntity))
                return typeof(MHoliday);
            else if (typeof(T) == typeof(MFormSignatureEntity))
                return typeof(MFormSignature);
            else if (typeof(T) == typeof(MSequenceKeyEntity))
                return typeof(MSequenceKey);
            else if (typeof(T) == typeof(MPrinterEntity))
                return typeof(MPrinter);
            else if (typeof(T) == typeof(MForumTypeEntity))
                return typeof(MForumType);
            else if (typeof(T) == typeof(MCourtTypeEntity))
                return typeof(MCourtType);
            //else
            throw new Exception("Error in converting Domain to NHibernate Type. Parsing Type is not a valid for Enforcement Mediator. " + typeof(T).FullName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dc"></param>
        /// <param name="queryList"></param>
        internal void TranformToDetachedCriteria(DetachedCriteria dc, ICollection<ICriterion> queryList)
        {
            foreach (ICriterion query in queryList)
            {
                dc.Add(query);
            }
        }

        /// <summary>
        /// Helper methods to get the DetachedCriteria 
        /// </summary>
        /// <typeparam name="T">Type to create NHibernate DetachedCreteria upon.</typeparam>
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="fieldName">The fields name and values of domain entity to use for deletion.</param>
        /// <param name="value">The value to filter.</param>
        /// <param name="hasObsInd">True if to check ObsInd is N, otherwise false.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteria<T, V>(string fieldName, V value, bool hasObsInd)
        {
            if (hasObsInd)
                return DetachedCriteria.For(typeof(T))
                                                    .Add(Expression.Eq(fieldName, value))
                                                    .Add(Expression.Eq("ObsInd", "N"))
                                                    ;
            else
                return DetachedCriteria.For(typeof(T))
                                                    .Add(Expression.Eq(fieldName, value))
                                                    ;
        }

        /// <summary>
        /// Helper methods to get the DetachedCriteria 
        /// </summary>
        /// <typeparam name="V">Type of the first value.</typeparam>
        /// <typeparam name="V2">Type of the second value.</typeparam>
        /// <param name="iEnforcement">Type of enforcement.</param>
        /// <param name="fieldName">The name of the first field to filter while retrieving the object.</param>
        /// <param name="value">The value of the first field to filter while retrieving the object.</param>
        /// <param name="sencondFieldName">The name of the second field to filter while retrieving the object.</param>
        /// <param name="secondValue">The value of the second field to filter while retrieving the object.</param>
        /// <param name="logicOperator">The logical operator used for query.</param>
        /// <param name="hasObsInd">True if to check ObsInd is N, otherwise false.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteria<V, V2>(Type iEnforcement, string fieldName, V value, string sencondFieldName, V2 secondValue, LogicalOperator logicOperator, bool hasObsInd)
        {
            DetachedCriteria detachedCriteria = null;
            if (hasObsInd)
            {
                switch (logicOperator)
                {
                    case LogicalOperator.AND:
                        detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName))
                                                .Add(Expression.And(Expression.Eq(fieldName, value), Expression.Eq(sencondFieldName, secondValue)))
                                                .Add(Expression.Eq("ObsInd", "N"));
                        break;
                    case LogicalOperator.OR:
                        detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName))
                                                .Add(Expression.Or(Expression.Eq(fieldName, value), Expression.Eq(sencondFieldName, secondValue)))
                                                .Add(Expression.Eq("ObsInd", "N"));
                        break;
                    //case LogicalOperator.NOT:
                    //    detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcementType.AssemblyQualifiedName))
                    //                            .Add(Expression.Not(Expression.Eq(firstFieldName, firstValue), Expression.Eq(sencondFieldName, secondValue)))
                    //                            .Add(Expression.Eq("ObsInd", "N"));
                    default:
                        detachedCriteria = null;
                        break;
                }
            }
            else
            {

                switch (logicOperator)
                {
                    case LogicalOperator.AND:
                        detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName))
                                                .Add(Expression.And(Expression.Eq(fieldName, value), Expression.Eq(sencondFieldName, secondValue)));
                        break;
                    case LogicalOperator.OR:
                        detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName))
                                                .Add(Expression.Or(Expression.Eq(fieldName, value), Expression.Eq(sencondFieldName, secondValue)));
                        break;
                    //case LogicalOperator.NOT:
                    //    detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcementType.AssemblyQualifiedName))
                    //                            .Add(Expression.Not(Expression.Eq(firstFieldName, firstValue), Expression.Eq(sencondFieldName, secondValue)));
                    default:
                        detachedCriteria = null;
                        break;
                }
            }
            return detachedCriteria;
        }

        /// <summary>
        /// Get the DetachedCriteria upon pass Enforcement type.
        /// </summary>
        /// <param name="iEnforcement">Type of enforcement.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteria(Type iEnforcement)
        {
            return DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName))
                                                                     .Add(Expression.Eq("ObsInd", "N"));
        }

        /// <summary>
        /// Get the DetachedCriteria upon pass Enforcement type and parameter.
        /// </summary> 
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="iEnforcement">Type of enforcement.</param>
        /// <param name="fieldName">Field name to use as filter.</param>
        /// <param name="value">Value to use as filter.</param>
        /// <param name="hasObsInd">True if to check ObsInd is N, otherwise false.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteria<V>(Type iEnforcement, string fieldName, V value, bool hasObsInd)
        {
            DetachedCriteria detachedCriteria = null;
            if (typeof(V).IsGenericType && typeof(V).GetGenericTypeDefinition() == typeof(Nullable<>) && value == null && hasObsInd)
            {
                detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName))
                                                                     .Add(Expression.IsNull(fieldName))
                                                                     .Add(Expression.Eq("ObsInd", "N"));

            }
            else if (typeof(V).IsGenericType && typeof(V).GetGenericTypeDefinition() == typeof(Nullable<>) && value == null && !hasObsInd)
            {
                detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName))
                                                                     .Add(Expression.IsNull(fieldName));
            }
            else if (hasObsInd)
            {
                detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName))
                                                                     .Add(Expression.Eq(fieldName, value))
                                                                     .Add(Expression.Eq("ObsInd", "N"));
            }
            else
            {
                detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName))
                                                                     .Add(Expression.Eq(fieldName, value));
            }

            if (detachedCriteria == null)
            {
                throw new Exception("Constructing the query criteria have some error.");
            }
            return detachedCriteria;
        }

        /// <summary>
        /// Get the DetachedCriteria upon pass Enforcement type and parameter.
        /// </summary> 
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="iEnforcement">Type of enforcement.</param>
        /// <param name="fieldName">Field name to use as filter.</param>
        /// <param name="fromValue">Start Value to use as filter.</param>
        /// <param name="toValue">End Value to use as filter.</param>
        /// <param name="hasObsInd">True if to check ObsInd is N, otherwise false.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteria<V>(Type iEnforcement, string fieldName, V fromValue, V toValue, bool hasObsInd)
        {
            DetachedCriteria detachedCriteria = null;
            if (hasObsInd)
            {
                detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName))
                                                               .Add(Expression.Between(fieldName, fromValue, toValue))
                                                               .Add(Expression.Eq("ObsInd", "N"));
            }
            else
            {
                detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName))
                                                               .Add(Expression.Between(fieldName, fromValue, toValue));
            }

            if (detachedCriteria == null)
            {
                throw new Exception("Constructing the query criteria have some error.");
            }
            return detachedCriteria;
        }

        /// <summary>
        /// Helper methods to get the DetachedCriteria for "between" values and second value usign AND Operator
        /// </summary>
        /// <typeparam name="T">Type of the entity upon which the DetachCrietral will create.</typeparam>
        /// <typeparam name="V">Type of the first value.</typeparam>
        /// <param name="iEnforcement">The corresponding type of the entity understood by NHibernate.</param>
        /// <param name="fieldName">The name of the first field.</param>
        /// <param name="value">The value of the first field.</param>
        /// <param name="hasObsInd">True if to check ObsInd is N, otherwise false.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteriaIn<T, V>(Type iEnforcement, string fieldName, List<V> value, bool hasObsInd)
        {
            DetachedCriteria detachedCriteria = null;
            try
            {
                if (hasObsInd)
                    detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName))
                                        .Add(Expression.In(fieldName, value))
                                        .Add(Expression.Eq("ObsInd", "N"))
                                        ;
                else
                    detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName))
                                        .Add(Expression.In(fieldName, value))
                                     ;

                if (detachedCriteria == null)
                {
                    Logger.Error("Get " + typeof(T).ToString() + ". Property names to query are not provided");
                    throw new Exception("Constructing the query criteria have some error.");
                }
            }
            catch (Exception e)
            {
                Logger.Error("Get " + typeof(T).ToString() + ". Constructing the query criteria have some error.", e);
                throw;
            }
            return detachedCriteria;
        }

        /// <summary>
        /// Helper methods to get the DetachedCriteria for "Like".
        /// </summary>
        /// <param name="iEnforcement">The corresponding type of the entity understood by NHibernate.</param>
        /// <param name="fieldName">The name of the like field.</param>
        /// <param name="fieldVlaue">The value of the like field.</param>
        /// <param name="hasObsInd">True if to check ObsInd is N, otherwise false.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteriaLike(Type iEnforcement, string fieldName, string fieldVlaue, bool hasObsInd)
        {
            DetachedCriteria detachedCriteria = null;
            if (hasObsInd)
            {
                detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName))
                                                    .Add(Expression.Like(fieldName, fieldVlaue, MatchMode.Anywhere))
                                                    .Add(Expression.Eq("ObsInd", "N"));
            }
            else
            {
                detachedCriteria = DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName))
                                                    .Add(Expression.Like(fieldName, fieldVlaue))
                                                    ;

            }

            if (detachedCriteria == null)
            {
                throw new Exception("Constructing the query criteria have some error.");
            }
            return detachedCriteria;
        }

        /// <summary>
        /// Get the DetachedCriteria without any filtering upon Enforcement type.
        /// </summary> 
        /// <param name="iEnforcement">Type of enforcement.</param>
        /// <returns>DetachedCriteria</returns>
        private DetachedCriteria GetDetachedCriteriaWithouthFiltering(Type iEnforcement)
        {
            return DetachedCriteria.For(Type.GetType(iEnforcement.AssemblyQualifiedName));
        }

        private List<MOMRegisterViewEntity> TransformToMOMRegisterView(List<object> listPagedResult)
        {
            List<MOMRegisterViewEntity> listMOMRegisterViewEntity = new List<MOMRegisterViewEntity>();
            foreach (object[] item in listPagedResult)
            {

                listMOMRegisterViewEntity.Add(new MOMRegisterViewEntity(
                    item[0] != null ? item[0].ToString() : null,
                    Convert.ToDateTime(item[1].ToString()),
                    item[2] != null ? item[2].ToString() : null,
                    item[3] != null ? item[3].ToString() : null,
                  item[4] != null ? item[4].ToString() : null,
                   item[5] != null ? item[5].ToString() : null,
                   item[6] != null ? item[6].ToString() : null
                    ));

            }

            return listMOMRegisterViewEntity;
        }

        internal List<EMSAppointmentEntity> GetListEMSAppointmentEntity(string EMSAccountId)
        {
            EMSAccount emsAccount = new EMSAccount { EMSAccountId = EMSAccountId };

            DetachedCriteria detachedCriteria = DetachedCriteria.For<EMSAppointment>()
               .Add(Expression.Eq("EMSAccount", emsAccount));

            List<EMSAppointment> listEMSAppointment = GetFromDetachedCriteria<EMSAppointment>(detachedCriteria);
            if (listEMSAppointment != null && listEMSAppointment.Count > 0)
            {
                return listEMSAppointment.Select(eMSAppointment => AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper.
                        EnforcementMapperToDTO.GetEMSAppointmentEntity(eMSAppointment)).ToList();
            }
            else
            {
                return null;
            }
        }
        private List<T> GetFromDetachedCriteria<T>(DetachedCriteria detachedCriteria)
        {
            IRepository<T> repository = new RepositoryImpl<T>(applicationSession);
            return repository.GetAll(detachedCriteria) as List<T>;
        }

        #endregion Methods
    }
}