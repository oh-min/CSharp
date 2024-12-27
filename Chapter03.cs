using System.ComponentModel;
using System.Dynamic;

namespace chapter
{
    public class chapter03
    {
        // 3.1 데이터에도 종류가 있다.

        // '기본 데이터 형식(Primitive Type)', '상수(Constants)', '열거형(Enumerator)'
        // C#은 기본 데이터 형식을 부품으로 삼아 구성되는 '복합 데이터 형식(Complex Data Type)'을 지원
        // 복합 데이터 형식의 종류 : 구조체, 클래스, 배열 등
        // 데이터 형식 분류 : 기본 - 복합 데이터 형식 / 값 - 참조 형식

        // 3.2 변수
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

        // 3.3 값 형식과 참조 형식

        // 값 형식(Value Type) : 변수가 값을 담는 데이터 형식
        // 참조 형식(Reference Type) : 변수가 값대신 값이 있는 곳의 위치(참조)를 담는 데이터 형식

        // 메모리 영역 : 스택(Stack) / 힙(Heap)
        // 값 형식과 관련 - 스택 / 참조 형식과 관련 - 힙

        public void steackAndHeap()
        {
            // 3.3.1 스택과 값 형식

            // 스택 : 책 더미와 같은 구조로, 제일 아래에 있는 데이터가 제일 먼저 쌓은 데이터이고, 가장 위에 있는 데이터가 가장 나중에 쌓은 데이터이다.
            // 만일 제일 아래에 있는 데이터를 꺼내려면 위에 쌓에 있는 모든 데이터를 걷어내야 한다.
            { // 코드 블록 시작
                int stack01 = 100;
                int stack02 = 200;
                int stack03 = 300;
            } // 코드 블록 끝 = 제거
              // 세 변수 stack01, 02, 03은 차례대로 스택에 쌓였다가 코드 블록이 끝나면서( } ) 스택에서 걷혀 제거된다.

            // 3.3.2 힙과 참조 형식

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

        // 3.4 기본 데이터 형식

        // 기본 데이터 형식(Primitive Type)에는 모두 15가지가 있는데, 숫자 형식, 논리 형식, 문자열 형식, 오브젝트 형식으로 나누어진다.
        // 문자열, 오브젝트 형식 -> 참조 형식 / 나머지 형식 -> 값 형식

        // 3.4.1 숫자 데이터 형식

        // 텍스트 데이터도 알고 보면 각 문자 하나 하나는 내부적으로 숫자 코드로 되어 있다. ex) a = 63, b = 64
        // 이미지, 음악 데이터 모두 수로 구성
        // C#은 15가지 기본 자료 형식 중 12가지를 숫자 데이터(Numeric Types) 형식으로 제공
        // 12가지 형식은 정시, 부동 소수, 소스 3가지로 나뉜다.

        // 3.4.2 정수 계열 형식

        // 정수 계열 형식(Integral Types) : 정수 데이터를 담기 위해 사용 (12가지 중 9가지)
        // 9가지의 정수 형식은 각각 크기와 담을 수 있는 데이터의 범위가 다름 -> 메모리를 효율적으로 사용하기 위함
        // byte : 부호 없는 정수 : 1바이트(8비트) : 0 ~ 255
        // sbyte : signed byte 정수 : 1바이트(8비트) : -128 ~ 127
        // short : 정수 : 2바이트(16비트) : -32,768 ~ 32,767
        // ushort : unsigned short 부호 없는 정수 : 2(16) : 0 ~ 65,535
        // int : 정수 : 4(32) : -2,147,483,648 ~ 2,147,483,647
        // uint : unsigned int 부호 없는 정수 : 4(32) : 0 ~ 4,294,967,295
        // long : 정수 : 8(64) : -922,337,203,685,477,508 ~ 922,337,203,685,477,507
        // ulong : unsigned long 부호 없는 정수 : 8(64) : 0 ~ 18,446,744,073,309,551,615
        // char : 유니코드 문자 : 2(16)

        // byte : 크기가 1바이트 / short : short integar 줄임말 / int : integar 줄임말 / long : long integar 줄임말 / char : character 줄임말

        // 한 학급의 성적을 처리하는 프로그램을 만들 때에는 int 면 충분, 하지만 대기업 회계 프로그램을 만든다면 long 형식 까지는 되어야 한다.
        // 그러면 대충 long으로 사용하면 되겠구나! -> 안됨. 메모리가 많이 필요

        // 3.4.3 정수 형식 예제 프로그램
        public void integralTypes()
        {
            sbyte a = -10;
            byte b = 40;

            Console.WriteLine($"a={a}, b={b}");

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c={c}, d={d}");

            int e = -1000_0000; // 0이 7개
            uint f = 3_0000_0000; // 0이 8개
            // 큰 자릿수의 정수 리터럴을 타이핑할 때는 자릿수 구분자(_)를 이용하면 편리. 위에서는 4번째 자리마다 구분했지만, 몇 번 째 자리에 구분할 건지는 본인 취향

            Console.WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000; // 0이 11개
            ulong h = 200_0000_0000_0000_0000; // 0이 18개

            Console.WriteLine($"g={g}, h={h}");

        }

        public void vitaminQuiz3_1()
        {
            // sbyte a = -10;
            // 위 코드를 아래 코드로 수정하여 컴파일하기
            // sbyte a = -5000_0000_0000; // 0이 11개

            // Console.WriteLine(a);
            // Cannot implicitly convert type 'long' to 'sbyte'. An explicit conversion exists (are you missing a cast?)CS0266 
            // : C#에서 발생하는 타입 변환 관련 오류. 구체적으로, long 타입을 sbyte 타입으로 암시적으로 변환할 수 없다는 오류. 범위 밖의 숫자를 넣은 경우
        }

        // 3.4.4 2진수, 10진수, 16진수 리터럴

        // C#은 2진수 리터럴을 위해 0b(숫자 0과 알파벳 b), 16진수 리터럴을 위해 0X(0x) 접두사를 제공
        // 10진수는 정수 리터럴에 어떤 접두사도 붙이지 않으면 10진수로 간주

        public void numLiteral()
        {
            byte a = 240; // 10진수 리터럴
            Console.WriteLine($"a={a}");

            byte b = 0b1111_0000; // 2진수 리터럴
            Console.WriteLine($"b={b}");

            byte c = 0XF0; // 16진수 리터럴
            Console.WriteLine($"c={c}");

            uint d = 0x1234_abcd; // 16진수 리터럴
            Console.WriteLine($"d={d}");

        }

        // 3.4.5 부호 있는 정수와 부호 없는 정수

        // sbyte, short, int, long -> 부호(+/-) 있는 정수 / byte, ushort, uint, ulong -> (부호 없는)정수
        // 부호 있는 정수 = 음의 영역까지 다룬다 / 부호 없는 정수 = 0과 양의 영역만을 다룬다

        // 똑같은 1바이트만을 사용하는데 sbyte는 -128~127을 담을 수 있고, byute는 0~255까지 담을 수 있는 이유?
        // byte나 sbyte 모두 1바이트(8비트)로 이루어져 있기 때문에 2^8-256가지 수를 표현할 수 있다.
        // byte는 8개의 비트를 모두 수를 표현하는데 사용
        // sbyte는 1개의 비트를 부호를 표현하기 위해 사용(부호비트 Sign Bit)하고 나머지 7개의 비트만 수를 표현하는데 사용
        // 0 ~ 127을 담을 때에는 byte나 sbyte 형식 모두 똑같이 표현된다.
        // 0 = | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 
        // 1 = | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 1 | 
        // 127 = | 0 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 
        // 동일하게 사용할 수 있는 이유는, 부호비트를 사용할 필요가 없었기 때문
        // 부호비트가 0 -> 양수 / 1 -> 음수
        // | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 는 -127 일 것 같지만, -1을 의미한다
        // 만약 부호비트를 순수하게 음과 양을 나타내는 데 사용하고 나머지 비트도 순수하게 수를 나타내는 데만 사용한다면 -127이 답일 것이다.
        // 이런 방식을 절대값(Sign-and-magnitude)방식이라고 한다
        // 이러한 방법으로는 0이 -0(0000 0000)과 +0(1000 0000) 두 가지가 존재하게 되는 문제가 발생한다
        // 그래서 2의 보수법(2's Complement)이라는 알고리즘을 채택하여 음수를 표현한다.

        // 2의 보수법 (-1 예시)
        // 1) 먼저 수 부분 비트를 채운다 -> | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 1 |
        // 2) 전체 비트를 반전시킨다 -> | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 0 |
        // 3) 반전되 비트에 1을 더한다 -> | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 |
        
        public void secondsComplement()
        {
            byte a = 255; // 1111 1111
            sbyte b = (sbyte)a; // (sbyte)는 변수를 sbyte 형식으로 변환하는 연산자

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        // 3.4.6 데이터가 넘쳐 흘러요
        
    }
}
