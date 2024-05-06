using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.DemoUI.WebAbstraction
{
    public interface IRegPortalPage
    {
        void CheckPageTitle(string pageTitle);

        void CkickTpForeignEcommerceVatCollector();

        void RegTabNextBtnClick();

        void EnterCompanyName(string companyName);

        void RegTabNextTpIdClick();

        void ContactTabEnterEmail(string email);

        void ClickContactTabEmailVerify();

        void EnterOTP(string strOTP);

        void ClockContactTabVerifyOTP();
    }


}
