// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digita il nome dell'evento che vuoi creare");
string eventName = Console.ReadLine();

Console.WriteLine("Digita la data dell'evento che vuoi creare (giorno/mese/anno)");
string eventDate = Console.ReadLine();

Console.WriteLine("Digita la capienza massima dell'evento che vuoi creare");
int eventAvailableSeats = Convert.ToInt32(Console.ReadLine());

string[] splitDate = eventDate.Split('/');
int day = Convert.ToInt32(splitDate[0]);
int month = Convert.ToInt32(splitDate[1]);
int year = Convert.ToInt32(splitDate[2]);

Event concerto1 = new Event(eventName, new DateTime(year, month, day), eventAvailableSeats);
Console.WriteLine(concerto1);