// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3.
string[] array= new string[] {"one", "two", "three", "four", "five"}; 

// string[] empty = new string[5]  ; 

// int i;
// int j;

//  for( i = 0; i<array.Length ; i++ )
//  {
//      for ( j = 0; array[i].Length <=3; j++)   Я не понимаю как заполнить пустой массив((((
    //      {
//          empty[j] = array[i];
//      } 
     
//       empty[j] =
//     Console.WriteLine(empty[j]);
//  }


 for(int i = 0; i<array.Length ; i++ )
 {
     if(array[i].Length <= 3)
     {
        Console.Write($" {array[i]}"); 
     }

 }