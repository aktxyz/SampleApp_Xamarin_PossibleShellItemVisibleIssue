using System;
using System.Collections.Generic;

using Xamarin.Forms;

using App6.Views;

namespace App6
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public static AppShell Instance { get; set; }

        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
            Instance = this;
        }

        private int _mode = 1;

        public int Mode
        {
            get { return _mode; }
            set
            {
                if (_mode != value)
                {
                    _mode = value;
                    OnPropertyChanged(nameof(Mode));
                    OnPropertyChanged(nameof(IsMode1));
                    OnPropertyChanged(nameof(IsMode2));
                }
            }
        }

        public bool IsMode1 { get { return _mode == 1; } }
        public bool IsMode2 { get { return _mode == 2; } }

    }
}
