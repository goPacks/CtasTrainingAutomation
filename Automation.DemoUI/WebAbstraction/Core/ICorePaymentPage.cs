using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.DemoUI.WebAbstraction.Core
{
    public interface ICorePaymentPage
    {




        void CheckPageTitle(string pageTitle);

        void ClickOnSideMenu(string sideMenu);


        void SelfServiceBillingCodeCreation(string objectPermitNumber);


        void EnterRequestNumber(string requestNumber);
    }
}
