using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFWebService_ASMX.Model.WebService
{
    public interface WebServiceActoinInterface
    {
        /// <summary>
        /// 登入公司網站
        /// </summary>
        /// <param name="activity"></param>
        string login();
    }
}
