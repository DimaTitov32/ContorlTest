public class ContolTest
{
     static void Main(string[] args)
     {
         string[] array = new string[] {"Dima", "One", "GB", "study", "test"};

     }

     public static string[] NewArray (string[] array)
     {
         string[] NewArray;
         int count =0;
         for (int i = 0; i < array.Length; i++)
         {
             if(array[i].Length<=3)
             count++;

         }
     }
}
