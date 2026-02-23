using System;

class Player
{
    public string Name;
    public int Helth;

    public Player()
        { 
            Name="Unknown";
            Helth=100;
        }
    public Player(string name, int helth)
    { 
        Name = name;
        Helth= helth;    
    }

    public void ShowInfo()
    { 
        Console.WriteLine($"이름: {Name}, 체력:{Helth}");   
    }

}


// 과제 9: 속성 (Property)


// 과제 10: 자동 구현 속성


// 과제 11: 읽기 전용 속성



// 과제 12: new 키워드와 개체 생성



// 과제 13: 개체 이니셜라이저


// 과제 14: Random 클래스 기본 사용


// 과제 15: 주사위 프로그램

// 과제 16: this 키워드
