using System;

namespace Editor_html
{
    public static class Menu

    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DTela();
            OpcoesUser();

            var opcao = short.Parse(Console.ReadLine());
            HandleMenuOption(opcao);

        }

        public static void DTela()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            for (int line = 0; line <= 10; line++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void OpcoesUser()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma posição");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opcão: ");
        }

        public static void HandleMenuOption(short opcao)
        {
            switch (opcao)
            {
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    Console.WriteLine("Visualizar");
                    break;
                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default: Show();
                    break;
            }
        }

    }
}