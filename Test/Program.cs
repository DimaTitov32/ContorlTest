public class ContorlTest 
{
    static void Main(string[] args)
    {
        string[] Array = new string[] {"Dima", "One", "GB", "study", "test", "two", "win"};

        string[] newArray = CreateNewArray(Array); 

        Console.WriteLine(String.Join(" ", newArray)); 
    }

    public static string[] CreateNewArray (string[] array) 
    {
        string[] newArray;

        int count = 0;

        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i].Length <= 3) 
            { 
                count++; 
            }
        }

        newArray = new string[count]; 
        count = 0;

        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i].Length <= 3) 
            {
                newArray[count++] = array[i];
            }
        }

        return newArray; 
    }
}