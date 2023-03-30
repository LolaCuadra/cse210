class Lecture : Event {
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime dateTime, Address address, string speaker, int capacity) : base(title, description, dateTime, address) {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetShortDescription() {
        return $"Lecture: {GetTitle()} on {GetDateTime().ToShortDateString()}";
    }

    public override string GetStandardDetails() {
        return $"Title: {GetTitle()}\nDescription: {GetDescription()}\nDate: {GetDateTime().ToShortDateString()}\nTime: {GetDateTime().ToShortTimeString()}\nAddress: {GetAddress()}";
    }

    public override string GetFullDetails() {
        return $"Type: Lecture\n{GetStandardDetails()}\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}