using XFWebService_ASMX.Model.WebService;

namespace XFWebService_ASMX.iOS.Model.WebService
{
    class MobileWebService : WebServiceActoinInterface
    {
        WebServiceASMXTest.test3 _Webservice = new WebServiceASMXTest.test3();

        public string login()
        {
            return _Webservice.Getest("a");
        }
    }
}