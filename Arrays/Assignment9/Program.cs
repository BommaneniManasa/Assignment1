using System;
              class Program
{
    static void Main()
    {
        int[] arr=new int[10];
Console.WriteLine("Enter 10 Numbers:");
              for (int i=0; i < 10; i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        for (int i=0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                if (arr[i]<arr[j])
                {
                    int temp=arr[i];
                    arr[i]=arr[j];
                    arr[j]=temp;
                }
            }
        }
 Console.WriteLine("Descending Order:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(arr[i]+" ");
        }
 int max=arr[0];
        int min=arr[0];
        int sum=0;
for (int i=0;i<10;i++)
        {
            if (arr[i]>max)
                max=arr[i];
  if (arr[i]<min)
                min=arr[i];
sum+=arr[i];
        }
Console.WriteLine("\nMaximum="+max);
        Console.WriteLine("Minimum="+min);
        Console.WriteLine("Sum="+sum);
    }
}
