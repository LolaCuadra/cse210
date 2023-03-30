abstract class Event {
    private string title;
    private string description;
    public DateTime dateTime;
    public Address address;

    public Event(string title, string description, DateTime dateTime, Address address) {
        this.title = title;
        this.description = description;
        this.dateTime = dateTime;
        this.address = address;
    }

    public string GetTitle() {
        return title;
    }

    public string GetDescription() {
        return description;
    }

    public DateTime GetDateTime() {
        return dateTime;
    }

    public Address GetAddress() {
        return address;
    }

    public abstract string GetShortDescription();
    public abstract string GetStandardDetails();
    public abstract string GetFullDetails();
}