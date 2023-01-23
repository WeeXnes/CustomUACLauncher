# CustomUACLauncher
Simple programm that takes a path to an exe file as an argument and launches it with admin permissions
(for example for use in the context menu)
## Example:
e.g. when using the terminal "Hyper.is" thers no simple way to launch it as admin from the context menu (right click menu).
Using this programm it handles as a "middleman" that gets launched instead and then launches the desired programm (in this case hyper.is) with admin permissions
## Usage:
1. Create a new Registry Key in:
```
HKEY_CLASSES_ROOT\Directory\shell\
```
2. Inside the newly created Registry Key, change the default value to the text you want displayed inside the context menu<br><br>
3. Inside the Registry Key, create a new STRING VALUE and name it "Icon" and as the Value, paste in the path to an .ico or .exe to add an icon to the context menu entry<br><br>
4. Create a new Registry Key inside the previously created Registry key and call it "command"<br><br>
5. Change the default value of the Registry Key you just created to the path of the <a href="https://github.com/WeeXnes/CustomUACLauncher/releases">exe file of this programm</href> like this:<br><br>
```
C:\Users\username\Downloads\CustomUACLauncher\CustomUACLauncher.exe -app "C:\Users\username\AppData\Local\Programs\Hyper\Hyper.exe" -path "%V"
```
6. Thats it! now you can launch Hyper.is as admin from the context menu. this is usable for any programm. Hyper.is was just an example
