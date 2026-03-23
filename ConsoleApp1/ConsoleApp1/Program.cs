using System;
using System.Numerics;
using System.Text;

namespace program

{
    class TicTacToe
    {
        static void ShowTitle()
        {
            Console.Clear();

            Ascii ascii = new Ascii();
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;

            Console.SetCursorPosition(0, 0);
            Console.WriteLine(ascii.TittleArt);

            //int startY = ascii.LogoHeight + 1;

            string[] MenuLines =
      {
        "========================================",
        "         Tic Tac Toe       ",
        "========================================",
        "",
        "      1. 같이하기",
           "  2.   혼자하기 ",
         "      3. 종료",
        "",
        "========================================"


      };

            int asciiLines = 2;
            int startY = asciiLines;

            //int startY = (height / 2) - (MenuLines.Length / 2);

            for (int i = 0; i < MenuLines.Length; i++)
            {

                int x = (width - MenuLines[i].Length) / 2;
                Console.SetCursorPosition(x >= 0 ? x : 0, startY + i);
                Console.WriteLine(MenuLines[i]);
            }

            string prompt = "메뉴를 선택하세요: ";
            int pX = (width - prompt.Length) / 2;
            Console.SetCursorPosition(pX >= 0 ? pX : 0, startY + MenuLines.Length + 1);
            Console.Write(prompt);
        }

        public class Ascii
        {
            public readonly string TittleArt = """
                
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢀⠄⠄⠒⢒⠐⡐⠒⠂⠄⢄⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠔⡈⠅⢂⠂⠅⡑⡐⡐⠄⠅⠅⠅⡂⠄⠅⡂⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡐⠡⢐⠠⢑⠠⠡⢁⠆⡂⠂⠅⡊⠨⠐⠄⠅⠅⡂⠅⡑⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡌⠄⡑⡐⠨⢐⠨⢈⠜⡀⡂⠅⠅⠆⡡⠡⡡⢁⠅⠌⢢⠐⠄⢂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠜⡀⠊⠄⡂⠅⡅⡊⡐⡅⠂⡂⠅⡡⢡⢂⠡⡂⠢⠨⠨⠀⢇⠡⢁⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠔⠬⢁⠂⡅⠅⡂⠅⡑⠌⢀⠎⡀⡂⠅⡐⠌⢡⠂⡍⢌⠸⠨⢈⠌⡂⠢⠐⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⣐⠕⠁⢈⠠⢪⠇⠅⡊⠀⢳⠉⠀⢅⠂⡂⠅⡂⠅⠀⡍⡂⠈⡌⢌⠐⠄⠇⡡⠑⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⡜⠀⠀⠀⠈⢔⠍⢬⢂⠓⠒⠒⣒⡂⠂⢊⢸⢐⠌⠴⠤⠧⠤⠤⠴⠡⠨⠨⢰⠠⡁⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠈⠊⠌⠈⠀⠀⠰⣿⡿⠀⠀⠐⠁⠀⠀⢸⡿⡿⠀⠀⡃⠅⠅⡊⠂⠢⡁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠌⠬⠀⠈⠀⢀⠀⠀⠄⠐⠀⠀⠄⠀⠀⠉⠀⡀⠁⡇⠌⢂⢂⠁⡨⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⠡⠑⢔⡈⡀⠀⠠⠀⠀⠄⠂⠀⡀⠁⠀⠄⠀⢀⡇⠌⡐⠄⡏⡐⠨⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⡊⠨⠨⠐⡕⡱⢹⡘⠩⠨⠐⢰⠂⡂⠢⠡⠙⡍⣎⠕⡈⡐⡈⡇⡐⡁⡂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⢘⢸⡨⢐⠸⡨⢺⠀⠅⠌⠨⢘⠔⠈⠄⡁⡂⠱⡣⡁⠢⢐⡐⠅⡂⡂⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡄⣂⠣⡐⠆⡌⠪⡆⠌⠄⠡⠁⢜⠄⠅⠡⢐⠠⠡⠃⢌⠬⢢⠎⡐⡐⡐⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢐⢸⠐⡘⠨⠨⡩⢊⠨⡈⠨⠈⢌⢂⠡⠁⡂⢚⠘⡈⡇⠕⡁⠢⢘⠄⠂⠆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡅⠂⡅⢂⠅⠅⡺⢀⠒⢊⢎⠌⠜⠄⣂⢡⠑⡐⢐⠀⢇⠅⠌⢌⡆⠊⠌⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢐⠱⠰⠠⢹⢐⢸⡀⡈⢔⣠⣐⣈⣄⣢⣀⣃⣐⣐⣈⡐⠌⡨⠢⢂⠑⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠑⡄⠘⠄⠕⡆⠂⡂⠡⠠⢈⠱⠁⠄⠂⠄⡐⡱⡣⡯⡂⢁⠢⠊⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠂⡆⠡⠠⠡⠈⠄⡘⡈⠌⠨⠐⠠⢈⢯⡚⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠡⣨⣠⣁⡅⠸⠠⡨⣠⣁⣅⡂⠜⠹⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
""";

