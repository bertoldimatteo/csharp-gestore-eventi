// See https://aka.ms/new-console-template for more information

class Event
{
    public string Title { get; set; }

    public DateTime EventDate { get; private set; }
    public int MaxPeopleForEvent { get; private set; }
    public int Reservation { get; private set; }

    public Event(string title, DateTime, int maxPeopleForEvent, int reservation)
    {
        Title = title;
        MaxPeopleForEvent = maxPeopleForEvent;
        Reservation = reservation;
    }

    public void bookSeats(int number)
    {
        switch (number)
        {
            case 0:
                if(MaxPeopleForEvent - number > 0 )
                {
                    MaxPeopleForEvent -= number;
                    Reservation += number;
                    Console.WriteLine(MaxPeopleForEvent);
                    Console.WriteLine(Reservation);
                    Console.WriteLine("Prenotazione effettuata con successo");
                }
                break;
            case 1:
                if (MaxPeopleForEvent - number <= 0)
                {
                    Console.WriteLine("Spiacente l'evento è già al completo");
                }
                break;
            default:
                Console.WriteLine("Non è più possibile prenotare per questo evento");
                break;
        }
    }

    public void cancelReservation(int number)
    {
        
    }
}
