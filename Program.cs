string [] array={"ZADA", "NIE", "1234"};

int PRINTARRAY (string[] arr)    //определение длины нового массива
{ int k=0;
  for(int i=0;i<array.Length;i++)
  {  if (array[i].Length<=3) k++;
    
  }
  return k;
}

PRINTARRAY(array);