            public int LogoHeight = 22;
        }

        internal class PlayGame

        {
            static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            static int player = 1;
            static int choice;
            static int flag = 0;


            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.SetWindowSize(80, 50); // 콘솔창 전체 타이틀

                while (true)
                {
                    ShowTitle(); // 타이틀 화면 표시
                    string input = Console.ReadLine();

                    if (input == "1") // 2인용 게임
                    {
                        Console.Clear();
                        Choice1.TogherGame();
                        Console.WriteLine("게임을 시작합니다...");
                        // 게임 시작 로직
                        break;
                    }
                    else if (input == "2") // 1인용 게임 
                    {
                        Choice2.Singlegame();
                        break;
                    }

                    else if (input == "3")
                    {
                        Environment.Exit(0); // 게임 종료
                    }
                    else
                    {
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                        System.Threading.Thread.Sleep(1000); // 1초 대기
                    }
                }



            }


            public class Choice1
            {
                public static void TogherGame()
                {
                    do
                    {
                        Console.Clear();

                        Console.WriteLine("플레이어 1: X 와 플레이어 2: O");
                        Console.WriteLine("\n");

                        if (player % 2 == 0)
                        {
                            Console.WriteLine("플레이어 2의 차례");
                        }
                        else
                        {
                            Console.WriteLine("플레이어 1의 차례");
                        }

                        Console.WriteLine("\n");
                        Board();

                        string line = Console.ReadLine();
                        bool res = int.TryParse(line, out choice);

                        if (res == true)
                        {
                            if (arr[choice] != 'X' && arr[choice] != 'O')
                            {
                                if (player % 2 == 0)
                                {
                                    arr[choice] = 'O';
                                }
                                else
                                {
                                    arr[choice] = 'X';
                                }

                                player++;
                            }
                            else
                            {
                                Console.WriteLine("죄송합니다. {0} 행은 이미 {1}로 표시되어 있습니다.", choice, arr[choice]);
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("숫자를 입려해주세요.");
                        }

                        flag = CheckWin();
                    }
                    while (flag != -1 && flag != 1);

                    if (flag == 1)  // 각 플레이어 승리 시 멘트 추가
                    {
                        Console.WriteLine("플레이어 {0}이(가) 이겼습니다.", (player % 2) + 1);
                    }
                    else
                    {
                        Console.WriteLine("무승부"); //무승부시 멘트 추가
                    }

                    Console.ReadLine();
                }

                static void Board()
                {
                    Console.WriteLine("     |     |     ");
                    Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[1], arr[2], arr[3]);
                    Console.WriteLine("_____|_____|_____");
                    Console.WriteLine("     |     |     ");
                    Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[4], arr[5], arr[6]);
                    Console.WriteLine("_____|_____|_____");
                    Console.WriteLine("     |     |     ");
                    Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[7], arr[8], arr[9]);
                    Console.WriteLine("     |     |     ");
                }

