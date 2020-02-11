using System;

namespace TextVenture
{
    class MenuVorm
    {
        string[] MenuOptions;
        string MainMenuTittle;
        bool BEGONE;

        public MenuVorm(string MainMenu, string[] InputOptions, bool IBEGONE = true)
        {
            MainMenuTittle = MainMenu;
            MenuOptions = InputOptions;
            BEGONE = IBEGONE;
        }

        public string Show()
        {
            int Ow = Console.CursorLeft;
            int Oh = Console.CursorTop;
            ConsoleKeyInfo cki;
            int sel = 0, AnimationFrame = 0;
            bool EnterPressed = false;
            do
            {
                //Clear Selections
                for (int P = 0; P > MainMenuTittle.Length; P++)
                {
                    Console.Write(" ");
                }
                for (int o = 0; o < MenuOptions.Length; o++)
                {
                    Console.Write(" ");
                    Console.WriteLine();
                    for (int P = 0; P > MenuOptions[o].Length; P++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.SetCursorPosition(Ow, Oh);


                Console.WriteLine(" --- " + MainMenuTittle + " --- ");


                for (int i = 0; i < MenuOptions.Length; i++)
                {
                    if (sel > MenuOptions.Length || sel < 0)
                    {
                        sel = 0;
                    }
                    if (sel == i)
                    {
                        if (AnimationFrame > 5)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }

                    }
                    Console.Write("-");
                    Console.WriteLine(MenuOptions[i]);
                    Console.ResetColor();
                }
                AnimationFrame++;
                if (AnimationFrame > 10)
                {
                    AnimationFrame = 0;
                }
                System.Threading.Thread.Sleep(100); // This is 1/10 of a second Basicly there are 10 frames each second

                if (Console.KeyAvailable)
                {
                    cki = Console.ReadKey();
                    switch (cki.Key)
                    {
                        case (ConsoleKey.UpArrow):
                            sel--;
                            break;
                        case (ConsoleKey.DownArrow):
                            sel++;
                            break;
                        case (ConsoleKey.Enter):
                            EnterPressed = true;
                            break;
                        default:
                            break;
                    }
                    if (sel > MenuOptions.Length - 1)
                        sel = MenuOptions.Length - 1;
                    if (sel < 0)
                        sel = 0;
                }

            } while (EnterPressed == false);

            //If you want the Menu gone after its finished its job

            if (BEGONE == true)
            {
                //Untill SOMEBODY FIXED THE DELETION CODE IMA JUST PUT THIS HERE
                Console.SetCursorPosition(Ow, Oh);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(" --- " + MainMenuTittle + " --- ");
                for (int i = 0; i < MenuOptions.Length; i++)
                {
                    Console.Write("-");
                    Console.WriteLine(MenuOptions[i]);
                }
                Console.SetCursorPosition(Ow, Oh);
            }
            Console.ResetColor();
            return MenuOptions[sel];
        }
    }
}
