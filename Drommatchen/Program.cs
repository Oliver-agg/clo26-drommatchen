Spelare spelare1 = new Spelare("Lionel Messi", 10, "Winger");
Spelare spelare2 = new Spelare("Cristiano Ronaldo", 9, "Striker");
Match match = new Match("Portugal", "Argentina", "2026-10-10");

match.Presentera();

match.AnnounceraMålskytt(spelare1);
match.AnnounceraMålskytt(spelare2);


// TODO: Skapa 1 match
// Match match = new Match("Hemmalag", "Bortalag", "Datum");

// TODO: Anropa match.Presentera()

// TODO: Anropa match.AnnounceraMålskytt() med båda spelarna
