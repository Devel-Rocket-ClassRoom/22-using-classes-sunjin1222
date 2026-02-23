using System;
using System.Numerics;
using System.Threading;

// README.md를 읽고 아래에 코드를 작성하세요.
/*


// 과제 1: 클래스 선언과 멤버 호출
ClassName.MemberName();


// 과제 2: 정적 멤버 호출
string square= Square.GetName();
Console.WriteLine(square);



// 과제 3: 정적 메서드와 인스턴스 메서드
MyFirstClass.Staticmethod();
MyFirstClass My = new MyFirstClass();
My.InstanceMathod();



// 과제 4: 개체 생성과 필드 사용


Person person1=new Person();
person1.name = "홍길동";
person1.age= 25;
person1.introduce();

Person person2 = new Person();
person2.name = "김철수";
person2.age = 30;
person2.introduce();




// 과제 5: 참조 타입 확인

Point point1=new Point();
point1.x = 10;
point1.y = 10;

Point point2 = point1;
point2.x = 100;

Console.WriteLine($"point1.x={point1.x}");
Console.WriteLine($"point1.x={point2.x}");



// 과제 6: 클래스와 구조체 비교

Pointstruct ps1 =new Pointstruct();
ps1.x = 10;
Pointstruct ps2 = ps1;
ps2.x = 100;
Console.WriteLine($"ps1.x={ps1.x} ps2.x={ps2.x}");

PointClass pc1 = new PointClass();
pc1.x = 10;
PointClass pc2 = pc1;
pc2.x = 100;
Console.WriteLine($"ps1.x={pc1.x} ps2.x={pc2.x}");




// 과제 7: 메서드 정의
Calculator calcu = new Calculator();
Console.WriteLine($"3+5={calcu.Add(3,5)}");
Console.WriteLine($"3*5={calcu.Multiply(3, 5)}");



// 과제 8: 생성자 오버로딩
Player player1 = new Player();
player1.ShowInfo();
Player player2 = new Player("용사", 150);
player2.ShowInfo();


// 과제 9: 속성 (Property)
Stock stock= new Stock();
 stock.CurrentPrioe= 30;
Console.WriteLine($"주가: {stock.CurrentPrioe}");


// 과제 10: 자동 구현 속성
Product product1 =new Product();
product1.Name="노트북";
product1.Price = 1500000;

Console.WriteLine($"{product1.Name}: {product1.Price}원 (수량:{product1.Quantity})");


// 과제 11: 읽기 전용 속성
Circle circle1 = new Circle();
circle1.Radius = 5;

Console.WriteLine($"반지름: {circle1.Radius}," +
    $" 넓이: {circle1.Area:F2}");



// 과제 12: new 키워드와 개체 생성
Monster monster1 = new Monster();
monster1.Name = "고블린";
monster1.Health = 50;

Monster monster2 = new Monster
{ 
    Name="오크",
    Health = 100
};
monster1.Attack();
monster2.Attack();



// 과제 13: 개체 이니셜라이저
Character character1 = new Character
{
    Name = "용사",
    Level = 10,
    Job = "전사",
};
Console.WriteLine($"{character1.Name}-Lv.{character1.Level} {character1.Job}");

// 과제 14: Random 클래스 기본 사용

Random random = new Random();
Console.WriteLine($"임의의 정수: {random.Next()}");
Console.WriteLine($"0~4: {random.Next(5)}");
Console.WriteLine($"1~9: {random.Next(1,10)}");
Console.WriteLine($"0.0~1.0: {random.NextDouble():f4}");


// 과제 15: 주사위 프로그램
Random random1 = new Random();
int count = 0;

Console.WriteLine($"주사위를 5번 굴립니다:");
for (int i = 0; i < 5; i++)
{
 
    count++;
    Console.WriteLine($"{count}번째: {random1.Next(1,7)}");
}
*/

// 과제 16: this 키워드
Person alice = new Person("Alice");
Person bob = new Person("Bob");
alice.SetFriend(bob);

class Person
{
    private string _name;

    public Person(string name)
    {
        this._name = name;
    }
    public void SetFriend(Person friend)
    {
        friend.PrintFriendInfo(this);
    }
    public void PrintFriendInfo(Person person)
    {
        Console.WriteLine($"{_name}의 친구는 {person._name}입니다.");
    }
}










