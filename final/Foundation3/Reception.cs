class Reception : Event {
    private string rsvpEmail;

    public Reception(string title, string description, DateTime dateTime, Address address, string rsvpEmail) : base(title, description, dateTime, address) {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetShortDescription() {
        return $"Reception: {GetTitle()} on {GetDateTime().ToShortDateString()}";
    }

    public override string GetStandardDetails() {
        return $"Title: {GetTitle()}\nDescription: {GetDescription()}\nDate: {GetDateTime().ToShortDateString()}\nTime: {GetDateTime().ToShortTimeString()}\nAddress: {GetAddress()}";
    }

    public override string GetFullDetails() {
        return $"Type: Reception\n{GetStandardDetails()}\nRSVP email: {rsvpEmail}";
    }
}

