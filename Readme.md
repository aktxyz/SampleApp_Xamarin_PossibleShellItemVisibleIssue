# SampleApp_Xamarin_PossibleShellItemVisibleIssue

This app shoes some inconsistent behavior with Shell Item visibility between IOS and ANDROID.

- when run on IOS
  - the shell tab visibility gets properly updated
    - THESE ALL WORK FINE
    - tap Mode0 button, should only show ABOUT, LOGIN tabs
    - tap Mode1 button, should only show ABOUT, LOGIN, MODE1 tabs
    - tap Mode2 button, should only show ABOUT, LOGIN, MODE2 tabs

- when run on ANDROID
  - the shell tab visibility gets properly updated
    - THESE ALL FAIL, visibility of tabs is never changed
    - tap Mode0 button, should only show ABOUT, LOGIN tabs --- BUT SHOWS ALL TABS
    - tap Mode1 button, should only show ABOUT, LOGIN, MODE1 tabs --- BUT SHOWS ALL TABS
    - tap Mode2 button, should only show ABOUT, LOGIN, MODE2 tabs --- BUT SHOWS ALL TABS

This has all been using the latest (as of 8/20/2020) Xamarin goodies v4.8.0.1269.

The AppShell.xaml has the IsVisible property for some tabs bound IsMode1 and IsMode2 boolean properties.

These props are then flipped in event handlers here

- <https://github.com/aktxyz/SampleApp_Xamarin_PossibleShellItemVisibleIssue/blob/master/App6/App6/Views/AboutPage.xaml.cs#L49>
- <https://github.com/aktxyz/SampleApp_Xamarin_PossibleShellItemVisibleIssue/blob/master/App6/App6/Views/LoginPage.xaml.cs#L49>
