// See https://aka.ms/new-console-template for more information

using System.Data;

class Event
{
    public string Title { get; set; }

    public DateTime Date { get; private set; }
    public int MaxPeopleForEvent { get; private set; }
    public int Reservation { get; private set; } = 0;

    public Event(string title, DateTime date, int maxPeopleForEvent)
    {
        Title = title;
        Date = date;
        MaxPeopleForEvent = maxPeopleForEvent;

        if (Title == "")
        {
            throw new noName("Devi inserire un titolo");
        }
        Title = title;
        if (Date < DateTime.Now)
        {
            throw new noDate("Non puoi scegliere una data già processata");
        }
        Date = date;
    }

    public void bookSeats(int number)
    {
        if(MaxPeopleForEvent - number > 0 )
        {
            MaxPeopleForEvent -= number;
            Reservation += number;
            Console.WriteLine("Prenotazione effettuata con successo");
            Console.WriteLine($"Posti ancora disponibili n:{MaxPeopleForEvent}, posti prenotati n:{Reservation}");
        }
        if (MaxPeopleForEvent - number <= 0)
        {
            Console.WriteLine("Spiacente l'evento è già al completo");
        }
    }

    public void cancelReservation(int number)
    {

        if(Date == this.Date)
        {
            if (Reservation - number > 0)
            {
                Reservation -= number;
                MaxPeopleForEvent += number;
                Console.WriteLine("Prenotazione disdetta con successo");
                Console.WriteLine($"Posti ancora disponibili n:{MaxPeopleForEvent}, posti prenotati n:{Reservation}");
            }
            else if (Reservation - number <= 0)
            {
                Console.WriteLine("Non è possibile disdire, controllare di aver selezionato l'evento corretto");
            }
        }
        if (Date != this.Date)
        {
            Console.WriteLine("La data selezionata non corrisponde a nessun evento");
        }
    }

    public override string ToString()
    {
        return $"{Date.ToString("dd/MM/yyyy")}, {Title}";
    }
}

public class noName : Exception
{
    public noName(string message) : base(message) { }
}
public class noDate : Exception
{
    public noDate(string message) : base(message) { }
}