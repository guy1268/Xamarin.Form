using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using XFWebService_ASMX.Model.WebService;

namespace XFWebService_ASMX.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        #region showWebService
        private string _showWebService;
        /// <summary>
        /// showWebService
        /// </summary>
        public string showWebService
        {
            get { return this._showWebService; }
            set { this.SetProperty(ref this._showWebService, value); }
        }
        #endregion


        private static WebServiceManager _webSerManager;
        public static WebServiceManager WebSerManager
        {
            get
            {
                return _webSerManager;
            }

            set
            {
                _webSerManager = value;
            }
        }

        public MainPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";

            showWebService = _webSerManager.call_login();
        }
    }
}
