# Setup

## Dev Container

This project has been configured to run from a GitHub Dev Container. If you are not familiar with this, I have some instructions below on what you can do to get your computer configured for writing code.

## Scripts

I have included several scripts that can be used to help setup and configure your computer. If you are unfamiliar with what a Dev Container is, no worries, running one of the following scripts should automatically configure your computer for writing software code. These scripts are taylor made for one of three primary operating systems.

- Windows
- iOS for Mac
- Ubuntu Linux

Should the automatic configuration script fail, manual installation steps can be found below.

### Windows

- Locate the script named see [/src/setup-windows.ps1](/src/setup-windows.ps1)
  - This script has been tested and should work.

### iOS

- Locate the script named see [/src/setup-mac.sh](/src/setup-mac.sh)
  - This script is untested and may not work as expected.

### Ubuntu

- Locate the script named see [/src/setup-ubuntu.sh](/src/setup-ubuntu.sh)
  - This script has been tested and should work.

## Manual Install Steps

To manually install the .NET SDK and set up VSCode, you can follow these steps:

1. Download the .NET SDK from the official Microsoft website: [https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)

2. Choose the appropriate version of the .NET SDK for your operating system and click on the download link.

3. Once the download is complete, run the installer and follow the on-screen instructions to install the .NET SDK.

4. Install VSCode from the website: [https://code.visualstudio.com/](https://code.visualstudio.com/)

5. After the installation is complete, open Visual Studio Code (VSCode).

6. Import VSCode Extensions Package

Note some of these steps may be slightly different depending on if your existing computer operating system and environment.

- ![Import VSCode Extensions 1](/src/Setup/Import%20VSCode%20Extensions%201.png)
  - Locate the 'cog' icon and click it
  - Select Profiles
  - Then select "Import Profile"
- ![Import VSCode Extensions 2](/src/Setup/Import%20VSCode%20Extensions%202.png)
  - Click the "Select File"
- ![Import VSCode Extensions 3](/src/Setup/Import%20VSCode%20Extensions%203.png)
  - Click "Show Local"
- ![Import VSCode Extensions 4](/src/Setup/Import%20VSCode%20Extensions%204.png)
  - Finally select the file "VSCode-Basic_Dev.code-profile" and import the profile along with its associated extensions.

Your base resources should now be installed and ready for use.
