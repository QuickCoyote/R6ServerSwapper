NOTE: this accesses the files in "userPath + "/Documents/My Games/Rainbow Six - Siege/". 
The user path is the Users Name. 

If you do not have a folder there, the application might crash. 
I'm not sure, but it doesn't NEED the additional support. 
If it's asked for I might implement / fix it.

ie. QuickCoyote/Documents/My Games/Rainbow Six - Siege/

After accessing that folder, it then goes through all folders in there

the Layout is
User Path
-> Documents
  -> My Games
    -> Rainbow Six - Siege
      -> Ubisoft User Id (This should be lots of random characters (numbers & numbers)
        -> GameSettings.ini

From there it modifies that GameSettings.ini file, and adjusts a line near the very bottom that says "DataCenterHint=" to whichever server you choose.
