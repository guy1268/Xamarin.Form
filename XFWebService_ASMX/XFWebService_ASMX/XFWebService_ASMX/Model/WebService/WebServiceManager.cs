using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFWebService_ASMX.Model.WebService
{
    public class WebServiceManager
    {
        private WebServiceActoinInterface webServiceActoinInterface;

        public WebServiceManager(WebServiceActoinInterface _WebServiceActoinInterface)
        {
            webServiceActoinInterface = _WebServiceActoinInterface;
        }

        /// <summary>
        /// 登入公司網站
        /// </summary>
        /// <param name="activity"></param>
        public string call_login()
        {
            return webServiceActoinInterface.login();
        }
    }
}
