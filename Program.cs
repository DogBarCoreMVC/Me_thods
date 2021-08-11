using System;

namespace Me_thods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name("Porawit", "Pumlamjeak");

            /*double result1 = GetAreaOfTriangle(5, 3);
            Console.WriteLine("Triangle1 = " + result1);*/

            /*int a = 3;
            ChangeValue(a);
            Console.WriteLine("Main function = " + a);*/

            /*int a = 3;
            ChangeValueref(ref a);
            Console.WriteLine("Main function = " + a);*/

            /*int a;//keyword out ไม่ต้องกำหนดค่าใน function main ต่างกับ keyword ref ที่ต้องกำหนดค่า
            ChangeValueout(out a);//เอาค่า a มาจาก function ChangeValueout ที่กำหนดไว้แล้ว
            Console.WriteLine("Main function = " + a);*/

            /*int[] number = { 1, 2, 3, 4, 5, };//ไม่ได้ใช้ keyword params 
            ShowArray(number);*/

            Showparams(1,2,3,4,5);//ใช้ keyword params 
        }
        static void Name(string firstName , string lastName)
        {
            Console.WriteLine("FullName = " + firstName + " " + lastName);
        }
        static double GetAreaOfTriangle(int width , int heigth)
        {
            return 0.5 * width * heigth;
        }
        static void ChangeValue(int a)//ค่าที่แสดงออกมาเป็นคนล่ะค่ากัน value type ค่ามี 5 กับ 3
        {
            a = 5;
            Console.WriteLine("Value Type a in Function = " + a);//ค่าที่แสดงออกมา
        }
        static void ChangeValueref(ref int a)//ค่าที่แสดงออกมาเป็นค่าเดียวกัน reference type ค่าคือ 5
        {
            a = 5;
            Console.WriteLine("reference type Value Type a = " + a);//ค่าที่แสดงออกมา
        }
        static void ChangeValueout(out int a)//out 
        {
            a = 5;//หนดค่าให้เอาไปแสดง
            Console.WriteLine("reference type Value Type a = " + a);
        }
        static void ShowArray(int[] valueInput)
        {
            int result = 0;

            for (int i = 0; i < valueInput.Length; i++)
            {
                result += valueInput[i];
            }
            Console.WriteLine("result = " + result);
        }
        static void Showparams(params int[] valueInputPa)//params เป็น keyword ที่เวลาเรียกใช้งานใน mehod main เราไม่ต้องสร้าง array ขึ้นมา เราใส่ค่าที่เราต้องการเข้าไปใน parameter ได้เลย
        {
            int result = 0;

            for (int i = 0; i < valueInputPa.Length; i++)
            {
                result += valueInputPa[i];
            }
            Console.WriteLine("result = " + result);
        }
    }
}
