using System;

namespace Pattern05.TemplateMethod
{
    class Program
    {
        public abstract class PitzzaMaker
        {
            public void Cook()
            {
                PrepararBread();
                PrepararIngridients();
                ComposeMaterial();
                StartCooking();
                Packageing();
                SendToCustomer();
            } // کار اصلی

            public abstract void PrepararBread(); // کار مشترک اما پیاده سازی متفاوت
            public abstract void PrepararIngridients(); // کار مشترک اما پیاده سازی متفاوت

            public void ComposeMaterial()// --> کار مشترک
            {
                //آماده سازی کلی
            }

            public void StartCooking()// --> کار مشترک
            {
            }

            public void Packageing()// --> کار مشترک
            {
            }

            public void SendToCustomer()// --> کار مشترک
            {
            }
        }

        public class VegtablePitzza : PitzzaMaker
        {
            public override void PrepararBread()
            {
                throw new NotImplementedException();
            }

            public override void PrepararIngridients()
            {
                throw new NotImplementedException();
            }
        }

        public class PeperonyPitzza : PitzzaMaker
        {
            public override void PrepararBread()
            {
                throw new NotImplementedException();
            }

            public override void PrepararIngridients()
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
            //کاری که مراحل و ترتیب آن ثابت است اما پیاده سازی آنها گاهی متفاوت است
            //مثل مراحل درست کردن پیتزا و تحویل به مشتری
            //اما بسته به نوع پیتزا پیاده سازی  و جزییات متفاوت می شود

            //اما هنگام ذخیره و بازیابی نمی دونم باید چه کارکرد که نوع پیتزا رو بفهمه

            PitzzaMaker pitzzaMaker1 = new VegtablePitzza();
            pitzzaMaker1.Cook();

            PitzzaMaker pitzzaMaker2 = new PeperonyPitzza();
            pitzzaMaker2.Cook();

            Console.WriteLine("Hello World!");
        }
    }
}
