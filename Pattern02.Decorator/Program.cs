using System;

namespace Pattern02.Decorator
{

    class Program
    {
        static void Main(string[] args)
        {
            //اضافه کردن کم کم ویژگی به ابجکت و تغییر رفتار آن
            //یک بستنی فروشی سه نوع بستنی کوچک و بزرگ و متوسط دارد
            var icecream11 = new Method_1.LargeOne();
            Console.WriteLine(icecream11.GetPrice());

            var icecream12 = new Method_1.MediumOne();
            Console.WriteLine(icecream12.GetPrice());

            var icecream13 = new Method_1.SmallOne();
            Console.WriteLine(icecream13.GetPrice());

            //Method_1 pass "S" and "O" Of solid But

            //بعد مدتی بستنی ها می توانند اسمارتیس هم داشته باشند که به قیمت آنها اضافه می شود
            //now if add property and add param lose "O"
            //if add 3 other class for after a while next change we have lots of class!!
            //and we need ask a lot of detail for create

            //یک سری کلاس داریم که بای پیاده سازی شوند
            //اما یک سری خاصیت دیگر داریم که باید کلاس ما را اکستند کنند و
            //نباید مجبور شوم که کلاس اصلی را تغییر دهم

            var icecream21 = new Method_2.LargeOne();
            //add cho
            var icecream21_Cho = new Method_2.IcecreamWithChocolate(icecream21);
            Console.WriteLine(icecream21_Cho.GetPrice());

            var icecream22 = new Method_2.MediumOne();
            //add smartis
            var icecream22_Smartis = new Method_2.IcecreamWithSmartis(icecream22);
            Console.WriteLine(icecream22_Smartis.GetPrice());

            var icecream23 = new Method_2.SmallOne();
            var p_SmallOne = icecream23.GetPrice();
            Console.WriteLine(p_SmallOne); 
            //add cho
            var icecream23_Cho = new Method_2.IcecreamWithChocolate(icecream23);
            var p_SmallOne_Cho = icecream23_Cho.GetPrice();
            Console.WriteLine(p_SmallOne_Cho);
            //add smartis
            var icecream23_ChoSmartise = new Method_2.IcecreamWithSmartis(icecream23_Cho);
            var p_SmallOne_Cho_Smartise = icecream23_ChoSmartise.GetPrice();
            Console.WriteLine(p_SmallOne_Cho_Smartise);

            //"S"
            //حل به ازای هر نوعی که اضافه می شوند فقط همان نوع اضافه می شود و نوعهای قبلی تغییری نمی کنند

            //"O"
            //اضافه کردن موارد جدید به راحتی انجام می شود

            //"L"
            //می شود فرزند را به جای پدر ارسال کرد و خطایی وجود ندارد

            //"D"
            //برای اینکه کار خود را انجام دهند یک وابستگی به کلاسی دارند که آن کلاس بیرون اول ساختع شده بعد به آن ارسال می گردد

        }
    }
}
