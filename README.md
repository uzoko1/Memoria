# Memoria
Final Fantasy IX tools

# Updates
1. Update the game to the latest version.
2. Update Memoria to the latest version.
3. **Delete** "Memoria.ini" from the game directory (otherwise you will not see new settings).
4. Patch again


# Build
1. Use Visual Studio 2015
2. Install Unity: https://unity3d.com/
3. Set a correct path to the Unity library folder in the Memoria.csproj (Notepad)
<FrameworkPathOverride>C:\Program Files\Unity\Editor\Data\Mono\lib\mono\unity\</FrameworkPathOverride>
4. Create the "\References" folder in the root solution directory.
5. Copy "Assembly-CSharp.dll", "UnityEngine.dll" and "XInputDotNetPure.dll" from "\FINAL FANTASY IX\x64\FF9_Data\Managed" to "\References"
6. Download "Mono.Cecil" package manualy or enable automaticaly package downloads.


# Patch:
1. Memoria.Patcher.exe - will patch game files using current directory or path from the windows registry
2. Memoria.Patcher.exe gameDirectory - will patch game files using a provided path


# First run:
1. Run game.
2. If there is no error you will see "Memoria.ini" file in the game directory.
3. If something went wrong you will see error in the "Memoria.log"
4. If you not see "Memoria.log" try to run game with administrator rights
5. If you see "Sharing violation on path" then close applications that hold this file
6. If you see "at Memoria.CsvReader.Read" then fix files in the StreamingAssets\Data directory or delete them and patch again.
7. If the error persists see "\FINAL FANTASY IX\x64(or x86)\FF9_Data\output_log.txt"


# Features:
1. Disable/Enable cheats
2. Fast battles (Change FPS, a Swirl duration, skip waiting or turn-based)
3. Save/Load anywhere (Alt+F5, Alt+F9) 
4. Edit game data (look at the "StreamingAssets\Data" folder)
5. All of the characters available (Alt+F2 to show a party window) [be careful](https://github.com/Albeoris/Memoria/issues/3)!
6. Easy rope jumping
7. Change the game font
8. Export text resources and field backgrounds
9. Import text resources


# Configuration:
1. Open Memoria.ini
2. Change "Enabled" value from "0" to "1" for what you need
3. Specify other params.
4. Save your edits and try run the game.


# Exported types (for developers)
1. Write you own type. Keep all members and its signature (private SerializeField too), name **and namespace**.
2. Mark it with ExportedTypeAttribute
3. Run patcher
4. Copy hash of type from console or Memoria.log and past to the ExportedTypeAttribute
5. Run the game, test all of you can and see output_log.txt for errors.

# Knowledge base
Please [visit our knowledge base](../../wiki#knowledge-base) before using this software.
