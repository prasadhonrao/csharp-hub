using System;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            var srt = new Player("Sachin Tendulkar");
            srt.Say("Boost is the secret of my energy");

            var kapil = new Player("Kapil Dev");
            kapil.Say("Our energy");

            Console.ReadLine();
        }
    }

    class Player
    {
        private string _player;

        public Player(string name = "")
        {
            _player = name;
        }

        public void Say(string dialog)
        {
            Console.WriteLine(_player + " : " + "'" + dialog + "'" );
        }
    }
}
