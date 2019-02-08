# LNKupdater
Small tool to edit/update TargetURL of multiple LNK-files (windows shortcuts) with find and replace (string)

LNKupdater is a tool (programmed in C#) to manipulate the TargetURL of programm links (lnk-files) of Windows.

Just choose a directory, with the option for recursive (sub-directories) and set a Filename-Filter, if wanted.
The Filename-Filter string is searched and the file will not be collected to the filelist, if the string was not found.

In the section "TargetURL" the Find and Replace string should be set.

**For example:**

All existing links are pointing to c:\Tools\... and they should point to the new place d:\Tools\.
Then you should add "c:\Tools" as "Find" string and "d:\Tools" to the "Replace" string.

After clicking "REPLACE" button all listed files will be updated with search and replace and is updating the URL.

**Additional function:**
All listed files can be removed with the "Delete Files" button.

Njoy my first C# open source project. 

Hope it help you with your daily stuff. :)
