using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5
{
    class vidu1
    {
       static void Main(string[] args){
        byte[] a = new byte[5];

        //nhap mang
        try{
            for(int i = 0; i < 5; i++){
                Console.WriteLine("a[{0}]=", i + 1);
                a[i] = Convert.ToByte(Console.ReadLine());
            }
       } 
       catch (FormatException ex){
        // Console.WriteLine(ex.Message)
        Console.WriteLine("Khong duoc nhap ki tu cho mang so");
       }
       catch (OverflowException ex){
        // Console.WriteLine(ex.Message)
        Console.WriteLine("Khong duoc nhap gia tri nam ngoai mien 0-255");
       }
       catch (IndexOutOfRangeException ex){
        // Console.writeLine(ex.Message)
        Console.WriteLine("Loi vuot qua pham vi cua mang");
       }
       for(int i = 0; i < 5; i++){
        Console.Write(" {0}", a[i]);
       }
    }
    }
}    