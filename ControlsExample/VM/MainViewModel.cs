﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DewUserControls.Common.Presentation;
namespace ControlsExample.VM
{
    class MainViewModel : NotifyPropertyChanged
    {
        private ObservableCollection<MainMenuItem> menuItems = new ObservableCollection<MainMenuItem>();

        public ObservableCollection<MainMenuItem> MenuItems
        {
            get { return menuItems; }
            set { menuItems = value; }
        }

        public MainViewModel()
        {
            MenuItems.Add(new MainMenuItem("Hamburger", "\uE700"));
        }

    }
}