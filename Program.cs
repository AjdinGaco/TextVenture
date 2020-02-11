using System;

namespace TextVenture
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalText defaultText = new NormalText(50);
            defaultText.Text("Hi there young one, how are you doing?");

            defaultText.Text("Now with colors!", ConsoleColor.Red);
            defaultText.Text("And even more colors", ConsoleColor.Blue);

            MenuVorm DebugStart = new MenuVorm("Debug mode", new string[] { "Start Game", "Editor" }, true);




            switch (DebugStart.Show())
            {
                case "Start Game":
                    Loader();
                    GameLoop();
                    break;
                case "Editor":
                    Editor();
                    break;
            }



            Console.ReadKey();


            void Loader()
            {
                //This will read all the gamedata from a direcotory

            }

            void GameLoop()
            {

            }
            void Editor()
            {

            }
        }




    }
}
