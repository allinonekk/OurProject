using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AllInOne.Legal.Domain.Hospital;
using AllInOne.Legal.Mediator.BackEnd.Impl;
using AllInOne.Legal.Domain;
using AllInOne.Legal.Mediator.BackEnd;
using AllInOne.Legal.Binder.BackEnd;

namespace AllInOneConfigFile
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IPatientMediator imp = BinderSingleton.Instance.GetInstance<IPatientMediator>();
            imp.BeginTransaction();
            PatientInfoEntity objEntity = new PatientInfoEntity();
            objEntity.UserName = "Test";
            objEntity.PatientId = AllInOne.Common.Library.Util.CommonUtil.CreateUniqueID("BE");
            objEntity.EmailId = "test.test@gmail.com";
            objEntity.ObsInd = YesNo.N;
            objEntity.LastModifiedDate = DateTime.Now;
            objEntity.LastModifiedBy = "test";
            imp.SaveOrUpdatePatientInfoEntity(objEntity, true);
            imp.CommitAndCloseSession();


            objEntity = imp.GetPatientInfoEntity(objEntity.PatientId);
        }
    }
}