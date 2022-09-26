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
            throw new NullEmptyNameException("Devi inserire un titolo");
        }
        Title = title;
        if (Date < DateTime.Now)
        {
            throw new NullEmptyDateException("Non puoi scegliere una data già processata");
        }
        Date = date;
    }

    public void bookSeats(int number)
    {
        if(MaxPeopleForEvent - number > 0 )
        {
            MaxPeopleForEvent -= number;
            Reservation += number;
        }
        if (MaxPeopleForEvent - number <= 0)
        {
            throw new BlockReservationException("Spiacente l'evento è già al completo");
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
                throw new ConfirmCancelReservationException("Prenotazione disdetta con successo");
            }
            else if (Reservation - number <= 0)
            {
                throw new DeniedCancelReservationException("Non è possibile disdire, controllare di aver selezionato l'evento corretto");
            }
        }
        if (Date != this.Date)
        {
            throw new MismathicngDateException("La data selezionata non corrisponde a nessun evento");
        }
    }

    public override string ToString()
    {
        return $"{Date.ToString("dd/MM/yyyy")}, {Title}";
    }
}

//se name è empty
public class NullEmptyNameException : Exception
{
    public NullEmptyNameException(string message) : base(message) { }
}
//se date è null
public class NullEmptyDateException : Exception
{
    public NullEmptyDateException(string message) : base(message) { }
}

//blocco prenotazione per evento completo
public class BlockReservationException : Exception
{
    public BlockReservationException(string message) : base(message) { }
}
//conferma cancellazione dopo aver prenotato
public class ConfirmCancelReservationException : Exception
{
    public ConfirmCancelReservationException(string message) : base(message) { }
}

//blocca cancellazione dopo aver prenotato
public class DeniedCancelReservationException : Exception
{
    public DeniedCancelReservationException(string message) : base(message) { }
}

//mismatching date

public class MismathicngDateException : Exception
{
    public MismathicngDateException(string message) : base(message) { }
}

