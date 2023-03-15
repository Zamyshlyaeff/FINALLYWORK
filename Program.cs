string [] array={"ZADA", "NIE", "1234"};

int LENGTHARRAY (string[] arr)    //определение длины нового массива
{ int k=0;
  for(int i=0;i<array.Length;i++)
  {  if (array[i].Length<=3) k++;
    
  }
  return k;
}
void PRINTARRAY(string[]array)
{   System.Console.Write("[");
    for (int i=0;i<array.Length-1;i++)
{
    Console.Write($"{array[i]},");
}
System.Console.Write("]");
}
LENGTHARRAY(array);