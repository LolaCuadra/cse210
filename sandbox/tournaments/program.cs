Console.WriteLne("Hello, World!");

Team firebirds = new Team("firebirds");

Player john = new Player ("John Molina", 12);
Player tim = new Player ("Tim Nunn", 13);
firebirds.AddPlayer(tim);
firebirds.AddPlayer(tim);
firebirds.DisplayRoster();

Team argentina = new Team("Argentina");

Player messi = new Player ("Lionel Messi", 10);
Player josue = new Player ("Josue Molina, 9");

argentina.AddPlayer(messi);
argentina.AddPlayer(josue);
argentina.DisplayRoster();

