Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
for(int i = 1; i < cube.Length; i++)
    {
    cube[i] = Convert.ToInt32(Math.Pow(i, 3));

    }
}

void PrintArry(int[] coll)
{
    for(int i = 1; i < coll.Length; i++)
    {
          Console.Write(coll[i]+ ",");
    }
}

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);