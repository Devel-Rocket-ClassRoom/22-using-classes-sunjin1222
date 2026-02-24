using System;

// README.md를 읽고 아래에 코드를 작성하세요.
ProductInfo productInfo1=new ProductInfo();
productInfo1.PrintInfo("노트북", 1500000,0);
ProductInfo productInfo2 = new ProductInfo();
productInfo2.PrintInfo("키보드", 800000, 20);





class ProductInfo
{
    public string Name{ get; set; }
    
    public int Price{ get; set; }
    public int DiscountPercent { get; set; }
    public int DiscountAmount
    {
        get
        {
            return DiscountPercent/Price;
        }
    }
    public int FinalPrice
    {
        get
        {
            return Price - DiscountAmount;
        }
    }

 


    public void PrintInfo(string Name, int Price, int DiscountPercent)
    {
        Console.WriteLine($"[상품정보] {Name}- 가격: {Price}원, 할인: {DiscountPercent}%" +
            $"({DiscountAmount}원), 최종가: {FinalPrice}원");
    }
}

