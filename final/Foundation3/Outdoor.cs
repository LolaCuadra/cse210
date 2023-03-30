class Outdoor : Event {
    private string weather;

    public Outdoor(string title, string description, DateTime dateTime, Address address, string weather) : base(title, description, dateTime, address) {
        this.weather = weather;
    }

    public override string GetShortDescription() {
        return $"Outdoor Gathering: {GetTitle()} on {GetDateTime().ToShortDateString()}";
    }

    public override string GetStandardDetails() {
        return $"Title: {GetTitle()}\nDescription: {GetDescription()}\nDate and Time: {dateTime.ToString()}\nAddress: {address.ToString()}";
    }

    public override string GetFullDetails() {
        return $"Title: {GetTitle()}\nDescription: {GetDescription()}\nDate and Time: {dateTime.ToString()}\nAddress: {address.ToString()}\nType of Event: Outdoor Gathering\nWeather Forecast: {weather}";
    }
}
