namespace Assignment_6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 0, 3, 5, 0 };
            int count = 0;
            //move non zeros to the front
            for (int i = 0; i < array.Length; i++)
            {
                

                if (array[i] != 0)
                {
                    array[count] = array[i];
                    count++;
                }

               
            }
            //place zeros at the end
            while (count < array.Length)
            {
                array[count] = 0;
                count++;
            }
            foreach (var element  in array)
            {
                Console.WriteLine(element+"");
            }


        }
    }
}
