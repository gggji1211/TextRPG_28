namespace TextRPG_28
{

    class Program
    {// 수정
        static int Level = 1;
        static string Name = ""; // 임의로 정하기
        static string Job = "전사"; // 임의로 정하기 
        static int Attack = 10;// 임의로 정하기 
        static int Defense = 5;// 임의로 정하기 
        static int Hp = 100;// 임의로 정하기 
        static int Gold = 50;// 임의로 정하기 

        static void Main()
        {
            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
            Console.WriteLine("이제 전투를 시작할 수 있습니다.\n");

            while (true)
            {
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 전투 시작\n");
                Console.Write("원하시는 행동을 입력해주세요.\n>> ");

                string input = Console.ReadLine();
                Console.Clear();

                if (input == "1")
                {
                    ShowStatus();
                }
                else if (input == "2")
                {
                    Console.WriteLine("전투를 시작합니다...\n");
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.\n");
                }
            }
        }

        static void ShowStatus()
        {
            Console.WriteLine("【 상태 보기 】\n");
            Console.WriteLine($"레벨 : {level}");
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"직업 : {job}");
            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"방어력 : {defense}");
            Console.WriteLine($"체력 : {health}");
            Console.WriteLine($"Gold : {gold}\n");
        }
    }
}