                static int CheckWin()
                {
                    // 가로 승리 조건
                    if (arr[1] == arr[2] && arr[2] == arr[3])
                    {
                        return 1;
                    }
                    else if (arr[4] == arr[5] && arr[5] == arr[6])
                    {
                        return 1;
                    }
                    else if (arr[7] == arr[8] && arr[8] == arr[9])
                    {
                        return 1;
                    }

                    // 세로 승리 조건
                    else if (arr[1] == arr[4] && arr[4] == arr[7])
                    {
                        return 1;
                    }
                    else if (arr[2] == arr[5] && arr[5] == arr[8])
                    {
                        return 1;
                    }
                    else if (arr[3] == arr[6] && arr[6] == arr[9])
                    {
                        return 1;
                    }

                    // 대각선 승리조건
                    else if (arr[1] == arr[5] && arr[5] == arr[9])
                    {
                        return 1;
                    }
                    else if (arr[3] == arr[5] && arr[5] == arr[7])
                    {
                        return 1;
                    }

                    // 무승부
                    else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' &&
            arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
                    {
                        return -1;
                    }
                    else { return 0; }

                }

            }
        }

        public class Choice2
        {

            public static void Singlegame()
            {
                int[,] map = new int[3, 3];
                int player = 1;
                int computer = 2;
                int attempt = 0;
                Random random = new Random();

                while (true)
                {
                    Console.Clear();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write('\n');
                        for (int j = 0; j < 3; j++)
                        {
                            
                            Console.Write(map[i, j] + " ");
                        }
                    }

                    Console.Write("\n당신의 차례 (x(1~3),y(1~3)) : ");
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input) || !input.Contains(","))
                        continue;

                    string[] usrInput = input.Split(',');

                   
                    if (!int.TryParse(usrInput[0], out int xRaw) || 
                        !int.TryParse(usrInput[1], out int yRaw)) 
                        continue;

                    int x = xRaw - 1;
                    int y = yRaw - 1;

                    if (x < 0 || x > 2 || y < 0 || y > 2) 
                        continue;

                    if (map[x, y] == 0)
                    {
                        map[x, y] = 1;
                        attempt++;

                        if (GameOver(map, x, y, player))
                        {
                            Console.WriteLine("!! Player win !!");
                            break;
                        }

                        if (attempt == 5) 
                        {
                            Console.WriteLine("!! A win !!");
                            break;
                        }

                       
                        Random rand = new Random();
                        int cptX, cptY;
                        do
                        {
                            cptX = rand.Next(0, 3);
                            cptY = rand.Next(0, 3);
                        } while (map[cptX, cptY] != 0);

                        map[cptX, cptY] = 2;
                        if (GameOver(map, cptX, cptY, computer))
                        {
                            Console.WriteLine("!! Computer win !!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("이미 차 있는 곳입니다!");
                        System.Threading.Thread.Sleep(500);
                    }
                }
                Console.WriteLine("\n아무 키나 누르면 메뉴로 돌아갑니다...");
                Console.ReadKey();
            }

           
            static bool GameOver(int[,] map, int x, int y, int turn)
            {
                
                for (int i = 0; i < 3; i++)
                {
                    if (map[x, i] != turn) 
                        break;
                    if (i == 2) return true;
                }
                for (int i = 0; i < 3; i++)
                {
                    if (map[i, y] != turn)
                        break;
                    if (i == 2) return true;
                }
               
                if (map[0, 0] == turn && map[1, 1] == turn && map[2, 2] == turn) 
                    return true;
                if (map[0, 2] == turn && map[1, 1] == turn && map[2, 0] == turn) 
                    return true;

                return false;
            }
        }
    }
}






