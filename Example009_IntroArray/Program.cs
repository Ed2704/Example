int Max(int arg1, int arg2, int arg3)
{
    int result=arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}
//              0  1  2  3  4  5  6  7  8
int [] array ={12,22,63,54,15,86,37,18,29};
array[0]=15;
Console.WriteLine(array[0] + array[1]);

