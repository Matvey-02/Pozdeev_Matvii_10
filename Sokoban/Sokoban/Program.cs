using System;

namespace Sokoban
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            char pla = '☺';
            char box = '□';
            char aox = '■';
            char aim = '●';

            char[,] map = {
            {'┌','─','─','─','┐','█','█','█','█' },
            {'|',' ',' ',' ','|','█','█','█','█' },
            {'|',' ',box,' ','|','█','┌','─','┐' },
            {'|',' ',box,' ','|','█','|',aim,'|' },
            {'└','─','┐',' ','└','─','┘',aim,'|' },
            {'█','┌','┘',pla,box,' ',aim,' ','|' },
            {'█','|',' ',' ',' ','|',' ',' ','|' },
            {'█','|',' ',' ',' ','├','─','─','┘' },
            {'█','└','─','─','─','┘','█','█','█' }
            };
            byte score = 0;
            int move = 0;
            update();
            byte coorX = 5, coorY = 3;

            bool flag = false;

            while (true)
            {
                if (score == 3)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                cki = Console.ReadKey();
                if (cki.Key.ToString() == "UpArrow" && map[coorX - 1, coorY] == ' ')
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    coorX--;
                    map[coorX, coorY] = pla;
                    update(); continue;

                }
                if (cki.Key.ToString() == "DownArrow" && map[coorX + 1, coorY] == ' ')
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    coorX++;
                    map[coorX, coorY] = pla;
                    update(); continue;
                }
                if (cki.Key.ToString() == "RightArrow" && map[coorX, coorY + 1] == ' ')
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    coorY++;
                    map[coorX, coorY] = pla;
                    update(); continue;
                }
                if (cki.Key.ToString() == "LeftArrow" && map[coorX, coorY - 1] == ' ')
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    coorY--;
                    map[coorX, coorY] = pla;
                    update(); continue;
                }


                if (cki.Key.ToString() == "UpArrow" && map[coorX - 1, coorY] == aim)
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    flag = true;
                    coorX--;
                    map[coorX, coorY] = pla;
                    update(); continue;
                }
                if (cki.Key.ToString() == "DownArrow" && map[coorX + 1, coorY] == aim)
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    flag = true;
                    coorX++;
                    map[coorX, coorY] = pla;
                    update(); continue;
                }
                if (cki.Key.ToString() == "RightArrow" && map[coorX, coorY + 1] == aim)
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    flag = true;
                    coorY++;
                    map[coorX, coorY] = pla;
                    update(); continue;
                }
                if (cki.Key.ToString() == "LeftArrow" && map[coorX, coorY - 1] == aim)
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    flag = true;
                    coorY--;
                    map[coorX, coorY] = pla;
                    update(); continue;
                }



                if (cki.Key.ToString() == "UpArrow" && map[coorX - 1, coorY] == box && map[coorX - 2, coorY] == ' ')
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    coorX--;
                    map[coorX, coorY] = pla;
                    map[coorX - 1, coorY] = box;
                    update(); continue;
                }
                if (cki.Key.ToString() == "DownArrow" && map[coorX + 1, coorY] == box && map[coorX + 2, coorY] == ' ')
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    coorX++;
                    map[coorX, coorY] = pla;
                    map[coorX + 1, coorY] = box;
                    update(); continue;
                }
                if (cki.Key.ToString() == "RightArrow" && map[coorX, coorY + 1] == box && map[coorX, coorY + 2] == ' ')
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    coorY++;
                    map[coorX, coorY] = pla;
                    map[coorX, coorY + 1] = box;
                    update(); continue;
                }
                if (cki.Key.ToString() == "LeftArrow" && map[coorX, coorY - 1] == box && map[coorX, coorY - 2] == ' ')
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    coorY--;
                    map[coorX, coorY] = pla;
                    map[coorX, coorY - 1] = box;
                    update(); continue;
                }


                if (cki.Key.ToString() == "UpArrow" && map[coorX - 1, coorY] == box && map[coorX - 2, coorY] == aim)
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    coorX--;
                    map[coorX, coorY] = pla;
                    map[coorX - 1, coorY] = aox;
                    score++;
                    update(); continue;
                }
                if (cki.Key.ToString() == "DownArrow" && map[coorX + 1, coorY] == box && map[coorX + 2, coorY] == aim)
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    coorX++;
                    map[coorX, coorY] = pla;
                    map[coorX + 1, coorY] = aox;
                    score++;
                    update(); continue;
                }
                if (cki.Key.ToString() == "RightArrow" && map[coorX, coorY + 1] == box && map[coorX, coorY + 2] == aim)
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    coorY++;
                    map[coorX, coorY] = pla;
                    map[coorX, coorY + 1] = aox;
                    score++;
                    update(); continue;
                }
                if (cki.Key.ToString() == "LeftArrow" && map[coorX, coorY - 1] == box && map[coorX, coorY - 2] == aim)
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    coorY--;
                    map[coorX, coorY] = pla;
                    map[coorX, coorY - 1] = aox;
                    score++;
                    update(); continue;
                }


                if (cki.Key.ToString() == "UpArrow" && map[coorX - 1, coorY] == aox && map[coorX - 2, coorY] == ' ')
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    flag = true;
                    coorX--;
                    map[coorX, coorY] = pla;
                    map[coorX - 1, coorY] = box;
                    score--;
                    update(); continue;
                }
                if (cki.Key.ToString() == "DownArrow" && map[coorX + 1, coorY] == aox && map[coorX + 2, coorY] == ' ')
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    flag = true;
                    coorX++;
                    map[coorX, coorY] = pla;
                    map[coorX + 1, coorY] = box;
                    score--;
                    update(); continue;
                }
                if (cki.Key.ToString() == "RightArrow" && map[coorX, coorY + 1] == aox && map[coorX, coorY + 2] == ' ')
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    flag = true;
                    coorY++;
                    map[coorX, coorY] = pla;
                    map[coorX, coorY + 1] = box;
                    score--;
                    update(); continue;
                }
                if (cki.Key.ToString() == "LeftArrow" && map[coorX, coorY - 1] == aox && map[coorX, coorY - 2] == ' ')
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    flag = true;
                    coorY--;
                    map[coorX, coorY] = pla;
                    map[coorX, coorY - 1] = box;
                    score--;
                    update(); continue;
                }


                if (cki.Key.ToString() == "UpArrow" && map[coorX - 1, coorY] == aox && map[coorX - 2, coorY] == aim)
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    flag = true;
                    coorX--;
                    map[coorX, coorY] = pla;
                    map[coorX - 1, coorY] = aox;
                    update(); continue;
                }
                if (cki.Key.ToString() == "DownArrow" && map[coorX + 1, coorY] == aox && map[coorX + 2, coorY] == aim)
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    flag = true;
                    coorX++;
                    map[coorX, coorY] = pla;
                    map[coorX + 1, coorY] = aox;
                    update(); continue;
                }
                if (cki.Key.ToString() == "RightArrow" && map[coorX, coorY + 1] == aox && map[coorX, coorY + 2] == aim)
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    flag = true;
                    coorY++;
                    map[coorX, coorY] = pla;
                    map[coorX, coorY + 1] = aox;
                    update(); continue;
                }
                if (cki.Key.ToString() == "LeftArrow" && map[coorX, coorY - 1] == aox && map[coorX, coorY - 2] == aim)
                {
                    if (flag) { map[coorX, coorY] = aim; flag = false; }
                    else map[coorX, coorY] = ' ';
                    flag = true;
                    coorY--;
                    map[coorX, coorY] = pla;
                    map[coorX, coorY - 1] = aox;
                    update(); continue;
                }
            }



            void update()
            {
                Console.WriteLine();
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Your score: " + score + "; moves: " + move);
                move++;
            }
        }
    }
}
