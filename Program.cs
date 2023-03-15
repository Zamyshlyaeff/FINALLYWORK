string [] array={"ZADA","NIE","1234","123","pin"};

int LENGTHARRAY (string[] arr)    //определение длины нового массива
{ int k=0;
  for(int i=0;i<array.Length;i++)
  {  if (array[i].Length<=3) k++;
    
  }
  return k;
}
void PRINTARRAY(string[]array) //печать массива
{   System.Console.Write("[");
    for (int i=0;i<array.Length;i++)
{   if(i<array.Length-1)
    {
        Console.Write($"{array[i]},");}
    else 
    {
        Console.Write($"{array[i]}");
    }
}
System.Console.Write("]");
}
void NEWARRAY(string []array, int k)// новый массив
{    string[] array1=new string[k];
     int p=0;
     for (int i=0;i<array.Length;i++)
     { if (array[i].Length<=3)
       {
       array1[p]=array[i];
       p++; 
       }
     }
     PRINTARRAY(array1);
}
int K=LENGTHARRAY(array);
NEWARRAY(array,K);