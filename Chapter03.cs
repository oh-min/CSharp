using System.ComponentModel;
using System.Dynamic;
using System.Xml.XPath;

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
        // 오버플로우(Overflow) : 변수에도 데이터 형식의 크기를 넘어서는 값을 담으면 넘치는 현상

        public void overflow()
        {
            uint a = uint.MaxValue; // uint의 최댓값 4294967295

            Console.WriteLine(a); // 4294967295

            a = a + 1; // 최댓값에 1을 더한 값 (담을 수 없는 값)

            Console.WriteLine(a); // 0
        }

        // 오버플로우된 변수 a는 0 = uint가 가질 수 있는 최저값
        // 왜? 이진수인 byte로 설명
        // byte의 최대값 255 -(이진수)-> 1111 1111 -> 1을 더하면 -> 1 0000 0000 이 된다.
        // byte는 1바이트 = 8비트 만 담을 수 있으므로 1 0000 0000 은 넘처흘러 왼쪽의 비트는 버리고 오른쪽의 8개 비트만 보관
        // 1 0000 0000 -> 0000 0000 (정수 0) 이 된다.

        // 언더플로우(Underflow) : 최저값보다 작은 데이터를 저장
        // byte에 -1 을 담으면
        // byte의 최솟값 0 -(이진수)-> 0000 0000 -> 1을 빼면 -> 1111 1111 이 된다.
        // 1111 1111는 정수 255이다.

        public void vitaminQuiz3_2()
        {

            int a = int.MaxValue;

            Console.WriteLine(a); // 2147483647 (최댓값)

            a = a + 1;

            Console.WriteLine(a); // -2147483648 (최솟값)
        }

        // 3.4.7 char : 정수 계열 형식

        // 3.4.8 부동 소수점 형식
        // 부동 소수점 형식(Floating Pint Types) : 소수점이 고정되어 있지 않고 움직이면서 수를 표현한다

        // 왜 소수점이 움직이는가? 소수점을 이동시켜 수를 표현하면 고정시켰을 때보다 더 제한된 비트를 이용해서 훨씬 넓은 범위의 값을 표현 할 수 있기 때문

        // 정수뿐 아니라 유리수를 포함하는 실수 영역의 데이터를 다룬다
        // 부동 소수점 형식이 정수 형식을 대체하지 못하는 이유
        // 1) 부동 소수점 형식은 소수점 표현하기 위해 일부 비트를 사용하기 때문에 같은 크기의 정수 계열 형식과 같은 크기의 수를 표현할 수 없음
        // 부동 소수점 형식은 숫자의 정밀도와 범위를 모두 표현하려고 하기 때문에 같은 크기의 비트를 사용할 경우 정수 형식만큼 정확하게 숫자를 표현할 수 없다
        // 2) 부동 소수점 형식은 산술 연산 과정이 정수 계열 형식보다 복잡해서 느림

        // float 형식 : 단일 정밀도 부동 소수점 형식(7개의 자릿수) / 4바이트(32비트) / -3.402823e38~3.402823e38
        // double 형식 : 복수 정밀도 부동 소수점 형식(15~16개의 자릿수)/ 8(64) / -1,79769313486232e308~1.79769313486232e308

        // float = Floating Point / double = Double Precision Floating Point
        // 단일 정밀도(Single Precision) / 복수 정밀도(Double Precision) 
        // '정밀도'라는 말은 부동 소수점 형식의 특징이자 한계를 나타냄
        // float 형식이 수를 표현할 때 -> 부호 비트(Sign Bit) 1비트(부호 전용) + 지수부(Exponent) 8비트(소수점 위치) + 가수부(Mantissa) 23비트(수 표현)
        // float 형식은 굉장히 넓은 범위의 수를 다루지만, 유효숫자는 7밖에 없어서 7자리 이상의 수는 '대략적으로' 표현한다
        // 이는 float 형식이 '한정된 정밀도'를 가진다는 것을 뜻한다

        public void precision()
        {
            float a = 3.1415_9265_3589_7932_3846f; // float 형식 변수에 값을 직접 할당하려면 숫자 뒤에 f를 붙여야한다
            Console.WriteLine(a); // 3.1415927

            double b = 3.1415_9265_3589_7932_3846;
            Console.WriteLine(b); // 3.141592653589793

        }
        // a와 b가 각각 자신의 가수부가 담을 수 있는 부분까지만 저장하고 나머지는 버렸기 때문

        // float 보다는 데이터 손실이 적은 double 사용은 권장
        // double을 사용했는데에도 데이터 손실이 우려된다면 decimal 형식을 사용하면 됨
        // decimal의 한계마저 넘어서는 데이터를 처리해야 한다면, 그 때는 직접 그 데이터를 처리할 수 있는 알고리즘을 담은 복합 데이터 형식을 직접 작성해야 한다

        // 3.4.9 Deciaml 형식

        // 실수를 다루는 데이터 형식. 부동 소수점과는 다른 방식으로 소수를 다루며 정밀도가 훨씬 높음
        // Decimal 형식 : 29자리 데이터를 표현할 수 있는 소수 형식 / 16바이트(128비트) / ±1.0 x 10e-28 ~ ±7.9 x 10e28

        public void decimalExample()
        {
            float a = 3.1415_9265_3589_7932_3846_2643_3832_79f; // f를 붙이면 float
            double b = 3.1415_9265_3589_7932_3846_2643_3832_79; // 아무것도 없으면 double
            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m; // m을 붙이면 decimal

            Console.WriteLine(a); // 3.1415927
            Console.WriteLine(b); // 3.141592653589793
            Console.WriteLine(c); // 3.1415926535897932384626433833
        }

        // 3.4.10 문자 형식과 문자열 형식

        // char 형식 : 정수를 데이터 형식 출신이지만, 수가 아닌 '가', '나', '다', 'a', 'b', 'c'와 같은 문자 데이터를 다룬다
        // 작은 따옴표(' ') 
        // char a = '가';
        // char b = 'a';

        public void charExample()
        {
            char a = '안';
            char b = '녕';
            char c = '하';
            char d = '세';
            char e = '요';

            Console.Write(a); // Write 메소드는 줄 바꿈 없다
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);
            Console.Write(e);
            Console.WriteLine(); // WriteLine 메소드는 출력 후 줄을 바꾼다

            // 안녕하세요
        }

        // string 형식 (문자열) : 여러 개의 문자 형식을 하나로 묶어서 처리하는 형식. 정해진 크기나 담을 수 있는 데이터의 범위가 정해지지 않는다
        // 변수가 담는 텍스트의 양에 따라 그 크기가 달라짐
        // 큰 따옴표(" ")
        // string a = "안녕하세요?";
        // string b = "반갑습니다.";

        public void stringExample()
        {
            string a = "안녕하세요?";
            string b = "반갑습니다.";

            Console.WriteLine(a); // 안녕하세요?
            Console.WriteLine(b); // 반갑습니다.
        }

        public void vitaminQuiz3_3()
        {
            // char a = "안"; // Error : " 사용
            // char b = '안녕'; // Error : 여러 개 문자
            char c = '안';

            //  string d = '안'; // Error : ' 사용
            //   string e = '안녕'; // Error : ' 사용
            string f = "안녕";

        }

        // 3.4.11 논리 형식

        // 논리 형식(Boolean Type) : 참(True), 거짓(False) / 1바이트(8비트)
        // 어떤 작업이 성공했는지(True) 실패했는지(False), 두 비교 데이터가 같은 지(True) 다른지(False)를 판단할 때 등 사용됨

        // boolean 형식이 없을 경우
        // if ( result == 0 )
        //      1번 작업을 합니다
        // else
        //      2번 작업을 합니다
        // 코드를 읽는 사람 입장에서는 사용된 0이 숫자 0인지 거짓 0을 의미하는지 헷갈린다

        public void booleanExample()
        {
            bool a = true;
            bool b = false;

            Console.WriteLine(a); // True
            Console.WriteLine(b); // False
        }

        // 3.4.12 object 형식

        // object 형식 : 어떤 데이터든지 다룰 수 있는 데이터 형식
        // '상속'의 효과 덕분에 다른 형식의 데이터도 담을 수 있다
        // 상속 : 부모 데이터 형식의 유산을 자식이 물려받는 것. 부모로부터 데이터와 메소드를 물려받은 자식은 부모와 똑같이 동작할 수 있다.

        public void objectExample()
        {
            object a = 123;
            object b = 3.141592653589793238462643383279m;
            object c = true;
            object d = "안녕하세요.";

            Console.WriteLine(a); // 123
            Console.WriteLine(b); // 3.1415926535897932384626433833
            Console.WriteLine(c); // True
            Console.WriteLine(d); // 안녕하세요.
        }

        // 정수 형식은 부호 있는 형식과 부호 없는 형식을 처리하는 방식이 서로 다르고, 부동 소수점 형식과 decimal 형식이 서로 소수를 처리하는 방식이 다른데 말이다.
        // 이 뒤에 일어나는 메커니즘은 박싱과 언박싱을 이해해야한다

        // 3.4.13 박싱과 언박싱

        // object 형식을 참조 형식이기 때문에 힙에 데이터를 할당한다
        // int 형식이나 double 형식은 값 형식이기 때문에 스택에 데이터를 할당한다
        // 그럼 값 형식의 데이터를 object 형식 객체에 담으면 스택?힙? 어느 메모리에 데이터가 할당되는 건가?

        // object 형식은 값 형식의 데이터를 힙에 할당하기 위한 "박싱(Boxing)"기능을 제공한다
        // object 형식에 값 형식의 데이터 할당하려는 시도 -> object 형식을 박싱 수행 -> 해당 데이터를 힙에 할당

        // object a = 20;
        // 20은 박스에 담긴채 힙에 저장된다

        // 힙에 있던 값 형식 데이터를 값 형식 객체에 다시 할당해야 하는 경우
        // object a = 20;
        // int b = (int)a;
        // a는 20이 박싱되어 저장되어 있는 힙을 참조하고 있다
        // b는 a가 참조하고 있는 메모리로부터 값을 복사하려고 하는 중이다
        // 언박싱(Unboxing) : 박싱되어 있는 값을 꺼내 값 형식 변수에 저장하는 과정을 일컬어서 말한다

        public void boxingUnboxing()
        {
            int a = 123;
            object b = (object)a; // a에 담긴 값을 박싱해서 힙에 저장
            int c = (int)b; // b에 담긴 값을 언박싱해서 스택에 저장

            Console.WriteLine(a); // 123
            Console.WriteLine(b); // 123
            Console.WriteLine(c); // 123

            double x = 3.1414213;
            object y = x; // x에 담긴 값을 박싱해서 힙에 저장. object 형식에 저장할 때 형식 변환연산자를 지정하지 않으면 암시적으로 object 형식으로 변환된다
            double z = (double)y; // y에 담긴 값을 언박싱해서 스택에 저장

            Console.WriteLine(x); // 3.1414213
            Console.WriteLine(y); // 3.1414213
            Console.WriteLine(z); // 3.1414213
        }

        // 3.4.14 데이터 형식 바꾸기

        // 형식 변환(Type Conversion) : 변수를 다른 데이터 형식의 변수에 옮겨 담는 것
        // 박싱과 언박싱 또한 형식 변환이라고 할 수 있다

        // 1) 크기(표현 범위)가 서로 다른 정수 형식 사이의 변환
        // 2) 크기(표현 범위)가 서로 다른 부동 소수점 형식 사이의 변환
        // 3) 부호 있는 정수 형식과 부호 없는 정수 형식 사이의 변환
        // 4) 부동 소수점 형식과 정수 형식 사이의 변환
        // 5) 문자열과 숫자 사이의 변환

        // 3.4.15 크기가 서롱 다른 정수 형식 사이의 변환

        // '용량'의 차이 때문에 문제가 발생
        // 작은 정수 형식의 변수에 있는 데이터 -> 큰 정수 형식의 변수로 옮길 때 문제 X 
        // but 반대의 경우(큰 -> 작은) 오버 플로우 발생
        // 물론, 큰 형식의 변수로부터옮겨오는 데이터가 작은 형식의 변수가 담을 수 있는 크기라면 문제 X

        // 예제 : 1바이트 크기의 sbyte 형식과 4바이트 크기의 int 형식 사이의 형식 변환(※ int -> sbyte)
        public void integralConversion()
        {
            sbyte a = 127;
            Console.WriteLine(a); // 127

            int b = (int)a;
            Console.WriteLine(b); // 127

            int x = 128; // sbyte의 최대값 127보다 큰 수
            Console.WriteLine(x); // 128

            sbyte y = (sbyte)x; // 오버플로우 발생
            Console.WriteLine(y); // - 128
        }

        // 3.4.16 크기가 서로 다른 부동 소수점 형식 사이의 변환

        // 부동 소수점 형식의 특성상 오버플로우가 존재하지 않는다 but 정밀성에 손상을 입는다
        // float 이나 double은 소수를 이진수로 메모리에 보관
        // 이것을 다른 형식으로 변환 하려면 10진수로 복원 후 -> 다시 이진수로 변환해서 기록하게 된다
        // 문제는 이진수로 표현하는 소수가 완전하지 않는다는 데 있다. 1/3 같은 수는 0.3333... 의 무한 소수가 된다
        // 따라서 정밀한 수를 다뤄야 하는 프로그램에서 float와 double 사이의 형식 변환을 시도할 때에는 주의를 기울여야 한다

        public void floatingConversion()
        {
            float a = 69.6875f;
            Console.WriteLine("a : {0}", a); // a : 69.6875

            double b = (double)a;
            Console.WriteLine("b : {0}", b); // b : 69.6875

            Console.WriteLine("69.6875 == b : {0}", 69.6875 == b); // 69.6875 == b : True

            float x = 0.1f;
            Console.WriteLine("x : {0}", x); //x : 0.1

            double y = (double)x;
            Console.WriteLine("y : {0}", y); // y : 0.10000000149011612

            Console.WriteLine("0.1 == y : {0}", 0.1 == y); // 0.1 == y : False
        }

        // 3.4.17 부호 있는 정수 형식과 부호 없는 정수 형식 사이의 변환
        public void unsignedConversion()
        {
            int a = 500;
            Console.WriteLine(a); // 500

            uint b = (uint)a;
            Console.WriteLine(b); // 500

            int x = -30;
            Console.WriteLine(x); // -30

            uint y = (uint)x;
            Console.WriteLine(y); // 4294967266
        }

        // 3.4.18 부동 소수점 형식과 정수 형식 사이의 변환

        // 부동 소수벙 형식 -> 정수 형식 : 소수점 아래는 버리고 소수점 위의 값만 남긴다
        // 0.9 -> 0 / 0.1 -> 0

        public void floatToIntConversion()
        {
            float a = 0.9f;
            int b = (int)a;
            Console.WriteLine(b); // 0

            float c = 1.1f;
            int d = (int)c;
            Console.WriteLine(d); // 1
        }

        // 3.4.19 문자열을 숫자로, 숫자를 문자열로

        // "12345"는 문자열이고, 따옴표가 없는 12345는 숫자이다
        // 문자열을 숫자로 바꾸려면 지금까지 했던것 처럼 변호나 연산자를 이용하면

        // string a = "12345";
        // int b = (int)a;

        // int c = 12345;
        // string d = (string)c;

        // 그러나 위 코드들은 컴파일 되지 않는다

        // 문자열 -> 숫자 사이의 형식 변환은 다른 방법을 사용하여야 한다
        // 정수 계열 형식, 부동 소수점 형식은 "Parse()"라는 메소드 가진다. 이 메소드는 숫자로 변환할 문자열을 넘기면 숫자로 변환해 준다
        // int a = int.Parse("12345");
        // float b = float.Parse("12345");

        // 숫자 -> 문자열
        // 정수 계열 데이터 형식이나 부동 수수점 데이터 형식은 object로부터 물려받은 "ToString()" 메소드를 자신이 갖고 있는 수자를 분자열로 변환하도록 했다(오버라이드)
        // int c = 12345;
        // string d = c.ToString();
        // float e = 123.45;
        // string f = e.ToString();

        public void stringToNumConversion()
        {
            int a = 123;
            string b = a.ToString();
            Console.WriteLine(b); // 123

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine(d); // 3.14

            string e = "123456";
            int f = Convert.ToInt32(e);
            Console.WriteLine(f); // 123456

            string g = "1.2345";
            float h = float.Parse(g);
            Console.WriteLine(h); // 1.2345
        }
    }
}
