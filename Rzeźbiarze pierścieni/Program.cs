﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Rzeźbiarze_pierścieni
{


    class Program
    {


        public static void Print(string Tekst)
        {
            Console.WriteLine(Tekst);
        }

        public static void AnyKey()
        {
            Console.ReadKey();
        }
            //          

            static void Main()
            {


                int Oxygen = 36;
                bool FoundBottle = false;
                bool CloseToBase = false;
            bool KnowSecret = false;

            int Days = 0;

                Random rnd = new Random();

            Character Player = new Character();

            // zmienna na aktualny numer paragrafu
            int ParNumber = 0;

            //póki jest True, gra działa
            bool Game = true;


            //funkcja wyboru następnego paragrafu


            


            void Crossroads(string[] Choices, int[] Addresses)
            {
                int Num = 1;

                Print("");

                foreach (string Choice in Choices)
                {
                    Console.WriteLine("[" + Num + "]" + Choice);
                    Num++;
                }
                Console.Write("Twój wybór: ");
                String Choiced = Console.ReadLine();

                while (true)
                {
                    try
                    {
                        ParNumber = Addresses[Convert.ToInt32(Choiced) - 1];
                    }
                    catch (FormatException)
                    {
                        Console.Write("Niewłaściwy wybór. Podaj liczbę nie większą niż " + Choices.Length + ": ");
                        Choiced = Console.ReadLine();
                        continue;
                    }

                    catch (IndexOutOfRangeException)
                    {
                        Console.Write("Niewłaściwy wybór. Podaj liczbę nie większą niż " + Choices.Length + ": ");
                        Choiced = Console.ReadLine();
                        continue;
                        
                    }
                    Print("");
                    break;
                }
            }


            while (Game == true)
            {
                switch (ParNumber)
                {
                    case 0:
                        {

                            Console.WriteLine("RZEŹBIARZE PIERŚCIENI");
                            Console.WriteLine("Na podstawie książki-gry Tomasza Kołodziejczaka");
                            Console.WriteLine("Wydawnictwo S.R., Warszawa 1995\n\n");
                            Console.ReadKey();

                            Console.Write("Nie ufamy ci! Nie ufamy ci!\n");
                            Console.ReadKey();
                            Console.Write("Głos huczy w twojej czaszce, miażdżąc umysł opętańczym hałasem. \nJednocześnie widzisz przed oczyma kaskadę świateł układających się w napis\n");
                            Console.ReadKey();
                            Console.Write("Nie ufamy ci! Nie ufamy ci! Kim jesteś?\n");
                            Console.ReadKey();

                            Console.Write("Jak to - kim jesteś? Wspomnienia przepływają przez twoją głowę. " +
                            "Obrazy kosmicznej pustki, roziskrzonej wielobarwnym światłem gwiazd, po której przesuwają się cienie najdziwaczniejszych statków kosmicznych." +
                            "\nBarwne tarcze planet naznaczone plamami księżyców. " +
                            "Gejzery świecącej materii wyrzucanej przez słońca." +
                            "I jeszcze ból, samotność i żar eksplozji.\n");
                            Console.ReadKey();
                            Console.Write("To pamiętasz. \n");
                            Console.ReadKey();
                            Console.Write("Ale...kim jesteś ?! Nie wiesz.\n");
                            Console.ReadKey();
                            Console.Write("Zapadasz w ciemność.\n");

                            ParNumber = 1;
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("- No już, obudź się, wszystko w porządku " +
                                "- twardy, mocny głos zdecydowanie przedziera się przez powłokę twego snu. " +
                                "Otwierasz oczy, siadasz gwałtownie.Znajdujesz się w małym pomieszczeniu. " +
                                "Oprócz łóżka stoi tu niski stolik i jedno krzesło. " +
                                "Ścianę nad łóżkiem pokrywa tafla teleekranu, teraz wygaszona. " +
                                "A nad tobą pochyla się człowiek o twarzy pokrytej wielobarwnymi wszczepkami./n");
                            Console.WriteLine("- Kim jesteś ? - pytasz. - Co się ze mną działo?");
                            AnyKey();
                            Console.WriteLine("- Już w porządku. - Mężczyzna musi mieć jakieś nakładki głosowe, " +
                            "bo dźwięk wydobywający się z jego gardła jest bardzo wysoki, prawie na granicy słyszalności. ");
                            AnyKey();
                            Print("- Odmroziliśmy cię, chłopie.Dobrze się czujesz? " +
                            "Czy wolałbyś jeszcze trochę odpocząć?");
                            Console.WriteLine("Podaje ci ubranie.\n");


                            Crossroads(new string[] { "Nie jesteś pewien, co robić, siedzisz w bezruchu",
                                "Mówisz, że jest w porządku, i zaczynasz się ubierać" }, new int[] { 35, 179 });
                            break;
                        }
                    case 2:
                        {
                            Print("Wiesz, że musisz uważać. Znajdujesz się na nieprzyjaznym dla życia globie.Tu można łatwo zginąć. " +
                                "Jeśli rozedrzesz skafander - zginiesz. " +
                                "Jeśli pęknie ci hełm - zginiesz. " +
                                "Jeśli zabraknie ci tlenu - zginiesz.Twój zapas tlenu pozwala ci na dziewięciogodzinną wędrówkę po powierzchni Transkolosa. " +
                                "Musisz kontrolować upływający czas.");
                            /*
                                        Mechanika
                                        Od tej pory każda akcja, którą podejmiesz, będzie trwała określoną ilość czasu.Jego upływ będzie albo niezależny od ciebie, albo sam będziesz decydował, ile czasu poświęcisz na wykonanie jakiejś akcji.
                                        Masz pełne butle z tlenem: zapas na 9 godzin, czyli 36 kwadransów.Zaznacz to na kartce i za każdym razem, gdy pojawia się takie polecenie, odliczaj odpowiednią liczbę kwadransów.Jeśli zużyjesz ostatnią porcję, a nie znajdziesz się w rakiecie powrotnej -umierasz i kończysz grę.
                                        Droga do bazy zajmie ci kwadrans(powrotna - kolejny kwadrans, pamiętaj o tym!).Odlicz ten czas z zapasu swojego tlenu. V > Idz do paragrafu 158.
                                        */
                            ParNumber = 158;
                            AnyKey();
                            break;
                        }
                    case 3:
                        {
                            Print("To ryzykowne - baza Rzeźbiarzy jest niedaleko, może oni będą mogli szybciej dotrzeć do ciebie. " +
                                "Ale wysyłasz komplet informacji o tym, co ci się przydarzyło. " +
                                "Więc może nie będą mogli cię zabić ot tak, po prostu. " +
                                "Oczywiście pod warunkiem, że gdzieś w pobliżu znajduje się jakiś statek solarny.");
                            ParNumber = 124;
                            AnyKey();
                            break;

                        }
                    case 4:
                        {
                            Print("Sprawdziłeś wszystko dokładnie. " +
                                "Teraz możesz z całą pewnością stwierdzić, że nic ciekawego tu nie ma. " +
                                "Przejdź do innego pomieszczenia bazy lub z niej wyjdź.");
                     
                            Crossroads(new string[] { "Moduł higieny", "Korytarz", "Duża sala", "Śluza hangaru", "Kolektory",
                                "Powrót do kosmolotu" }, new int[] { 56, 143, 167, 30, 128, 64 });

                            AnyKey();
                            break;
                        }
                    case 5:
                        {
                            Print("Tak, wygrałeś. Pokonałeś wszystkie przeszkody, poznałeś rozwiązanie zagadki Transkolosa, przetrwałeś. " +
                                "Dane ci było ujrzeć jeden z najbardziej tajemniczych obiektów zasiedlonej przez ludzi części kosmosu. " +
                                "Zostałeś Rzeźbiarzem Pierścieni.");
                            AnyKey();
                            Game = false;
                            break;
                        }
                    case 6:
                        {
                            Character Ander = new Character(4, 2, 8, "Ander Xor", "technik wirtuali. Obsługiwałeś wirtualne programy użytkowe -sterowałeś automatycznymi próbnikami górniczymi, satelitami łączności, sondami naukowymi." +
                                    "Twoją głowę porasta miękka masa powłoki oczyszczającej " +
                                    "- raz na miesiąc zrywasz ją z głowy i zasadzasz nową. " +
                                    "To symbiotyczne stworzenie, które oczyszcza twój organizm ze związków chemicznych używanych przez ciebie w czasie pracy.");

                            Player = Ander;

                            //Player.PrintName();
                            Console.Write(Player.Name + " - " + Player.Description);
                            //Player.PrintDesc();

                            //Mechanika
                            //Umysł 4
                            //Ciało 2 < 
                            //Ego 8

                            ParNumber = 175;
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Huk silników narasta. ");
                            Console.ReadKey();
                            Console.WriteLine("Powoli przejmujesz sterowanie układami pojazdu.Czujesz, " +
                                "jak twoja myśl przenika elektroniczne podzespoły, " +
                                "jak wprost do twojego procesora osobowości dopływają sygnały z układów " +
                                "sterowania i pomiaru.Twój umysł rozszerza się, synchronizując ze sztucznymi inteligencjami rakiety. " +
                                "Stajesz się mózgiem i sercem tej maszyny.Przed oczami tańczą ci barwne wzory, " +
                                "z nich wyłania się sieć współrzędnych, na którą myślą nanosisz cele.Koordynaty pojawiają się i znikają, " +
                                "miga hologram docelowego punktu. Czujesz falę ciepła i wilgoci - " +
                                "to do komory gniazda wlewa się organiczny płyn, który pomoże twemu ciału znieść przeciążenia. " +
                                "Szybko nakładasz na usta małą maskę. Przylgi oblepiają twoją głowę w tej samej chwili, " +
                                "w której czujesz drżenie całego pojazdu.Wystartowałeś. ");
                            ParNumber = 130;
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("-Zaczepiłeś go, Fidi - Leonardo staje w twojej obronie - A on wciąż jest w szoku. " +
                                "Cybery z medycznego powiedzieli, że przez dwa, trzy dni może mieć chwilowe kłopoty z osobowością.Trafiłeś na taką chwilę.");
                            Console.ReadKey();
                            Console.WriteLine("- Dobra, dobra - mruczy Fidiasz, a do ciebie dodaje: -Jeszcze się spotkamy, cholerny psychopato.");
                            Console.ReadKey();
                            Console.WriteLine("Rusza korytarzem, a wy kierujecie się w przeciwną niż on stronę.");
                            Console.ReadKey();
                            Console.WriteLine("- Musisz bardziej nad sobą panować -upomina cię Leonardo. -Odtworzyliśmy twoją psychikę, " +
                                "ale dopiero teraz będzie się ona stabilizować. Więc nie atakuj, z łaski swojej, każdego napotkanego faceta.");
                            Console.ReadKey();
                            Print("Po chwili milczenia dodaje: - Ani babki.Dobra?");
                            AnyKey();
                            Console.WriteLine("- OK. - odpowiadasz, ruszając za Leonardem.");
                            AnyKey();
                            ParNumber = 91;
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Startujesz z powierzchni Transkolosa.");
                            Console.ReadKey();
                            if (KnowSecret == false)
                            {
                                Print("Kierujesz się do bazy Rzeźbiarzy, na Kolosa");
                            }
                            else
                            {
                                Crossroads(new string[] { "Kierujesz się do bazy Rzeźbiarzy, na Kolosa", "Chcesz lecieć do pierścieni" }, new int[] { 39, 93});
                            }

                            //Kierujesz się do bazy Rzeźbiarzy, na Kolosa - ParNumber = 39.
                            //Jeśli chcesz lecieć do pierścienia idź do paragrafu, którego numer odpowiada liczbie elementów Rzeźby(powinieneś ją znać z nagrania dokonanego przez martwego Rzeźbiarza).
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("Patrzysz na niego, nie odzywając się ani słowem. Podchodzisz bliżej, próbując pojąć jego prawdziwe uczucia i zamiary.");
                            Console.ReadKey();
                            Console.WriteLine("- Zgadzam się - mówisz w końcu i widzisz, jak Leonardo uśmiecha się szeroko. ");
                            
                            ParNumber = 100;
                            AnyKey();
                            break;
                        }
                    case 11:
                        {

                            Console.WriteLine("Eksplozja w kosmosie jest bezgłośna. Twój statek w jednej chwili rozsypuje się na tysiące kawałków. " +
                                "Pęka twój kokon ochronny, a otulający cię organiczny płyn w jednej chwili zamarza.");


                            Console.ReadKey();
                            Console.WriteLine("Lecz ty już tego nie czujesz. Nie żyjesz. ");
                            
                            ParNumber = 20;
                            AnyKey();
                            break;
                        }
                    case 12:
                        {
                            Console.WriteLine("Wchodzicie do przestronnego pokoju, w którym nie stoją żadne sprzęty oprócz fotela z wirtualnymi przystawkami.Wystrój nadaje temu pomieszczeniu niezwykłe wrażenie. " +
                                "Ściany pokryte są foliami ekranów, na których widnieją zapierające dech w piersiach kosmiczne krajobrazy.Jakby kamerę ustawiono w środku jednego z pierścieni -widać przesuwające się powoli " +
                                "skalne bryły, w tle tarczę Ordmoru naznaczoną wstęgami atmosferycznych gazów i plamami zawirowań.W ten kadr wpełzają czasem tarcze księżyców Ordmoru i " +
                                "owadokształtne sylwetki statków kosmicznych.Przez dłuższą chwilę stoisz zauroczony otaczającym cię zewsząd ogromem.");
                            Console.ReadKey();
                            Print("Z zadumy wyrywa cię dopiero szept Leonarda:");
                            Console.WriteLine(" - Złóż pokłon!");
                            Console.WriteLine("Naśladujesz ruchy swego opiekuna - klękasz na jedno kolano i spuszczasz głowę. Dopiero teraz orientujesz się, że w pomieszczeniu jest ktoś jeszcze.");
                            Console.WriteLine("- Podnieście się - słyszysz głos i wstajesz." +
                         "Przed tobą stoi wysoki mężczyzna o twarzy ukrytej pod wirtualną maską -" +
                         " w miejscu głowy nieznajomego tkwi roziskrzona wielobarwna kula. " +
                         "Kolorowe odpryski spływają wzdłuż jego ciała, oplatając piersi i nogi. " +
                         "Człowiek ów nie ma zwykłych rąk, tylko dwa kikuty przedramion, zakończone wieloma długimi palcami o wielu stawach.");
                            Console.WriteLine("Wygląda to dziwnie, żeby nie powiedzieć: obrzydliwie...");

                            ParNumber = Player.StatTest("mind", 0, 0, 53, 140);
                            //Mechanika
                            //Test Umysł:
                            //              Udany - ParNumber = 53.Nieudany - paragraf 140.
                            AnyKey();
                            break;
                        }
                    case 13:
                        {
                            Console.WriteLine("Stoisz w korytarzu prowadzącym do lądowiska. Jest cicho, panuje półmrok.Przed tobą olbrzymi ekran," +
                                " na którym czerwieni się gigantyczna tarcza Ordmoru.Patrzysz na ten ogrom z przerażeniem i fascynacją. " +
                                "Już wkrótce tam lecisz. Transkolos znajduje się znacznie bliżej planety, prawie na granicy pierwszego pasa pierścienia.Kierujesz się ku lądowisku.");
                            Console.WriteLine("Nagle zatrzymujesz się.To może być złudzenie, ale wydaje ci się, że za twoimi plecami coś się poruszyło.");
                            
                            Crossroads(new string[] { "Cofasz się", "Idziesz na miejsce startu"}, new int[] {31, 71});


                                //Cofasz się -ParNumber = 31.
                                //Idziesz na miejsce startu -paragraf 71.
                                break;
                        }
                    case 14:
                        {
                            Console.WriteLine("Osłoniłeś okręt zaporą siłową, odciąłeś większość układów wewnętrznych. " +
                                "To utrudni wykrycie cię przez pościgowe jednostki z Kolosa.Z każdą chwilą znajdujesz się coraz dalej od bazy " +
                                "Rzeźbiarzy i coraz bliżej planet wewnętrznych, gdzie mogą funkcjonować placówki Dominium.Jednocześnie zablokowanie nadajników i " +
                                "rejestratorów czyni cię niemal ślepym i głuchym.Może okazać się ryzykowne, szczególnie w pobliżu Ordmoru, " +
                                "który przyciąga liczne asteroidy. Jeśli któryś z tych skalnych okruchów trafi w twój statek, będzie po tobie. " +
                                "Przedłużając lot „na ślepo\", " +
                                "jednocześnie zwiększasz szansę ucieczki od Rzeźbiarzy, ale i ryzyko trafienia przez meteor.");

                            Console.WriteLine("Ile dni tak lecisz: ");
                            
                            Days = Convert.ToInt32(Console.ReadLine());

                            ParNumber = Player.StatTest("", Days+1, 0, 66, 47);



                            //Mechanika ]Określ, ile dni tak lecisz(od 0 do 9).
                            
                            
                            //Przetestuj tę liczbę dni(otwórz książkę na dowolnej stronie, sprawdź ostatnią cyfrę).
                            //Wynik mniejszy niż wybrana liczba dni - ParNumber = 66.Wynik większy bądź równy od wybranej liczby dni - paragraf 47.

                            break;
                        }
                    case 15:
                        {
                            Console.WriteLine("Prawie setka brył wiruje wokół ciebie. Nie są to zwykłe skalne okruchy, lecz regularne czworościany, " +
                                "sześciany, dwudziestościany, wszystkie wykonane z szarej materii, o chropawej powierzchni i " +
                                "lekko zaokrąglonych krawędziach. Zamykają przestrzeń -tworząc powierzchnię walca o średnicy dwóch kilometrów i " +
                                "długości czterech - w którą nie wlatuje zwykły kosmiczny złom tworzący pierścienie planety.Same bryły wirują wokół " +
                                "siebie w zmiennym rytmie, tworząc coraz to nowe kształty. Nigdy nie widziałeś czegoś takiego.Bryły co chwila zmieniają swoje " +
                                "położenie -raz wydają się budować zarys jakiejś maszyny, raz dziwnego stworzenia, by za chwilę ułożyć się w twarz monstrum.");
                            Console.WriteLine("Teraz rozumiesz, czemu Rzeźbiarz zwariował. Gdy zobaczył to, on, fanatyczny wyznawca pierścieni, twórca rzeźb " +
                            "z kilku brył, rzeźb tak nietrwałych, jak ta wydawała się wieczna - musiał oszaleć.");
                            ParNumber = 127;
                            AnyKey();
                            break;
                        }
                    case 16:
                        {
                            Console.WriteLine("-Nie - odpowiadasz zdecydowanym głosem. -Żądam natychmiastowego powiadomienia o mojej obecności rezydenta Dominium Solarnego w układzie Reagana.");
                            Console.WriteLine("- No to masz problem. - Czyżby Leonardo rzeczywiście się zasmucił? " +
                                "Odwraca się do drzwi, otwiera je, jakby chciał wyjść. Zdziwiony postępujesz krok za nim. " +
                                "Niepotrzebnie.Nagle Leonardo uskakuje w bok, a do twojej celi wpada dwóch mężczyzn. " +
                                "Jeden, dość wysoki, trzyma w ręku jakieś urządzenie, drugi, drobniejszy, rzuca się w twoją stronę. " +
                                "Nie ma paralizera, w kabinie jest za ciasno, by go używać.Skaczesz ku pierwszemu przeciwnikowi.");
                            ParNumber = Player.StatTest("body", 0, 0, 75, 122);

                            //Mechanika Test Ciało:
                            //                Udany - ParNumber = 75.Nieudany - paragraf 122.
                            AnyKey();
                            break;
                        }
                    case 17:
                        {
                            Console.WriteLine("Niestety, zakazane dla ciebie obszary pamięci obwarowano potężnymi zabezpieczeniami. " +
                                "W czasie penetracji cyberprzestrzeni pokładowego komputera nadwyrężyłeś swój umysł. " +
                                "Tak naprawdę nie zdołałeś uzyskać żadnych sensownych danych. A jednak... a jednak jesteś przekonany," +
                                " że usłyszałeś cień, echo śladu informacji o tym, że w układzie istnieje placówka administracji solarnej i " +
                                "że może zdołałbyś tam dolecieć. Ale gdzie ta placówka się znajduje i jak się z nią połączyć - nie wiesz.");
                            //Mechanika
                            //"Zredukuj cechę Umysł postaci o 1 punkt. ]v
                            Player.setMind(Player.Mind - 1);

                            ParNumber = 68;
                            AnyKey();
                            break;
                        }
                    case 18:
                        {
                            Print("Im więcej czasu poświęciłeś na poszukiwania, tym większa szansa, że coś znajdziesz. Jednak skraca się twój czas pobytu na powierzchni planety.");
                            //Mechanika

                            //Test Umysł (przed testem cechę Umysł powiększ o wskazaną liczbę kwadransów): 
                            //Udany - ParNumber = 109. 
                            //Nieudany - paragraf 174.
                            //Jeśli wynik testu(ostatnia cyfra numeru strony) wyniósł 8 lub 9 - paragraf 165.
                            break;
                        }
                    case 19:
                        {
                            Console.WriteLine("Idiota! Nie sprawdziłeś - pistolet wali całą mocą.Owadokształtny stwór i otaczające go skałki wyparowały w ułamku sekundy. " +
                                "Sygnał w twoim hełmie ucichł.W pobliżu nie ma już żadnego zagrożenia.Szkoda, że nie dowiedziałeś się, co to było.");
                            Oxygen -= 1;
                            ParNumber = 67;

                            AnyKey();
                            
                            break;
                        }
                    case 20:
                        {
                            Console.WriteLine("To już koniec tej przygody. Jesteś zadowolony z osiągniętego wyniku? " +
                                "Czy chciałbyś sprawdzić, jak inaczej mogły potoczyć się twoje losy? Możesz zakończyć tę grę już teraz.");
                            Console.WriteLine("Ale możesz rozpocząć ją jeszcze raz: wylosować nową postać, inaczej ją wzmocnić, podjąć inne decyzje...Spróbuj!");

                            AnyKey();
                            Game = false;
                            break;
                        }
                    case 21:
                        {
                            Console.WriteLine("Niestety, albo ty coś źle obliczyłeś, albo pokładowy komputer zwariował. " +
                            "Przeleciałeś nad bazą i wylądowałeś w pewnej odległości od jej zabudowań.Przed tobą ładny kawałek drogi.");
                            CloseToBase = true;
                            ParNumber = 120;

                            AnyKey();
                            break;
                        }
                    case 22:
                        {
                            Console.WriteLine("Otwierasz oczy i podnosisz się szybko. Nie wiesz, ile czasu leżałeś nieprzytomny, ale chyba niedługo, " +
                                "skoro strażnicy jeszcze nie nadbiegli.Wszystko cię boli - skóra piecze, mięśnie wpadają w szaleńcze skurcze, oczy łzawią. " +
                                "System ochronny bazy wyrzucił cię z sieci, nie dostaniesz się do wahadłowca.Kuśtykając, ruszasz korytarzem.");
                            AnyKey();
                            Console.WriteLine("I wtedy właśnie zza zakrętu wypadają dwaj uzbrojeni żołnierze.Na twój widok zatrzymują się i wysuwają broń.");

                            Crossroads(new string[] { "Strzelasz", "Nie strzelasz" }, new int[] { 73, 24 });

                            //Strzelasz - paragraf 73.
                            //Nie strzelasz - paragraf 24.
                            AnyKey();
                            break;
                        }
                    case 23:
                        {
                            Console.WriteLine("Wypadasz zza zakrętu. Niemal zbijasz z nóg biegnącego z przeciwka człowieka. " +
                                "Człowieka? Czarny pancerz, hełm pokryty barwnymi malunkami, broń. To jedna z końcówek mózgu wojskowego bazy.");
                            Console.WriteLine("Próbujesz wykorzystać zaskoczenie i wyrwać z rąk tej istoty paralizer.");

                            ParNumber = Player.StatTest(3, "body", 0, 0, 125, 33, 77);

                            // Mechanika
                            //Test Ciało:
                            //Udany - ParNumber = 125.
                            //Nieudany - paragraf 33.
                            //Wynik mniejszy niż 3 - paragraf 77.
                            AnyKey();
                            break;
                        }
                    case 24:
                        {
                            Console.WriteLine("Dostałeś!");
                            Console.ReadKey();
                            Console.WriteLine("Boli, jak strasznie boli! Wypuszczasz broń, padasz na kolana, krzyczysz. " +
                                "Boli! Wijesz się na ziemi, widząc podchodzących coraz bliżej żołnierzy.");

                            ParNumber = Player.StatTest("body", 0, 0, 60, 77);
                            /*
                             Mechanika Test Ciało: Udany - paragraf 60.Nieudany - paragraf 77.
                            */
                            AnyKey();
                            break;
                        }
                    case 25:
                        {
                            Console.WriteLine("Nagle odbierasz komunikat zagrożenia - to rejestratory twojego skafandra namierzyły jakiś obiekt. " +
                            "Poruszający się obiekt!Wstrzymujesz bieg, zastygasz w bezruchu, wsłuchując się w kolejne dane.Są niepewne. " +
                            "To coś niedużego - człowiek lub mały pojazd, poruszający się między skałami, co chwila głuszącymi sygnał.");

                            Crossroads(new string[] {"Ruszasz ku niemu", "Idziesz wprost do bazy" }, new int[] { 28, 67 });

                            //Console.WriteLine("[1] Ruszasz ku niemu");
                            //ParNumber = 28.
                            //Console.WriteLine("[2] Idziesz wprost do bazy - paragraf 67.
                            AnyKey();
                            break;
                        }
                    case 26:
                        {
                            Print("Niczego ciekawego nie zauważyłeś. Nie sądzisz, abyś mógł tu znaleźć coś, co pomoże ci rozwiązać zagadkę. " +
                                "Jeśli jednak jeszcze raz chcesz przeszukać korytarz, to możesz spróbować.");

                            Crossroads(new string[] {"Szukasz jeszcze raz\nIdziesz do innego pomieszczenia:", "Duża sala", "Moduł higieny",  
                                 "Sypialnie", "Powrót do kosmolotu"  }, new int[] { 104, 167, 56, 110, 64 });

                            //Console.WriteLine("Szukasz jeszcze raz - ParNumber = 104.
                            //Console.WriteLine("Idziesz do innego pomieszczenia:
                            //Duża sala -paragraf 167.
                            //Moduł higieny -paragraf 56.
                            //Sypialnie - paragraf 110.
                            //Powrót do kosmolotu - paragraf 64(odejmij kwadrans).
                            
                            break;
                        }
                    case 27:
                        {
                            Console.WriteLine("Fidiasz uchyla się i sam wyprowadza uderzenie. Trafia w brzuch, odbierając ci oddech.Widzisz pięść zbliżającą się do twojej twarzy.");
                            Console.WriteLine("- Stój, durniu!-Leonardo odpycha go w ostatniej chwili. - Zwariowałeś ? !Odmrożeńca zaczepiasz ? !");
                            Console.WriteLine("- Co ty, nie widziałeś? Chciał mnie stuknąć - zaperza się Fidiasz.");
                            ParNumber = 8;
                            AnyKey();
                            break;
                        }
                    case 28:
                        {
                            Console.WriteLine("Skręcasz zgodnie ze wskazówkami kompa. Wyciągasz pistolet z olstra przyczepionego do uda.Sygnał narasta. " +
                            "Przytulasz się do skały.Jeśli to wróg, to każdy twój błąd może kosztować cię wiele. Ale to przecież nie musi być wróg...");
                            Console.WriteLine("Obły kształt wypełza spomiędzy skał.Metaliczny żuk wysuwa ku tobie odnóża.");

                            Crossroads(new string[] { "Strzelasz", "Nie strzelasz" }, new int[] { 19, 113 });

                            //Strzelasz - ParNumber = 19.
                            //Nie strzelasz -paragraf 113.
                            break;
                        }
                    case 29:
                        {
                            Console.WriteLine("Tracisz przytomność. Niestety, nigdy jej nie odzyskasz. Twój pozbawiony pilota statek eksploduje.");
                            ParNumber = 38;
                            Game = false;
                            AnyKey();
                            break;
                        }
                    case 30:
                        {

                            Console.WriteLine("Zapalasz reflektor i wchodzisz do śluzy hangaru. Jest to dość duża komora, " +
                                "przed sobą masz zamknięte wrota. Widzisz tablicę sterującą - diody pulsują łagodnym światłem. " +
                                "Podchodzisz do ściany i chwilę przyglądasz się wyświetlanemu na monitorze napisowi:");
                            Console.WriteLine("ALERT!ALERT!");
                            Console.WriteLine("A więc mózg bazy jeszcze pracuje. Może tutaj uzyskasz jakieś informacje.");
                            Console.WriteLine("Wolałbyś nie ryzykować wchodzenia do sieci, ale chcesz zwiedzić hangar. Niestety, prowadzące " +
                "doń wrota śluzy są zamknięte, elektroniczny klucz, który otrzymałeś od Rzeźbiarzy, nie działa.Widocznie ktoś z miejscowych musiał zmienić kody dostępu.");
                            Console.WriteLine("Istnieje szansa, że jeśli wejdziesz w sieć bazy, to je odzyskasz.Ale pewności nie masz żadnej, " +
                                "a na dodatek gmeranie w nieznanej sieci, w której zapewne postawiono jakieś pułapki, może się okazać ryzykowne.Co robisz?");

                            Crossroads(new string[] { "Próbujesz podłączyć swój czip mózgowy do sieci bazy\nRezygnujesz z przeszukania hangaru i idziesz w inne miejsce bazy:",
                                "Śluza bazy", "Kolektory", "Powrót do kosmolotu" }, new int[] { 50, 145, 128, 64 });

                            //Próbujesz podłączyć swój czip mózgowy do sieci bazy -ParNumber = 50.
                            //Rezygnujesz z przeszukania hangaru i idziesz w inne miejsce bazy:

                            //Śluza bazy - paragraf 145.
                            //Kolektory - paragraf 128.
                            //Powrót do kosmolotu - paragraf 64 (odlicz kwadrans).

                            break;
                        }
                    case 31:
                        {
                            Console.WriteLine("Zawracasz, przyśpieszając kroku - czyżby rzeczywiście ktoś cię śledził? Wszak książę sugerował, że tamci mogą mieć wspólnika wśród Rzeźbiarzy.");
                            Console.WriteLine("Jednak nikogo nie widzisz, dobiegasz do miejsca, w którym korytarze się " +
                                "rozgałęziają. Tu się zatrzymujesz, patrzysz na zegarek. „Czas wracać\" - myślisz.");
                            ParNumber = 116;
                            AnyKey();
                            break;
                        }
                    case 32:
                        {
                            Console.WriteLine("Wybiegasz zza zakrętu, ściskając kolbę w spoconej dłoni.Czekają tam " +
                                "- trzy człekoowadzie postacie z wymierzonymi w ciebie lufami paralizerów. ");
                            Console.ReadKey();
                            Print("Rzucasz się w bok, ku ścianie, jednocześnie naciskając spust.");

                            ParNumber = Player.StatTest("body", 0, 0, 73, 24);

                            //Test Ciało:
                            //Udany - paragraf 73.
                            //Nieudany - paragraf 24.

                            break;
                        }
                    case 33:
                        {
                            Console.WriteLine("Czarny chrząszcz jest silniejszy od ciebie - przecież to wojownik. Odpycha cię jednym ruchem ręki i groźnie wysuwa paralizer.");
                            Console.WriteLine("- Nawet nie drgnij -mówi.Stoisz w bezruchu, nie wiedząc, czy czeka cię śmierć, " +
                                "czy coś jeszcze gorszego. Teraz już nie masz żadnych szans. Najmniejszy wrogi gest może sprowokować żołnierza.");

                            ParNumber = 60;
                            AnyKey();
                            break;
                        }
                    case 34:
                        {
                            Console.WriteLine("Natrafiłeś na dziwny podłużny przedmiot.Przy bliższych oględzinach okazało się, " +
                                "że jest to element pistoletu laserowego. Mogła to być broń, ale równie dobrze mogli go wykorzystywać budowniczowie bazy przy prowadzeniu prac ziemnych.");
                            Console.WriteLine("Czy szukasz dalej?");

                            Crossroads(new string[] { "Tak\nNie - udaj się do innego punktu bazy:", "Duża sala",
                                "Moduł higieny", "Sypialnie"  }, new int[] {49, 167, 56, 110 });

                            //                Tak - ParNumber = 49.
                            //Nie - udaj się do innego punktu bazy:
                            //Duża sala -paragraf 167.
                            //Moduł higieny -paragraf 56.
                            //Sypialnie - paragraf 110.


                            break;
                        }
                    case 35:
                        {
                            Console.WriteLine("- Nazywam się Leonardo, jestem Rzeźbiarzem - mężczyzna akcentuje ostatnie słowo, jakby miało jakieś szczególne znaczenie. " +
                                "Nic ci ono nie mówi, choć jesteś pewien, że już je kiedyś słyszałeś. " +
                                "W nagłym błysku olśnienia uświadamiasz sobie, że w ogólne niewiele pamiętasz. " +
                                "Jak się nazywasz, kim jesteś? Co robisz w tym miejscu? Kim jest ten człowiek? " +
                                "Nie masz zielonego pojęcia. Patrzysz na niego, chcąc zadać jakieś pytania, ale nie wiesz nawet, o co miałbyś pytać." +
                                "\n- Nie przejmuj się, to normalne - uśmiecha się Leonardo. - Kiedy otworzyli twoją puszkę, myśleli, że jesteś wyłączony. " +
                                "A potem okazało się, że jednak twój procesor pamięci jeszcze pracuje, a tkanki da się odtworzyć. No i zreperowaliśmy cię. " +
                                "\n- Mnie ? Kogo ? Jaka puszka?... - Zaczynasz mechanicznie nakładać ubranie." +
                                "\n- Jak to jaka? - Twarz Leonarda wykrzywia się w grymasie zdziwienia. - Człowieku! " +
                                "Trzy tygodnie temu nasi ludzie namierzyli sygnał ratunkowy z twojej kapsuły. " +
                                "Przechwyciliśmy ją i wyciągnęliśmy cię z anabiozy. " +
                                "Miałeś rozwalony mózg, musieliśmy trochę posztukować twoją pamięć. " +
                                "\n- To znaczy, że leciałem kosmolotem i że była katastrofa... - mówisz." +
                                "\n- A jakże.Pasażerski liniowiec \"Kraft\" rozwalił się trzynaście lat temu. " +
                                "\n- Trzynaście lat temu... - Nagle jakby ktoś przekręcił zawór kranu prowadzący do zbiornika twojej pamięci. Już wiesz, kim jesteś.");
                            //Mechanika
                            //Otwórz książkę na dowolnej stronie. Sprawdź i zapamiętaj ostatnią cyfrę numeru tej strony. Jeśli wyszło 0, powtórz test. 
                            //ParNumber = 181.
                            AnyKey();
                            ParNumber = 181;


                            break;
                        }
                    case 36:
                        {

                            Console.WriteLine("Twój umysł  próbuje penetrować  pamięć komputera.  Niestety,  " +
                                "nie udało  ci się  złamać zabezpieczeń. Na dodatek osłabiłeś swoje wszczepki – twoje Ego się zmniejsza.");

                            Player.setEgo(Player.Ego - 1);

                            
                            //          Odejmij Ego postaci i punkt.
                            
                            ParNumber = 68;
                            break;
                        }
                    case 37:
                        {
                            Console.WriteLine("Przeszukujesz hangar, na tyle dokładnie, na ile jest to możliwe w świetle reflektora. " +
                                "\nOkreśl, ile czasu (w kwadransach) tu spędzisz.");



                            Console.ReadKey();
                            /*
                            Decide37:

                            int Time;

                            String Inpuut = Console.ReadLine();
                            if (Inpuut.Contains("1") || Inpuut.Contains("2") || Inpuut.Contains("3") || Inpuut.Contains("4") || Inpuut.Contains("5") || Inpuut.Contains("6"))
                            {
                                Time = Convert.ToInt32(Inpuut);
                            }
                            else
                            {
                                goto Choose;
                            }
                            Oxygen -= Time;
                            //Test Umysł(przed testem cechę Umysł powiększ o wskazaną liczbę kwadransów):  

                            //Udany – paragraf 34.

                            //Nieudany – paragraf 148.

                            */

                            break;
                        }
                    case 38:
                        {

                            Console.WriteLine(" Przykre, prawda?");
                            Console.WriteLine(" Zakończyłeś  już udział  w tej  przygodzie  –  podejmowałeś złe  decyzje,  " +
                            "natknąłeś się  na zbyt trudne zadania albo po prostu miałeś pecha." +
                            " Ale nie przejmuj się – to tylko gra.Najlepiej");



                            Console.WriteLine("spróbuj jeszcze raz.");

                            break;
                        }
                    case 39:
                        {

                            Console.WriteLine(" Start przebiegł bez większych kłopotów, zanurzasz się w kokonie ochronnym " +
                                "i bierzesz kurs na Kolosa. Baza Rzeźbiarzy znajduje się teraz po przeciwnej stronie Ordmoru," +
                                " podróż potrwa  kilka dni.  Nie przejmujesz  się tym  –   sieć pokładowa  zapewnia wiele  bardzo" +
                                " interesujących symulacji rozrywkowych.  ");
                            Console.WriteLine("Ze sztucznego świata wyrywa cię dopiero sygnał przywoławczy bazy na Kolosie. Wkrótce lądujesz.");






                            ParNumber = 149;


                            break;
                        }
                    case 40:
                        {

                            Console.WriteLine("Znów jesteś   na skrzyżowaniu   korytarzy.Nagle uświadamiasz   sobie,   " +
                                "że wcześniej niepotrzebnie skręciłeś w prawo. Przecież Leonardo mówił ci, że lądowisko znajduje się w korytarzu na wprost twojej kabiny. " +
                                "Nie zastanawiasz się dłużej, tym bardziej że słyszysz już głosy nadciągającego pościgu.Znów biegniesz.");

                            ParNumber = 57;


                            break;
                        }
                    case 41:
                        {

                            Console.WriteLine("Zmęczenie,  nerwy,  małe ciążenie.  To cię  pokonało. " +
                                "Źle stawiasz  stopę,  nie potrafisz utrzymać równowagi. Turlasz się po stoku. " +
                                "Czujesz ból w lewym kolanie i nawet gdy już się zatrzymujesz na dole wzgórza, ból nie mija. " +
                                "Na szczęście skafander je st szczelny. Zaciskając zęby, " +
                                "ruszasz w dalszą drogę.Idziesz wolno, ostrożnie. Droga do kosmolotu zajmie ci trochę czasu w zależności od tego, jaka jest twoja kondycja.");
                            /*
                        Mechanika



                        Zredukuj  cechę Ciało  o  1  punkt,  a następnie  sprawdź,  ile czasu  będziesz szedł  w



                    zależności od cechy Ciało:

                                    Ciało 0 - 13 kwadranse;



                                    Ciało 2 - 7 2 kwadranse;



                                    Ciało 8 - 9 1 kwadrans.


                        Odejmij właściwą liczbę kwadransów.  
                        Jeśli wciąż masz zapas tlenu – ParNumber = 99.


                        Jeśli tlen się skończył – paragraf 176.




                    */

                            break;
                        }
                    case 42:
                        {

                            Console.WriteLine("Przed oczami tańczą kolorowe plamy układające się w abstrakcyjne kompozycje. " +
                            "Ale twój umysł powoli  zaczyna pracować  normalnie.  „Nie dałem  się”  –  myślisz i w tym  momencie zaczynasz rejestrować dochodzące gdzieś z góry głosy: ");
                            Console.ReadKey();
                            Console.WriteLine("– Szkoda faceta, długo się nie nażył – to Leonardo.  ");
                            Console.ReadKey();
                            Console.WriteLine("– Jak to nie nażył, przecież go nie likwidujemy – dziwi się Mały.");


                            Console.ReadKey();
                            Console.WriteLine("–  Co to za życie –  śmieje się Leonardo. –  Będzie poddany ciągłemu warunkowaniu. I do końca dni swoich weźmie w opiekę naszą plantację.");


                            Console.ReadKey();
                            Console.WriteLine("– Plantację ? – rechoczą tamci. – Nieźle powiedziane: plantację!\n");

                            Console.ReadKey();
                            Console.WriteLine("Nie masz dużo czasu. Zaraz zorientują się, że wytrzymałeś elektroniczne warunkowanie i że twój umysł dalej pracuje normalnie. Musisz działać. " +
                                "Podrywasz się  błyskawicznie.Walisz na  odlew. " +
                                "Najpierw Leonarda, potem  Małego. Poprawiasz kopniakiem. Ale z  trzecim nie pójdzie ci tak łatwo. Czujesz uderzenie w nerki. Odwracasz się błyskawicznie.");
                            ParNumber = Player.StatTest("body", 0, 0, 92, 111);
                            if (ParNumber == 111)
                            {
                                Player.setBody(Player.Body - 1);
                            }
                            /*
                                            Mechanika

                                            Test Ciało:



                                                        Udany – paragraf 92.



                                                        Nieudany – paragraf 111(i zredukuj cechę Ciało o 1 punkt).
                                                        */
                            AnyKey();
                            break;
                        }
                    case 43:
                        {

                            Console.WriteLine("Powrót tam to zagłada. Albo cię zabiją, albo wymażą twoją osobowość, albo uwarunkują jako żywego robota. " +
                            "Ot, choćby do wykonywania jakichś prostych czynności. Nie wrócisz tam, choćbyś miał zdechnąć!" +
                            " Na razie żyjesz jeszcze i jesteś wolny!O ile wolnością można nazwać zamknięcie w " +
                            "akwarium niewiele większym od ciebie, skazanie na hełm i maskę, na bezruch i " +
                            "sztuczne widoki rysowane przed twoimi oczami we wnętrzu hełmu.Doskonale zdajesz sobie " +
                            "z tego sprawę, że jeśli nikt cię szybko nie odnajdzie, to po prostu zwariujesz.");


                            ParNumber = 124;


                            break;
                        }
                    case 44:
                        {

                            Console.WriteLine("W oddali widać bazę. Ale tylko pozornie znajduje się ona blisko.Czeka cię spory kawałek " +
                                "forsownego marszu.  A właściwie  skoków.Mimo jednej  trzeciej g  i specjalnego  obciążenia " +
                                "skafandra, wciąż  jesteś niemal  dwukrotnie lżejszy  niż normalnie.  Musisz być  ostrożny. " +
                                "Skafander automatycznie  załata małe  rozdarcie,  ale gdybyś  upadł i  stłukł hełm  lub dziura byłaby zbyt duża...");

                            Console.WriteLine("Nad sobą masz usiane gwiazdami niebo, na dziwnie bliskim horyzoncie(wszak planetka ma mały promień) " +
                            "rysuje się łuna wschodzącego Ordmoru.Na jej tle ostro strzelają górskie szczyty, a nieco bliżej – kopuła bazy.");


                            Oxygen -= 1;







                            ParNumber = 25;


                            break;
                        }
                    case 45:
                        {
                            Print("Nagły impuls poraża twój mózg blaskiem i hukiem. Tak zawsze zaczyna się wejście do " +
                                "sieci bez  znajomości  haseł.Wydaje ci  się,  że słyszysz  nie tylko  bicie swego  serca,  ale i " +
                                "klikanie pracujących neuronów.Teraz programy nakładkowe w twoim procesorze zaemulują " +
                                "twoją osobowość i wprowadzą ją do sieci wraz z całym pakietem aplikacji ochronnych.   " +
                                "Wchodzisz w nieznaną cyberprzestrzeń, w której mogą czyhać rozliczne pułapki. " +
                                "Wydaje ci się, że czujesz, jak twoje myśli płyną światłowodami wprost do mózgu centralnego. I tam " +
                                "oczywiście      zostają zaatakowane       przez programy      defensywne bazy.   Szukasz kodu " +
                                "wejściowego do śluzy hangaru. Mijają cenne sekundy.");  
                                ParNumber = Player.StatTest("ego", 0, 0, 136, 70);
                           
                            /*


                                       Test Ego:

                                                   Udany – paragraf 136.



                                                   Nieudany – paragraf 70.

                            */
                            break;
                        }
                    case 46:
                        {
                            Print("Fidiasz bezwładnie przewraca się na podłogę. Leonardo doskakuje do ciebie, chwyta cię za ramiona i krzyczy:\n " +
                                "– Zwariowałeś?! Co ty wyprawiasz?! \n" +
                                "Złość już opadła.Czujesz, że boli cię ręka, widzisz gramolącego się z podłogi mężczyznę, słyszysz głos Leonarda: " +
                                "\n– Nic ci nie jest, Fidiaszu?  \n" +
                                "–  Chyba...  –  Mężczyzna obmacuje twarz, jakby sprawdzając, czy nie odkształciła się od twojego ciosu. " +
                                "\n– To świr jakiś, co? " +
                                "\n– Ja... – chcesz coś tłumaczyć. – Ja...");
                            ParNumber = 8;

                        
                            break;
                        }
                    case 47:
                        {
                            Print("Miałeś szczęście, przez ten czas nie natrafiłeś na żadne kosmiczne śmieci, " +
                                "które mogłyby uszkodzić  twój pojazd.  " +
                                "Teraz już  nie warto  ryzykować. Uaktywniasz wszystkie systemy " +
                                "statku – będzie cię można namierzyć z daleka, ale i system ochronny będzie mógł wyłapywać wszystkie zagrożenia.");
                            AnyKey();
                            Print("Już po dwóch godzinach od uaktywnienia systemu nawiązujesz łączność z obcym statkiem. Przyjaciel to czy wróg?" +
                                "Czy wystarczająco długo leciałeś wygaszonym kosmolotem, by ścigający cię Rzeźbiarze zgubili trop?");

                            ParNumber = Player.StatTest("", Days, 0, 86, 55);
                            /*

                                   Mechanika


                                       Testuj podaną wcześniej w paragrafie 14 liczbę dni(0 - 9). Wylosuj ostatnią cyfrę numeru


                                   strony.


                                       Wynik większy od wskazanej liczby dni – ParNumber = 55.

                                       Wynik mniejszy bądź równy od wskazanej liczby dni – paragraf 86.

                          
                            */

                            break;
                        }
                    case 48:
                        {
                            Print("I nagle wszystko gaśnie. Ogarnia cię ciemność i cisza.A po chwili słychać komunikat: " +
                                "„Pilot bez uprawnień!Żądanie natychmiastowego opuszczenia pojazdu!” " +
                                "Znów zgrzyta  osłona gniazda. Jednocześnie słyszysz tupot podkutych butów i krzyki. " +
                                "Zdzierasz z głowy hełm, próbujesz wygramolić się z gniazda. Widzisz, jak w otwierających " +
                                "się drzwiach śluzy stają żołnierze. Zeskakujesz na ziemię.Podnosisz porzucony przed chwilą paralizer.\n");
                                   
                            Crossroads(new string[] { "Strzelasz", "Nie strzelasz" }, new int[] { 73, 24 });

                            /*
                            Strzelasz – paragraf 73.


                                       Nie strzelasz – paragraf 24.

                                    */
                            break;
                        }
                    case 49:

                        {
                            Console.WriteLine("Najpierw ustal liczbę kwadransów, które przeznaczasz na dodatkowe poszukiwania w magazynie: ");
                            int Time = Convert.ToInt32(Console.ReadLine());
                            Oxygen -= Time;
                            Print("");
                            // Mechanika



                            //Odejmij od zapasu tlenu wybraną liczbę kwadransów.  
                            ParNumber = 65;


                            break;
                        }
                    case 50:
                        {

                            Console.WriteLine("Wkładasz łącze w gniazdo na tablicy rozdzielczej. Koncentrujesz się na sieci.");

                            ParNumber = Player.StatTest("ego", 0, 0, 72, 123);

                            //Mechanika

                            /*

                                           Test Ego:



                                                       Udany – paragraf 72.

                                                       Nieudany – paragraf 123.

                                        */
                            break;
                        }
                    case 51:
                        {

                            Console.WriteLine("Słyszysz tupot  butów.Następni żołnierze  śpieszą na  spotkanie z  tobą.");
                            Console.WriteLine("Czy chcesz  im stawić czoła, czy może podasz tyły?");

                            Crossroads(new string[] { "Ruszasz na spotkanie", "Wycofujesz się biegiem" }, new int[] { 32, 40 });

                            //Ruszasz na spotkanie – ParNumber = 32.
                            //Wycofujesz się biegiem – paragraf 40.
                            break;
                        }
                    case 52:
                        {

                            Console.WriteLine("Teraz musisz tę dostawę rozprowadzić po całym basenie, musisz sprawdzić jej zawartość, " +
                            "musisz się  nią zaopiekować.  Gdzieś na  dnie twojego  mózgu kołacze  myśl,  że kiedyś  byłeś " +
                            "kimś  innym,  że żyłeś  w piękniejszym  niż ten  świecie.");
                            Print("Ale ten  błysk niepożądanej  myśli szybko gaśnie.");


                            Console.WriteLine("Biomasa jest najważniejsza.Istniejesz tylko po to, aby się nią opiekować.Więc śpieszysz" +
                                " się, bo wkrótce przyjdzie nowy transport surowca. Żebyś mógł dalej opiekować się biomasą.");

                            ParNumber = 121;


                            break;
                        }
                    case 53:
                        {

                            Print("– Posłuchaj mnie, człowieku. Odnaleźliśmy i przywróciliśmy do życia twojego trupa." +
                                "Nie chcemy cię więzić, ale potrzebujemy twojej pomocy. Musimy powierzyć ci pewną misję, " +
                                "jeśli przeprowadzisz ją pomyślnie, powiadomimy o tobie władze solarne i pozwolimy ci wrócić do normalnego życia.");

                            Print("– A jeśli się nie zgodzę?");
                            AnyKey();
                            Print("– Wiedzą o tobie tylko wtajemniczeni, ty nie znasz nikogo. – Książę nie groził. Po prostu przypominał fakty.");
                            AnyKey();
                            Print("– Nie macie prawa mnie przetrzymywać – odpowiadasz ostro. ");
                            AnyKey();
                            Print("–  Tu ja stanowię prawo, człowieku – tym razem książę podniósł głos, a kula jego głowy poczerniała. – Więc jak, zgadzasz się?");

                            Crossroads(new string[] { "Tak", "Nie" }, new int[] { 103, 61 });

                            AnyKey();
                            break;
                        }
                    case 54:
                        {

                            Print("Ból! Ból! Ból!");
                            Print("Nie wiesz, ile czasu trwa powrót, kleszcze systemu ochronnego zaciskają się na twoim umyśle.");
                            Print("Nie znasz hasła, więc układ odpornościowy sieci traktuje cię jak intruza.");


                            Print("Nagle ból znika.Stoisz oniemiały, znów patrząc na błyszczącą diodami tablicę rozdzielczą.");


                            Print("Udało się!Uciekłeś!Czujesz  skurcz dłoni, nieporadnym  ruchem wyciągasz  wtyczkę łącza.");

                            Print("Powoli wracasz do siebie, choć na pewno osłabiłeś swoje wszczepki.");


                            Print("Patrzysz na zegarek.Nie do wiary – wydawało ci się, że to tylko chwila, a ty spędziłeś w sieci całe pół godziny!");



                            Oxygen -= 2;

                            Crossroads(new string[] { "Ponownie próbujesz złamać sieć\nPostanawiasz zbadać inne obiekty:", "Kolektory", "Śluza bazy", "Powrót do kosmolotu" }, new int[]
                            {50, 128, 145, 64});

                            /*
                           Ponownie próbujesz złamać sieć – ParNumber = 50.


                           Postanawiasz zbadać inne obiekty:  
                           Kolektory – paragraf 128.
                           Śluza bazy – paragraf 145.
                           Powrót do kosmolotu – paragraf 64(odejmij kwadrans).

                        */
                            break;
                        }
                    case 55:
                        {

                            Print("–  To ja, twój  przyjaciel  –  słyszysz w  słuchawkach,  od razu  poznajesz głos  Leonarda.");

                            Print("- Zaraz przejmiemy kontrolę nad twoim statkiem. I co, warto było uciekać, odmrożeńcu?");


                            Print("Próbujesz coś  powiedzieć,  ale brakuje  ci czasu.  Znów odżywają  układy statku, ale  tym razem to nie ty je kontrolujesz.");



                            Print("Gwałtowny błysk rozjaśnia twój umysł, by za chwilę pogrążyć go w ciemności. " +
                            "Gdzieś na skraju gasnącej  świadomości słyszysz  powtarzane regularnie  słowa:  „Plantacja,  plantacja,  plantacja...” ");

                            ParNumber = 59;


                            break;
                        }
                    case 56:
                        {

                            Print("Gródź modułu higieny też jest podniesiona. " +
                                "Prawie nie ma zniszczeń, tylko materiał worka prysznicowego podarł się na strzępy. " +
                                "Przez chwilę rozglądasz się po pomieszczeniu. Kible na stacjach z  małą grawitacją  zawsze wzbudzały  twoje zainteresowanie.  " +
                                "Frapowała cię  ilość pomysłów, na jakie wpadali ludzie, by nawet w warunkach nieważkości móc zrobić co trzeba." +
                                "Przeszukanie kabiny zajmuje ci kwadrans, ale nie znajdujesz tu niczego ciekawego. ");

                            Oxygen -= 1;
                            Print("Przejdź do innego pomieszczenia bazy:");
                            Crossroads(new string[] { "Sypialnie", "Korytarz", "Duża sala" }, new int[]
                            {110, 143, 167});

                            /*
                           
                           Sypialnie – paragraf 110.
                           Korytarz – paragraf 143.
                           Duża sala – paragraf 167.

                        */
                            break;
                        }
                    case 57:
                        {

                            Console.WriteLine("Jest tak, jak  myślałeś.Nie zwalniasz  przy żadnym  z rozgałęzień  korytarza i  w końcu " +
                                "docierasz  do stalowych wrót, nad  którymi  pobłyskuje napis:  „Śluza lądowiska.  " +
                                "Dostęp  –   rzeci stopień”.  Nie wiesz, co  to oznacza, ale  domyślasz się, że  powinieneś mieć  odpowiedni klucz " +
                                "wejściowy.A skoro go nie masz...Musisz przełamać tę blokadę.Z gniazda zamka wyciągasz bolec neurowszczepu i wsuwasz go w otwór w swojej potylicy.");
                            AnyKey();
                            ParNumber = 45;


                            break;
                        }
                    case 58:
                        {

                            Print("Udało się. Co prawda zajęło ci to jeszcze trochę czasu, ale wiesz już, co jest na karcie.To kod otwierający śluzę hangaru.");

                            Crossroads(new string[] { "Chcesz obejrzeć hangar\nChcesz obejrzeć inne pokoje bazy:", "Moduł higieny", "Sypialnie", "Duża sala" }, new int[]
                            {141, 156, 110, 167});

                            /*Jeśli chcesz obejrzeć hangar – ParNumber = 141.


                            Chcesz obejrzeć inne pokoje bazy:

                                        Moduł higieny – paragraf 56.



                                        Sypialnie – paragraf 110.


                            Duża sala – paragraf 167.

                            */
                            break;
                        }
                    case 59:
                        {

                            Print("Wszystko to pamiętasz jak przez mgłę. Stoisz pośrodku olbrzymiej jaskini, z której sufitu zwieszają się " +
                                "ogromne lampy  świecące jaskrawym  żółtym światłem.  Tkwisz po  kolana w " +
                                "brunatnym szlamie, czując smród jego  wyziewów. W dłoniach trzymasz analizator " +
                                "– miernik stężenia    poszczególnych składników      biomasy. " +
                                "Jesteś tu  dla biomasy.     Biomasa jest najważniejsza.");

                            ParNumber = 121;


                            break;
                        }
                    case 60:
                        {

                            Print("Po kilku minutach zjawiają się twoi prześladowcy.Leonardo trzyma dziwne urządzenie, z " +
                                "którego wychodzą liczne łącza neurowszczepów.Podchodzi do ciebie ostrożnie, tak aby ani " +
                                "na chwilę nie znaleźć się między tobą a żołnierzem. Czujesz jego dłoń na włosach, a potem " +
                                "metaliczny chłód bolców neurowszczepu wślizgujących się w twoją czaszkę.");


                            Print("–  I warto  było uciekać?  –  słyszysz.  –  Sprawdzimy twoją  odporność.Może dostaniesz " +
                                "jeszcze jedną szansę, a może czeka cię plantacja.Ciekawe...bardzo ciekawe...");

                            Console.ReadKey();
                            Print("Tracisz przytomność. ");
                            /*Mechanika



                            Test Ego:



                                        Udany – paragraf 132.

                                        Nieudany – paragraf 59.

                            */
                            break;
                        }
                    case 61:
                        {

                            Print("Od pół  godziny znów  siedzisz w  swojej kabinie.  Leonardo odprowadził  cię tu  po " +
                                "rozmowie z księciem. Dali ci czas do namysłu.Możesz przyjąć ich ofertę, zaufać, że potem " +
                                "rzeczywiście spełnią  swoją obietnicę.  Albo odrzucić  tę propozycję.  Co zrobią  wtedy? Nie wiesz.");

                            Print("Chodzisz więc po swojej kabinie niczym zwierz zamknięty w klatce. Trzy kroki, zwrot, " +
                                "trzy  kroki, zwrot, trzy kroki...Odcięli cię  od świata  –  drzwi się  nie otwierają, nie  działa " +
                                "wideościana i czepek wirtuala.A może chcieli odciąć świat od ciebie?");

                            Print("Wydaje ci się, że słyszysz kroki. Zastygasz w bezruchu, nasłuchujesz.Rzeczywiście, ktoś " +
                                "zatrzymuje  się Przed  twoimi drzwiami.Chwilę manipuluje  przy magnetycznym  zamku.");


                            Print("Drzwi rozsuwają się i staje w nich Leonardo.");
                            Print("– No i jak, namyśliłeś się? Pomożesz nam?  ");
                            
                            Crossroads(new string[] { "Tak", "Nie" }, new int[] { 10, 16 });
                            
                            break;
                        }
                    case 62:
                        {

                            Print("Idziecie długim   korytarzem.Po prawej   stronie macie   ścianę pokrytą   świetlnymi oznaczeniami, " +
                            "po  lewej drzwi  do kolejnych kabin.  Niektóre  z nich  są przyozdobione malunkami holosprayu. ");

                            Print("– Gdzie jestem? – pytasz.");



                            Print("–  Kolos, czwarty księżyc planety Ordmor. Trzecie Gniazdo Klanu Rzeźbiarzy Pierścieni.");


                            Print("Przypominasz sobie? – Patrzy na ciebie pytająco. Kręcisz głową. Jedne z drzwi otwierają się, " +
                        "wychodzi z  nich niski, grubawy  mężczyzna.Podobnie jak  twój przewodnik  ma na  czole gniazda neurowszczepów i zniekształcone gardło. I równie dziwny głos.");


                            Print("– Witaj, Leonardo – mówi.");


                            Print("–  Cześć, Fidi. –  Twój przewodnik kiwa głową i wskazuje na ciebie palcem. – " +
                            "Zobacz, to nasz  zmarźlak.Nawet żwawo  się rusza, jak  na faceta, który  tyle lat  przeleżał w  boi ratunkowej.");


                            Print(" Podnosisz rękę w geście przywitania.");


                            Print(" – Naleniuchował się, to teraz ma krzepę – mówi Fidiasz i maca twoje ramię, jakby oceniał jego siłę.Wkurza cię to.");

                            ParNumber = Player.StatTest("mind", 0, 0, 74, 105);
                            
                            /* Mechanika





                               Test Umysł:



                                          Udany – paragraf 74.



                                          Nieudany – paragraf 105.

                              */
                            AnyKey();
                            break;
                        }
                    case 63:
                        {

                            Print("Podpełzasz bliżej. Martwy człowiek leży na plecach, przyciskając dłonie do brzucha. " +
                            "Nie jesteś  w  stanie dostrzec  jego twarzy  –  szybę hełmu  pokrywa mgła.  " +
                            "Nie jesteś  pewien,  ale chyba   rdzawoczerwona mgła.   Wstrząsa tobą   dreszcz.Odginasz ramiona   trupa, " +
                            "ale w skafandrze nie  ma dziury.  Prawdopodobnie został  postrzelony,  zanim założył  kombinezon.");


                            Print("Potem wpełzł do korytarza, aby się ukryć.A potem skonał.");



                            Print("Obszukujesz ciało, ale  obok nieboszczyka  nie leży  żaden przedmiot.  " +
                            "Przez chwilę  nie wiesz, co robić.Rozwiązanie pojawia się nagle. " +
                            "Usiłujesz sięgnąć do naramiennego czytnika kart pamięciowych.Żeby to  zrobić, " +
                            "musisz wpełznąć na martwe ciało.Otwierasz blokadę i już trzymasz w dłoni kartę. " +
                            "Być może dzięki niej poznasz prawdę. ");
                            Print("Wszystko zajęło ci kolejny kwadrans.");


                            Oxygen -= 1;


                            ParNumber = 90;

                            AnyKey();
                            break;
                            
                        }
                    case 64:
                        {
                            Oxygen -= 1;
                            Print("Nie masz  tu czego  szukać.Zobaczyłeś wszystko, co  mogłeś zobaczyć, i  znalazłeś,  co mogłeś znaleźć. Opuszczasz bazę.");

                            if (CloseToBase == true)
                            {
                                ParNumber = 9;
                                    }
                            else
                            {
                                ParNumber = 81;
                                    }

                            //Jeśli lądowałeś w pobliżu bazy(tzn.przeszedłeś przez punkt 119) – ParNumber = 9.

                            //Jeśli lądowałeś daleko od bazy(tzn.przeszedłeś przez punkt 21) – ParNumber = 81.

                            AnyKey();
                            break;
                        }
                    case 65:
                        {

                            Print("Szczerze mówiąc, robisz  to bez  przekonania. No bo  cóż jeszcze  można tu znaleźć?");
                            AnyKey();
                            Print("Im dłużej szukasz, tym bardziej się zniechęcasz.");
                            
                            ParNumber = Player.StatTest("mind", 0, 0, 156, 78);

                            /*
                           Test Umysł:

                                       Udany – paragraf 156.
                                       Nieudany – paragraf 78.

                        */

                            AnyKey();
                            break;
                        }
                    case 66:
                        {

                            Print("To jednak  było wielkie  ryzyko. " +
                                "Rój meteorytów  zniszczył osłonę  kosmolotu. Skalne okruchy przebiły pancerz i uszkodziły wiele urządzeń. " +
                                "Najgorszy był ten pocisk, który trafił w silnik.Nastąpiło zakłócenie pracy stosu, gigantyczna temperatura nadtopiła zbiornik paliwa." +
                                "Nawet nie  zdążyłeś zareagować  –  zresztą nie  miałeś żadnych  szans. ");
                            Print("Kilka sekund  po zderzeniu twój statek eksplodował.");
                            Console.ReadKey();



                            ParNumber = 11;


                            AnyKey();
                            break;
                        }
                    case 67:
                        {

                            Print("Po kolejnych  piętnastu minutach  docierasz  do bazy.Obcy obiekt  niepokoi  cię,  " +
                                "tym bardziej że straciłeś jego namiar. Przed sobą masz budynek mieszkalny i hangar. " +
                                "Nieco po prawej dostrzegasz pusty, ciemny prostokąt lądowiska.");


                            Print("Gdybyś powędrował nieco dalej w lewo, po piętnastu minutach doszedłbyś do stojących na wzgórzu kolektorów. " +
                                "Pamiętaj, że masz ograniczony zasób tlenu w butlach.");
                            Oxygen -= 1;

                            Crossroads(new string[] { "Oglądasz bazę", "Idziesz do kolektorów" }, new int[] {83, 128 });
                            /*
                           Oglądasz bazę – paragraf 83.

                           Idziesz do kolektorów – paragraf 128.

                        */
                            break;
                        }
                    case 68:
                        {

                            Print("Coraz bardziej nurtuje cię myśl o tym, żeby spróbować ucieczki.Nie masz przecież żadnej gwarancji. " +
                                "Misja może okazać się niebezpieczna. A nawet jeśli zakończysz ją szczęśliwie, to kto wie co zrobią Rzeźbiarze.");


                            Print("To jednak  nie będzie  łatwe. Na pewno  musiałbyś przejąć  kontrolę nad  komputerem pokładowym – " +
                            "nie wiesz, jakie zabezpieczenia ponakładali na niego Rzeźbiarze.");


                            Print("Czy twoje Ego jest dostatecznie silne? Czy jesteś pewien swojego Umysłu? I czy w ogóle chcesz się buntować?");
                            
                            Crossroads(new string[] { "Tak", "Nie"}, new int[] { 129, 138});
                            
                            /*
                            Tak – ParNumber = 129.



                            Nie – paragraf 138.

                         */
                            break;
                        }
                    case 69:
                        {
                            Character Hugo = new Character(7, 3, 4, "Hugo Amazing", "biznesmen.W swoim czasie prowadziłeś interesy związane z produkcją cyborgów. " +
                                    "W układzie  Reagana chciałeś  handlować z  Klanem Rzeźbiarzy  Pierścieni i " +
                                    "naukowcami badającymi krzemowe Życie w magmowych wylewach na księżycu Ognistym. " +
                                    "Masz dobry  procesor osobowości, znasz  się na  wielu rzeczach.  " +
                                    "Twoją twarz  i pierś pokrywają reklamowe tatuaże twojej firmy." +
                                    " Ich kolory i kształty zmieniają się z każdą chwilą, układając w  zaprojektowane przez " +
                                    "specjalistów od  marketingu wzory, które  pozytywnie oddziałują na klienta.");

                            Player = Hugo;

                            Player.PrintName();
                            Console.Write(" - ");
                            Player.PrintDesc();

                            ParNumber = 175;

                            AnyKey();
                            break;
                        }
                    case 70:
                        {

                            Print("Czujesz szarpiący ból przenikający mięśnie.Przed oczami eksploduje ci tysiąc rakiet. " +
                                "Nie udało się, nie złamałeś kodu. Spróbujesz jeszcze raz.");

                            Player.setEgo(Player.Ego - 1);
                            ParNumber = Player.StatTest("ego", 0, 0, 136, 97);
                            /*
                               Zredukuj cechę Ego o 1 punkt.


                              Test Ego:  

                              Udany – paragraf 136.

                              Nieudany – paragraf 97.

                            */
                            AnyKey();
                            break;
                            
                        }
                    case 71:
                        {

                            Print("Miałeś chyba rację, to tylko złudzenie.Spokojnie docierasz do lądowiska, gdzie czeka już na ciebie gotowy prom.");



                            ParNumber = 116;

                            AnyKey();
                            break;
                        }
                    case 72:
                        {

                            Print("Bez trudu przebiłeś się przez warstwę zaporową sieci i znalazłeś hasło otwierające śluzę hangaru.");

                            Crossroads(new string[] { "Wchodzisz do hangaru\nIdziesz do innego miejsca bazy:", "Duża sala", "Korytarz", "Moduł higieny", "Sypialnie", "Śluza bazy"}, 
                                new int[] { 141, 167, 143, 56, 110, 145 });

                            /* Wchodzisz do hangaru – paragraf 141.



                             Idziesz do innego miejsca bazy(patrz schemat).

                           */
                            
                            break;
                        }
                    case 73:
                        {

                            Print("Jeden z  twoich przeciwników  wali się  na podłogę.  " +
                            "Po jego  hełmie przebiegają  błękitne iskry, ciało trzepocze na ziemi.Próbujesz zdjąć następnego, gdy dopada cię fala bólu.");



                            ParNumber = 24;
                            AnyKey();

                            break;
                        }
                    case 74:
                        {

                            Print("– Odwal się – mówisz, wyszarpując ramię. – Co to za pajac? – zwracasz się do Leonarda.");
                            Console.ReadKey();
                            Print("–  Poznajcie się, panowie  –  twój przewodnik  chce załagodzić  sytuację.  –   To nasz odmrożeniec, a to Fidiasz." +
                                "Rzeźbiarz Pierścieni, rzecz   jasna.");
                            Console.ReadKey();
                            Print("No, Fidi, podaj dłoń przybyszowi z przeszłości.");
                            Print("– No to już się znamy – mruczysz. ");
                            Console.ReadKey();
                            Print("Fidiasz przygląda ci się uważnym wzrokiem. W końcu uśmiecha się i zwraca do Leonarda:");
                            Print("– Niech będzie, lubimy się.Cześć. –  Odwraca się na pięcie i odchodzi. Chwilę patrzycie " +
                                "za nim, obserwując tęczowe pręty świetlne pobłyskujące z czubka jego czaszki.");
                            Print("– To teraz modne – wyjaśnia Leonardo i ruszacie dalej.");


                            AnyKey();
                            ParNumber = 91;


                            break;
                        }
                    case 75:
                        {

                            Print("Powalasz mężczyznę  silnym uderzeniem.  Na twojej  drodze staje  drugi przeciwnik.");
                            AnyKey();

                            Print("Próbujesz kopnąć go w kolano. On się uchyla.");

                            ParNumber = Player.StatTest("body", 0, 0, 92, 122);

                            /*
                            Test Ciało:
            Udany – paragraf 92.
                                        Nieudany – paragraf 122.


                              */
                            break;
                        }
                    case 76:
                        {

                            Print("A więc to nie żadna obca ingerencja. " +
                            "To szaleństwo jednego z Rzeźbiarzy doprowadziło do katastrofy.Odkrył w pierścieniu gigantyczną rzeźbę, taką, jakiej nie " +
                            "potrafiłby stworzyć żaden z klanowych braci.Czy to cudowny twór przyrody? " +
                            "Czy dzieło Obcych, nieznanych Obcych,  którzy też  oddawali cześć  pierścieniom? " +
                            "I  to ostatnie  zdanie:  „Ale przecież  wy wiecie”.  " +
                            "Czyżby książę  wiedział o  tej rzeźbie?  Teraz staje  się jasne, dlaczego  koniecznie chciał tu wysłać ciebie. " +
                            "Bał się, by inni Rzeźbiarze nie poznali prawdy.");
                            AnyKey();

                            Print("Dwóch członków trzyosobowej załogi bazy nie żyje.Pozostał tylko wariat. Gdzie on jest?");
                            AnyKey();


                            Print("Czy czeka na ciebie z miotaczem w ręku i szaleństwem w oczach? A może ty go...");
                            AnyKey();
                            Print("Nagle  do głowy przychodzi  ci  szaleńczy pomysł:  a gdyby  tak zobaczyć  tę rzeźbę?  A gdyby tak polecieć w głąb pierścienia?");


                            AnyKey();
                            ParNumber = 64;


                            break;
                        }
                    case 77:
                        {

                            Print("Czujesz straszliwy ból.Twoja skóra piecze, jakby palono ją żywym ogniem. Krzyczysz.");
                            AnyKey();

                            Print("Ale cierpienie  wciąż narasta.  Jak przez  mgłę widzisz  cofającego się  o krok  żołnierza, patrzącego na trzymany w ręku paralizer.");
                            AnyKey();
                            Print("„Strzelił pełną mocą” – gasnąca myśl wolno przepływa przez twoją głowę. ");
                            Print("Osuwasz się na kolana, a potem bezwładnie walisz na ziemię. " +
                                "Nie czujesz uderzenia – tylko tężejące mięśnie, trzepoczące rozpaczliwie serce i drżące powieki.  ");
                            AnyKey();

                            Print("Umierasz,  a żołnierz  stoi nad  tobą w  bezruchu,  czekając na  rozkazy swego  mózgu wojennego.");
                            AnyKey();
                            ParNumber = 38;
                            
                            break;
                        }
                    case 78:
                        {

                            Print("Tak jak się spodziewałeś – tylko zmarnowałeś czas. Zniechęcony wychodzisz z hangaru. ");

                            Print("Dokąd idziesz?");

                            Crossroads(new string[] { "Kolektory", "Śluza bazy", "Powrót do kosmolotu" }, new int[] { 128, 145, 64 });


                                /*
                              Kolektory – paragraf 128.


                              Śluza bazy – paragraf 145.

                              Powrót do kosmolotu – paragraf 64(odejmij kwadrans).

                        */
                            break;
                        }
                    case 79:
                        {

                            Print("Źle obliczyłeś skok. Sądziłeś, że ominiesz dziwny szpiczasty kamień, " +
                                "a jednak zahaczyłeś o niego czubkiem buta i wywróciłeś się. " +
                                "Podniosłeś się od razu i ruszyłeś dalej.");


                            Oxygen -= 1;
                            ParNumber = 99;


                            break;
                        }
                    case 80:
                        {

                            Print("Ta informacja jak grom spada na ciebie po sześciu godzinach lotu, kiedy już zacząłeś się uspokajać i wierzyć w powodzenie.");

                            AnyKey();

                            Print(" „Zgłaszam wyczerpanie  stosu paliwowego  –  pulsujące czerwienią  litery przesuwają  się przed twoimi oczami. " +
                                "– Za trzydzieści trzy minuty pojazd utraci sterowność. Najbliższa baza ");

                            AnyKey();

                            Print("– Gniazdo Rzeźbiarzy na księżycu Kolos.Manewr powrotu można zrealizować. " +
                                "Po wyczerpaniu  paliwa pojazd  będzie leciał  bezwładnie, a po  124  godzinach wyjdzie  z " +
                                "ekliptyki   układu. Możliwe przechwycenie   przez grawitację   Ordmoru i   spłonięcie w " +
                                "atmosferze. Układy podtrzymywania  biologicznego czerpią  energię z  baterii słonecznych.");
                            Print("Czas utrzymania pasażera przy życiu w miarę oddalania się od gwiazdy centralnej układu – 2 lata i 24 dni”");
                            AnyKey();
                            Print("Komputer pokładowy odpowiada na twoje wszystkie zadawane w myślach pytania.");

                            Crossroads(new string[] {"Zawracasz,  narażając się  na niechybne  przechwycenie przez  patrolowce Rzeźbiarzy", "Lecisz dalej, ryzykując  śmierć w  atmosferze Ordmoru  lub wieloletnią, " +
                                "zakończoną śmiercią samotność"  }, new int[] {101, 43 });

                            /*Zawracasz,  narażając się  na niechybne  przechwycenie przez  patrolowce Rzeźbiarzy  –  

                        paragraf 101.


                            Lecisz dalej, ryzykując  śmierć w  atmosferze Ordmoru  lub wieloletnią, zakończoną


                        śmiercią samotność – paragraf 43.
                        */

                            break;
                        }
                    case 81:
                        {

                            Print("Posuwasz się krokiem miarowym i szybkim – już opanowałeś chodzenie po powierzchni Transkolosa. " +
                                "A jednak i tobie może zdarzyć się błąd.");

                            int Roll = rnd.Next(0, 9);
                            if (Roll < 3)
                            {
                                ParNumber = 79;
                            }
                            if (Roll > 2 && Roll < 7)
                            {
                                ParNumber = 41;
                            }
                            if (Roll > 6)
                            {
                                ParNumber = 155;
                            }
                            /*Mechanika



                            Wylosuj cyfrę 0 - 9(otwierając książkę na dowolnej stronie i sprawdzając ostatnią cyfrę).

                            Cyfra 0 - 2 idź do 79.



                              Cyfra 3 - 6 idź do 41.



                                Cyfra 7 - 9 idź do 155.



                          */
                            AnyKey();
                            break;
                        }
                    case 82:
                        {

                            Print("Znajdujesz dwie  karty pamięciowe, ale, niestety, połamane, szczątki  holoprojektora,  " +
                            "kawałki plastikowych naczyń.Nic ciekawego, zmarnowałeś trochę czasu.");
                            Print("Wchodzisz do korytarza.");



                            ParNumber = 143;

                            AnyKey();
                            break;
                        }
                    case 83:
                        {

                            Print("Baza wydaje  się martwa, jakby  stanowiła nieodłączny  i odwieczny  element krajobrazu.");


                            Print("Śluzy są otwarte, wewnątrz budynku panuje mrok. Sprawdzasz rezerwowe zbiorniki z tlenem, " +
                                "które znajdują  się koło  lądowiska.");
                            AnyKey();
                            Print("Niestety,  są puste.  Jesteś więc  zdany na  zapas tlenu  wtwoich butlach.Pamiętaj o tym.");

                            AnyKey();
                            Print("Obejście terenu  wokół bazy  zajęło ci  trochę czasu, więcej, niż  się sam  spodziewałeś.");

                            AnyKey();
                            Print("Musisz bardziej kontrolować jego upływ.");

                            int Time = rnd.Next(0, 9);
                            if (Time < 6)
                            {
                                Oxygen -= 1;
                            }
                            if (Time > 5)
                            {
                                Oxygen -= 2;
                            }
                            /*
                                Mechanika
                                Wylosuj cyfrę 0 - 9(otwierając książkę na dowolnej stronie i sprawdzając ostatnią cyfrę).
                                Cyfra 0 - 5 – Oxygen -= 1;
                                Cyfra 6 - 9 – Oxygen -= 2;
                            */
                            AnyKey();
                            ParNumber = 126;
                            break;
                        }
                    case 84:
                        {

                            Print("– Nie wiem, kiedy powstała Rzeźba – książę nie zwrócił uwagi na twoje słowa – i nawet " +
                                "nie próbujemy  się tego  dowiedzieć.Szkolimy naszych  adeptów,  by swoimi  ułomnymi " +
                                "tworami  oddawali cześć  Rzeźbie i  jej twórcom.  A gdy  ktoś z  naszych poczuje  się wielkim " +
                                "Rzeźbiarzem Pierścieni, kiedy  urośnie w  pychę,  bo umie  stworzyć dzieło  z kilkunastu " +
                                "elementów, wtedy dostępuje ostatniego stopnia wtajemniczenia – może zobaczyć Rzeźbę.");

                            AnyKey();
                            Print("– Ja już widziałem – znów przypominasz. – Jestem obcy. Co ze mną zrobicie?");
                            AnyKey();
                            Print("Na jedną chwilę znika wirtualna osłona głowy księcia. Widzisz twarz starca –  a może to tylko złudzenie?");
                            AnyKey();
                            Print("– Masz wybór – mówi książę. – Wiesz jaki.");

                            Crossroads(new string[] {"Żądasz, żeby cię uwolniono", "Decydujesz się przestąpić próg wtajemniczenia? Zostać Rzeźbiarzem Pierścieni? Tworzyć " +
                                "własne dzieła i czcić Rzeźbę" }, new int[] {149, 5 });
                            /*Żądasz, żeby cię uwolniono – paragraf 149.


                            Decydujesz się przestąpić próg wtajemniczenia? Zostać Rzeźbiarzem Pierścieni? Tworzyć

                        własne dzieła i czcić Rzeźbę – paragraf 5.

                          */
                            break;
                        }
                    case 85:
                        {

                            Print("Lot ma trwać blisko sześćdziesiąt godzin. Przez ten czas tkwisz zanurzony w organicznym " +
                                "płynie    wypełniającym moduł     sterujący.Galaretowata zawiesina     pomaga ci   znieść " +
                                "przeciążenia, odmładza  cię,  regeneruje organizm.  Na głowie  masz hełm  sprzęgający cię  z " +
                                "układem sterowniczym rakiety. To przez wszczep docierają do twojego mózgu informacje o " +
                                "przebiegu  lotu.Ty po  prostu  „czujesz”  statek,  rejestrujesz stany, w  jakich znajdują  się " +
                                "poszczególne  podzespoły. Awarie sygnalizuje  ból,  sprawność  –  przyjemna sytość.  " +
                                "Poprzez hełm możesz też oglądać otaczający cię kosmos. Rosnącą tarczę Ordmoru, malejący krążek Kolosa. " +
                                "Próbujesz też  przejrzeć dane  zawarte w  mózgu komputera, ale  większość z  nich " +
                                "zablokowano.Przede wszystkim  chciałbyś wiedzieć, gdzie  w układzie  znajdują się  inne " +
                                "ludzkie bazy i jaki zasięg ma twój pojazd.");

                            ParNumber = Player.StatTest("ego", 0, 0, 17, 36);
                            AnyKey();
                            
                            /*
                          Mechanika



                          Test Ego:



                                      Udany – paragraf 17.

                                      Nieudany – paragraf 36.

                        */
                            break;
                        }
                    case 86:
                        {

                            Print("Po chwili  twój hełm  ożywa,  przed oczami  rysuje ci  się jasny  ekran,  na którym  wolno przepływają zielone litery.");

                            Print("Tu solarny ścigacz „Taryn”. Podaj swoje dane. ");

                            Print("Solarny ścigacz „Taryn”! Solarny! Ścigacz!  ");
                            AnyKey();
                            Print("Nie  zwlekasz.  Miałeś  jedną  szansę  na  sto  i  udało  się!  Na  twój  dryfujący  prom  natrafił " +
                                "statek solarny patrolujący te rubieże układu. Okręt wojskowy! To dlatego zarejestrowałeś go, " +
                                "dopiero gdy był bardzo blisko. Po prostu podchodził do ciebie na osłonach siłowych.");
                            AnyKey();

                            Print("„Mayday!   Mayday!  –  nadajesz.  – Obywatel  Dominium  Solarnego  prosi  o  pomoc! Mayday!”");
                            AnyKey();
                            Print("Jesteś uratowany.");
                            AnyKey();
                            ParNumber = 20;

                            break;
                        }
                    case 87:
                        {
                            Character Jack = new Character(8, 3, 3, "Jack Rodhon", "artysta multimedialny. " +
                                  "Byłeś twórcą sztuki wirtualnej - dzieł przekazywanych wprost do mózgu odbiorcy, " +
                                  "łączących doznania zmysłowe (obraz, muzyka) i podświadome (wpływ na funkcjonowanie organów wewnętrznych i " +
                                  "obwodowego układu nerwowego.\nByłeś ciągle naszprycowany różnymi świństwami, " +
                                    "bardzo często poddawałeś się niekontrolowanej stymulacji wirtualnej," +
                                    " nie przykładałeś wagi do ochrony własnego organizmu.Zamiast oczu masz wszczepy " +
                                    "płytek światłowodowych, a na ustach i dziąsłach liczne wszczepy wąsów czuciowych. " +
                                    "Twoja głowa przypomina przez to łeb ogromnego owada. Ponieważ byłeś artystą, " +
                                    "Rzeźbiarze potraktowali cię szczególnie i w czasie leczenia dodatkowo podrasowali twój mózg.");

                            Player = Jack;

                            Player.PrintName();
                            Console.Write(" - ");
                            Player.PrintDesc();

                            ParNumber = 175;

                            break;
                        }
                    case 88:
                        {
                            Print("Odzyskujesz kontrolę nad własną świadomością i rakietą. Gwałtownym skrętem schodzisz " +
                                "z  linii  strzału.  Już  wiesz,  kto  cię  atakuje  –  na  twoim  ogonie  siedzi  mały,  ale  niezwykle " +
                                "zwrotny stateczek Rzeźbiarzy. Ten sam, którego zabrakło na lądowisku Transkolosa. Szalony " +
                                "Rzeźbiarz strzeże swego odkrycia.");

                            ParNumber = Player.StatTest("ego", 0, 0, 153, 172);
                            AnyKey();
                            /*
                                Mechanika  
                                Test Ego:  

                                Udany – paragraf 153.  

                                Nieudany – paragraf 172.  
                                */
                            break;
                        }
                    case 89:
                        {
                            Print("Strzelasz. Ciało żołnierza wali się na ziemię z łoskotem, a ty czujesz w nozdrzach swąd spalenizny.");
                            ParNumber = 51;
                            AnyKey();
                            break;
                        }
                    case 90:
                        {
                            Print("Stoisz przed wejściem do hangaru i po raz kolejny przesłuchujesz zawartość karty, jakbyś " +
                                "chciał wydobyć z niej coś więcej,  niż usłyszałeś. Choć i tak wiesz już wiele, znów słyszysz " +
                                "słowa  wypowiadane  drżącym  głosem  Przez  konającego  człowieka,  który  wpełzł  do  tunelu, " +
                                "wierząc, że tam zdoła przed szaleńcem ukryć nie siebie nawet, ale tę wiadomość:  ");


                            AnyKey();
                            Print("„Dziewięćdziesiąt trzy obiekty... tak mówił... choć to niemożliwe... oszalał... zabił Wita... " +
                                "zastrzelił go... i mnie też... oszalał, mówi, że odkrył naturalną rzeźbę... dziewięćdziesiąt trzy " +
                                "elementy...  chciał  zniszczyć  stację...  po  co,  mówił,  po  co  ta  stacja...  i  my...  skoro  sam " +
                                "pierścień tworzy tak wspaniałą rzeźbę... albo ktoś, kto tu był przed nami... stracił wiarę... zabił " +
                                "Wita...  i  mnie...  książę  stworzył  rzeźbę  z  trzydziestu  elementów...  a  tam  dziewięćdziesiąt " +
                                "trzy... umieram... umieram bez wiary... ktoś tu był przed nami... ale przecież wy to wiecie...”");

                            AnyKey();
                            ParNumber = 76;

                            break;
                        }
                    case 91:
                        {
                            Print("– Opowiedz mi więcej – prosisz. – Kim jesteście?");
                            Print("–  Rzeźbiarzami  –  mówi  dumnie  Leonardo.  –  Dominium  przyznało  nam  status  wolnego klanu,  " +
                           "tak jak  Lotniarzom  i  Gwiezdnym  Nurkom.  Utrzymujemy  sześć  baz, " +
                           " a  na  kilkunastu innych  mamy  swoje  przedstawicielstwa.  Wykonujemy  też  usługi  dla  wielu  prywatnych sponsorów.  ");
                            AnyKey();
                            Print("– No dobrze, ale co robicie, biżuterię? – pytasz.  ");
                            AnyKey();
                            Print("– Biżuterię ? – Leonardo śmieje się cicho. – Och tak, biżuterię olbrzymów. Nie, człowieku, " +
                                "my tworzymy największe dzieła sztuki w tym kawałku kosmosu, rzeźbimy pierścienie planet.");
                            AnyKey();
                            Print("Oczywiście  nie  całe  –  dodaje  szybko,  widząc  twoje  zdziwienie.  –  Tworzymy  dynamiczne " +
                                "konstrukcje złożone z kilku lub kilkunastu skalnych i lodowych brył tworzących pierścienie. " +
                                "Wcześniej  nadajemy im odpowiednie kształty. Nasi mistrzowie potrafią nadać odpowiednie " +
                                "trajektorie  nawet  kilkudziesięciu  bryłom.  Działamy  też  na  większą  skalę.  Wprowadzamy " +
                                "sztuczne  księżyce  pasterskie  i  zmieniamy  tory  pierścieni,  pleciemy  je,  kształtujemy...");
                            AnyKey();
                            Print("No a teraz mamy kłopot.");
                            AnyKey();
                            Print("– Jaki?");
                            AnyKey();
                            Print("– Dowiesz się we właściwym czasie. – Nagle zmienia temat: – Jesteś głodny? ");

                            Crossroads(new string[] { "Jesteś", "Nie jesteś" }, new int[] { 102, 151 });
                            /*
                            Jesteś – ParNumber = 102.  
                            Nie jesteś – paragraf 151.  
                            */
                            break;
                        }
                    case 92:
                        {
                            Print("Wypadasz na korytarz. Na szczęście jest tu pusto, ale nie wątpisz, że obserwowano was i " +
                                "że pościg jest już w drodze. Nie zastanawiając się wiele, pędzisz wprost przed siebie.");
                            AnyKey();
                            Print("„To  baza!  –  kołacze  ci  w  głowie.  –  To  zamknięta  baza!  Tu  nigdzie  się  nie  ukryjesz!");
                            AnyKey();
                            Print("Jedyny ratunek to lądowisko”.");
                            AnyKey();
                            Print("Wciąż  biegniesz.  Nagle  korytarz  rozgałęzia  się  –  jedna  drog a  wiedzie  w  prawo,  druga " +
                                "prosto. Przypominasz sobie, że Leonardo mówił ci, która wiedzie do lądowiska.");
                            Crossroads(new string[] {"Skręcasz w prawo", "Dalej biegniesz prosto" }, new int[] {23, 57 });
                            //Skręcasz w prawo – paragraf 23.  
                            //Dalej biegniesz prosto – paragraf 57.  

                            break;
                        }
                    case 93:
                        {
                            Print("Na  karcie  pamięciowej  były  również  koordynaty.  Komputer  przyjął  je  i  zanalizował,  a " +
                            "potem poprowadził statek niczym po niewidzialnym sznurze wprost w to miejsce.  ");

                            AnyKey();

                            Print("Nie  musiałeś  nic  robić.  W  końcu  się  tam  znalazłeś  i  zobaczyłeś  Rzeźbę,  której  nie wykonał człowiek. Na pewno nie.");
                            AnyKey();
                            ParNumber = 15;

                            break;
                        }
                    case 94:
                        {
                            Character Philip = new Character(3, 8, 3, "Philip O’Connor", "Zawsze  pracowały  raczej  twoje  mięśnie  niż  mózg.\n" +
                                    "Twój partner i szef zarazem zginął w katastrofie, z której ty wyszedłeś cało.\n" +
                                    "Stymulacja  cybernetyczna  i  farmakologiczna,  której  używałeś,  osłabiła  twoje  Ego.  " +
                          "Ale masz doskonały refleks, intuicję, a kuracja, jakiej poddano cię w klinice Klanu Rzeźbiarzy, uczyniła cię siłaczem.");

                            Player = Philip;

                            Player.PrintName();
                            Console.Write(" - ");
                            Player.PrintDesc();

                            ParNumber = 175;
                            AnyKey();
                            break;
                        }
                    case 95:
                        {
                            Print("Próbujesz dźwignąć klapę. Jest ciężka, bardzo ciężka.");

                            ParNumber = Player.StatTest("body", 0, 0, 117, 114);
                            /*
                        Mechanika  
                       Test Ciało:  

                       Udany – paragraf 117.  

                       Nieudany – paragraf 114.  
                       */
                            break;
                        }
                    case 96:
                        {
                            Print("W   ostatnim   przebłysku   świadomości   słyszysz   dochodzący   jakby   z   zaświatów   głos Leonarda:");
                            Print("– Przetrzymał to, jest silny. Pójdzie na plantację.");
                            AnyKey();
                            ParNumber = 59;

                            break;
                        }
                    case 97:
                        {
                            Print("Przed twoimi oczami przepływają setki znaków, barw, kształtów. W uszach dudni tętniąca " +
                                "muzyka.  Nagle  gdzieś  w  głębi  umysłu  pojawia  się  pulsujący  napis:  „Brak  dostępu.  Brak dostępu”. " +
                                "Nie udało ci się! Twoje mięśnie słabną, osuwasz się na podłogę.");

                            // Mechanika  
                            /*
                            Zredukuj o 1 punkt jedną wybraną przez ciebie cechę: Ego, Umysł albo Ciało.  
                            */
                            ParNumber = 22;

                            break;
                        }
                    case 98:
                        {
                            Character Allan = new Character(4, 2, 8, "Allan  Ghobaz", "wirtman.  Byłeś  człowiekiem  uzależnionym  od  wirtuali. " +
                                   "Nieustająco zażywałeś     narkotyki    i   środki   pobudzające,      wchodziłeś     w   dziesiątki    rzeczywistości wirtualnych. " +
                                   "Brakowało  ci  pieniędzy  na  kuracje  oczyszczające  organizm  –  to  zniszczyło " +
                                   "twoje ciało i umysł. Teraz masz szansę powrotu do normalnego życia.\n" +
                                   "Jesteś chudym  mężczyzną  o  białej  skórze,  wybarwionych  tęczówkach  i  głowie  pokrytej srebrzystą     siecią   łączy. " +
                                "Praktycznie na całej długości kręgosłupa masz gniazda neurowszczepów.");

                            Player = Allan;

                            Player.PrintName();
                            Console.Write(" - ");
                            Player.PrintDesc();

                            ParNumber = 175;
                            AnyKey();
                            break;
                        }
                    case 99:
                        {
                            Print("W końcu dotarłeś do kosmolotu. Kiedy poczułeś, jak automaty ściągają z ciebie skafander, " +
                                "a  odżywczy  płyn  wlewa  się  w  kokon  ochronny,  odetchnąłeś  z  ulgą.  Jesteś  bezpieczny. " +
                                "Przynajmniej na jakiś czas.  ");
                            AnyKey();
                            ParNumber = 9;

                            break;
                        }
                    case 100:
                        {
                            Print("– Dzieje  się  coś  dziwnego  –  mówi  książę.  –  Moi  ludzie  jeszcze  o  tym  nie  wiedzą,  bo wstrzymałem  loty. " +
                                "Pięć  dni  temu  zamilkła  nasza  baza  na  Transkolosie  3.  Było  tam  trzech naszych. " +
                                "Ktoś mógł ich zaatakować. Masz sprawdzić, co stało się z tą placówką.");
                            AnyKey();
                            Print("– Dlaczego nie wysłałeś tam swoich ludzi?");
                            AnyKey();
                            Print("–  To  nie  takie  proste.  Być  może  szantażują  nas  Rzeźbiarze  z  innego  bractwa. " +
                                "Ale  być może macza w tym palce ktoś z moich ludzi. Jesteś jedyną osobą, o której wiem wszystko.");
                            AnyKey();
                            Print("Przygotuj się do drogi. Startujesz za dwie godziny. W międzyczasie Rzeźbiarze poddają twój organizm zabiegom wzmacniającym.");
                            AnyKey();

                            Player.setEgo(Player.Ego + 1);
                            Player.setMind(Player.Mind + 1);
                            Player.setBody(Player.Body + 1);

                            /*Mechanika  

                            Podnieś o 1 punkt każdą cechę (maksymalnie do 9 punktów).  
                            */
                            ParNumber = 13;  
                            
                            break;
                        }
                    case 101:
                        {
                            Print("Stos rzeczywiście się wyczerpał. Nie miało to większego znaczenia. Gdy tylko zbliżyłeś się do Ordmoru, " +
                                "zostałeś namierzony i przechwycony przez patrolowce Rzeźbiarzy. " +
                                "Z nich sterowano zdalnie twoim statkiem i tobą. Niewiele pamiętasz z wydarzeń tamtych  godzin – " +
                                "twoje zmysły zaatakowano nawałą   obrazów   i   dźwięków.   Koszmarny   hałas, " +
                                "porażające  oczy  migotanie,  nagłe  ochłodzenie  fizjologicznej  kąpieli  otępiły  cię  do  tego  stopnia, " +
                                "że ledwie zarejestrowałeś moment lądowania.");
                            AnyKey();
                            Print("Potem wywlekli cię z gniazda i jeszcze tam, w doku, wzięli się do ciebie. " +
                                "Podłączyli twój procesor osobowości do jakiegoś urządzenia i zafundowali najstraszniejszy wirtualny koszmar w twoim życiu.");
                            AnyKey();
                            ParNumber = Player.StatTest("ego", 0, 0, 112, 38);
                            //Mechanika
                            /*


                            Test Ego:  

                            Udany – paragraf 112.  

                            Nieudany – paragraf 38.  
                            */
                            break;
                        }
                    case 102:
                        {
                            Print("Kiwasz głową. Nie czujesz się najlepiej, ale coś byś zjadł.");
                            Print("–  Idąc prosto, doszlibyśmy do lądowiska. A my pójdziemy tutaj. " +
                                 "– Leonardo pociąga cię za rękaw i skręcane w boczny korytarz. ");
                            AnyKey();
                            Print("Jest tu ciemniej i drzwi znajdują się po obu stronach.");
                            AnyKey();
                            Print("Po  suficie  biegną  ścieżki  barwnego  światła  –  oznaczenie  dróg  awaryjnych  na  wypadek dekompresji.");
                            AnyKey();
                            Print("Zza  zakrętu  wyłaniają  się  dwie  istoty.  Zatrzymujesz  się,  zdziwiony  i  przestraszony. " +
                                "Wyglądają niczym ogromne chrząszcze – w hełmach i pokrywających całe ciała pancerzach, " +
                                "z  których  wyrastają  łącza,  kable,  serwery  hormonalne.  Stroje  są  idealnie  czarne,  tylko  na " +
                                "kaskach wymalowano wielobarwne znaki.");
                            AnyKey();
                            Print("Mijają was, nie odpowiadając na pozdrowienie Leonarda.");
                            AnyKey();
                            Print("–  To  najemnicy  –  mówi  twój  opiekun.  –  Zatrudniliśmy  mózg  wojenny  wraz  z  rojem wojowników. " +
                                "Ochraniają bazę. Wiesz, jesteśmy wolnym klanem, więc nie możemy w pełni ufać jurysdykcji Dominium. " +
                                "Ale kiedy lecimy do pierścienia, nikt nam nie może pomóc.");
                            AnyKey();
                            Print("– Czemu? – pytasz, gdy stajecie przed autokuchtą. Po chwili żujesz gumę pokarmową.");
                            AnyKey();
                            Print("– Czy myślisz, że to łatwe ? – dopiero teraz odpowiada Leonardo. – Latanie w pierścieniu?");

                            AnyKey();
                            Print("Pośród  setek  skalnych  brył,  w  ciągle  zmieniających  się  warunkach  grawitacyjnych. " +
                                "Z łącznością  zakłócaną  przez  erupcje  planety. O nie, tam  jesteś  naprawdę  samotny. " +
                                "Tylko ciężkie  ćwiczenia  i  wrodzony  kunszt.Wiara  w  sztukę  i  w  fizykę.I  setki  godzin  na symulatorze. " +
                                "Tam nawet mózg wojskowy nie dałby rady.");
                            AnyKey();
                            Print("–  Gdzie  my  właściwie  idziemy?  –  Nagle  uświadamiasz  sobie,  że  Leonardo  ci  tego  nie powiedział.");
                            AnyKey();
                            Print("– Do naszego księcia.");

                            ParNumber = 12;
                            AnyKey();
                            break;
                        }
                    case 103:
                        {
                            Print("– Czy mam jakieś inne wyjście? – mówisz zrezygnowany.");
                            AnyKey();

                            Print("– Masz – odpowiada książę – ale to nie jest dobre wyjście.");
                            AnyKey();

                            Print("– W porządku – machasz ręką – zgadzam się.");
                            AnyKey();
                            Print("Wirtualna głowa księcia nabiera jasnozielonego blasku.");
                            AnyKey();
                            ParNumber = 100;

                            break;
                        }
                    case 104:
                        {
                            Print("Wiele  zależy  od  twojej  spostrzegawczości.  Jak  długo  chcesz  prowadzić  poszukiwania?");
                            Console.Write("Podaj liczbę kwadransów: ");
                            int Time = Convert.ToInt32(Console.ReadLine());
                            Oxygen -= Time;

                            ParNumber = Player.StatTest("mind", 0, Time, 154, 26);
                            /*
                    

                       Odejmij  z  zapasu  tlenu  wybraną  liczbę  kwadransów.  Test  Umysł  (przed  testem  cechę  

                   Umysł powiększ o wskazaną liczbę kwadransów):  

                       Udany – paragraf 154.  
                       Nieudany – paragraf 26.  
                       */
                            break;
                        }
                    case 105:
                        {
                            Print("Nie potrafisz nad sobą zapanować. Zaciskasz palce i walisz Fidiego w gębę. ");
                            Print("Nie zdążył zareagować. Twoja pięść ląduje dokładnie na jego wytatuowanym nosie. ");

                            ParNumber = Player.StatTest("body", 0, 0, 46, 27);
                            /*
                        Mechanika  

                        Test Ciało:  
                        Udany – paragraf 46.  

                        Nieudany – paragraf 27.  
                        */
                            break;
                        }
                    case 106:
                        {
                            Print("Stojąc na środku płaskiej płyty lądowiska, podnosisz wzrok. Na twoich oczach " +
                            "rozgrywa się   jedno   z   najcudowniejszych   przedstawień   kosmosu.   " +
                            "Wschód   gazowego   olbrzyma, obserwowany  z  jego  księżyca.  " +
                            "Niemal  w  jednej chwili  na całej  linii  horyzontu  pojawia  się  zielony blask. " +
                            "Gwiazdy bledną, a czarne niebo ustępuje miejsca gigantycznej tarczy pokrytej " +
                            "barwnymi  plamami  i  deseniami,  naznaczonej  cieniami  innych  księżyców  i  pętlą  pierścieni. " +
                            "Czy decydujesz się poświęcić chwilę czasu, by popatrzeć na to zjawisko?");

                            Crossroads(new string[] { "Tak", "Nie" }, new int[] { 139, 169 });
                            if (ParNumber == 139)
                            {
                                Oxygen -= 1;
                            }
                            /*Tak – odejmij 1 kwadrans i ParNumber = 139.  

                           Nie – paragraf 169.  
                           */
                            break;
                        }
                    case 107:
                        {
                            Print("Uff,  udało  się.  Klniesz  własną  głupotę.  Zawracasz  ku  bazie,  ostatnim  spojrzeniem obrzucając okolicę.");

                            ParNumber = Player.StatTest("mind", 0, 0, 161, 169);
                            /*
                                Mechanika  
                                Test Umysł:  

                                Udany – paragraf 161.  

                                Nieudany – paragraf 169.  
                                */
                            break;
                        }
                    case 108:
                        {

                            Print("Nagle  wszystko  się  uspokaja.  Wraca  normalny  obraz.  Znów  czujesz,  że  ty  i  kosmolot " +
                                "stanowicie jedność.Udało się! Udało! Przejąłeś kontrolę nad statkiem.Teraz dopiero czujesz, ile kosztowała cię ta walka, ale jesteś wolny.Wolny!Możesz robić, co chcesz.\n");

                            Crossroads(new string[] {"Decydujesz się od razu zacząć nadawać sygnał sos", "Kierujesz swój pojazd ku planetom wewnętrznym, " +
                                "by najpierw maksymalnie oddalić się od bazy Rzeźbiarzy" }, new int[] {3, 14 });
                            

                            break;
                        }
                    case 109:
                        {
                            Print("Pod stertą połamanego plastiku znalazłeś pistolet laserowy. Nie masz wątpliwości, że nie jest to górniczy automat  – to broń. " +
                                "W ładownicy tkwi bateria, ale jest całkowicie wyczerpana.");
                            AnyKey();



                            Print("A to  oznacza, że ktoś z tego pistoletu strzelał. I rzeczywiście, po dłuższej chwili odkrywasz " +
                                "bruzdę  spalonego  plastiku  ciągnącą  się  wzdłuż  jednej  ze  ścian.  Kopuła  bazy  nie  została naruszona, " +
                                "ale plastikowa wykładzina stopiła się w morderczym żarze. A więc nie przydarzył się tu po prostu nieszczęśliwy wypadek. " +
                                "Ale kto mógł strzelać w bazie? Czy to broniący się Rzeźbiarze? " +
                                "Czy też ich przeciwnik?");

                            Crossroads(new string[] { "Szukasz dalej\nIdziesz do innych pomieszczeń", "Duża sala", "Korytarz", "Moduł higieny", "Sypialnie", "Śluza bazy" },
                                new int[] { 147, 167, 143, 56, 110, 145 });
                        

                            /*
                                Szukasz dalej – paragraf 147.  
                                Idziesz do innych pomieszczeń (oznaczenia na schemacie).  
                */
                            break;
                        }
                    case 110:
                        {
                            Print("To kiedyś była kabina mieszkalna. Pod ścianą stoją dwa piętrowe łóżka, w otworze drzwi tkwi zaklinowana szafka. " +
                                "Gródź awaryjna nie opadła w chwili dekompresji śluzy głównej. To oznacza jedno – " +
                                "ktoś musiał najpierw przejąć kontrolę nad siecią bazy, a potem jednocześnie otworzyć wszystkie śluzy. " +
                                "Niezdarnie przechodzisz nad szafką.");
                            ParNumber = 162;
                            AnyKey();
                            break;
                        }
                    case 111:
                        {
                            Print("Drugi cios spada na twoją szczękę, rzuca cię na ścianę. ");
                            Console.ReadKey();

                            Print("Trzeci zgina wpół. ");
                            Console.ReadKey();
                            Print("Nie masz szans –  znów  ściągają  cię  na  ziemię  i  wciskają  w  gniazdo  neurowszczepu  końcówkę  tej  swojej cholernej maszyny. " +
                                "I znów ból, błysk i ciemność.");
                            ParNumber = Player.StatTest("ego", 0, 0, 132, 59);
                            Player.setEgo(Player.Ego - 1);
                            /*
                            Mechanika  
                            Test Ego:  

                            Udany – paragraf 132.  

                            Nieudany – paragraf 59.  
                            Niezależnie od wyniku testu odejmij 1 pkt Ego.  
                            */
                            break;
                        }
                    case 112:
                        {
                            Print("Ocknąłeś się tylko na chwilę.");
                            AnyKey();
                            Print("Leżysz  na  twardym,  dużym  łóżku,  na  głowie  masz  hełm,  czujesz  łącze  wetknięte  w gniazdo twojej czaszki. " +
                                "Słyszysz szybkie kroki, a potem kobiecy, przyjemny głos:");
                            AnyKey();
                            Print("„Jest twardy, ocknął się. Może będzie z niego jeszcze jakiś inny pożytek niż plantacja?”");
                            AnyKey();
                            Print("„Sprawdźcie go jeszcze raz” –  nie jesteś pewien, czy ten drugi głos należy do Leonarda.");
                            AnyKey();
                            Print("Znów czujesz ból i ponownie zapadasz w ciemność.");

                            ParNumber = Player.StatTest("ego", 0, 0, 132, 59);
                            /*
                                Mechanika  

                                Test Ego:  
                                Udany – paragraf 132.  

                                Nieudany – paragraf 59.  
                */
                            AnyKey();
                            break;
                        }
                    case 113:
                        {
                            Print("I dobrze robisz. Już po chwili odbierasz meldunek.");
                            AnyKey();
                            Print("„Tu  automatyczna  koparka.  Zgłaszam  przepełnienie  zbiorników.  Czy  mam  wstrzymać pracę?”");
                            AnyKey();



                            Print("I  już  po  nerwach.  To  robot  górniczy.  Prawdopodobnie  kilka  takich  maszyn  pełza  po powierzchni Transkolosa. " +
                                "Kruszą  skały, wydzielają  z  nich  tlen  i  wodę  na  potrzeby  bazy, a jednocześnie  wydobywają  rzadkie  metale.Normalna  procedura  kolonizacyjna. " +
                                "Najpierw zgromadzić  surowce, potem  sprowadzić  automatyczną  fabrykę  i  można  stawiać  domy!");
                            AnyKey();
                            Print("Prawdopodobnie Rzeźbiarze chcieli solidnie rozbudować osadę na Transkolosie.");
                            AnyKey();
                            Print("– Tak – odpowiadasz. – Kiedy wydano ostatnie polecenia? ");
                            AnyKey();
                            Print("„Pięć dni temu” – odpowiada robot.");
                            AnyKey();
                            Print("Na  próbę  wyciągnięcia  od  robota  jakichkolwiek  ciekawych  danych  tracisz  pół  godziny.");
                            AnyKey();
                            Print("Jednak automat nie informuje cię o niczym, co bezpośrednio dotyczy twojej pracy. Do bazy docierasz po następnym kwadransie.");
                            AnyKey();
                            Oxygen -= 3;
                            ParNumber = 67;
                            break;
                        }
                    case 114:
                        {
                            Print("Niestety, nie dajesz rady. Klapa jest ciężka, dokładnie spasowana z otworem. Przyglądasz jej się jeszcze raz, obmacujesz krawędź. " +
                                "Bez wątpienia – zamki są otwarte.");
                            Crossroads(new string[] { "Próbujesz jeszcze raz podnieść klapę\nBadasz inne pomieszczenia bazy:", "Moduł higieny",
                            "Sypialnie", "Korytarz\n", "Powrót do kosmolotu"}, new int[] {115, 56, 110, 143, 64 });
                            /*     
                            Próbujesz jeszcze raz podnieść klapę – paragraf 115.  

                                 Badasz inne pomieszczenia bazy:  

                                 Moduł higieny – paragraf 56.  
                                 Sypialnie – paragraf 110.  

                                 Korytarz – paragraf 143.  

                                 Powrót do kosmolotu – paragraf 64 (odejmij kwadrans).  
                              */
                            break;
                        }
                    case 115:
                        {
                            Print("To duży wysiłek. Czujesz, że klapa drga lekko, już, już ją unosisz... ");
                            ParNumber = Player.StatTest("body", 0, 0, 117, 177);
                            /*
                            Mechanika  

                            Test Ciało:  
                           Udany – ParNumber = 117.  

                           Nieudany – zredukuj cechę Ciało o 1 punkt i ParNumber = 177.  
                           */
                            break;
                        }
                    case 116:
                        {
                            Print("Start  przebiegł  sprawnie,  szybko  opanowałeś  sterowanie  tym  pojazdem.  Rzeźbiarze dysponowali  doskonałym  sprzętem  sprzęgającym  umysł  z  systemem  kosmolotu  " +
                                "–  musieli mieć takie urządzenia, aby móc wykonywać swoje niesamowite konstrukcje. Przy okazji wzmocniły się twoje wszczepki.");

                            Player.setEgo(Player.Ego + 1);

                            /*
                            Mechanika  

                            Powiększ cechę Ego postaci o 1 i .  
                       */
                            AnyKey();
                            ParNumber = 85;
                            break;
                        }
                    case 117:
                        {
                            Print("Przed tobą ciemny, wąski tunel. Przy wylocie widzisz trzy rzędy szczelin grodzi, dalej jest " +
                                "już gładka ściana. Żeby tam wejść, musisz przyklęknąć.");
                            AnyKey();


                            Print("„Jak  kret”  –  myślisz  i  ruszasz  w  głąb  korytarza.  Początkowo  pełzniesz  w  dół,  " +
                                "lecz  po kilkunastu  metrach  tunel  zaczyna  biec  poziomo.  I  wtedy  właśnie  w  świetle  reflektora dostrzegasz przed sobą  ciemny kształt. " +
                                "Zatrzymujesz się, wyciągasz z olstra pistolet. To coś nie  porusza  się  jednak.  " +
                                "I  nic  dziwnego  –  masz  przed  sobą  martwego,  choć  ubranego  w skafander człowieka.");
                            AnyKey();
                            ParNumber = 63;
                            break;
                        }
                    case 118:
                        {
                            Print("Przykra wiadomość – nie żyjesz.");
                            AnyKey();

                            ParNumber = 38;
                            break;
                        }
                    case 119:
                        {
                            Print("Udało się. Twój pojazd miękko usiadł prosto na prostokątnej płycie lotniska. Przed sobą masz budynek bazy i hangar magazynu.");
                            AnyKey();
                            Print("Aktywizują  się  procedury  lądowania.  Pompy  wchłaniają  płyn  odżywczy,  " +
                             "odłączają  się sprzęgi  z  komputerem  statku.Z  podajnika  wysuwa  się  skafander. " +
                             "W  butlach  będziesz  miał zapas tlenu na 9 godzin.");
                            AnyKey();
                            Print("wylądowałeś w pobliżu bazy.");
                            CloseToBase = true;
                            ParNumber = 2;
                            AnyKey();
                            break;
                        }
                    case 120:
                        {
                            Print("Wiesz,  że musisz uważać. Znajdujesz się na nieprzyjaznym dla  życia  globie. Tu można łatwo  zginąć. " +
                                "Jeśli  rozedrzesz  skafander  –  zginiesz.  Jeśli  pęknie  ci  hełm  –  zginiesz. Jeśli zabraknie ci tlenu – zginiesz. " +
                                "Twój zapas tlenu pozwala ci na dziewięciogodzinną wędrówkę po powierzchni Transkolosa. " +
                                "Musisz kontrolować upływający czas.");
                            AnyKey();
                            //Mechanika  

                            Print("Od tej pory każda akcja, którą podejmiesz, będzie trwała określoną ilość czasu. " +
                                "Czasami jego upływ będzie niezależny od ciebie, czasami ty będziesz decydował, ile czasu poświęcisz na wykonanie jakiejś akcji.");
                            AnyKey();
                            Print("Masz pełne butle z tlenem: zapas na 9 godzin, czyli 36 kwadransów. Jeśli  zużyjesz  ostatnią  porcję,  a  nie  znajdziesz  się  w  rakiecie  powrotnej  – umierasz i kończysz grę. ");
                            AnyKey();

                            Print("Jeśli  zużyjesz  ostatnią  porcję,  a  nie  znajdziesz  się  w  rakiecie  powrotnej - umierasz i kończysz grę.");

                            Print("W każdej chwili możesz nacisnąć klawisz „O”, żeby odczytać stan tlenu w butli.");

                            AnyKey();
                            /*Zaznacz to na kartce  

                            i   za   każdym   razem,       gdy   pojawia   się   takie   polecenie,   odliczaj   odpowiednią   liczbę  
                            kwadransów.  
                             */
                            ParNumber = 44;
                            break;
                        }
                    case 121:
                        {
                            Print("Szczękają  rygle  włazu  wlotowego.  Szybko  odchodzisz  na  bok,  bo  oto  przez  dziurę  w sklepieniu  " +
                                "do  jaskini  wlewa  się  nowa  porcja  ścieków,  które  tu  zostaną  przerobione  na przydatne  człowiekowi  produkty. " +
                                "Pompy  wessą  kolejne  tony  biomasy,  by  tam  dalej,  za ścianą,  w  podziemnej  fabryce, wyprodukować  żywność  dla  mieszkańców  Kolosa. " +
                                "Cieszysz się na myśl, że im służysz. Od tego wszak jesteś – by opiekować się biomasą.");
                            AnyKey();

                            Print("Biomasa jest najważniejsza.");
                            AnyKey();


                            ParNumber = 52;

                            break;
                        }
                    case 122:
                        {
                            Print("Twarde uderzenie niemal miażdży ci nos. Ogłuszony cofasz się o krok. Drugi cios zgina cię wpół i powala na podłogę. " +
                                "Dociskają cię do ziemi  –  Leonardo trzyma ręce, ten większy nogi,  a  mały  przekręca  ci  głowę, szukając gniazda  wszczepu neuronowego. " +
                                "Jego  palce natrafiają na metaliczne zgrubienie. " +
                                "Jedną ręką rozgarnia ci włosy, drugą sięga  po końcówkę urządzenia, " +
                                "które przynieśli. Szarpiesz się, próbujesz ich z siebie zrzucić, ale jesteś za słaby.");
                            AnyKey();
                            Print("Nagły  impuls  przebiega  twoje  ciało  –  mięśnie  tężeją,  igła  bólu  przeszywa  mózg.  To wszczep. " +
                                "W  twojej  głowie  tkwi  bolec  neurosterownika.  Co  oni  chcą  ze  mną  zrobić? – to ostatnia myśl, " +
                                "która przebiega ci przez głowę.");
                            AnyKey();
                            Print("Potem jest ciemność.");
                            ParNumber = Player.StatTest("ego", 0, 0, 42, 59);
                            AnyKey();
                            /*
                                Mechanika  

                                Test Ego:  

                                Udany – paragraf 42.  
                                Nieudany – paragraf 59.  
                                */
                            break;
                        }
                    case 123:
                        {
                            Print("Twój umysł przebija się przez zewnętrzne warstwy oprogramowania. Czujesz jednak, że " +
                                "twój  napór  słabnie.  Przedzierasz  się  przez  gąbczaste  zasłony,  " +
                                "które  jednak  stają  się  coraz mniej  sprężyste:  " +
                                "wydają  się  zaciskać  na  tobie,  więzić  twój  mózg. Orientujesz  się, że nie dotrzesz  do sieci bazy. Natomiast zyskujesz pewność, " +
                                "że w sieci jest ukryte hasło umożliwiające otwarcie śluzy i zbadanie wnętrza hangaru.");

                            Print("Próbujesz zawrócić, ale nie jest to łatwe.");
                            ParNumber = Player.StatTest("ego", 0, 0, 144, 54);
                            /*
                        Mechanika  
                        Test Ego:  

                        Udany – paragraf 144.  

                        Nieudany – zredukuj cechę Ego o 1 punkt i ParNumber = 54.  
                        */
                            break;
                        }
                    case 124:
                        {
                            Print("Nagły komunikat wyrwał cię z półdrzemki, z błogiego  rozleniwienia umysłu, który może swobodnie  skakać  z  tematu  na  temat  i  rozważać  abstrakcyjne  problemy. " +
                                "Coraz  częściej zapadałeś  w  takie  stany. " +
                                "Wiedziałeś, że  to  pierwszy  znak, że  twój  umysł  traci kontrolę, że szuka ratunku przed samotnością. " +
                                "I że zakończy się to schizofrenią.");
                            AnyKey();
                            Print("Jednak  nadszedł  sygnał.  Obcy  obiekt  znajdował  się  sześć  minut  świetlnych  od  ciebie  i wyraźnie kierował się w twoją stronę.");

                            ParNumber = Player.StatTest("", 1, 0, 86, 55);

                            /*    
                            Mechanika  

                                Losowo  wygeneruj  liczbę  0-9  (otwierając  książkę  na  dowolnej  stronie  i  biorąc  ostatnią  

                            cyfrę numeru strony) Cyfra 0-1 – paragraf 86.  
                                Cyfra 2-9 – paragraf 55.  
                                */

                            AnyKey();
                            break;
                        }
                    case 125:
                        {



                            Print("Tak  naprawdę  żołnierz  jest  od  ciebie  znacznie  silniejszy.  Ale  doskonale  wykorzystałeś element zaskoczenia. Wyszarpujesz paralizer z jego rąk. Stoi nieruchomo, czekając na to, co zrobisz.");

                            Crossroads(new string[] {"Chcesz go zabić", "Nie chcesz" }, new int[] {89, 51 });
                            /*    
                            Chcesz go zabić – paragraf 89.  

                                Nie chcesz – paragraf 51.  
                                */
                            break;
                        }
                    case 126:
                        {
                            Print("Schemat  bazy  pokazany  jest  na  rysunku.  W  każdej  chwili  możesz  iść  do  dowolnego " +
                            "otwartego pomieszczenia, udać się do kolektorów lub wrócić do lądownika. ");

                            Crossroads(new string[] {"Śluza hangaru", "Śluza bazy", "Do kolektorów słonecznych", "Powrót do lądownika" },
                                new int[] {30, 145, 128, 64 });
                            /*
                       do zaznaczonego na bazie paragrafu.  
                            Śluza hangaru – ParNumber = 30.  

                            Śluza bazy – paragraf 145.  

                           Do kolektorów słonecznych – paragraf 128.  

                           Powrót do lądownika – paragraf 64 (przy wyborze tej opcji zawsze odejmij kwadrans).  
                            */
                            break;
                        }
                    case 127:
                        {
                            Print("Nagły wstrząs targa twoim ciałem. W jednej chwili aktywizuje się  hełm.");
                            AnyKey();
                            Print("„Atak! Atak!”");

                            AnyKey();
                            Print("sygnalizuje   komputer.   Widzisz   eksplodujące   wokół   okruchy   pierścienia,   a   przeraźliwe przeciążenie ściska twoje ciało.");

                            ParNumber = Player.StatTest("body", 0, 0, 88, 29);
                            AnyKey();
                            /*
                                Mechanika  

                                Test Ciało:  
                                Udany – paragraf 88.  

                                Nieudany – paragraf 29.  
                                */
                            break;
                        }
                    case 128:
                        {
                            Print("Kolektory znajdują się w pewnej odległości od bazy, na wzgórzu. Szacujesz, że droga do nich  zajmie  ci  " +
                                "jakieś  piętnaście  minut  w  jedną  stronę.  " +
                                "Na  dodatek  oddalasz  się  od  swojej rakiety. " +
                                "Czy chcesz poświęcić tyle czasu? Może nie warto?");
                            Crossroads(new string[] {"Śluza hangaru", "Baza", "Powrót do lądownika", "Kolektory słoneczne" }, new int[] {30, 145, 64, 178 });

                            if (ParNumber == 178)
                            {
                                Oxygen -= 1;
                            }
                            
                            /*
                                 Śluza hangaru – paragraf 30.  
                                Baza – paragraf 145.  

                                Powrót do lądownika – paragraf 64 (przy wyborze tej opcji zawsze odejmij kwadrans).  

                                Jeśli zdecydowałeś się na spacer do kolektorów słonecznych –  odejmij kwadrans i idź do  
                            paragrafu 178.  
                            */
                            break;
                        }
                    case 129:
                        {
                            Print("Decyzja jest nagła i ostateczna. Przełączasz swój umysł, w jednej chwili znika symulacja " +
                                "normalnych  wrażeń  zmysłowych.  Wchodzisz  w  cyberprzestrzeń  sieci  pokładowej.  ");
                            AnyKey();
                            Print("Przed twoimi " +
                                "oczami  przelewa  się  szara  mgła.  Z  niej  wynurzają  się  obłe  kształty  nieistniejących brył  i  form. ");
                            AnyKey();
                            Print("Niczym  elementy  monstrualnej  układanki  przesuwają  się  wokół  ciebie  barwne klocki. " +
                                "Ich  forma  jest  obca  zwykłemu  umysłowi  –  w  przestrzeni  trójwymiarowej  nie występują. " +
                                "Ale oto miarowy rytm przyśpiesza. ");
                            AnyKey();
                            Print("Ty też. Atakujesz system obronny sieci, twój umysł ściera się z  programami  zaporowymi. " +
                                "Niektóre  z  brył  rozpadają  się,  obryzgując  cię krwią niczym żywe istoty. " +
                                "Inne zaczynają się przeobrażać, zmieniają w monstra szczerzące ku  tobie  ohydne  paszcze  i  wyciągające  setki  łap.  ");
                            AnyKey();
                            Print("Wiesz  o  tym,  że  tak  naprawdę  to  twój procesor  osobowości  generuje  ciągi  liczb  będące  kodami  rozkazów  i  procedur.  " +
                                "Ale  twój człowieczy  umysł  nie  jest  przystosowany  do  takich  operacji  –  " +
                                "i  dlatego  zmysły  tłumaczą wszystko na język obrazów. " +
                                "I dźwięków. Wydaje ci się, że z oddali dobiega głos Leonarda: „Nieróbtegonieróbtegonieróbtegonierób...”, " +
                                "że  gra  hałaśliwa  atonalna  muzyka,  że  słyszysz  rozpaczliwy skowyt katowanej kobiety. ");
                            AnyKey();
                            Print("A potem obraz rozpryskuje się na tysiące kawałków – pozostaje tylko czerń, a w jej środku pulsuje ciemnozielona bryła. " +
                                "To obraz blokady cyberprzestrzennej.");
                            

                            ParNumber = Player.StatTest("ego", 0, 0, 108, 131);
                            if (ParNumber == 108)
                            {
                                Player.setEgo(Player.Ego - 1);
                            }

                            /*
                       Mechanika  
                       Test Ego:  

                       Udany – zredukuj cechę Ego postaci o 1 punkt i ParNumber = 108.  

                       Nieudany – paragraf 131.  
                       */
                            break;
                        }
                    case 130:
                        {
                            Print("Lecisz już drugą godzinę. Układy sprzęgające działają bez zarzutu – każdym nerwem ciała czujesz, " +
                                "że  w  środku  wszystko  jest  w  porządku,  że  wszystkie  moduły  pojazdu  pracują " +
                                "prawidłowo, że rejestratory nie wychwytują sygnałów kosmolotów pościgowych.");
                            Print("I to właśnie cię niepokoi. Coraz bardziej nabierasz przekonania, że poszło ci zbyt łatwo.");

                            Print("Przecież  gdyby  chcieli,  mogliby  zatrzymać  cię  jeszcze  w  bazie,  ewentualnie  zablokować mózg sterujący kosmolotu.");
                            Print("Na razie chcesz odlecieć jak najdalej od bazy na Transkolosie.");

                            ParNumber = 80;
                            AnyKey();
                            break;
                        }
                    case 131:
                        {
                            Print("Błysk. Jęk. Nic nie widzisz.");

                            Print("„System  kontroli  naruszony  –  monotonny  głos  powtarza  trzy  słowa  –  system  kontrolny naruszony. " +
                                "System kontrolny naruszony...”");

                            Print("Nie  wiesz,  co  się  dzieje.  Próbujesz  odzyskać  kontrolę  przede  wszystkim  nad  swoim procesorem, potem nad statkiem.");

                            Print("„Włączono  procedury  likwidujące  –  informuje  cię  maszyna.  –  Uruchomiono  procedurę samozniszczenia”.");
                            Print("To wszystko trwa tylko ułamki sekundy. Tobie wydaje się wiecznością.");

                            ParNumber = 11;
                            AnyKey();
                            break;
                        }
                    case 132:
                        {
                            Print("– No już! Nie udawaj, frajerze! –  Ktoś mocno uderza cię w policzek, aż głowa odskakuje ci na bok.");

                            Print("Powoli otwierasz oczy. Wszystko jest rozmazane, płynne, niepewne. Ale obraz stopniowo nabiera kształtów i kolorów, a pochylone nad tobą twarze – ostrości");

                            Print("– Twardziel, co? – mówi Leonardo. – Przetrzymał stymulacje. Ty, odmrożeniec – zwraca " +
                                "się do ciebie, nie widząc, że otworzyłeś oczy.  –  Porozumiałem się z księciem. " +
                                "Nasz władca ceni sobie ludzi mocnych i kontrolujących swój umysł. " +
                                "Dał ci ostatnią szansę – podejmujesz się misji?");

                            Print("„Plantacje  –  uświadamiasz  sobie.  –  Uwarunkują  mnie  i  skierują  do  pracy  na  plantacji biomasy. Nie mam szans”.");

                            Print("– Zgadzam się – mówisz cicho. – Będę wam służył.");

                            Print("–  Nawet  nie  wiesz,  jak  się  cieszę.  –  Twarz  Leonarda  wykrzywia  się  w  czymś  na podobieństwo uśmiechu.");

                            ParNumber = 100;
                            AnyKey();
                            break;
                        }
                    case 133:
                        {
                            Print("Im   dłużej   przeszukujesz   pokój,   tym   większe   masz   szanse   na   znalezienie   czegoś ciekawego.");

                            Console.Write("Ustal, ile kwadransów na to poświęcasz:");

                            int Time = Convert.ToInt32(Console.ReadLine());

                            Player.StatTest("mind", 0, Time, 4, 135);
                            /*
                            Mechanika  
                            Test Umysł (podnieś cechę Umysł o wybraną liczbę kwadransów):  

                            Udany – paragraf 4.  

                            Nieudany – paragraf 135.  

                             */
                            break;
                        }
                    case 134:
                        {

                            Print("Reflektor wydobywa z ciemności coraz to nowe przedmioty.");
                            Console.Write("Określ, ile czasu poświęcisz na przeszukanie korytarza: ");

                            int Time = Convert.ToInt32(Console.ReadLine());

                            Oxygen -= Time;

                            /*Mechanika  

                            Odejmij wybraną liczbę kwadransów.  
                            */
                            ParNumber = 104; 
                            
                            break;
                        }
                    case 135:
                        {

                            Print("Nie znalazłeś nic ciekawego. Może jednak coś przegapiłeś?");

                            Print("Idziesz do innego pomieszczenia bazy lub z niej wychodzisz:");

                            Crossroads(new string[] {"Moduł higieny", "Korytarz", "Duża sala", "Śluza hangaru",
                                "Kolektory", "Powrót do kosmolotu"  }, new int[] { 56, 143, 167, 30, 128, 64 });

                            /*
                            Moduł higieny – paragraf 56.  
                            Korytarz – paragraf 143.  

                            Duża sala – paragraf 167.  

                            Śluza hangaru – paragraf 30.  
                            Kolektory – paragraf 128.  

                            Powrót do kosmolotu – paragraf 64 (odejmij kwadrans).  
                            */
                            break;
                        }
                    case 136:
                        {
                            Print("Drzwi      rozsuwają      się   z   cichym      sykiem.     Wskakujesz        do    hangaru.     Stoi    tam wewnątrzukładowy prom – " +
                                "widzisz obły kadłub, nietoperzowe kształty skrzydeł.");
                            AnyKey();
                            Print("Prom  przystosowany  jest  do  lądowania  na  księżycach  o  bardzo  rzadkiej  atmosferze.  Na dziobie widać gniazdo pilota – " +
                                "czarną jamę z wystającymi na zewnątrz zwojami łączy.");
                            AnyKey();
                            Print("„Niczym  trumna”  –  myślisz,  ale  nie  wahasz  się  ani  chwili.  Wskakujesz  do  gniazda.");
                            AnyKey();
                            Print("Wygodnie sadowisz się w fotelu. Nakładasz na głowę hełm zakrywający całą twarz. W tym momencie  statek  ożywa.  " +
                       "Łomocze  pokrywa  włazu  zamykającego  gniazdo,  huczą  silniki.");

                            AnyKey();
                            Print("Przed twoimi oczami przewija się ciąg liczb, barw i kodów. To poszczególne zespoły statku zgłaszają sprawność. ");

                            ParNumber = Player.StatTest("mind", 0, 0, 7, 48);
                            /*
                                Mechanika  
                                Test Umysł:  

                                Udany – paragraf 7.  

                                Nieudany – paragraf 48.  
                              */
                            break;
                        }
                    case 137:
                        {

                            Print("Wkładasz kartę do czytnika. Nie wydaje się, aby zapory były szczególnie mocne, ale ta operacja zajmie ci trochę czasu.");
                            Player.StatTest("ego", 0, 0, 159, 160);
                            /*Mechanika  

                            Test Ego:  

                            Udany – paragraf 159.  

                            Nieudany – paragraf 160.  
                             */
                            AnyKey();
                            break;
                        }
                    case 138:
                        {

                            Print("Transkolos to mały księżyc. Jego jądro jest jednak zadziwiająco ciężkie, co sprawia, że utrzymuje się tu ciążenie bliskie jednej trzeciej g. Na dodatek posiada wcale gęstą, jak na tak " +
                                "mały  obiekt,  atmosferę.  Oba  te  czynniki  znacznie  ułatwiały  budowę  i  eksploatacj ę  bazy.");
                            AnyKey();
                            Print("Kiedyś mieściła się tu placówka naukowa, potem Rzeźbiarze przejęli ją i zamienili na swoją stację wypadową do działań w pierścieniu.");
                            Print("Lądowisko znajduje się tuż obok bazy. Okazuje się jednak, że nie panujesz nad statkiem tak, " +
                                "jak byś chciał. Masz pewne kłopoty z podchodzeniem do lądowania.");

                            ParNumber = Player.StatTest("ego", 0, 0, 119, 21);
                            AnyKey();
                            
                            /*
                   Mechanika  
                   Test Ego:  

                   Udany – paragraf 119.  

                   Nieudany – paragraf 21.  
                   */
                            break;
                        }
                    case 139:
                        {
                            Print("Robisz kilka kroków do przodu, niemal w lunatycznym transie. Powoli wchodzisz na mały pagórek, " +
                                "który  nieco  zasłania  ci  widok.Stajesz  na  szczyci e  wzgórza, podnosisz  wzrok.");
                            AnyKey();
                            Print("Zielony blask Ordmoru odbija się na szybie twojego hełmu. Stałeś się nieuważny! To może drogo kosztować. " +
                                "Źle postawiłeś stopę, twoja noga obsuwa się po skalnym stoku. Próbujesz złapać równowagę – czy ci się uda?");
                            ParNumber = Player.StatTest("body", 0, 0, 107, 173);
                            /*
                                Mechanika  
                                Test Ciało:  

                                Udany – paragraf 107.  

                                Nieudany – paragraf 173.  
                              */
                            break;
                        }
                    case 140:
                        {

                            Print("Ogarnia cię fala irytacji. Dlaczego to masz klękać przed tym monstrum?!");
                            AnyKey();
                            Print("–  Czego ode mnie chcecie?  –  pytasz głośno.  –  Żądam skontaktowania mnie z władzami solarnymi.");
                            AnyKey();

                            Print(" –  Uratowaliśmy ci życie –  odpowiada spokojnie książę. Gdy mówi, jego wirtualny hełm staje się ciemnogranatowy.");
                            AnyKey();
                            Print("– Na pewno nie za darmo – dodajesz szybko.");
                            AnyKey();
                            Print("–  A  teraz  udzielimy  ci  lekcji  pokory  –  mówi  książę  i  nagle  jedna  z  jego  macek wystrzeliwuje w twoją stronę. " +
                                "Czujesz dziwny zapach, słyszysz stłumione głosy Leonarda i księcia:");
                            AnyKey();
                            Print("– Wybacz mu, panie, jego osobowość wciąż jest nieustabilizowana.");
                            AnyKey();
                            Print("– Wybaczam. I leczę. Teraz to mój poddany.");
                            AnyKey();
                            Print("Po chwili znów normalnie postrzegasz świat. Jesteś gotów do rozmowy.");

                            Player.setMind(Player.Mind - 1);

                            /*Mechanika  

                            Zredukuj cechę Umysł o 1 punkt.  
                            */
                            ParNumber = 53;
                            AnyKey();
                            break;
                        }
                    case 141:
                        {
                            Print("Wchodzisz  do  hangaru.  W  dużej  hali  jest  ciemno  i  pusto.  Pod  ścianami  stoją  jakieś urządzenia  –  " +
                                "moduły wahadłowców, zestawy automechaników i kilka urządzeń, których nie rozpoznajesz.");
                            ParNumber = 37;
                            AnyKey();
                            break;
                        }
                    case 142:
                        {

                            Print("Jak tam twój zapas tlenu? Masz go tyle, żeby spokojnie wrócić do kosmolotu? Pamiętaj o tym, podejmując kolejne decyzje.");

                            Crossroads(new string[] {"Szukasz dalej\nIdziesz do innego pomieszczenia bazy lub z niej wychodzisz:", "Moduł higieny", "Korytarz", "Duża sala", "Śluza hangaru",
                                "Kolektory", "Sypialnie", "Powrót do kosmolotu"  }, new int[] {147, 56, 143, 167, 30, 128, 110, 64 });

                            /*Szukasz dalej – paragraf 147.  

                            Idziesz do innego pomieszczenia bazy lub z niej wychodzisz:  
                            Moduł higieny – paragraf 56.  

                            Korytarz – paragraf 143.  

                            Duża sala – paragraf 167.  

                            Śluza hangaru – paragraf 30.  
                            Kolektory – paragraf 128.  

                            Sypialnie – paragraf 110.  

                            Powrót do kosmolotu – paragraf 64 (odejmij kwadrans).  
                             */

                            AnyKey();
                           
                            break;
                        }
                    case 143:
                        {

                            Print("Podłoga wygląda tak samo jak w śluzie.");
                            AnyKey();
                            Print("Idziesz do innego pomieszczenia bazy lub z niej wychodzisz: ");
                            Crossroads(new string[] {"Moduł higieny", "Korytarz", "Duża sala", "Śluza hangaru",
                                "Kolektory", "Sypialnie", "Powrót do kosmolotu"  }, new int[] { 56, 143, 167, 30, 128, 110, 64 });
                            /*
                            Moduł higieny – paragraf 56.  

                            Korytarz – paragraf 143.  

                            Duża sala – paragraf 167.  
                            Śluza hangaru – paragraf 30.  

                            Kolektory – paragraf 128.  

                            Sypialnie – paragraf 110.  

                            Powrót do kosmolotu – paragraf 64 (odejmij kwadrans).  
                            */



                            break;
                        }
                    case 144:
                        {
                            Print("Jednak  –  udało  ci  się  wycofać.  Drżącą  dłonią  wyjmujesz  łącze  z  gniazda.  Czujesz  pot zlepiający włosy.Cała operacja zajęła kwadrans.");

                            Oxygen -= 1;
                            Crossroads(new string[] {"Możesz ponownie spróbować złamać sieć\nBadasz inne obiekty bazy:", "Śluza bazy", 
                                "Kolektory", "Powrót do kosmolotu"  }, new int[] { 50, 145, 128, 64 });
                            /*
                           Możesz ponownie spróbować złamać sieć – ParNumber = 50.  
                           Badasz inne obiekty bazy:  

                           Śluza bazy – paragraf 145.  

                           Kolektory – paragraf 128.  
                           Powrót do kosmolotu – paragraf 64 (odejmij kwadrans).  
                           */
                            AnyKey();
                            break;
                        }
                    case 145:
                        {
                            Print("Do  bazy  prowadzi  potrójny  moduł  śluzy,  teraz  jednak  grodzie  są  otwarte. Uważnie przyglądasz się tablicy sterowania – jest zniszczona, jakby przecięta laserowym promieniem. " +
                                "Na podłodze poniewierają się szczątki sprzętów wymiecionych z bazy przez pęd uciekającego powietrza.");
                            Print("Klękasz i zaczynasz je przeglądać.");
                            Console.Write("Określ w kwadransach, ile czasu ci to zajmie: ");

                            int Time = Convert.ToInt32(Console.ReadLine());
                            Oxygen -= Time;
                            /*
                                Mechanika  
                                Odejmij wybraną liczbę kwadransów.  
                                */
                            ParNumber = 82;

                            break;
                        }
                    case 146:
                        {

                            Character Karin = new Character(3, 7, 4, "Karin  Ed  Dir", "urzędnik  solarny  niskiej  kategorii.  Kierowałeś  zaopatrzeniem  służb technicznych " +
                                   "Dominium  Solarnego  w  układzie  Reagana.  Prowadziłeś  życie  spokojne,  ale nudne, bez szansy na awans.\n" +
                                   "Jesteś  silny  i  dobrze  zbudowany.  " +
                                "Palce  bez  paznokci  oraz  wstawki  kolorowej  skóry  na czole i policzkach to jedyne ekstrawagancje twego stroju.");

                            Player = Karin;

                            Player.PrintName();
                            Console.Write(" - ");
                            Player.PrintDesc();


                            ParNumber = 175;
                            AnyKey();
                            break;
                        }
                    case 147:
                        {
                            Print("Określ czas przeznaczony na przeszukanie pomieszczenia. " +
                                "Im dłużej będziesz szukał, tym większą masz szansę na znalezienie czegoś ciekawego.");
                            Console.Write("podaj liczbę kwadransów: ");

                            int Time = Convert.ToInt32(Console.ReadLine());
                            Oxygen -= Time;

                            ParNumber = Player.StatTest("mind", 0, Time, 165, 142);


                            /*Mechanika  

                            Odejmij wybraną liczbę kwadransów.  

                            Test Umysł (cechę Umysł powiększ o wybraną liczbę kwadransów):  
                            Udany – paragraf 165.  

                            Nieudany – paragraf 142.  
                            */

                            //Player.StatTest("mind", 0, Time, 165, 142);
                            AnyKey();
                            break;
                        }
                    case 148:
                        {
                            Print("Niestety, nie znalazłeś niczego, co mogłoby cię zainteresować.");

                            Crossroads(new string[] { "Szukasz dalej\nIdziesz do innego miejsca bazy lub wracasz do kosmolotu:",
                                "Śluza bazy", "Kolektory", "Powrót do kosmolotu" }, new int[] {49, 145, 128, 64 });


                            /*Szukasz dalej – ParNumber = 49.  

                            Idziesz do innego miejsca bazy lub wracasz do kosmolotu:  

                            Śluza bazy – paragraf 145.  
                            Kolektory – paragraf 128.  

                            Powrót do kosmolotu – paragraf 64 (odejmij kwadrans).  
                            */
                            break;
                        }
                    case 149:
                        {
                            Print("Leonardo patrzy z wyrzutem.");
                            
                            Print("– Książę liczył na ciebie. ");
                            AnyKey();
                            Print("–  To mnie nie interesuje – powtarzasz po raz kolejny. –  Poleciałem tam, zrobiłem to, co mogłem. Wiecie o wszystkim, o czym ja wiem. To nie moja wina.");
                            AnyKey();
                            Print("–  Może nie twoja  –  w  głosie  Leonarda  nie ma ani cienia życzliwości. Denerwujesz się. Bardzo się denerwujesz.");
                            AnyKey();
                            Print("– Zrealizujcie swoją obietnicę. Powiadomcie administrację Dominium o mojej obecności.");
                            AnyKey();
                            Print("–  Niestety,  odmrożeńcu  –  mówi  Leonardo.  –  Zawiodłeś  księcia.  Zawiodłeś  Klan.  Nie możesz liczyć na naszą pomoc.");
                            AnyKey();
                            Print("Ogarnia cię fala wściekłości.");
                            AnyKey();
                            Print("–  Zabiję cię  –  krzyczysz i rzucasz się na Rzeźbiarza. Ten nie musi nawet dawać znaku.");
                            AnyKey();
                            Print("Zza jego pleców wysuwa się opancerzony niczym chrząszcz, zdalnie sterowany żołnierz. " +
                                "W twoją stronę mierzy lufa paralizera. Żołnierz naciska spust. Ból poraża twoje nerwy w ułamku sekundy. " +
                                "Bezwładnie walisz się na ziemię. Ogarnia cię ciemność.");
                            ParNumber = Player.StatTest("body", 0, 0, 96, 118);
                            /*
                                Mechanika  

                                Test Ciało:  
                                Udany – paragraf 96.  

                                Nieudany – paragraf 118.  
                                */
                            AnyKey();
                            break;
                        }
                    case 150:
                        {
                            Print("Kiedy   się   ocknąłeś,   zorientowałeś   się,   że   minęło   pół   godziny.   Na   szczęście   na Transkolosie   ważysz   tylko   jedną   trzecią   swej   normalnej   wagi. " +
                                "Skafander   wytrzymał.");

                            Print("Niemniej jesteś poobtłukiwany i czujesz, że droga powrotna do rakiety zajmie ci sporo czasu.");

                            ParNumber = Player.StatTest("body", 0, 0, 98, 99);

                            if (ParNumber == 98)
                            {
                                Oxygen -= 2;
                                ParNumber++;

                            }
                            if (ParNumber == 99)
                            {
                                Oxygen -= 4;
                            }

                            /*
                                Mechanika  
                                Test Ciało:  

                                Udany – Oxygen -= 2;  

                                Nieudany – odejmij 4 kwadranse.  
                                ParNumber = 99.  

                                Zabrakło tlenu – paragraf 176.  
                                */
                            break;
                        }
                    case 151:
                        {
                            Print("– Nie muszę – mówisz. – A gdzie my właściwie idziemy?");
                            AnyKey();
                            Print("– Książę czeka. Kazał cię przyprowadzić, gdy tylko się przebudzisz.");

                            ParNumber = 12;
                            AnyKey();
                            break;
                        }
                    case 152:
                        {


                            Print("...metaliczny blask niemal tuż pod twoimi stopami. Kucasz, rozgrzebujesz pokrywające " +
                                "w tym  miejscu  podłogę  resztki  zamrożonej  biomasy  glonów  –  prawdopodobnie  głównego składnika diety mieszkańców bazy. " +
                                "W świetle reflektora odkrywasz okrągły właz śluzy. " +
                                "Do tej  pory  musiałeś  być  ślepy  –  ciężka  klapa  znajduje  się  w  rogu  pomieszczenia,  niemal dokładnie na wprost korytarza. " +
                                "Zamki są otwarte, jednak nie działają automatyczne dźwigary.");
                            AnyKey();
                            Print("Nie będzie ci łatwo dźwignąć klapy.");

                            ParNumber = Player.StatTest("mind", 0, 0, 164, 95);
                            /*Mechanika  
                            
                            Test Umysł:  

                            Udany – paragraf 164.  
                            Nieudany – paragraf 95.  
                            */
                            AnyKey();
                            break;
                        }
                    case 153:
                        {
                            Print("Gwałtownym  nawrotem  zmuszasz  przeciwnika  do  ucieczki.  Twój  pojazd  okazuje  się znacznie lepiej  uzbrojony, " +
                                "niż się tego spodziewałeś. Włączają się automatyczne procedury obronne." +
                                " Spokojnie   obserwujesz,   jak   dwa   wystrzelone   przez   ciebie   pociski   pożerają przestrzeń, zbliżając się do statku " +
                                "Rzeźbiarza. A potem eksplozja.");

                            Print("Widzisz jeszcze, jak od zniszczonej rakiety odłącza się kapsuła ratunkowa i mknie wprost ku Rzeźbie. " +
                                "I jak dotarłszy do niewidzialnej granicy chroniącej Rzeźbę przed obcymi ciałami, rozpala się jasnym błyskiem i znika.");

                            Print("„To koniec – myślisz – czas wracać”. Wyłączasz systemy bojowe statku i ustalasz kurs na Kolosa.");

                            ParNumber = 166;
                            AnyKey();
                            break;
                        }
                    case 154:
                        {
                            Print("Znajdujesz  kartę  pamięciową.  Jest  zakurzona  i  lekko  wygięta,  ale  na  pewno  da  się odczytać. " +
                                "Niestety, po włożeniu do stacji okazuje się, że została zakodowana. Nie znasz hasła " +
                                "– istnieje obawa, że jeśli spróbujesz je złamać, to dane się skasują.");
                            Oxygen -= 1;
                            ParNumber = 137;
                            AnyKey();
                            break;
                        }
                    case 155:
                        {
                            Print("Pech, po prostu pech. I głupota. Zachciało ci się iść na skróty. Skalna kładka, po której chciałeś przejść nad trzymetrowej głębokości jarem, " +
                                "okazała się  zdradliwa. Kamień skruszył się pod twoim ciężarem i runąłeś w dół. Straciłeś przytomność.");

                            Oxygen -= 2;

                            ParNumber = 150;
                            //Brak tlenu – paragraf 176.  


                            AnyKey();
                            
                            break;
                        }
                    case 156:
                        {
                            Print("Udało ci się przepchnąć wózek transportowy i oto... w świetle reflektora widzisz właz w podłodze. " +
                                "Okrągły i tak wąski, że człowiek ledwie mógłby się weń wcisnąć. Podekscytowany klękasz i sprawdzasz zamek. " +
                                "Dokąd prowadzi to wyjście?");

                            Print("Podnosisz klapę. W świetle reflektora widzisz okrągły tunel, tak niski, że aby tam wejść, musiałbyś poruszać się na czworakach. " +
                                "A w oddali, prawie na granicy widoczności, majaczy jakiś kształt.");

                            Print("Leżące bezwładnie ciało człowieka w skafandrze kosmicznym.");

                            ParNumber = 63;
                            AnyKey();
                            break;
                        }
                    case 157:
                        {
                            Character Khar = new Character(2, 8, 4, "Khar", "żołnierz solarny. Co prawda wypadek dopadł cię rok po zakończeniu służby, ale " +
                                    "wciąż jeszcze zachowałeś wszystkie cechy dobrego obrońcy Dominium Solarnego – żelazną " +
                                    "wolę i sprawność.Sztuczne wszczepy ścięgien i procesor walki w twoim mózgu pozwolą ci " +
                                    "zmierzyć się z każdym przeciwnikiem.");

                            Player = Khar;

                            Player.PrintName();
                            Console.Write(" - ");
                            Player.PrintDesc();

                            ParNumber = 175;
                            AnyKey();


                            break;
                        }
                    case 158:
                        {
                            Print("Lądowisko  to  prostokąt  o  rozmiarach  dwieście  na  trzysta  metrów.  W  tym  miejscu stopiono  i " +
                                "wyrównano  skałę.Obchodzisz  je  kilkakrotnie. Cały  plac  pokryty  jest cienką warstwą pyłu. " +
                                "To świadczy, że pojazd Rzeźbiarzy odleciał stąd przynajmniej dzień temu.");

                            // Mechanika

                            Oxygen -= 1;
                            ParNumber = 106;
                            AnyKey();
                            break;
                        }
                    case 159:
                        {
                            Print("Bez problemu przełamujesz zabezpieczenia. Uzyskałeś bardzo cenne informacje – " +
                                "to kod otwierający zamknięte wrota śluzy w hangarze.");

                            Crossroads(new string[] {"Chcesz tam pójść\nNie:", "Moduł higieny", "Korytarz", "Duża sala", "Śluza hangaru", "Kolektory\n", "Powrót do kosmolotu"}, 
                                new int[] {141, 56, 143, 167, 30, 128, 64 });

                            /*Chcesz tam pójść – paragraf 141.  
                             Nie?  

                             Moduł higieny – paragraf 56.  

                             Korytarz – paragraf 143.  

                             Duża sala – paragraf 167.  
                             Śluza hangaru – paragraf 30.  

                             Kolektory – paragraf 128.  

                             Powrót do kosmolotu – paragraf 64 (odejmij kwadrans).  


                          */

                            break;
                        }
                    case 160:
                        {
                            Print("Niestety, nie udało ci się złamać zabezpieczeń, choć czujesz, że nie są one zbyt mocne. " +
                                "Podejmujesz kolejną próbę odczytu. Tracisz na to sporo czasu.");

                            // Mechanika  

                            Oxygen -= 1;
                            ParNumber = 58;

                            //Brak tlenu – paragraf 176
                            AnyKey();
                            break;
                        }
                    case 161:
                        {
                            Print("Nagle zatrzymujesz     wzrok.     W    zielonym    blasku    padającym      na   skalistą   równinę " +
                                "dostrzegasz jakiś kształt. Wyciągasz z olstra pistolet. Ruszasz w stronę znaleziska.");

                            ParNumber = 168;
                            AnyKey();
                            break;
                        }
                    case 162:
                        {
                            Print("Tu  szpargałów  jest  znacznie  więcej.  Znajdujesz  czepek  wirtuala,  roztrzaskane  pudełko  " +
                                "osobistego notesu, torebkę z lekami i stymulatorami. Świetnie, aplikujesz sobie działkę, to cię wzmocni. " +
                                "Czy teraz okażesz się dostatecznie spostrzegawczy, by wyłowić tu coś, co pomoże ci " +
                                "zrekonstruować wydarzenia, jakie zaszły w bazie?");
                            /*
                            Mechanika  
                            Podnieś jedną cechę o 1 punkt (maksymalnie do 9).  
                            */
                            ParNumber = 133;
                            AnyKey();
                            break;
                        }
                    case 163:
                        {
                            Character Dartan = new Character(3, 3, 8, "Dartan", "pilot układowy. Potrafiłeś obsługiwać każde latające urządzenie – " +
                                "oczywiście nie licząc kutrów nadprzestrzennych. Pracowałeś dla wojska i dla firm transportowych, " +
                                "zdarzały się rejsy nielegalne.\n" +
                                "Zawsze nosisz specjalne rękawice, by ochronić sztucznie unerwione opuszki palców.");

                            Player = Dartan;

                            Player.PrintName();
                            Console.Write(" - ");
                            Player.PrintDesc();



                            ParNumber = 175;
                            AnyKey();
                            break;
                        }
                    case 164:
                        {
                            Print("Śluza  niewątpliwie  zabezpiecza  wejście  do  jakiegoś  pomieszczenia  lub  korytarza.  A dokąd może prowadzić ten korytarz? Pomyśl.");
                            AnyKey();
                            ParNumber = 95;
                            break;
                        }
                    case 165:
                        {
                            Print("Jesteś coraz bardziej zły. Zmarnowałeś tu mnóstwo czasu, lecz ani o krok nie zbliżyłeś się do   rozwiązania   zagadki. " +
                                "Co   się   stało   z   trzema  mieszkańcami   bazy?   Brakuje   pojazdu Rzeźbiarzy, " +
                                "ale  nim  mogły  lecieć  co  najwyżej  dwie  osoby.  Kto  ich  zaatakował?  Po  co " +
                                "przełamywał  barierę  ochronną  sieci?  Wciąż  nie  znasz  odpowiedzi  na  te  pytania. " +
                                "Ze  złością kopiesz leżącą na podłodze tubę żywnościową. Z niejaką satysfakcją śledzisz jej powolny lot, " +
                                "widzisz,  jak  uderza  o  ścianę  i  spada  na  ziemię.  Tuż  obok  niezauważonej  wcze śniej  przez " +
                                "ciebie karty danych. Podchodzisz do niej i podnosisz do oczu. Masz dziwne przeczucie.");

                            ParNumber = 171;
                            AnyKey();
                            break;
                        }
                    case 166:
                        {
                            Print("– Oczywiście, że wiem o Rzeźbie – mówi spokojnie książę. – Tak jak wiedział o niej mój " +
                                "poprzednik i jego poprzednik, i wszyscy  książęta Klanu Rzeźbiarzy Pierścieni. Klan powstał dla ochrony Rzeźby. " +
                                "To nasza najważniejsza świątynia, człowieku. Utrzymujemy jej istnienie w tajemnicy, " +
                                "tylko najbardziej wtajemniczeni mogą poznać jej położenie. Carpeaux, oby jego imię  było  przeklęte,  " +
                                "odkrył  ją  przypadkowo.  I  oszalał.  Nie  mogłem  wysłać  po  niego Rzeźbiarzy. " +
                                "A tym bardziej obcych.");

                            Print("– Mnie mogłeś – mówisz cicho. – Bo wszyscy uznali mnie za zmarłego. A teraz wiem za dużo.");
                            AnyKey();
                            ParNumber = 84;

                            break;
                        }
                    case 167:
                        {
                            Print("Stoisz    w    największym       pomieszczeniu        bazy.    Poprzewracane         meble,     potrzaskane " +
                                "urządzenia  –  oto  ślady  zniszczeń.  To  jedyny  pokój  w  bazie,  w  którym  jest  okno.  Przez " +
                                "nieduży     okrągły     otwór     wpada      tu   blask    gigantycznej      tarczy    Ordmoru.       Zaczynasz poszukiwania. ");
                            Console.Write("Określ, ile czasu na nie poświęcisz: ");
                            int Time = Convert.ToInt32(Console.ReadLine());
                            Oxygen -= Time;
                            /*
                            Mechanika

                           Odejmij wybraną liczbę kwadransów.  */
                            ParNumber = 18;
                           
                            break;
                        }
                    case 168:
                        {

                            Print("To  martwy  człowiek.  Leży  na  brzuchu,  z  rozrzuconymi  rękami,  hełmem  wciśniętym  w ziemię. " +
                                "Jego plecy przecina czarna bruzda –  ślad laserowego strzału. Ten człowiek nie żyje, nie ma co do tego najmniejszych wątpliwości. " +
                                "Pochylasz się nad nim, oglądasz dokładnie. Nie ma  broni. " +
                                "Sakwy  jego  skafandra  są  puste,  a  w  czytniku  nie  ma  żadnej  karty.  Nie  chcesz odwracać  go  na  plecy  –  " +
                                "musiałbyś  spojrzeć  w  jego  twarz.  Nie  ma  też  rezerwowych  butli tlenowych.  " +
                                "Być  może  znajdują  się  one  gdzieś  indziej  –  to  umożliwiłoby  ci  doładowanie zapasu tlenu. " +
                                "o ile je znajdziesz...");
                            AnyKey();
                            Print("Rozegrała się tu tragedia. Co się stało z pozostałymi Rzeźbiarzami?");
                            ParNumber = 83;

                            break;
                        }
                    case 169:
                        {
                            Print("Szkoda cennego czasu na głupoty. ");
                            Print("Odwracasz się i idziesz w kierunku bazy.");

                            /*Wybierz miejsce, do którego się udajesz.  
                            */
                            ParNumber = 83;

                            break;
                        }
                    case 170:
                        {
                            Character Gerder = new Character(7, 2, 5, "Gerder  Hennel", "– astrobiolog. " +
                                    "Badałeś zadziwiające procesy zachodzące w czynnych wulkanach Ognistego, jednego z satelitów Ordmoru. " +
                                    "Zarejestrowano tam zjawiska wskazujące, że w lawie istnieją tajemnicze organizmy, przedstawiciele krzemowego życia organicznego.\n" +
                                    "Z bliska wyglądasz bardzo dziwnie - twoje humanoidalne ciało pokrywa twarda, szarobrunatna   łuska. " +
                                "Z   policzków   wystają   bolce   wszczepów   elektronicznych   i mechanicznych. " +
                                "Kiedyś mocowałeś na nich specjalny hełm i przystawkę metaboliczną - dzięki temu mogłeś zanurzać się w zadziwiającym świecie Ognistego. " +
                                "Twój organizm przez pół godziny może żyć bez tlenu.");

                            Player = Gerder;

                            Player.PrintName();
                            Console.Write(" - ");
                            Player.PrintDesc();

                            ParNumber = 175;
                            AnyKey();
                            break;
                        }
                    case 171:
                        {
                            Print("Wkładasz kartę do czytnika. „Witamy  w  różowym  świecie  gry  hardy.  Czy  dawno  nie  miałeś  kobiety?...”  –  " +
                                "słyszysz ciepły kobiecy głos. Gwałtownym ruchem wyciągasz kartę z czytnika i klnąc na czym świat stoi, mniesz ją w dłoniach. " +
                                "I wtedy właśnie dostrzegasz...");

                            ParNumber = 152;
                            AnyKey();
                            break;
                        }
                    case 172:
                        {
                            Print("Nie udaje ci się od razu odzyskać kontroli nad komputerem pokładowym, który realizuje" +
                                " własne   autonomiczne   instrukcje   obronne.   Widocznie   książę   i   Leonardo   przewidywali " +
                                "możliwość spotkania takiego jak to.");
                            AnyKey();
                            Print("Stateczek  twojego  przeciwnika,  doskonały  od  skakania  pomiędzy  skalnymi  i  lodowymi " +
                                "bryłami  pierścieni  po  ich  delikatne  przepychanie  grawitacyjnymi  muśnięciami,  nie  jest przeznaczony do walki. " +
                                "A twój kosmolot doskonale się do tego nadaje.");
                            AnyKey();
                            ParNumber = 153;
                            break;
                        }
                    case 173:
                        {
                            Print("Straciłeś  równowagę.  Bezładnie  turlasz  się  w  dół,  modląc  się  tylko  o  jedno  –  by  nie uszkodzić skafandra. " +
                                "Na szczęście zmniejszona grawitacja łagodzi skutki upadku. W końcu się zatrzymujesz. " +
                                "Chwilę leżysz w bezruchu, nasłuchując syku uciekającego powietrza. Bez sensu. " +
                                "Gdyby skafander pękł, już byś nie żył. Podnosisz się powoli, przeklinając swoje głupie zachcianki. I dostrzegasz coś, " +
                                "co leży ledwie kilka kroków od ciebie.");
                            ParNumber = 168;
                            AnyKey();
                            break;
                        }
                    case 174:
                        {
                            Print("Znalazłeś  sporo  różnych  szpargałów,  w  tym  kilkanaście  kart  pamięciowych.  Nie  było " +
                                "jednak na nich żadnej interesującej informacji.");


                            /*
                                            Jeśli kontynuujesz poszukiwania, zaznacz, ile czasu na to poświęcasz.  

                                        Mechanika  

                                        Odejmij wybraną przez siebie liczbę kwadransów.  */
                            ParNumber = 18;  
                                        
                            break;
                        }
                    case 175:
                        {

                            
                            /*
                        Mechanika  
                        Poznałeś  opis  i  cechy  twojej  postaci.  Rozdziel  dodatkowe  trzy  punkty,  zwiększając  

                    wybrane cechy. Zanotuj wynik. Maksymalna wartość dla danej cechy wynosi 9, minimalna 0.  

                    Im  wyższy  jest  współczynnik,  tym  większa  jest  szansa,  że  w  określonych  sytuacjach  twój  
                    bohater poradzi sobie z problemami.  

                        Umysł   obrazuje   to   wszystko,   co   związane   jest   z   myśleniem,   wiedzą,   inteligencją,  

                    wyobraźnią.  

                        Ciało odzwierciedla cechy fizyczne: siłę, zwinność, refleks.  
                        Ego to określenie opisujące zdolność do współpracy postaci z sieciami komputerowymi,  

                    kontrolowania  za  pomocą  wszczepek  urządzeń  zewnętrznych,  zapanowania  nad  innymi  

                    umysłami (w tym sztucznymi inteligencjami) przebywającymi w sieci itp.  
                        W trakcie gry cechy twojej postaci mogą być trwale redukowane bądź rosnąć. Notuj to na  

                    bieżąco.  

                        W   niektórych   testach   (związanych   z   upływem   czasu),            liczba   kwadransów,   które  
                    przeznaczasz  na  wykonanie  różnych  czynności,  może  –  jednorazowo,  dla  danego  testu   –  

                    dodatkowo podwyższać cechę.  
                    */
                            ParNumber = 62;
                            AnyKey();
                            break;
                        }
                    case 176:
                        {
                            Print("Popatrz na wskaźnik poziomu tlenu. Zauważyłeś? Na pewno. Sygnał właśnie gaśnie. Tlen w twoich butlach skończył się. " +
                                "Przykra sprawa. Śmierć przez uduszenie tak daleko od domu.");

                            Print("Pa, pa.");
                            ParNumber = 38;

                            break;
                        }
                    case 177:
                        {
                            Print("Klapa musiała się jakoś parszywie zaklinować. Na dodatek czujesz, że naciągnąłeś sobie mięsień lewej ręki. Trochę boli.");

                            Player.setBody(Player.Body - 1);

                            Print("Idź do innego pomieszczenia bazy: ");

                            Crossroads(new string[] {"Moduł higieny", "Korytarz", "Duża sala", "Śluza hangaru" , "Kolektory", "Powrót do kosmolotu" },
                                new int[] {56, 143, 167, 30, 128, 64 });
                            /*
                                Mechanika  
                                Zredukuj cechę Ciało o 1 punkt.  

                                Idź do innego pomieszczenia bazy:  

                                Moduł higieny – paragraf 56.  

                                Korytarz – paragraf 143.  
                                Duża sala – paragraf 167.  

                                Śluza hangaru – paragraf 30.  
                                Kolektory – paragraf 128.  

                                Powrót do kosmolotu – paragraf 64 (odejmij kwadrans).  
                                */
                            break;
                        }
                    case 178:
                        {
                            Print("Pole kolektorów zajmuje powierzchnię wielu hektarów. Tysiące mikroskopijnych baterii słonecznych  ustawia  się  do  odległej  gwiazdy  układu  lub  wodzi  za  Ordmorem. " +
                                "Listki fotokolektorów wyglądają z daleka jak srebrzyste rośliny złaknione światła.");
                            Print("Wygląda to pięknie, ale, niestety, nie znalazłeś tu niczego ciekawego. Zmarnowałeś tylko czas. " +
                                "A może po prostu czegoś nie zauważyłeś?");


                            Oxygen -= 1;
                            Crossroads(new string[] { "Szukasz dalej\nWracasz?","Śluza hangaru", "Baza", "Powrót do kosmolotu"  }, new int[] {180, 30, 145, 64 });
                            /*

                            Szukasz dalej – ParNumber = 180.  

                            Wracasz?  

                            Śluza hangaru – paragraf 30.  
                            Baza – paragraf 145.  

                            Powrót do kosmolotu – paragraf 64 (odejmij kwadrans).  

                        */

                            break;
                        }
                    case 179:
                        {
                            Console.WriteLine("Zapinasz rzepy koszuli i powoli ruszasz ku mężczyźnie. " +
                                        "Tak naprawdę nic nie jest w porządku. " +
                                        "Nie wiesz, kim jesteś. Nie wiesz, gdzie jesteś. Nie wiesz, co się stało. ");
                            Console.ReadKey();

                            ParNumber = 35;




                            break;
                        }
                    case 180:
                        {
                            Console.WriteLine(" Może nie było warto? Szukanie zabiera ci dodatkowy czas. ");
                            Oxygen -= 1;
                            AnyKey();
                            ParNumber = 182;



                            break;
                        }
                    case 181:
                        {


                            Console.WriteLine("Tak, już wiesz, kim jesteś.");

                            int character = rnd.Next(1, 9);
                            if (character == 1)
                            {
                                ParNumber = 6;
                            }
                            if (character == 2)
                            {
                                ParNumber = 69;
                            }
                            if (character == 3)
                            {
                                ParNumber = 87;
                            }
                            if (character == 4)
                            {
                                ParNumber = 94;
                            }
                            if (character == 5)
                            {
                                ParNumber = 98;
                            }
                            if (character == 6)
                            {
                                ParNumber = 146;
                            }
                            if (character == 7)
                            {
                                ParNumber = 157;
                            }
                            if (character == 8)
                            {
                                ParNumber = 163;
                            }
                            if (character == 9)
                            {
                                ParNumber = 170;
                            }




                            AnyKey();
                break;
            } 
                    case 182:
                        {




                            if (FoundBottle == false)
                            {
                                Console.WriteLine("Nagle widzisz jakiś ciemny kształt leżący obok jednego z kolektorów, jakby plecak.\n" +
                                "Podchodzisz bliżej. To tornister używany na powierzchni planety. A w nim – pełna butla z tlenem!");
                                Oxygen += 7;
                                FoundBottle = true;
                                Console.WriteLine("Uzupełniasz swoje zasoby tlenu o niemal dwugodzinny zapas");
                            }



                            Console.WriteLine("\nDokąd teraz idziesz?\n");





                            Crossroads(new string[] { "Śluza hangaru", "Baza", "Powrót do kosmolotu" }, new int[] { 30, 145, 64 });






                            break;
                        }
                }
            }
        }
    }
}


