int Max(int arg1, int arg2, int arg3)
{
    int result=arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}


int a1=10;
int b1=12;
int c1=5555;
int a2=14;
int b2=25;
int c2=8;
int a3=444444;
int b3=55;
int c3=18;

//int max1=Max(a1,b1,c1);
//int max2=Max(a2,b2,c2);
//int max3=Max(a3,b3,c3);

int maximum=Max(Max(a1,b1,c1), 
            Max(a2,b2,c2),
            Max(a3,b3,c3));
Console.WriteLine(maximum);

