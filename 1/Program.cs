string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

int [] array1 = Transformation(st);

System.Console.WriteLine(String.Join(",",array1));

Count(array1);

int [] Transformation (string [] array){
    int [] trans = new int [array.Length];
    for (int i=0; i<array.Length; i++){
        trans[i]=int.Parse(array[i]);
    }
    return trans;
}

void Count(int [] array){
    int count = 0;
    for (int i=0; i<array.Length; i++){
        if (array[i]>0) count++;
    }
    System.Console.WriteLine(count);
}