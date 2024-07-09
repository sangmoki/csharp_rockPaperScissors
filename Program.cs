
namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
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
                case 0:
                    Console.WriteLine("당신은 가위를 선택했습니다.");
                    break;
                case 1:
                    Console.WriteLine("당신은 바위를 선택했습니다.");
                    break;
                case 2:
                    Console.WriteLine("당신은 보를 선택했습니다.");
                    break;
            }

            // 컴퓨터 입력 값
            switch(aiChoice)
            {
                case 0:
                    Console.WriteLine("컴퓨터는 가위를 선택했습니다.");
                    break;
                case 1:
                    Console.WriteLine("컴퓨터는 바위를 선택했습니다.");
                    break; 
                case 2:
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
            } else if (myChoice == 0 && aiChoice == 2)
            {
                Console.WriteLine("당신의 승리입니다.");
            } else if (myChoice == 1 && aiChoice == 0)
            {
                Console.WriteLine("당신의 승리입니다.");
            } else if (myChoice == 2 && aiChoice == 1)
            {
                Console.WriteLine("당신의 승리입니다.");
            } else
            {
                Console.WriteLine("당신의 패배입니다.");
            }
        }
    }
}