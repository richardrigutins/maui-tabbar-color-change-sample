# maui-tabbar-color-change-sample

This repository contains a minimal sample to reproduce the color change
in the tab bar on Android when navigating between different flyout pages
in a .NET MAUI application.

If the dark theme is enabled in the Android device settings, the bottom
tab bar is displayed in the dark theme color. When navigating between
different flyout pages, where only one of the pages has a bottom tab bar,
the bottom tab bar is briefly displayed as white before changing back to
the dark theme color.

## Steps to reproduce

1. Enable the dark theme in the Android device settings
2. Launch the application on Android
3. The bottom tab bar is displayed in the dark theme color
4. Open the flyout menu and navigate to the About page
5. Open the flyout menu again and navigate to the Home page
6. The bottom tab bar is briefly displayed as white before changing
back to the dark theme color.
