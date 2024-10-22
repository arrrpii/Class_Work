using static List.ListImp;
using System;

class Program
{
    static void Main()
    {
        ArrayList<int> arrayList = new ArrayList<int>();

        arrayList.AddElement(1);
        arrayList.AddElement(26);
        arrayList.AddElement(4);
        arrayList.AddElement(56);
        arrayList.AddElement(12);


        Console.WriteLine(arrayList.Count); 
        arrayList.RemoveAtIndex(1); 
        Console.WriteLine(arrayList.Count);
        



    }
}
