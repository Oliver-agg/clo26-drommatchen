Spelare spelare1 = new Spelare("Lionel Messi", 10, "Winger");
Spelare spelare2 = new Spelare("Cristiano Ronaldo", 7, "Striker");

Match match = new Match("Portugal", "Argentina", "10-10-2026");

match.Presentera();

match.AnnounceraMålskytt(spelare1);
match.AnnounceraMålskytt(spelare2);
