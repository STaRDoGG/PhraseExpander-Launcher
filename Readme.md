# PhraseExpander ("PE") Launcher is a simple utility to make sure PE launches properly upon Windows startup. #

## Screenshot ##
![The main and only screen.](http://i.imgur.com/xx23lDq.png)

## Description ##
On some computers, for unknown reasons, simply having some programs in your usual startup areas doesn't reliably launch the program. For me, PE is one of them, so I whipped up this little launcher for it.

You can also tweak the delay time before the launcher launches PE itself, and whether or not PE should start opened or minimized to the tray by checking/unchecking the "Autorun" box. Upon launching the launcher, the timer countdown begins immediately (watch the progressbar), and will launch PE when it's done. You can press the Pause button to pause the timer if you want to have time to tweak any of the launcher's settings, and/or use the Launch button to manually launch PE.

## Installation ##
* Just take the PhraseExpander Launcher.exe file and drop it into the same folder on your computer as PhraseExpander.exe.
* Remove any instances of the regular PE in any of the usual Windows startup areas of your computer (registry, startup folders, etc).
* Manually run this launcher once.
* Select a startup area to add this launcher to from the dropdown menu and click the Add button. You can also choose whether or not you want the launcher invisible while it runs.
* From that point on, forget about it as it launches PE for you automatically whenever you start up Windows. If you need/want to change anything with it later, manually run it again, you don't have to re-add it to any startup area if you're only changing the delay time, however, if you're adding/removing any of the AutoRun/Hidden options, you do, (See TODO:: below).

## Tip ##
For best results, choose the "AutoRun" and "Hidden" options before you click the Add button.

## Download ##
If you don't want to download the source code and compile it yourself, you can download the compiled Launcher from the releases area:

PhraseExpander-Launcher.zip
https://github.com/STaRDoGG/PhraseExpander-Launcher/releases

## ToDo ##
* Note that this is the first release and is considered Beta software.
* This launcher adds itself to the usual Windows startup areas, (your startup folder, or registry key, whichever you select) when you click the Add button; however, if you want to add it to a different area or re-add it after some changes, you'll need to manually remove the previous addition using the standard, well known, methods to do so. That said, down the road I'll possibly update the code to do all of this automatically, it's just not at the top of my TODO list as of right now.

## Disclaimer ##
This launcher was not created by, supported by, endorsed by or affiliated with the author(s) of PhraseExpander, so don't go to them for any support or questions related to this launcher. However, I am providing a link below to the PhraseExpander website in case you'd like to try it, buy it, etc.

http://geekdrop.com/x/phrase-expander
