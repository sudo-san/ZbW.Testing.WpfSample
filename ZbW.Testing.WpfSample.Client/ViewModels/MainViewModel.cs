using System.Collections.Generic;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using ZbW.Testing.WpfSample.Client.Models;
using ZbW.Testing.WpfSample.Client.Services;

namespace ZbW.Testing.WpfSample.Client.ViewModels
{
    internal class MainViewModel : BindableBase
    {
        private readonly IpInfoReader _ipInfoReader;
        private string _ip;
        private List<IpDataObject> _ipDataObjectItems;

        public MainViewModel()
        {
            CmdLoad = new DelegateCommand(OnLoad);
            _ipInfoReader = new IpInfoReader();
        }

        public ICommand CmdLoad { get; }

        public string Ip
        {
            get => _ip;
            set => SetProperty(ref _ip, value);
        }

        public List<IpDataObject> IpDataObjectItems
        {
            get => _ipDataObjectItems;
            set => SetProperty(ref _ipDataObjectItems, value);
        }

        private void OnLoad()
        {
            IpDataObjectItems = new List<IpDataObject> {_ipInfoReader.GetData(Ip)};
        }
    }
}