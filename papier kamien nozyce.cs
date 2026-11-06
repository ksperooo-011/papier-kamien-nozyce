
while (true)
{
    Console.WriteLine("papier , kamien , nozyce");
    Random r = new Random();
    int pkn = r.Next(1, 4);
    switch (Console.ReadLine())

    {
        case "papier":////////////////////////////////////////////////////papier
            int papier1 = 1;
            if (papier1 == pkn)
            {
                Console.Clear();////////////////////////////////////////remis
                Console.WriteLine("remis");
                Console.WriteLine("kliknij enter by kontynuowac");
                Console.ReadLine();
                Console.WriteLine("----------------------------");
            }
            if (pkn == 2)
            {
                Console.Clear();////////////////////////////////////////przegrana
                Console.WriteLine(" przegrales bot wybral nozyce");
                Console.WriteLine("kliknij enter by kontynuowac");
                Console.ReadLine();
                Console.WriteLine("----------------------------");
            }
            if (pkn == 3)
            {
                Console.Clear();////////////////////////////////////////wygrana
                Console.WriteLine("wygrales bot wybral kamien");
                Console.WriteLine("kliknij enter by kontynuowac");
                Console.ReadLine();
                Console.WriteLine("----------------------------");
            }
            break;
        case "nozyce":////////////////////////////////////////////////////////////////////////////////////////nozyce
            int nozyce2 = 2;
            if (nozyce2 == pkn)
            {
                Console.Clear();////////////////////////////////////////remis
                Console.WriteLine("remis");
                Console.WriteLine("kliknij enter by kontynuowac");
                Console.ReadLine();
                Console.WriteLine("----------------------------");
            }
            if (pkn == 3)
            {
                Console.Clear();////////////////////////////////////////przegrana
                Console.WriteLine("przegrales wybral kamien");
                Console.WriteLine("kliknij enter by kontynuowac");
                Console.ReadLine();
                Console.WriteLine("----------------------------");
            }
            if (pkn == 1)
            {
                Console.Clear();////////////////////////////////////////wygrana
                Console.WriteLine("wygrales bot wybral papier");
                Console.WriteLine("kliknij enter by kontynuowac");
                Console.ReadLine();
                Console.WriteLine("----------------------------");
            }
            break;
        case "kamien"://///////////////////////////////////////////////////////////////////////////kamien
            int kamien3 = 3;
            if (kamien3 == pkn)
            {
                Console.Clear();////////////////////////////////////////remis
                Console.WriteLine("remis");
                Console.WriteLine("kliknij enter by kontynuowac");
                Console.ReadLine();
                Console.WriteLine("----------------------------");
            }
            if (pkn == 1)
            {
                Console.Clear();////////////////////////////////////////przegrana
                Console.WriteLine(" przegrales bot wybral papier");
                Console.WriteLine("kliknij enter by kontynuowac");
                Console.ReadLine();
                Console.WriteLine("----------------------------");
            }
            if (pkn == 2)
            {
                Console.Clear();////////////////////////////////////////wygrana
                Console.WriteLine("wygrales bot wybral nozyce");
                Console.WriteLine("kliknij enter by kontynuowac");
                Console.ReadLine();
                Console.WriteLine("----------------------------");
            }
            break;
        default:
            Console.WriteLine("blad try again");///////////////////////////////////////////////blad
            Console.WriteLine("----------------------------");
            break;
    }
}