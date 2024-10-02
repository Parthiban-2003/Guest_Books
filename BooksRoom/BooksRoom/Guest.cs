using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BooksRoom
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter their Adults:");
        int nAdults = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter their Children:");
        int nChildren = Convert.ToInt32(Console.ReadLine());

        int nRooms = 4;
        int nMaxGuests = 4;
        int nPeoples = 16;

        int nTot = nAdults + nChildren;

        if (nTot > nPeoples)
        {
            Console.WriteLine("Guest Limited..!!");
            return;
        }

        int nRoomAllocate = 0;

        while ((nAdults > 0 || nChildren > 0) && nRoomAllocate < nRooms)
        {
            int nAdultsRoom = Math.Min(nAdults, 2); 
            int nChildrenRoom = Math.Min(nChildren, nMaxGuests - nAdultsRoom);

            nAdults = nAdults - nAdultsRoom;
            nChildren =nChildren - nChildrenRoom;

            nRoomAllocate++;
            Console.WriteLine($"Room {nRoomAllocate}:");
            Console.WriteLine($"Adult = {nAdultsRoom}, Children = {nChildrenRoom}");
            Console.ReadKey();
        }

    }
}