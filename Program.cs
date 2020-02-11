using System;

namespace TextVenture
{
    class Program
    {
        static void Main(string[] args)
        {
            //here i have to set vars to make the map data and all other stuff posible


            NormalText defaultText = new NormalText(50);
            defaultText.Text("Hi there young one, how are you doing?");
            defaultText.Text("Nevermind, lets get on with it! who are you again?");
            testinglol();
            void testinglol(){
            
                Player currentPlayer = new Player();
            Console.ReadLine(currentPlayer.name);
            defaultText.Text(currentPlayer.name);
                

            }
            

            
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
