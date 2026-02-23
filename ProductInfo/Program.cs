using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");


class ProductInfo
{
    public string Name="키보드";
    public int Price=80000;
    public int DiscountPercent=0;
    public int DiscountAmount
    {
        get
        {
            return Price / DiscountPercent;
        }
    }
    public int FinalPrice
    {
        get
        {
            return Price - DiscountAmount;
        }
    }

 


    public void PrintInfo()
    {
        Console.WriteLine($"[상품정보] {Name}- 가격: {Price}원, 할인: {DiscountPercent}%" +
            $"({DiscountAmount}원), 최종가: {FinalPrice}원");
    }
}

