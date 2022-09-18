int [] array ={2,5,3,556,2355,52,354,3,97,282,54};

int n = array.Length;
int find = 3;
int index=0;

while(index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}