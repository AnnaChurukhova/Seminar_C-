// CountArray();
// void CountArray()
// {
//             Random myRand = new Random();   
//             int syzeOfArray = myRand.Next(15);
//             int[] array = new int[syzeOfArray];
//             int result = 0;
//             for(int i =0;i<syzeOfArray;i++)
//             {
//                 array[i] = myRand.Next(100, 1000);
//                 System.Console.WriteLine(array[i]);
//                 if (array[i] % 2 == 0) result ++;
//             }
//             System.Console.WriteLine("Количество четных чисел в массиве: "+result);
// }



// int [] CreateArray() 
// {
//             Random myRand = new Random();
//             int syzeOfArray = myRand.Next(15);
//             int[] array = new int[syzeOfArray];
//             return array;
// }
// void CountArray(int [] array) 
// {
//             Random myRand = new Random();
//             int result = 0;
//             for(int i =0;i<array.Length;i++)
//             {
//                 array[i] = myRand.Next(100);
//                 System.Console.WriteLine(array[i]);
//                 if (i % 2 ==1) result +=array[i];
//             }
//             System.Console.WriteLine("Сумма элементов массива на нечетных позициях: "+result);
// }
// CountArray(CreateArray());

void Requer()
{
Random myRand = new Random();

            int syzeOfArray = myRand.Next(5, 10);
            double[] array = new double[syzeOfArray];
            array[0] = myRand.Next(-100, 100);
            double min  = array[0];
            double max = array[0];
            for(int i =1;i<syzeOfArray;i++)
            {
                array[i] = myRand.Next(-100, 100);
                if (array[i] >= max) max = array[i];
                if (array[i] <= min) min = array[i];
                Console.WriteLine(array [i]);
            }
            System.Console.WriteLine("Разница между минимальным и максимальным: "+ (max-min));
}
Requer();