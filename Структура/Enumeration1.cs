using System;

class Enumeration1
{
    public static void Enumiration1Class (string[] args)
    {

        DayOfWeek MyFavoriteDay;

        MyFavoriteDay = DayOfWeek.Friday;

        Console.WriteLine(MyFavoriteDay);
    }   
}
         

   enum DayOfWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

enum ProgramData
{
    ProgramId = 123,
    AuthorId = 567
}

   enum Semaphore
   
   {
     Red = 100,
     Yellow = 200,
     Green = 300
   }
