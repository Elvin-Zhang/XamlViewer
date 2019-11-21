﻿using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlViewer.ViewModels
{
    public class SettingViewModel : BindableBase
    {
        private string _show = "Setting";
        public string Show
        {
            get { return _show; }
            set { SetProperty(ref _show, value); }
        }
    }
}