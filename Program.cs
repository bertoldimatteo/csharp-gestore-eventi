// See https://aka.ms/new-console-template for more information

Console.WriteLine("Inserisci il nome del tuo programma Eventi:");
string eventTitle = Console.ReadLine();

Console.WriteLine("Indica il numero di eventi da inserire:");
int eventNumber = Convert.ToInt32(Console.ReadLine());

ProgramEvent evento1 = new ProgramEvent(eventTitle);

int totalEvent = 0;

while(totalEvent < eventNumber)
{
    Console.WriteLine($"Inserisci il nome del {totalEvent++}° evento:");
    string title = Console.ReadLine();

    Console.WriteLine($"Inserisci la data dell'evento (gg/mm/yyyy):");
    string date = Console.ReadLine();

    Console.WriteLine("Inserisci il numero dei posti totali:");
    int seats = Convert.ToInt32(Console.ReadLine());

    string[] splitDate = date.Split('/');
    int day = Convert.ToInt32(splitDate[0]);
    int month = Convert.ToInt32(splitDate[1]);
    int year = Convert.ToInt32(splitDate[2]);

    Event event1 = new Event(title, new DateTime(year, month, day), seats);
    evento1.addEvent(event1);
    totalEvent++;
}

//Milestone 2 check
//Console.WriteLine("Digita il nome dell'evento che vuoi creare");
//string eventName = Console.ReadLine();

//Console.WriteLine("Digita la data dell'evento che vuoi creare (giorno/mese/anno)");
//string eventDate = Console.ReadLine();

//Console.WriteLine("Digita la capienza massima dell'evento che vuoi creare");
//int eventAvailableSeats = Convert.ToInt32(Console.ReadLine());

//string[] splitDate = eventDate.Split('/');
//int day = Convert.ToInt32(splitDate[0]);
//int month = Convert.ToInt32(splitDate[1]);
//int year = Convert.ToInt32(splitDate[2]);

//Event concerto1 = new Event(eventName, new DateTime(year, month, day), eventAvailableSeats);
//Console.WriteLine($"Creazione avvenuta con successo per l'evento {concerto1}");
//Console.WriteLine($"Posti disponibili {eventAvailableSeats}");

//Console.WriteLine("Quanti posti vuoi prenotare?");
//int reservation = Convert.ToInt32(Console.ReadLine());
//concerto1.bookSeats(reservation);

//bool enter = true;

//while (enter)
//{
//    Console.WriteLine("Vuoi disdire dei posti?(si/no)");
//    string userChoice = Console.ReadLine();

//    switch (userChoice)
//    {
//        case "si":
//            Console.WriteLine("Indica quanti posti vuoi disdire:");
//            int cancelNumber = Convert.ToInt32(Console.ReadLine());
//            concerto1.cancelReservation(cancelNumber);
//        break;
//        case "no":
//            Console.WriteLine("Concludo l'operazione per disdire dei posti");
//            Console.WriteLine($"Posti a disposizione N: {concerto1.MaxPeopleForEvent}");
//            Console.WriteLine($"Posti prenotati N: {concerto1.Reservation}");
//            enter = false;
//            break;
//    }
//}
