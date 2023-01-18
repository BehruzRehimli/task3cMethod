using System;

namespace dersdetask3cuders
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        #region Dersdeki Tasklar :
        static bool asigment(char a) 
        {
            //Verilmish charin reqem olub olmadigini tapan metod
            string digit = "0123456789";
            for (int i = 0; i < digit.Length; i++)
            {
                if (a == digit[i])
                {
                    return true;
                }
            }
            return false;   
        }
        static bool yoxlama(string str,char cr)
            //Verilmish yazida verilmish charin olub olmadigini yazan method
        {
            foreach (var item in str)
            {
                if (item==cr)
                {
                    return true;
                }
            }
            return false;
        }
        static int quvvet (int a,int b)
            // Verilmish ededi verilmish quvvete yukselden metod
        {
            int result = 1;
            for (int i = 0; i <b; i++)
            {
                result *= a;
            }
            return result;
        }
        static int max(int[] numbers)
            //Verilmish ededler siyahisinda en boyuk ededi tapan method
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max= numbers[i];
                }
            }
            return max;
        }
        #endregion
        #region Task 1  - Verilmiş ədədlər siyahısındaki ədədlərdən ən kiçiyini tapan metod 
        //static int min(int[] arr)
        //{
        //    //int min = arr[0];
        //    //foreach (var item in arr)
        //    //{
        //    //    if (min > item)
        //    //    {
        //    //        min = item;
        //    //    }
        //    //}
        //    //return min; 
        //}
        #endregion
        #region Task 2 : - Verilmiş yazıda verilmiş chardan neçə ədəd olduğunu tapan metod
        //static int searching(string str,char cr)
        //{
        //    int counter = 0;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i]==cr)
        //        {
        //            counter++;
        //        }
        //    }
        //    return counter;
        //}

        #endregion
        #region Task 3 : - Verilmiş ədədlər siyahısında verilmiş ədədin yerləşdiyi indexi tapan metod, əgər həmin ədəd siyahıda yoxdursa -1 qaytarsın, varsa ilk yerləşdiyi indexi.
        //static int ArrSearch (int[]arr,int num)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i]==num)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
        #endregion
        #region Task 4 : - Verilmiş yazını əksinə çevirən metod (misalçün metoda "salam" göndərsəniz metod geriyə "malas" return etməlidir)
        //static string convert(string input)
        //{
        //    string result = "";
        //    for (int i = input.Length-1; i >= 0; i--)
        //    {
        //        result += input[i];
        //    }
        //    return result;
        //}
        #endregion
        #region Task 5 :- Verilmiş yazıda rəqəm olub olmadığını tapan metod
        //static bool FindDigit(string str)
        //{
        //    string digits = "0123456789";
        //    for (int i = 0; i < digits.Length; i++)
        //    {
        //        foreach (var item in str)
        //        {
        //            if (item == digits[i])
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;

        //}
        #endregion



    }
}
