// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3.
string[] array= new string[] {"one", "two", "three", "four", "five", "six"}; 

 int j=0;
string[] empty = new string[array.Length]  ; 

 for(int i = 0; i<array.Length ; i++ )
 {
     if(array[i].Length <= 3)  
         {
             //Array.Resize(ref empty, empty.Length +1);
           empty[j] = array[i] ;
             
              j++;
           Array.Resize(ref empty, j+1);
          Console.Write($" {empty[j-1]}");
        
         } 
 }

//                         ВАРИАНТ 2

//   string[] array= new string[] {"one", "two", "three", "four", "five", "six"}; 

//  int j=0;
// string[] empty = new string[1]  ; 

//  for(int i = 0; i<array.Length ; i++ )
//  {
//      if(array[i].Length <= 3)  
//          {
             
//            empty[j] = array[i] ;
             
//               j++;
//            Array.Resize(ref empty, empty.Length +1);
//           Console.Write($" {empty[j-1]}");
        
//          } 
//  }                        