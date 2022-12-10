System.Console.WriteLine("Введите значение k1");
double k1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите значение b1");
double b1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите значение k2");
double k2 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите значение b2");
double b2 = double.Parse(Console.ReadLine());

void Intersection(double k1,double b1, double k2, double b2){
    if((k1==k2) &&(b1==b2)) System.Console.WriteLine("Прямые совпадают");
    else if (k1==k2) System.Console.WriteLine("Прямые параллельны");
    else{
   double x =(b2-b1)/(k1-k2);
   
   double y =(k1*(b2-b1))/(k1-k2)+b1;
    System.Console.WriteLine(x+" ; "+y);
}
}
Intersection(k1,b1,k2,b2);