public class games {
    public string Nazv;
    public string Janr;
    public int God;
    public int Reyt;
    public int Proces;

    public int Dostizheniya { get; private set; }

    public games(string nazv, int god, int reyt, int proces, int dostizheniya) {
        Nazv = nazv;
        God = god;
        Reyt = reyt;
        Proces = proces;
        Janr = "Action";

        Dostizheniya = 0;
    }

    public void AddDostizhenie(int skolko) {
        if (skolko <= 0) {
            return;
        }

        Dostizheniya += skolko;
    }

    public bool igral() {
        return Proces > 0;
    }
        public bool CanBeCompleted() {
        return Proces == 0;
    }
}
public class GameCatalog {
    private List<games> _games = new List<games>();

    public string Name { get; private set; }

    public int GameCount {
        get { return _games.Count; }
    }

    public GameCatalog(string name) {
        Name = name;
    }

    public bool AddGame(games game) {
        if (FindByName(game.Nazv) != null) {
            return false;
        }

        _games.Add(game);
        return true;
    }

    public games? FindByName(string name) {
        if (string.IsNullOrWhiteSpace(name)) {
            return null;
        }

        string searchName = name.Trim();

        foreach (games g in _games) {
            if (string.Equals(g.Nazv, searchName, StringComparison.OrdinalIgnoreCase)) {
                return g;
            }
        }

        return null;
    }

    public bool RemoveByName(string name) {
        games? game = FindByName(name);
        if (game == null) {
            return false;
        }
        return _games.Remove(game);
    }

    public List<games> GetGames() {
        List<games> result = new List<games>();
        foreach (games g in _games) {
            result.Add(g);
        }
        return result;
    }

    public int CountHighRated(int minimum) {
        int count = 0;
        foreach (games g in _games) {
            if (g.Reyt >= minimum) {
                count += 1;
            }
        }
        return count;
    }
}
public class Playthrough {
public games? Target { get; private set; }
public bool IsFinished { get; private set; }

public bool TryStart(games game) {
    if (IsFinished) {
        return false;
    }
    if (Target != null) {
        return false;
     }
        if (!game.CanBeCompleted()) {
        return false;
    }

    Target = game;
    return true;
    }

    public bool TryFinish() {
        if (IsFinished) {
            return false;
        }
        if (Target == null) {
            return false;
        }
        if (!Target.CanBeCompleted()) {
            return false;
        }
        
        Target.Proces = 10;
        Target.AddDostizhenie(1);
        IsFinished = true;
        return true;
    }
}
