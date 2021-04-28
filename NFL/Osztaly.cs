using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace NFL
{
    class Osztaly
    {
        static void Main(string[] args)
        {
            string rawTextFile = readAndTrimFile("NFL_iranyitok.txt");
            string[] textFileByRows = cutIntoRows(rawTextFile);
            Jatekos[] players = createPlayersArray(textFileByRows);
            // 5.Feladat
            Console.WriteLine("5. feladat: A statiszikaban " + players.Length + " iranyito szerepel.");
            // 7.Feladat
            Console.WriteLine("7.feladat");
            Jatekos[] playersWOver100RAnd4000PY = selectPlayersWithRatingAndPassedYardsOverValue(100, 4000, players);
            for (int i = 0; i < playersWOver100RAnd4000PY.Length; i++)
            {
                Console.WriteLine(
                    playersWOver100RAnd4000PY[i].name + 
                    " (Iranyito mutato:" + playersWOver100RAnd4000PY[i].rating + 
                    ". Passzok: " + convertYardsToMeters(playersWOver100RAnd4000PY[i].passedYards) + "m.)"
                    );
            }
            // 8.Feladat
            Console.WriteLine("8.feladat: Eladott labdak szama: ");
            int maxLostBallsCount = Convert.ToInt32(Console.ReadLine());
            string[] textByRowsToPrint = getNamesOfPlayersFromArray(getListOfPlayersWLostBallsOverValue(maxLostBallsCount, players));
            sortArrayAlphabetically(textByRowsToPrint);
            createTextFileByRows(textByRowsToPrint);
            // 9. Feladat
            Jatekos playerWMostTDs = getPlayerWithMostTDs(players);
            Console.WriteLine("9.feladat: Legtobb TD-t szerzo jatekos: ");
            Console.WriteLine(" Neve: " + playerWMostTDs.name);
            Console.WriteLine(" TD-k szama: " + playerWMostTDs.touchdownCount);
            Console.WriteLine(" Eladott labdak szama: " + playerWMostTDs.lostBallCount);
            // 10. Feladat
            Console.WriteLine("10. feladat: Legsikeresebb egyetemek ");
            University[] unis = getUniStatistics(players);
            for (int i = 0; i < unis.Length; i++)
            {
                if (unis[i].isItATopUniversity() == true)
                {
                    Console.WriteLine(unis[i].name);
                    Console.WriteLine(unis[i].players.Length);
                }
            }

            static string FormazottNev(string nev)
            {
                var n = nev.Split(' ');
                n[n.Length - 1] = n[n.Length - 1].ToUpper();
                return string.Join(" ", n);
            }

            static string readAndTrimFile(string fileName)
            {
                StreamReader streamReader = new StreamReader(fileName, System.Text.Encoding.Default);
                return streamReader.ReadToEnd().Trim();
            }

            static string[] cutIntoRows(string rawText)
            {
                return Regex.Split(rawText, "\\n");
            }

            static Jatekos[] createPlayersArray(string[] textFileByRows)
            {
                List<Jatekos> players = new List<Jatekos>();

                for (int i = 0; i < textFileByRows.Length; i++)
                {
                    string[] cutUpRow = textFileByRows[i].Split(";");
                    players.Add(new Jatekos());
                    players[i].name = cutUpRow[0];
                    players[i].passedYards = Convert.ToInt32(cutUpRow[1]);
                    players[i].passAttemptCount = Convert.ToInt32(cutUpRow[2]);
                    players[i].successfulPassCount = Convert.ToInt32(cutUpRow[3]);
                    players[i].touchdownCount = Convert.ToInt32(cutUpRow[4]);
                    players[i].lostBallCount = Convert.ToInt32(cutUpRow[5]);
                    players[i].rating = Konvertal(cutUpRow[6]);
                    players[i].currentUniversity = new University(FormazottNev(cutUpRow[7]));
                }
                return players.ToArray();
            }
            
            static int convertYardsToMeters(double yards)
            {
                return Convert.ToInt32(yards * 0.9144);
            }

            static double Konvertal(string iranyitoMutato)
            {
                var decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                iranyitoMutato = iranyitoMutato.Replace(",", decimalSeparator).Replace(".", decimalSeparator);
                if (double.TryParse(iranyitoMutato, out var ertek))
                    return ertek;
                throw new FormatException("Hibás érték (irányítómutató)");
            }

            static Jatekos[] selectPlayersWithRatingAndPassedYardsOverValue(int ratingValue, int passedMetersValue , Jatekos[] players)
            {
                double passedYardsValue = passedMetersValue / 0.9144;
                List<Jatekos> playersOverThreshold = new List<Jatekos>();
                for (int i = 0; i < players.Length; i++)
                {
                    if (players[i].rating > ratingValue && players[i].passedYards > passedYardsValue)
                    {
                        playersOverThreshold.Add(players[i]);
                    }
                }
                return playersOverThreshold.ToArray();
            }

            static Jatekos[] getListOfPlayersWLostBallsOverValue(int maxLostBallsValue, Jatekos[] players)
            {
                List<Jatekos> playersOverValue = new List<Jatekos>();
                for (int i = 0; i < players.Length; i++)
                {
                    if(players[i].lostBallCount > maxLostBallsValue)
                    {
                        playersOverValue.Add(players[i]);
                    }
                }
                return playersOverValue.ToArray();
            }

            static string[] getNamesOfPlayersFromArray(Jatekos[] players)
            {
                List<Jatekos> playersList = new List<Jatekos>(players);
                string[] playersNames = new string[playersList.Count];
                for (int i = 0; i < playersNames.Length; i++)
                {
                    playersNames[i] = playersList[i].name;
                }
                return playersNames.ToArray();
            }

            static void sortArrayAlphabetically(string[] textToSort)
            {
                Array.Sort(textToSort);
            }

            static void createTextFileByRows(string[] textByRows)
            {
                File.WriteAllLines(@"C:\Users\Law\source\repos\NFL\legtobbeladott.txt", textByRows);
            }

            static Jatekos getPlayerWithMostTDs(Jatekos[] players)
            {
                Jatekos highestPlayer = new Jatekos();
                for (int i = 0; i < players.Length; i++)
                {
                    if (players[i].touchdownCount > highestPlayer.touchdownCount)
                        highestPlayer = players[i];
                }
                return highestPlayer;
            }

            static University[] getUniStatistics(Jatekos[] players)
            {
                List<University> allUnis = new List<University>();
                string[] uniNames= getUniNamesArray(players);
                for (int i = 0; i < uniNames.Length; i++)
                {
                    allUnis.Add(new University(uniNames[i]));
                    allUnis[i].players = findAllPlayersWithUniName(uniNames[i], players);
                }
                return allUnis.ToArray();
            }

            static string[] getUniNamesArray(Jatekos[] players)
            {
                List<string> uniNames = new List<string>();
                for (int i = 0; i < players.Length; i++)
                {
                    if (uniNames.Contains(players[i].currentUniversity.name) == false)
                    {
                        uniNames.Add(players[i].currentUniversity.name);
                    }
                }
                return uniNames.ToArray();
            }

            static Jatekos[] findAllPlayersWithUniName(string uniName, Jatekos[] players)
            {
                List<Jatekos> playersWuniName = new List<Jatekos>();
                for (int i = 0; i < players.Length; i++)
                {
                    if (players[i].currentUniversity.name == uniName)
                    {
                        playersWuniName.Add(players[i]);
                    }
                }
                return playersWuniName.ToArray();
            }
        }
    }
}
