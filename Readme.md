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
