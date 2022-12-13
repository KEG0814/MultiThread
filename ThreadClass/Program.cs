// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//파라미터가 없는 ThreadStart() 사용
Thread thread1 = new Thread(new ThreadStart(Run));
thread1.Start();


//ParameterizedThreadStart() 파라미터 전달.
//Start()의 파라미터로 radius 전달.
Thread threadd2 = new Thread(new ParameterizedThreadStart(Calc));
threadd2.Start(10.0);


//TreadStart 에서 파라미터 전달.
Thread thread3 = new Thread(() => Sum(10, 20, 30));
thread3.Start();



static void Run()
{

    Console.WriteLine($"Run,{Thread.CurrentThread.ManagedThreadId}");
}

static void Calc(object? radius)
{
    if (radius == null)
        return;

    var r = (double)radius;

    var area = 3.14 * r * r;

    Console.WriteLine($"r = {r}, Area = {area} , {Thread.CurrentThread.ManagedThreadId}");
}

static void Sum(int i, int j, int k)
{
    int sum = i + j + k;
    Console.WriteLine($"Sum = {i} + {j} + {k} = {sum}    , {Thread.CurrentThread.ManagedThreadId}");
}

