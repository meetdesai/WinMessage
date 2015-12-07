# WinMessage - iMessage/Remote Messages client for Windows.
<h2><a href="https://github.com/0xFireball/WinMessage/releases/download/v1.1.1/WinMessageSetup.exe" class="btn">Download Latest Build</a></h2>

Apple has had a history of being exclusive with its technologies.
iMessage has been available on OSX for a long time, but Windows users
have been forced to use their mobile devices, left without a desktop client.

WinMessage changes this, allowing you to access all the features of
iMessage from your Windows PC. It works by connecting to a WebSocket
server called Remote Messages, which must be installed on your device
in order to use WinMessage.

![Screenshot](https://raw.githubusercontent.com/0xFireball/WinMessage/master/screenshot.PNG)

# What's new in this version
## Version 1.1 brings new features to the client, including integrated USB connection support with the new included USBTool program.
### Version 1.1.0
- Now, you can connect to your iPhone/iPad when your computer does not have a network connection;
as long as your device has MMS/SMS or cellular data network connectivity.
- This works through the open-source tool iProxy; USBTool provides a graphical frontend for this tool.

### Version 1.1.1
- Report issues from inside the app.
- Update checker.

# Get WinMessage
## You can download builds [here](https://github.com/0xFireball/WinMessage/releases/).
## The latest builds are available at the top of this page.

# About/Server Requirements
- WinMessage uses the Remote Messages server.
You must first install this on your iOS device in order to use
WinMessage.
- WinMessage may disconnect from the iOS device after some time;
this can be solved by plugging the device in to a power source. 

# Build
 - Build with a developer command prompt, run releasebuild.bat.
 - WinMessage depends on Awesomium.NET; in order to build WinMessage,
 you will have to install the Awesomium.NET SDK.
 - WinMessage also depends on MK.MobileDevice; this open-source library
  is available <a href="https://github.com/exaphaser/MK.MobileDevice">from ExaPhaser on GitHub</a>.
 - Prebuilt releases are available.  
 
 
 # License Information
 - WinMessage is FREE SOFTWARE, however, you may not distribute or modify
 it without explicit permission. We may decide to add an open-source
 license in the future, but for the time being, distribution and
 commercial use are explicitly prohibited. 
