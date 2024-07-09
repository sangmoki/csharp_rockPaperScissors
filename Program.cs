
namespace RockPaperScissors
{
    class Program
    {
        // 열거형 타입 정의
        enum enumChoice 
        {
            Rock = 1,
            Paper = 2,
            Scissors = 0
        }

        static void Main(string[] args)
        {

            // 상수 선언
/*            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 0;*/

            Random random = new Random();
            // 0~2 사이의 랜덤 값
            // 0: 가위, 1: 바위, 2: 보
            int aiChoice = random.Next(0, 3);

            Console.WriteLine("0~2 사이의 값을 입력해주세요. \n 0: 가위, 1: 바위, 2: 보");

            // 콘솔에 숫자 입력 -> 변수를 숫자로 넘김
            int myChoice = Convert.ToInt32(Console.ReadLine());

            // 내 입력 값
            switch(myChoice) 
            {
                case (int)enumChoice.Scissors:
                    Console.WriteLine("당신은 가위를 선택했습니다.");
                    break;
                case (int)enumChoice.Rock:
                    Console.WriteLine("당신은 바위를 선택했습니다.");
                    break;
                case (int)enumChoice.Paper:
                    Console.WriteLine("당신은 보를 선택했습니다.");
                    break;
            }

            // 컴퓨터 입력 값
            switch(aiChoice)
            {
                case (int)enumChoice.Scissors:
                    Console.WriteLine("컴퓨터는 가위를 선택했습니다.");
                    break;
                case (int)enumChoice.Rock:
                    Console.WriteLine("컴퓨터는 바위를 선택했습니다.");
                    break;
                case (int)enumChoice.Paper:
                    Console.WriteLine("컴퓨터는 보를 선택했습니다.");
                    break;
            }

            // 결과 -> 기본적인 상황
            // 내가 가위를 선택한 경우
/*            if (myChoice == 0) {
                // 컴퓨터가 가위를 선택한 경우
                if (aiChoice == 0) {
                    Console.WriteLine("무승부 입니다.");
                // 컴퓨터가 바위를 선택한 경우
                } else if (aiChoice == 1) {
                    Console.WriteLine("컴퓨터가 승리하였습니다.");
                // 컴퓨터가 보를 선택한 경우
                } else {
                    Console.WriteLine("당신이 승리하였습니다.");
                }
            // 내가 바위를 선택한 경우
            } else if (myChoice == 1) {
                // 컴퓨터가 가위를 선택한 경우
                if (aiChoice == 0) {
                    Console.WriteLine("당신이 승리하였습니다.");
                    // 컴퓨터가 바위를 선택한 경우
                } else if (aiChoice == 1) {
                    Console.WriteLine("무승부 입니다.");
                    // 컴퓨터가 보를 선택한 경우
                } else {
                    Console.WriteLine("컴퓨터가 승리하였습니다.");
                }
            // 내가 보를 선택한 경우
            } else {
                // 컴퓨터가 가위를 선택한 경우
                if (aiChoice == 0) {
                    Console.WriteLine("컴퓨터가 승리하였습니다.");
                    // 컴퓨터가 바위를 선택한 경우
                } else if (aiChoice == 1) {
                    Console.WriteLine("당신이 승리하였습니다.");
                    // 컴퓨터가 보를 선택한 경우
                } else {
                    Console.WriteLine("무승부입니다.");
                }
            }*/

            // 결과 -> 간단한 방법(클린코드)
            if (myChoice == aiChoice)
            {
                Console.WriteLine("무승부입니다.");
            } else if (myChoice == (int)enumChoice.Scissors && aiChoice == (int)enumChoice.Paper)
            {
                Console.WriteLine("당신의 승리입니다.");
            } else if (myChoice == (int)enumChoice.Rock && aiChoice == (int)enumChoice.Scissors)
            {
                Console.WriteLine("당신의 승리입니다.");
            } else if (myChoice == (int)enumChoice.Paper && aiChoice == (int)enumChoice.Rock)
            {
                Console.WriteLine("당신의 승리입니다.");
            } else
            {
                Console.WriteLine("당신의 패배입니다.");
            }
        }
    }
}