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
}