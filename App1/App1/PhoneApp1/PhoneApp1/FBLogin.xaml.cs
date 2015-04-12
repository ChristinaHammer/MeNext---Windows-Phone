using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;


namespace FacebookControls_WP8
{
    public partial class FBLogin : PhoneApplicationPage
    {
        public FBLogin()
        {
            InitializeComponent();
        }

        private void OnSessionStateChanged(object sender, Facebook.Client.Controls.SessionStateChangedEventArgs e)
        {
            this.ContentPanel.Visibility = (e.SessionState == Facebook.Client.Controls.FacebookSessionState.Opened) ?
                            Visibility.Visible : Visibility.Collapsed;
        }
    }
}