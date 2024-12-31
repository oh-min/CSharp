// See https://aka.ms/new-console-template for more information
//using VariablePractice;
// Console.WriteLine("Hello from main!");
//Variable myClass = new Variable();
// myClass.var01();
// myClass.var02();

using System;   // => System 네임스페이스 안에 있는 클래스를 사용하겠다고 컴파일러에게 알리는 역할
using System.ComponentModel.DataAnnotations;
using chapter;

// using : C#의 키워드(keyword) 중 하나
// 키워드(keyword) : C# 언어의 규격에 미리 정의되어 있는 특별한 단어
// using이 키워드이기 때문에 다른 용도(변수, 식별자 등)로 사용할 수 없다
// System : C# 코드가 기본적으로 필요로 하는 클래스를 담고 있는 네임스페이스
// ;(세미콜론) : 컴파일러에게 문장의 끝을 알리는 기호
using static System.Console;
// using static : 어떤 데이터 형식(ex. 클래스)의 정적 멤버를 데이터 형식의 이름을 명시하지 않고 참조하겠다고 선언하는 기능
// using 키워드만 사용하면 네임스페이스 전체를 사용한다는 의미

namespace BrainCSharp // => BrainCSharp 이란 이름의 네임스페이스 생성
                      // 네임스페이스 : 성격이나 하는 일이 비슷한 클래스, 구조체, 인터페이스, 대리자, 열거 형식 등을 하나의 이름 아래 묶는 일을 한다
                      // ex. System.IO 네임스페이스 : 파일 입출력을 다루는 각종클래스, 구조체, 대리자, 열거 형식들 있고,
                      // ex. System.Printing 네임스페이스 : 인쇄에 관련된 일을 하는 클래스 등이 소속되어있다.
                      // 네임스페이스 만들 때
                      // namespace 네임스페이스_이름
                      // {
                      // 클래스
                      // 구조체
                      // 인터페이스 등
                      // }  
{
    class HelloWorld // => BrainCSharp 네임스페이스에 HelloWorld 클래스 담기
                     // 클래스(class) : C# 프로그램을 구성하는 기본 단위로서 데이터와 데이터를 처리하는 기능(메소드 method)으로 이루어짐
                     // C# 프로그램은 최소한 하나 이상의 클래스로 이루어진다.
    {
        // 프로그램 실행이 시작되는 곳
        static void Main(string[] args) // => Main() 메소드 : 프로그램의 진업점(Entry Point)
                                        // 프로그램을 시작하면 실행되고, 이 메소드가 종료되면 프로그램이 종료된다.
                                        // 모든 프로그램은 반드시 Main이라는 이름을 가진 메소드를 하나 가지고 있어야 한다.
                                        // static : 한정자(modifier) : 메소드나 변수 등을 수식
                                        // C# 프로그램의 각 요소는 코드가 실행되는 시점에 비로소 메모리에 할당되는 반면,
                                        // static 키워드로 수식되는 코드는 프로그램이 처음 구동될 때부터 진작에 메모리에 할당된다는 특징이 있다.
                                        // 프로 그램이 실행되면 CLR은 프로그램을 메모리에 올린 후 프로그램의 진입점을 찾는데,
                                        // 이 때 Main() 메소드가 static 키워드로 수식되어 있지 않다면 CLR은 진입점을 찾지 못하여 컴파일 에러 메시지를 출력한다.
                                        // CLR(Common Language Runtime) : C#으로 만든 프로그램이 실행되는 환경
                                        // void : 반환 형식 
                                        // Main : 메소드 이름 
                                        // String[] args : 매개 변수

        {
            args = ["World"]; // 매개 변수 값을 넣어줘야 'Hello, World'가 출력됨. 
            if (args.Length == 0) // 매개 변수 
            {
                Console.WriteLine("사용법 : HelloWorld.exe <이름>");
                return;
            }
            Console.WriteLine("Hello, {0}!", args[0]); // Hello, World를 프롬프트에 출력

            // chapter02 / practice01()
            chapter02 chapter02 = new chapter02();
            // chapter02.practice01();

            // chapter03 / Variable(), valueType()
            chapter03 chapter03 = new chapter03();
            // chapter03.Variable();
            // chapter03.steackAndHeap();
            // chapter03.integralTypes();
            // chapter03.vitaminQuiz3_1();
            // chapter03.numLiteral();
            // chapter03.secondsComplement();
            // chapter03.overflow();
            // chapter03.vitaminQuiz3_2();
            // chapter03.precision();
            // chapter03.decimalExample();
            // chapter03.charExample();
            // chapter03.stringExample();
            // chapter03.booleanExample();
            // chapter03.objectExample();
            chapter03.boxingUnboxing();
        }
    }
}

