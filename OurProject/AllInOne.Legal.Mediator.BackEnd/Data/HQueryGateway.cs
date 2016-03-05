namespace AllInOne.Legal.Mediator.BackEnd.Data
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using AllInOne.Common.DataAccess.Utilities;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Enforcement;

    using log4net;

    using NHibernate;
    using NHibernate.Criterion;

    internal class HQueryEnforcementGateway : HQueryGateway
    {
        #region Constructors

        internal HQueryEnforcementGateway(ISession session)
            : base(session)
        {
        }

        internal HQueryEnforcementGateway()
            : base()
        {
        }

        #endregion Constructors

        #region Methods

        internal List<EnfrocementMaintainChequeQREntity> GetMaintainCheque(string chequeNoFrom, string chequeNoTo, DateTime payDateFrom, DateTime payDateTo, string subCaseNo, string accountNo, string chequeStatus, string chequeNo, bool isMainTainCheque, List<string> listForumId)
        {
            QueryParameterMaintainCheque queryParameter = new HQueryEnforcementGateway.QueryParameterMaintainCheque()
            {
                AccountNo = accountNo,
                DateFrom = payDateFrom,
                DateTo = payDateTo,
                ChequeNoFrom = chequeNoFrom,
                ChequeNoTo = chequeNoTo,
                CaseOrSubCaseNo = subCaseNo,
                ChequeStatus = chequeStatus,
                ChequeId = chequeNo,
                ListForumId = listForumId
            };

            List<EnfrocementMaintainChequeQREntity> listMaintainCheque = new List<EnfrocementMaintainChequeQREntity>();

            StringBuilder queryString = this.GetMaintainChequeHQuery().Append(this.GetMaintainChequeSearchParameters(queryParameter, "EMSCheque"));
            IQuery query = applicationSession.CreateQuery(queryString.ToString());
            query = this.InitializeMaintainChequeQueryParameters(query, queryParameter, "EMSCheque");
            IList<Hashtable> listPayemntResult = query.SetResultTransformer(NHibernate.Transform.Transformers.AliasToEntityMap).List<Hashtable>();

            //if (isMainTainCheque)
            //    listMaintainCheque.AddRange(this.TransformToMaintainChequeEntity(listPayemntResult).FilterUniqueByValue(unFilterList => unFilterList.EMSChequeId));
            //else
                listMaintainCheque.AddRange(this.TransformToMaintainChequeEntity(listPayemntResult, MaintainChequeType.M));

            StringBuilder queryStringHistory = this.GetMaintainChequeHistoryHQuery().Append(this.GetMaintainChequeHistorySearchParameters(queryParameter));
            IQuery queryHistory = applicationSession.CreateQuery(queryStringHistory.ToString());
            queryHistory = this.InitializeMaintainChequeQueryParameters(queryHistory, queryParameter, "EMSChequeHistory");
            IList<Hashtable> listPayemntResultHistory = queryHistory.SetResultTransformer(NHibernate.Transform.Transformers.AliasToEntityMap).List<Hashtable>();

            if (isMainTainCheque)
                listMaintainCheque.AddRange(this.TransformToMaintainChequeEntity(listPayemntResultHistory, MaintainChequeType.H).FilterUniqueByValue(unFilterList => unFilterList.EMSChequeHistoryId));
            //else
            //    listMaintainCheque.AddRange(this.TransformToMaintainChequeEntity(listPayemntResultHistory));

            StringBuilder queryStringStateFund = this.GetMaintainChequeStateFundHQuery().Append(this.GetMaintainChequeSearchParameters(queryParameter, "EMSStateFund"));
            IQuery queryStateFund = applicationSession.CreateQuery(queryStringStateFund.ToString());
            queryStateFund = this.InitializeMaintainChequeQueryParameters(queryStateFund, queryParameter, "EMSStateFund");
            IList<Hashtable> listPayemntResultStateFund = queryStateFund.SetResultTransformer(NHibernate.Transform.Transformers.AliasToEntityMap).List<Hashtable>();

            listMaintainCheque.AddRange(this.TransformToMaintainChequeEntity(listPayemntResultStateFund, MaintainChequeType.S));
            return listMaintainCheque;
        }

        internal List<EnfrocementProcessPaymentQREntity> GetProcessPayment(Criteria parmaCriteria)
        {
            return null;
        }

        internal List<EnfrocementProcessPaymentQREntity> GetProcessPayment(string paymentVoucherNo, DateTime voucherDateFrom, DateTime voucherDateTo, string subCaseNo, string payeeName, string accountNo, List<string> listForumId)
        {
            QueryParameter queryParameter = new HQueryEnforcementGateway.QueryParameter()
            {
                AccountNo = accountNo,
                DateFrom = voucherDateFrom,
                DateTo = voucherDateTo,
                PayeeId = payeeName,
                PaymentVoucherNo = paymentVoucherNo,
                CaseOrSubCaseNo = subCaseNo,
                ListForumId = listForumId
            };

            StringBuilder queryString = this.GetProcessPaymentHQuery().Append(this.GetProcessPaymentSearchParameters(queryParameter));
            IQuery query = applicationSession.CreateQuery(queryString.ToString());
            query = this.InitializeQueryParameters(query, queryParameter);
            IList<Hashtable> listPayemntResult = query.SetResultTransformer(NHibernate.Transform.Transformers.AliasToEntityMap).List<Hashtable>();

            return this.TransformToProcessPaymentEntity(listPayemntResult);
        }

        private StringBuilder GetMaintainChequeHistoryHQuery()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(" select " +
                             " CHH.EMSChequeHistoryId as EMSChequeHistoryId, " +
                             " CHH.OrgChequeNo as ChequeNo, " +
                             " CHH.OrgChequeStatus as ChequeStatus, " +
                             " CHH.OrgRemarks as ChequeRemarks, " +
                             " CHH.OrgPaymentDate as PaymentDate,  " +
                             " CH.EMSChequeId as EMSChequeId, " +
                             " CH.ChequeAmount as ChequeAmount, " +
                             " JU.UserName as PaymentOfficerName,  " +
                             " P.EMSPaymentId as EMSPaymentId, " +
                             " P.PaymentAmount as PaymentAmount, " +
                             " P.PayeeName as PayeeName, " +
                             " PV.PaymentVoucherNo as PaymentVoucherNo, " +
                             " PV.PaymentVoucherType as PaymentVoucherType, " +
                             " PV.ApprovedDate as ApprovedDate, " +
                             " AC.EMSAccountId as EMSAccountId, " +
                             " AC.AccountNo as AccountNo, " +
                             " AC.AccountSerialNo as AccountSerialNo, " +
                             " AC.AccountYear as AccountYear, " +
                             " SC.SubCaseInfoId as SubCaseInfoId, " +
                             " SC.SubCaseNo as SubCaseNo, " +
                             " CI.CaseInfoId as CaseInfoId, " +
                             " CI.CaseNo as CaseNo, " +
                             " 'ReIssued' as IsReIssued " +
                            " from EMSChequeHistory as CHH " +
                            " join CHH.EMSCheque as CH " +
                            " join CH.PaymentOfficer JU " +
                            " join CH.EMSPaymentCheques PC " +
                            " join PC.EMSPayment P " +
                            " join P.EMSPaymentVoucher PV " +
                            " join PV.EMSAccount AC " +
                            " left outer join AC.SubCaseInfo SC " //+
                            //" left outer join AC.CaseInfo CI "
                            );

            return strBuilder;
        }

        private StringBuilder GetMaintainChequeHistorySearchParameters(QueryParameterMaintainCheque queryParameter)
        {
            StringBuilder parameterQueryString = new StringBuilder();

            //FJ implementation
            parameterQueryString.Append(this.ComposeForumBaseSQL(queryParameter.ListForumId));

            if (queryParameter.IsAllParamNull())
            {
                return parameterQueryString; //No parameters to filter. Return empty string.
            }

            parameterQueryString.Append(" where ");

            bool isAndOperatorRequired = false;

            if (!string.IsNullOrEmpty(queryParameter.ChequeNoFrom) && !string.IsNullOrEmpty(queryParameter.ChequeNoTo))
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" (CHH.OrgChequeNo between  :chequeNoFrom and :chequeNoTo)  ");
                isAndOperatorRequired = true;
            }

            if (!string.IsNullOrEmpty(queryParameter.ChequeId))
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" CH.EMSChequeId  = :chequeId ");
                isAndOperatorRequired = true;
            }

            if (!string.IsNullOrEmpty(queryParameter.ChequeStatus))
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" CHH.OrgChequeStatus = :chequeStatus ");
                isAndOperatorRequired = true;
            }

            if (!string.IsNullOrEmpty(queryParameter.AccountNo))
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" AC.AccountNo = :accountNo ");
                isAndOperatorRequired = true;
            }

            if (!string.IsNullOrEmpty(queryParameter.CaseOrSubCaseNo))
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" (SC.SubCaseNo = :subCaseNo or CI.CaseNo = :subCaseNo) ");
                isAndOperatorRequired = true;
            }

            if (queryParameter.DateFrom != DateTime.MinValue && queryParameter.DateTo != DateTime.MinValue)
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" (CHH.OrgPaymentDate between  :paymentDateFrom and :paymentDateTo) ");
                isAndOperatorRequired = true;
            }

            if (isAndOperatorRequired)
            {
                parameterQueryString.Append(" and ");
            }
            parameterQueryString.Append(" (P.ObsInd = :obsIndP)  and (CH.ObsInd = :obsIndC) and (CHH.ObsInd = :obsIndCH)");

            return parameterQueryString;
        }

        private StringBuilder GetMaintainChequeHQuery()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(" select " +
                             " CH.EMSChequeId as EMSChequeId, " +
                             " CH.ChequeNo as ChequeNo, " +
                             " CH.ChequeStatus as ChequeStatus, " +
                             " CH.ChequeAmount as ChequeAmount, " +
                             " CH.Remarks as ChequeRemarks, " +
                             " CH.PaymentDate as PaymentDate,  " +
                             " JU.UserName as PaymentOfficerName,  " +
                             " P.EMSPaymentId as EMSPaymentId, " +
                             " P.PaymentAmount as PaymentAmount, " +
                             " P.PayeeName as PayeeName, " +
                             " PV.EMSPaymentVoucherId as PaymentVoucherId, " +
                             " PV.PaymentVoucherNo as PaymentVoucherNo, " +
                             " PV.PaymentVoucherType as PaymentVoucherType, " +
                             " PV.ApprovedDate as ApprovedDate, " +
                             " AC.EMSAccountId as EMSAccountId, " +
                             " AC.AccountNo as AccountNo, " +
                             " AC.AccountSerialNo as AccountSerialNo, " +
                             " AC.AccountYear as AccountYear, " +
                             " SC.SubCaseInfoId as SubCaseInfoId, " +
                             " SC.SubCaseNo as SubCaseNo, " +
                             " CI.CaseInfoId as CaseInfoId, " +
                             " CI.CaseNo as CaseNo, " +
                             " '' as IsReIssued " +
                            " from EMSCheque as CH " +
                            " join CH.PaymentOfficer JU " +
                            " join CH.EMSPaymentCheques PC " +
                            " join PC.EMSPayment P " +
                            " join P.EMSPaymentVoucher PV " +
                            " join PV.EMSAccount AC " +
                            //" join AC.SubCaseInfo SC " +
                            " left outer join AC.SubCaseInfo SC " //+
                            //" left outer join AC.CaseInfo CI "
                            );

            return strBuilder;
        }

        private StringBuilder GetMaintainChequeSearchParameters(QueryParameterMaintainCheque queryParameter, string type)
        {
            StringBuilder parameterQueryString = new StringBuilder();

            //FJ implementation
            parameterQueryString.Append(this.ComposeForumBaseSQL(queryParameter.ListForumId));

            if (queryParameter.IsAllParamNull())
            {
                return parameterQueryString; //No parameters to filter. Return empty string.
            }

            parameterQueryString.Append(" where ");

            bool isAndOperatorRequired = false;

            if (!string.IsNullOrEmpty(queryParameter.ChequeNoFrom) && !string.IsNullOrEmpty(queryParameter.ChequeNoTo))
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" (CH.ChequeNo between  :chequeNoFrom and :chequeNoTo)  ");
                isAndOperatorRequired = true;
            }

            if (!string.IsNullOrEmpty(queryParameter.ChequeId))
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" CH.EMSChequeId  = :chequeId ");
                isAndOperatorRequired = true;
            }

            if (!string.IsNullOrEmpty(queryParameter.ChequeStatus))
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" CH.ChequeStatus = :chequeStatus ");
                isAndOperatorRequired = true;
            }

            if (!string.IsNullOrEmpty(queryParameter.AccountNo))
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" AC.AccountNo = :accountNo ");
                isAndOperatorRequired = true;
            }

            if (!string.IsNullOrEmpty(queryParameter.CaseOrSubCaseNo))
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" (SC.SubCaseNo = :subCaseNo or CI.CaseNo = :subCaseNo )");
                isAndOperatorRequired = true;
            }

            if (queryParameter.DateFrom != DateTime.MinValue && queryParameter.DateTo != DateTime.MinValue)
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" (CH.PaymentDate between  :paymentDateFrom and :paymentDateTo) ");
                isAndOperatorRequired = true;
            }

            if (isAndOperatorRequired)
            {
                parameterQueryString.Append(" and ");
            }
            if (type == "EMSCheque")
                parameterQueryString.Append(" (P.ObsInd = :obsIndP)  and (CH.ObsInd = :obsIndC)");
            else if (type == "EMSStateFund")
                parameterQueryString.Append(" (SF.ObsInd = :obsIndP)  and (CH.ObsInd = :obsIndC)");

            return parameterQueryString;
        }

        private StringBuilder GetMaintainChequeStateFundHQuery()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(" select " +
                             " CH.EMSChequeId as EMSChequeId, " +
                             " CH.ChequeNo as ChequeNo, " +
                             " CH.ChequeStatus as ChequeStatus, " +
                             " CH.ChequeAmount as ChequeAmount, " +
                             " CH.Remarks as ChequeRemarks, " +
                             " CH.PaymentDate as PaymentDate,  " +
                             " JU.UserName as PaymentOfficerName,  " +
                             " SF.TransAmt as PaymentAmount, " +
                             " 'Transfer To State Fund' as PayeeName, " +
                             " AC.EMSAccountId as EMSAccountId, " +
                             " AC.AccountNo as AccountNo, " +
                             " AC.AccountSerialNo as AccountSerialNo, " +
                             " AC.AccountYear as AccountYear, " +
                             " SC.SubCaseInfoId as SubCaseInfoId, " +
                             " SC.SubCaseNo as SubCaseNo, " +
                             " CI.CaseInfoId as CaseInfoId, " +
                             " CI.CaseNo as CaseNo, " +
                             " '' as IsReIssued " +
                            " from EMSCheque as CH " +
                            " join CH.PaymentOfficer JU " +
                            " join CH.EMSStateFunds SF " +
                            " join SF.EMSAccount AC " +
                            " left outer join AC.SubCaseInfo SC " //+
                            //" left outer join AC.CaseInfo CI "
                            );

            return strBuilder;
        }

        private StringBuilder GetProcessPaymentHQuery()
        {
            StringBuilder strBuilder = new StringBuilder();
                strBuilder.Append(" select PV.EMSPaymentVoucherId as EMSPaymentVoucherId, ").Append(
                                    " PV.PaymentVoucherNo as PaymentVoucherNo, ").Append(
                                    " PV.PaymentVoucherType as PaymentVoucherType, ").Append(
                                    " PV.OCDocId as OCDocId, ").Append( //CR-ENFUAT-2012090101
                                    " PV.ApprovedDate as ApprovedDate, ").Append(
                                    " AC.EMSAccountId as EMSAccountId, ").Append(
                                    " AC.AccountNoCreatedDate as AccountNoCreatedDate, ").Append(
                                    " AC.AccountNo as AccountNo,  ").Append(
                                    " AC.AccountSerialNo as AccountSerialNo, ").Append(
                                    " AC.AccountYear as AccountYear, ").Append(
                                    " SC.SubCaseInfoId as SubCaseInfoId, ").Append(
                                    " SC.SubCaseNo as SubCaseNo, ").Append(
                                    " CI.CaseInfoId as CaseInfoId, ").Append(
                                    " CI.CaseNo as CaseNo, ").Append(
                                    " P.PayeeName as PayeeName, ").Append(
                                    " P.PaymentAmount as PaymentAmount, ").Append(
                                    " P.Type as PaymentType, ").Append(
                                    " P.EMSPaymentId as EMSPaymentId, ").Append(
                                    " P.PaymentStatus as PaymentStatus").Append(
                                    " from EMSPaymentVoucher as PV ").Append(
                                    " join PV.EMSAccount AC ").Append(
                                    " join PV.EMSPayments P ").Append(
                                    " left outer join AC.SubCaseInfo SC ");

            return strBuilder;
        }

        protected string ComposeForumBaseSQL(List<string> listForumId)
        {
            if (listForumId.HasContent())
                return " join AC.CaseInfo CI with CI.MForumType.ForumId in (:forumIds) ";
            else
                return " join AC.CaseInfo CI "; 
        }

        private StringBuilder GetProcessPaymentSearchParameters(QueryParameter queryParameter)
        {
            StringBuilder parameterQueryString = new StringBuilder();
            
            //FJ implementation
            parameterQueryString.Append(this.ComposeForumBaseSQL(queryParameter.ListForumId));

            if (queryParameter.IsAllParamNull())
            {
                return parameterQueryString; //No parameters to filter. Return empty string.
            }

            parameterQueryString.Append(" where ");

            bool isAndOperatorRequired = false;

            if (!string.IsNullOrEmpty(queryParameter.PaymentVoucherNo))
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" PV.PaymentVoucherNo = :paymentVoucherNo ");
                isAndOperatorRequired = true;
            }

            if (!string.IsNullOrEmpty(queryParameter.AccountNo))
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" AC.AccountNo = :accountNo ");
                isAndOperatorRequired = true;
            }

            if (!string.IsNullOrEmpty(queryParameter.PayeeId))
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" P.PayeeName = :payeeName ");
                isAndOperatorRequired = true;
            }

            if (!string.IsNullOrEmpty(queryParameter.CaseOrSubCaseNo))
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" (SC.SubCaseNo = :subCaseNo or CI.CaseNo = :subCaseNo) ");
                isAndOperatorRequired = true;
            }

            if (queryParameter.DateFrom != DateTime.MinValue && queryParameter.DateTo != DateTime.MinValue)
            {
                if (isAndOperatorRequired)
                {
                    parameterQueryString.Append(" and ");
                }

                parameterQueryString.Append(" (PV.ApprovedDate between  :voucherDateFrom and :voucherDateTo) ");
                isAndOperatorRequired = true;
            }

            if (isAndOperatorRequired)
            {
                parameterQueryString.Append(" and ");
            }
            parameterQueryString.Append(" (P.PaymentStatus = :paymentStatus) and (P.ObsInd = :obsIndP)  and (PV.ObsInd = :obsIndPV) ");// and CHQ.ChequeStatus != :chequeStatus) ");
            isAndOperatorRequired = true;
            return parameterQueryString;
        }

        private IQuery InitializeMaintainChequeQueryParameters(IQuery query, QueryParameterMaintainCheque queryParameter, String type)
        {
            try
            {
                if (!string.IsNullOrEmpty(queryParameter.ChequeNoFrom) && !string.IsNullOrEmpty(queryParameter.ChequeNoTo))
                {
                    query.SetParameter("chequeNoFrom", queryParameter.ChequeNoFrom);
                    query.SetParameter("chequeNoTo", queryParameter.ChequeNoTo);
                }

                if (!string.IsNullOrEmpty(queryParameter.ChequeId))
                    query.SetParameter("chequeId", queryParameter.ChequeId);

                if (!string.IsNullOrEmpty(queryParameter.ChequeStatus))
                    query.SetParameter("chequeStatus", queryParameter.ChequeStatus);

                if (!string.IsNullOrEmpty(queryParameter.AccountNo))
                    query.SetParameter("accountNo", queryParameter.AccountNo);

                if (!string.IsNullOrEmpty(queryParameter.CaseOrSubCaseNo))
                    query.SetParameter("subCaseNo", queryParameter.CaseOrSubCaseNo);

                if (queryParameter.DateFrom != DateTime.MinValue && queryParameter.DateTo != DateTime.MinValue)
                {
                    query.SetParameter("paymentDateFrom", queryParameter.DateFrom);
                    query.SetParameter("paymentDateTo", queryParameter.DateTo);
                }

                query.SetParameter("obsIndP", "N"); // N == not osolete.
                query.SetParameter("obsIndC", "N"); // N == not osolete. //Need Attention !!! // not to use hard-coded value. to change.

                if (type == "EMSChequeHistory")
                    query.SetParameter("obsIndCH", "N"); // N == not osolete. //Need Attention !!! // not to use hard-coded value. to change.
                if (queryParameter.ListForumId.HasContent())
                    query.SetParameterList("forumIds", queryParameter.ListForumId); // Forum List For FJ/SU/HC

                return query;
            }
            catch (Exception e)
            {
                Logger.Error("In InitializeQueryParameters: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        private IQuery InitializeQueryParameters(IQuery query, QueryParameter queryParameter)
        {
            try
            {
                if (!string.IsNullOrEmpty(queryParameter.PaymentVoucherNo))
                    query.SetParameter("paymentVoucherNo", queryParameter.PaymentVoucherNo);

                if (!string.IsNullOrEmpty(queryParameter.AccountNo))
                    query.SetParameter("accountNo", queryParameter.AccountNo);

                if (!string.IsNullOrEmpty(queryParameter.PayeeId))
                    query.SetParameter("payeeName", queryParameter.PayeeId);

                if (!string.IsNullOrEmpty(queryParameter.CaseOrSubCaseNo))
                    query.SetParameter("subCaseNo", queryParameter.CaseOrSubCaseNo);

                if (queryParameter.DateFrom != DateTime.MinValue && queryParameter.DateTo != DateTime.MinValue)
                {
                    query.SetParameter("voucherDateFrom", queryParameter.DateFrom);
                    query.SetParameter("voucherDateTo", queryParameter.DateTo);
                }

                query.SetParameter("paymentStatus", "U"); // U == un-processed.
                query.SetParameter("obsIndP", "N"); // N == not osolete.
                query.SetParameter("obsIndPV", "N"); // N == not osolete. //Need Attention !!! // not to use hard-coded value. to change.
                
                if(queryParameter.ListForumId.HasContent())
                    query.SetParameterList("forumIds", queryParameter.ListForumId); // Forum List For FJ/SU/HC

                return query;
            }
            catch (Exception e)
            {
                Logger.Error("In InitializeQueryParameters: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        private List<EnfrocementMaintainChequeQREntity> TransformToMaintainChequeEntity(IList<Hashtable> listPayemntResult, MaintainChequeType maintainChequeType)
        {
            try
            {
                List<EnfrocementMaintainChequeQREntity> listEnfrocementMaintainChequeQREntity = new List<EnfrocementMaintainChequeQREntity>();

                for (int i = 0; i < listPayemntResult.Count; i++)
                {
                    EnfrocementMaintainChequeQREntity enfrocementMaintainChequeQREntity = new EnfrocementMaintainChequeQREntity();

                    enfrocementMaintainChequeQREntity.PaymentDate = Convert.ToDateTime(listPayemntResult[i]["PaymentDate"]);
                    enfrocementMaintainChequeQREntity.EMSAccountId = listPayemntResult[i]["EMSAccountId"] == null ? string.Empty : listPayemntResult[i]["EMSAccountId"].ToString();
                    enfrocementMaintainChequeQREntity.EMSAccountNo = listPayemntResult[i]["AccountNo"] == null ? string.Empty : listPayemntResult[i]["AccountNo"].ToString();
                    enfrocementMaintainChequeQREntity.AccountSerialNo = listPayemntResult[i]["AccountSerialNo"] == null ? 0 : Convert.ToInt32(listPayemntResult[i]["AccountSerialNo"]);
                    enfrocementMaintainChequeQREntity.AccountYear = listPayemntResult[i]["AccountYear"] == null ? 0 : Convert.ToInt32(listPayemntResult[i]["AccountYear"]);
                    enfrocementMaintainChequeQREntity.PartyName = listPayemntResult[i]["PayeeName"] == null ? string.Empty : listPayemntResult[i]["PayeeName"].ToString();
                    enfrocementMaintainChequeQREntity.SubCaseInfoId = listPayemntResult[i]["SubCaseInfoId"] == null ? string.Empty : listPayemntResult[i]["SubCaseInfoId"].ToString();
                    enfrocementMaintainChequeQREntity.SubCaseNo = listPayemntResult[i]["SubCaseNo"] == null ? string.Empty : listPayemntResult[i]["SubCaseNo"].ToString();
                    enfrocementMaintainChequeQREntity.CaseInfoId = listPayemntResult[i]["CaseInfoId"] == null ? string.Empty : listPayemntResult[i]["CaseInfoId"].ToString();
                    enfrocementMaintainChequeQREntity.CaseNo = listPayemntResult[i]["CaseNo"] == null ? string.Empty : listPayemntResult[i]["CaseNo"].ToString();
                    enfrocementMaintainChequeQREntity.ChequeAmount = listPayemntResult[i]["ChequeAmount"] == null ? 0 : Convert.ToDecimal(listPayemntResult[i]["ChequeAmount"]);
                    enfrocementMaintainChequeQREntity.EMSPaymentId = listPayemntResult[i]["EMSPaymentId"] == null ? string.Empty : listPayemntResult[i]["EMSPaymentId"].ToString();
                    enfrocementMaintainChequeQREntity.ChequeNo = listPayemntResult[i]["ChequeNo"] == null ? string.Empty : listPayemntResult[i]["ChequeNo"].ToString();
                    enfrocementMaintainChequeQREntity.EMSChequeId = listPayemntResult[i]["EMSChequeId"] == null ? string.Empty : listPayemntResult[i]["EMSChequeId"].ToString();
                    enfrocementMaintainChequeQREntity.PaymentVoucherNo = listPayemntResult[i]["PaymentVoucherNo"] == null ? string.Empty : listPayemntResult[i]["PaymentVoucherNo"].ToString();
                    enfrocementMaintainChequeQREntity.PaymentVoucherType = listPayemntResult[i]["PaymentVoucherType"] == null ? PaymentVoucherType.F : (PaymentVoucherType)Enum.Parse(typeof(PaymentVoucherType), listPayemntResult[i]["PaymentVoucherType"].ToString());
                    enfrocementMaintainChequeQREntity.PaymentVoucherId = listPayemntResult[i]["PaymentVoucherId"] == null ? string.Empty : listPayemntResult[i]["PaymentVoucherId"].ToString();
                    enfrocementMaintainChequeQREntity.PaymentAmount = listPayemntResult[i]["PaymentAmount"] == null ? 0 : Convert.ToDecimal(listPayemntResult[i]["PaymentAmount"]);
                    enfrocementMaintainChequeQREntity.ApprovedDate = listPayemntResult[i]["ApprovedDate"] == null ? DateTime.MinValue : Convert.ToDateTime(listPayemntResult[i]["ApprovedDate"]);
                    enfrocementMaintainChequeQREntity.ChequeStatus = listPayemntResult[i]["ChequeStatus"] == null ? PaymentChequeStatus.Null : (PaymentChequeStatus)Enum.Parse(typeof(PaymentChequeStatus), listPayemntResult[i]["ChequeStatus"].ToString());
                    enfrocementMaintainChequeQREntity.PaymentOfficerName = listPayemntResult[i]["PaymentOfficerName"] == null ? string.Empty : listPayemntResult[i]["PaymentOfficerName"].ToString();
                    enfrocementMaintainChequeQREntity.ChequeRemarks = listPayemntResult[i]["ChequeRemarks"] == null ? string.Empty : listPayemntResult[i]["ChequeRemarks"].ToString();
                    enfrocementMaintainChequeQREntity.EMSChequeHistoryId = listPayemntResult[i]["EMSChequeHistoryId"] == null ? string.Empty : listPayemntResult[i]["EMSChequeHistoryId"].ToString();
                    enfrocementMaintainChequeQREntity.IsReIssued = listPayemntResult[i]["IsReIssued"] == null ? string.Empty : listPayemntResult[i]["IsReIssued"].ToString();
                    enfrocementMaintainChequeQREntity.MaintainChequeType = maintainChequeType;
                    listEnfrocementMaintainChequeQREntity.Add(enfrocementMaintainChequeQREntity);
                }

                return listEnfrocementMaintainChequeQREntity;
            }
            catch (Exception e)
            {
                Logger.Error("In TransformToProcessPaymentEntity: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        private List<EnfrocementProcessPaymentQREntity> TransformToProcessPaymentEntity(IList<Hashtable> listPayemntResult)
        {
            try
            {
                List<EnfrocementProcessPaymentQREntity> listEnfrocementProcessPaymentQREntity = new List<EnfrocementProcessPaymentQREntity>();

                for (int i = 0; i < listPayemntResult.Count; i++)
                {
                    EnfrocementProcessPaymentQREntity enfrocementProcessPaymentQREntity = new EnfrocementProcessPaymentQREntity();
                    enfrocementProcessPaymentQREntity.EMSPaymentVoucherId = listPayemntResult[i]["EMSPaymentVoucherId"].ToString();
                    enfrocementProcessPaymentQREntity.EMSPaymentVoucherNo = listPayemntResult[i]["PaymentVoucherNo"] == null ? string.Empty : listPayemntResult[i]["PaymentVoucherNo"].ToString();
                    enfrocementProcessPaymentQREntity.PaymentVoucherType = listPayemntResult[i]["PaymentVoucherType"] == null ? PaymentVoucherType.F : (PaymentVoucherType) Enum.Parse(typeof(PaymentVoucherType), listPayemntResult[i]["PaymentVoucherType"].ToString());
                    enfrocementProcessPaymentQREntity.ApprovedDate = Convert.ToDateTime(listPayemntResult[i]["ApprovedDate"]);
                    enfrocementProcessPaymentQREntity.EMSAccountId = listPayemntResult[i]["EMSAccountId"].ToString();
                    enfrocementProcessPaymentQREntity.AccountNoCreatedDate = listPayemntResult[i]["AccountNoCreatedDate"] == null ? DateTime.MinValue : Convert.ToDateTime(listPayemntResult[i]["AccountNoCreatedDate"]);//CR-ENFUAT-2012082901 - Mantis: 0006104
                    enfrocementProcessPaymentQREntity.EMSAccountNo = listPayemntResult[i]["AccountNo"] == null ? string.Empty : listPayemntResult[i]["AccountNo"].ToString();
                    enfrocementProcessPaymentQREntity.AccountSerialNo = listPayemntResult[i]["AccountSerialNo"] == null ? 0 : Convert.ToInt32(listPayemntResult[i]["AccountSerialNo"]);
                    enfrocementProcessPaymentQREntity.AccountYear = listPayemntResult[i]["AccountYear"] == null ? 0 : Convert.ToInt32(listPayemntResult[i]["AccountYear"]);
                    enfrocementProcessPaymentQREntity.PartyName = listPayemntResult[i]["PayeeName"] == null ? string.Empty : listPayemntResult[i]["PayeeName"].ToString();
                    enfrocementProcessPaymentQREntity.CaseInfoId = listPayemntResult[i]["CaseInfoId"] == null ? string.Empty : listPayemntResult[i]["CaseInfoId"].ToString();
                    enfrocementProcessPaymentQREntity.CaseNo = listPayemntResult[i]["CaseNo"] == null ? string.Empty : listPayemntResult[i]["CaseNo"].ToString();
                    enfrocementProcessPaymentQREntity.SubCaseInfoId = listPayemntResult[i]["SubCaseInfoId"] == null ? string.Empty : listPayemntResult[i]["SubCaseInfoId"].ToString();
                    enfrocementProcessPaymentQREntity.SubCaseNo = listPayemntResult[i]["SubCaseNo"] == null ? string.Empty : listPayemntResult[i]["SubCaseNo"].ToString();
                    enfrocementProcessPaymentQREntity.EMSPaymentAmount = listPayemntResult[i]["PaymentAmount"] == null ? 0 : Convert.ToDecimal(listPayemntResult[i]["PaymentAmount"]);
                    enfrocementProcessPaymentQREntity.PaymentType = listPayemntResult[i]["PaymentType"] == null ? PaymentType.Null : (PaymentType)Enum.Parse(typeof(PaymentType), listPayemntResult[i]["PaymentType"].ToString());
                    enfrocementProcessPaymentQREntity.EMSPaymentId = listPayemntResult[i]["EMSPaymentId"] == null ? string.Empty : listPayemntResult[i]["EMSPaymentId"].ToString();
                    enfrocementProcessPaymentQREntity.OCDocId = listPayemntResult[i]["OCDocId"] == null ? string.Empty : listPayemntResult[i]["OCDocId"].ToString();//CR-ENFUAT-2012090101
                    listEnfrocementProcessPaymentQREntity.Add(enfrocementProcessPaymentQREntity);
                }

                return listEnfrocementProcessPaymentQREntity;
            }
            catch (Exception e)
            {
                Logger.Error("In TransformToProcessPaymentEntity: Message - " + e.Message + " StackTrace - " + e.StackTrace);
                throw;
            }
        }

        #endregion Methods

        #region Nested Types

        private class QueryParameter
        {
            #region Properties

            internal string AccountNo
            {
                get; set;
            }

            internal string CaseOrSubCaseNo
            {
                get; set;
            }

            internal DateTime DateFrom
            {
                get; set;
            }

            internal DateTime DateTo
            {
                get; set;
            }

            internal bool IsCase
            {
                get; set;
            }

            internal string PayeeId
            {
                get; set;
            }

            internal string PaymentVoucherNo
            {
                get; set;
            }

            internal List<string> ListForumId
            { get; set; }

            #endregion Properties

            #region Methods

            internal virtual bool IsAllParamNull()
            {
                if (string.IsNullOrEmpty(PaymentVoucherNo) && string.IsNullOrEmpty(CaseOrSubCaseNo) && string.IsNullOrEmpty(AccountNo)
                        && string.IsNullOrEmpty(PayeeId) && DateFrom == DateTime.MinValue && DateTo == DateTime.MinValue)
                { return true; }

                return false;
            }

            #endregion Methods
        }

        private class QueryParameterMaintainCheque : QueryParameter
        {
            #region Properties

            internal string ChequeId
            {
                get; set;
            }

            internal string ChequeNoFrom
            {
                get; set;
            }

            internal string ChequeNoTo
            {
                get; set;
            }

            internal string ChequeStatus
            {
                get; set;
            }

            internal List<string> ListForumId
            { get; set; }

            #endregion Properties

            #region Methods

            internal override bool IsAllParamNull()
            {
                if (string.IsNullOrEmpty(PaymentVoucherNo) && string.IsNullOrEmpty(CaseOrSubCaseNo) && string.IsNullOrEmpty(AccountNo)
                        && string.IsNullOrEmpty(PayeeId) && DateFrom == DateTime.MinValue && DateTo == DateTime.MinValue
                        && string.IsNullOrEmpty(ChequeNoFrom) && string.IsNullOrEmpty(ChequeNoTo) && string.IsNullOrEmpty(ChequeStatus)
                        && string.IsNullOrEmpty(ChequeId))
                { return true; }

                return false;
            }

            #endregion Methods
        }

        #endregion Nested Types
    }

    internal class HQueryGateway : AbstractGateway
    {
        #region Constructors

        internal HQueryGateway(ISession session)
            : base(session)
        {
        }

        internal HQueryGateway()
            : base()
        {
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Passes the <paramref name="columnName"/> and <paramref name="value"/>. Get the <typeparam name="T"></typeparam> back.
        /// </summary>
        /// <typeparam name="V">Type of the value to use as a filter.</typeparam>
        /// <param name="columnName">The name of the filed to filter while retrieving objects.</param>
        /// <param name="value">The value of the filed to filter while retrieving objects.</param>
        /// <returns>List<T></returns>
        internal override List<T> GetEntity<T, V>(string columnName, V value, bool isNotObs)
        {
            return null;
        }

        #endregion Methods
    }
}