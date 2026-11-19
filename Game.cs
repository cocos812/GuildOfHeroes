public class games {
    public string Nazv;
    public string Janr;
    public int God;
    public int Reyt;
    public int Proces;

    public int Dostizheniya { get; private set; }

    public games(string nazv, int god, int reyt, int proces) {
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
}