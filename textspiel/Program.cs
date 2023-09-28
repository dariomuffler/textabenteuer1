using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textspiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abschnitt für ein tolles Titelbild
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("$$$_____$$$$$$$_$$$$$$$_$$$_______$$$_$$$$$$$$$$");
            Console.WriteLine("$$$____$$$____$$$____$$$_$$$_____$$$__$$$_______");
            Console.WriteLine("$$$____$$$_____$_____$$$_$$$_____$$$__$$$_______");
            Console.WriteLine("$$$_____$$$_________$$$___$$$___$$$___$$$$$$$$__");
            Console.WriteLine("$$$______$$$_______$$$_____$$$_$$$____$$$_______");
            Console.WriteLine("$$$_______$$$_____$$$______$$$_$$$____$$$_______");
            Console.WriteLine("$$$$$$$$$___$$$$$$$_________$$$$$_____$$$$$$$$$$\n");


            Console.WriteLine("Checkliste für einen guten Vortrag\n");


            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("********************************************************************************************************\n\n");

            Console.WriteLine("Drücke die A-Taste und bestätige mit Enter, um die Checkliste zu starten.");
            string startsignal = Console.ReadLine();

            if (startsignal.ToLower() == "a")
            {


                //Szene 1
                // Einführungstext schreiben
                string meintext = "Ihr habt in der Schule den Auftrag erhalten,\neinen Vortrag zu eurem Hobby zu machen.\nDu hast eben mit deiner Lehrerin über den Vortrag gesprochen.\nDu sitzt im Klassenzimmer, die Schule ist aus. Die Frage ist jetzt,\nwas du als nächstes machst. Du grübelst...\n\n";
                SlowTyping(meintext);
                //switch für die Auswahl, ob überhaupt am Vortrag gearbeitet werden soll oder nicht. 
                Console.WriteLine("Jetzt stellt sich die Frage, was du machst, weil heute ja die Sonne scheint und es richtiges Badewetter ist.");
                Console.WriteLine("1) Du gehst mit deinen Freunden an den See und es gibt unerwartet eine Party.\n2) Du gehst zum Fussballtraining und hast nur noch wenig Zeit am Abend.\n3) Du bleibst nach Schulschluss im Klassenzimmer, um dir ein paar Tipps zu holen.\n 4) Du gönnst dir zuerst eine Pause vom Unterricht und kümmerst dich dann um den Vortrag.");
              
                string eingabestart = Console.ReadLine();
                int ausgangslage = 0;
                ausgangslage = Convert.ToInt32(eingabestart);
                bool richtigewahl = false; 
                switch (ausgangslage)
                {
                    case 1:
                        Console.WriteLine("Ha ha - Witzbold, Du darfst noch nicht einmal Party machen. Zurück ins Zimmer mit dir!");
                        break;
                    case 2:
                        Console.WriteLine("Das kann mal sein, dass der Sport Vorrang hat, aber nur dieses eine Mal, gäll!?");
                        break;
                    case 3: Console.WriteLine("Was für ein Vorbildlicher Schüler! Toll!");
                        richtigewahl = true;
                        break;
                    case 4:
                        Console.WriteLine("Du gönnst dir zuerst eine Pause, indem du mit Freunden in die Badi gehst, im Anschluss widmest du dich dem Vortrag.");
                        richtigewahl = true;
                        break;
                    default: 
                        Console.WriteLine("Ungültiger Wert. Gib den Buchstaben A, B oder C ein.");
                        break;
                }
                if (richtigewahl)
                {

                
                
                //Option C
                Console.WriteLine("A: Du hast keine Lust, viel Zeit zu investieren und entscheidest dich dafür, dass du ein paar Webseiten im Internet konsultierst.");

                //Option B
                Console.WriteLine("B: Gehst du zu deinem Trainer, der in deiner Nachbarschaft wohnt und bittest ihn gleich, dir ein Interview für deinen Vortrag zu geben? Du könntest auch gleich ein Foto von ihm machen, um den Vortrag zu illustrieren.");
                SlowTyping("Schreibe a oder b! Bestätige mit der Enter-Taste.");
                string eingabe = Console.ReadLine();

                //Wenn man a eingibt
                if (eingabe.ToLower() == "a")
                {
                    Console.WriteLine("Du entscheidest dich dafür, dass du ein paar Webseiten im Internet konsultierst. Husch husch bereitest du einen Vortrag vor.");
                    Console.WriteLine("Das gibt eine ungenügende Note.");
                }

                //falls b eingegeben wird
                else if (eingabe.ToLower() == "b")
                {
                    Console.WriteLine("Du hast Dich dafür entschieden, ein persönliches Interview zu führen.");

                    //Einführungstext 3
                    Console.WriteLine("Du begibst dich also auf den Weg zu deinem Trainer, nachdem du ein paar Fragen vorbereitet hast. Du überlegst dir, was du als nächstes machst. A oder B?");
                    Console.WriteLine("A) Du entscheidest dich, dass das ausreichend Material ist für deinen Vortrag und gibst dich zufrieden.");
                    Console.WriteLine("B) Du willst noch weitere Aspekte einbauen und entscheidest dich, in die Bibliothek zu gehen, um alte Leichtathletik-Zeitschriften anzuschauen und darin zu stöbern, um vor allem Fakten zu recherchieren und Aussagen deines Trainers zu überprüfen.");

                    string eingabe2 = Console.ReadLine();

                    //wenn a ausgewählt wird und das Spiel hier zu Ende ist
                    if (eingabe2.ToLower() == "a")
                    {
                        Console.WriteLine("Du bekommst das Prädikat gut. Du hast schon einiges investiert, aber es ginge natürlich noch mehr.");

                    }
                    //wenn b ausgewählt wird, kommt folgende Szene inkl. weitere Verzweigung
                    else if (eingabe2.ToLower() == "b")
                    {
                        Console.WriteLine("Du bist schon eine Weile in der Bibliothek, sie schliesst schon bald. Du räumst deine Sachen zusammen und entscheidest dich, zu Hause am Computer nochmals etwas nachzulesen, um ein paar offene Fragen zu klären. ");
                        Console.WriteLine("Daheim am PC entdeckst du einen Vortrag, der schon mal gehalten wurde. Übernimmst du ihn?");

                        string eingabe3 = Console.ReadLine();
                        //Entscheid Ja, das heisst Gameover
                        if (eingabe3.ToLower() == "Ja")
                        {
                            Console.WriteLine("Du kopierst die ganze Powerpoint und lernst den Text, was deine Lehrerin merkt. Du bekommst eine ungenügende Note. Schade! ");
                        }
                        //hier geht es noch weiter im Spiel, nächste Verschachtelung
                        else if (eingabe3.ToLower() == "Nein")
                        {
                            Console.WriteLine("Du übernimmst eine coole Idee aus dem Vortrag, nämlich, dass du ein paar Nagelschuhe oder ein andere Requisit mitnehmen könntest. Der Vortrag gewinnt immer mehr an Tiefe und Professionalität. Du hast sicher schon eine 5,5. Willst du noch das Tüpfli auf dem i?");

                            string eingabe4 = Console.ReadLine();
                            if (eingabe4.ToLower() == "Ja")
                            {
                                Console.WriteLine("Jetzt geht es darum, den Vortrag noch super zu üben. Der Auftritt entscheidet mit.");
                            }
                            else
                            {
                                Console.WriteLine("Du hast gut gearbeitet und kannst auch ohne perfektes Ende zufrieden mit dir sein. ");
                                Console.ReadLine();

                            }
                        }
                    }
                    //alles andere
                    else
                    {
                        Console.WriteLine("Das ist eine ungültige Eingabe.");
                    }
                }

                //Wenn etwas anderes als a oder b eingegeben wird
                else
                {
                    Console.WriteLine("Das ist eine ungültige Eingabe.");
                }
                }
                else
                {
                    Console.WriteLine("Fehler. Neustarten.");
                }
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Du sollst die A-Taste drücken, habe ich gesagt!");
                Console.ReadLine();
            }

        }
        private static void SlowTyping(string meintext)
        {
            for (int i = 0; i < meintext.Length; i++)
            {
                Console.Write(meintext[i]);
                System.Threading.Thread.Sleep(10);

            }

        }
    }
    
}
