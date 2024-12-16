using System.ComponentModel;
using System.Dynamic;

namespace chapter
{
    public class chapter03
    {
        // '기본 데이터 형식(Primitive Type)', '상수(Constants)', '열거형(Enumerator)'
        // C#은 기본 데이터 형식을 부품으로 삼아 구성되는 '복합 데이터 형식(Complex Data Type)'을 지원
        // 복합 데이터 형식의 종류 : 구조체, 클래스, 배열 등
        // 데이터 형식 분류 : 기본 - 복합 데이터 형식 / 값 - 참조 형식
        public void Variable()
        {
            // 변수 : 값을 대입시켜 변화시킬 수 있는 요소. 데이터를 담는 일정 크기의 공간.
            // 변수를 선언 = 컴파일러에게 "이 변수에 필요한 메모리 공간을 예약해줘"라고 알린다는 뜻

            // 변수 선언하기 : 데이터 형식 명시 + 변수 식별자(이름) 명시 + ;(세미콜론)
            // int x; : 선언된 변수 x에 대입 연산자 '=' 를 통해 데이터 입력
            // x = 100; : x를 위해 할당된 메모리 공간에 데이터 100이 기록

            // 초기화(Initialization) : 변수에 최초의 데이터를 할당하는 것.
            // 초기화되지 않은 변수를 사용하려 들면 컴파일러가 에러 메시지를 내면서 실행 파일을 만들어 주지 않는다.
            // 어떤 초기값을 줘야 하는지 규칙이 있는 것은 아니지만, 수치 형식의 변수는 0으로 초기화를 하는 경우가 많다.

            // 선언과 초기화를 별도로 하는 방법
            int x; // 선언과
            x = 100; // 데이터 할당
            Console.WriteLine(x);

            // 선언과 초기화를 한번에 하는 방법
            int y = 200;
            Console.WriteLine(y);

            // 변수 여러개 동시에 선언하기
            int a, b, c;
            a = 30;
            b = 40;
            c = 50;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            int aa = 11, bb = 22, cc = 33;
            Console.WriteLine(aa);
            Console.WriteLine(bb);
            Console.WriteLine(cc);

            // 리터럴(Literal) : 고정값을 나타내는 표기법
            int l1 = 100; // 변수 l1, 리터럴 : 100
            int l2 = 0x200; // 변수 l2, 리터럴 : 0x200 (0x200은 10진수 512의 16진수 표기)
            float l3 = 3.14f; // 변수 l3, 리터럴 : 3.14f
            double l4 = 0.12345678; // 변수 l4, 리터럴 : 0.12345678
            string l5 = "가나다라마바사"; // 변수 l5, 리터럴 : "가나다라마바사"
            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l3);
            Console.WriteLine(l4);
            Console.WriteLine(l5);
          }

        public void valueAndReferenceType()
        {
            // 값 형식(Value Type) : 변수가 값을 담는 데이터 형식
            // 참조 형식(Reference Type) : 변수가 값대신 값이 있는 곳의 위치(참조)를 담는 데이터 형식\

            // 메모리 영역 : 스택(Stack) / 힙(Heap)
            // 값 형식과 관련 - 스택 / 참조 형식과 관련 - 힙
            
            // 스택 : 책 더미와 같은 구조로, 제일 아래에 있는 데이터가 제일 먼저 쌓은 데이터이고, 가장 위에 있는 데이터가 가장 나중에 쌓은 데이터이다.
            // 만일 제일 아래에 있는 데이터를 꺼내려면 위에 쌓에 있는 모든 데이터를 걷어내야 한다.
            { // 코드 블록 시작
            int stack01 = 100;
            int stack02 = 200;
            int stack03 = 300;
            } // 코드 블록 끝 = 제거
            // 세 변수 stack01, 02, 03은 차례대로 스택에 쌓였다가 코드 블록이 끝나면서( } ) 스택에서 걷혀 제거된다.

            // 힙 : 저장되어 있는 데이터를 스스로 제거하는 메커니즘을 갖고 있지 않고, CLR의 가비지 컬렉터로 데이터를 제거한다.
            // 가비지 컬렉터(Garbage Collector) : 프로그램 뒤에 숨어 동작하면서 힙에 더 이상 사용하지 않는 객체가 있으면 그 객체를 쓰레기로 간주하고 수거
            // 프로그래머가 힙에 데이터를 올려 놓으면, 코드 블록이 종료되는 시점과 상관 없이 그 데이터는 계속 생명을 유지
            // 그리고 데이터는 프로그래머가 더 이상 사용하지 않는 쓰레기가 됐을 때 가비지 콜렉터가 메모리에서 제거

            // 참조 형식의 변수는 힙과 스택을 함께 이용 -> 힙 영역에서 데이터 저장, 스택 영역에서 데이터가 저장되어 있는 힙 메모리의 주소 저장
            // 데이터를 직접 저장하는 대신 실제 데이터가 저장되어 있는 메모리의 주소를 참조한다고 해서 -> 참조 형식
            {
                object heap01 = 10;
                object heap02 = 20;
                // 실제 값 10 과 20은 힙에 저장하고, heap01과 heap02는 값이 저장된 힙의 주소만 스택에 저장
            } // heap01과 heap02는 스택에서 제거, 10과 20은 힙에 여전히 존재
            // 10과 20은 CLR의 메모리 청소부인 가비지 콜렉터가 수거

            // 스택은 변수의 생명 주기가 다 하면 자동으로 데이터를 제거하고, 
            // 힙은 더 이상 데이터를 참조하는 곳이 없을 때 가비지 콜렉터가 데이터를 치워주는 구조의 메모리 영역

        }

        public void primitiveType()
        {
            // 기본 데이터 형식(Primitive Type)에는 모두 15가지가 있는데, 숫자 형식, 논리 형식, 문자열 형식, 오브젝트 형식으로 나누어진다.
        }
    }
}
