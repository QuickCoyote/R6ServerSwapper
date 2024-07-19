NOTE: this accesses the files in "userPath + "/Documents/My Games/Rainbow Six - Siege/" the user path is the Users Name.
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
