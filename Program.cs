// See https://aka.ms/new-console-template for more information

class Event
{
    public string Title { get; set; }

    public DateTime EventDate = new DateTime(); 
    public int MaxPeopleForEvent { get; }
    public int Reservation { get; }

    public Event(string title, int maxPeopleForEvent, int reservation)
    {
        Title = title;
        MaxPeopleForEvent = maxPeopleForEvent;
        Reservation = reservation;
    }

    public void bookSeats(int number)
    {

    }
}
