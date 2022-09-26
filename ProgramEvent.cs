// See https://aka.ms/new-console-template for more information
class ProgramEvent
{
    public string Title { get; set; }

    private List<Event> events;

    public ProgramEvent(string title)
    {
        Title = title;
        events = new List<Event>();
    }

    public void addEvent(Event el)
    {
        events.Add(el);
    }

    public List<Event> dateEvent(string date)
    {
        string[] splitDate = date.Split('/');
        int day = Convert.ToInt32(splitDate[0]);
        int month = Convert.ToInt32(splitDate[1]);
        int year = Convert.ToInt32(splitDate[2]);
        DateTime eventDate = new DateTime(day, month, year);

        List<Event> result = events.FindAll(e => e.Date == eventDate);
        return result;
    }

    public static void printEvents(List<Event> allEvents)
    {
        Console.WriteLine("Lista Eventi:");
        foreach (Event el in allEvents)
        {
            Console.WriteLine(el);
        }
    }
}