using System;

// README.md를 읽고 아래에 코드를 작성하세요.

GameCharacter hero=new GameCharacter();
hero.Name="용사";
hero.Level = 5;
GameCharacter monster = new GameCharacter();
monster.Name = "고블린";
monster.Level = 3;
hero.ShowStatus();
monster.ShowStatus();



class GameCharacter 
{
   public string Name;
   public int Level;
   public int MaxHp = Level * 100;
   public int CurrentHp;
   public int AttackPower= Level * 10;
    public int IsAlive = CurrentHp < 0;


    public void Attack()
    {
        AttackPower= Level * 10;

    }

    public void ShowStatus()
    {
        Console.WriteLine($"[{Name}] Lv.{Level}-Hp:" +
            $" {CurrentHp}/{MaxHp}, 공격력: {AttackPower}");
    }
}
