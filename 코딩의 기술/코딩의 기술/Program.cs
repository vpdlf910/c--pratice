// See https://aka.ms/new-console-template for more information

//1장 1부 var사용에 관한 고민

//잘못된 방법

//class Program
//{
//    static void Main(string[] args)
//    {
//        Dictionary<string, Action<TextWriter>> dic = new Dictionary<string, Action<TextWriter>>();
//        dic.Add("Sample1", (writer) => { writer.WriteLine("I'm sample1"); });
//        dic.Add("Sample2", (writer) => { writer.WriteLine( "I'm sample2"); });
//        foreach (var item in dic.Values) item(Console.Out);

//        Console.WriteLine(dic["Sample1"]);
//        Console.WriteLine(Console.Out);
/// <summary>
/// /var를 이용하는 방법
/// c#에서는 선언된 형이 유지된다.
/// </summary>
//        var dic1 = new Dictionary<string, Action<TextWriter>>();
//        dic1.Add("sample1", (writer) => { writer.WriteLine(); });
//        dic1.Add("sample2", (writer) => { writer.WriteLine(); });
//        foreach (var item in dic.Values) item(Console.Out);


//    }
//}
///1장 2부 if와 switch에 관한 오해
/// case를 이용하여 식을 하나로 줄여 버그를 줄일 수 있다.
/// 다른 프로그래밍 언어에 경우 break가 없어도 오류가 뜨지 않고
/// 제어이동(case를 하고 바로 다음 case로 이동해서 true 검증)을 실행 하게 된다.
/// c#은 불가능
///

//class Program
//{
//static void convert(ref string color)
//{
//    if (color == "Red") color = "빨강";
//    else if (color == "Green") color = "초록";
//    else if (color == "Blue") color = "파랑";
//    else color = "알 수 없는 색";
//}
//static void Main(string[] args)
//{
//    string s = "Red";
//    convert(ref s);
//    Console.WriteLine(s);
//}

//    static void convert(ref string color)
//    {
//        switch (color) 
//        {
//            case "Red": color = "빨강"; break;
//            case "Green": color = "초록"; break;
//            case "Blue": color = "파랑"; break;

//            default: color = "알 수 없는 색"; break;
//        }
//    }

//    static void Main(string[] args)
//    {
//        string s = "Red";
//        convert(ref s);
//        Console.WriteLine(s);
//    }
//}
///1장 3부  for와 foreach에 관한 오해
///
//class Program
//{
//static void Main(string[] args)
//{
//    var heavyQuery = Enumerable.Range(0, 10).Where(c =>
//    {
//        Task.Delay(1000).Wait();
//        return true;

//    });
//    var start = DateTime.Now;
//    //for문의 인덱스를 사용하기에 속도가 상당히 느리다
//    for (int i = 0; i < heavyQuery.Count(); i++)
//    {
//        Console.Write(heavyQuery.ElementAt(i));
//    }
//    Console.WriteLine("소요시간:{0}", DateTime.Now-start);

//}
///인덱스를 제거하여 속도가 더 빠르다
//    static void Main(string[] args)
//    {
//        var heavyQuery = Enumerable.Range(0, 10).Where(c =>
//        {
//            Task.Delay(1000).Wait();
//            return true;
//        });
//        var start = DateTime.Now;
//        var enumerator = heavyQuery.GetEnumerator();
//        for(; enumerator.MoveNext();)
//        {
//            Console.Write(enumerator.Current);
//        }
//        Console.WriteLine("소요시간:{0}", DateTime.Now - start);
//    }

//   static void Main(string[] args)
//    {
//        var heavyQuery = Enumerable.Range(0, 10).Where(c =>
//        {
//            Task.Delay(1000).Wait();
//            return true;
//        });
//        var start = DateTime.Now;
//        foreach(var item in heavyQuery)
//        {
//            Console.WriteLine(item);
//        }
//        Console.WriteLine("소요시간: {0}", DateTime.Now -start);
//    }
//}

//1장 4부 while을 이용한 조건 판정
//while은 반복을 처리하기 위한 것이기 때문에 break가 오작동을 할 수 있다.
//class Program
//{
//    static void Main(string[] args)
//    {
//int a = 1;
//while (a==1)
//{
//    int b = a *2;
//    if (b > 0) break;
//    Console.WriteLine(b);

//}
//Console.WriteLine("All done");
//if 문을 조합해서 조건에 만족하지 않을 경우 실행하지 않게 만들어서 해결 가능하다.
//        int a = 1;
//        if(a == 1) {

//            int b = a* 2;
//            if (b <=0) Console.WriteLine(b);

//        }
//        Console.WriteLine("All done");


//    }
//}
/// 1장 5부 do는 유용하지만 잘 사용하지 않는다.
//do 를 사용하지 않게 되면 while을 위한 or를 통해 최소 한 번 발생되도록 만들 수 있지만 불필요
//class Program
//{
//    private static void sample(int a)
//    {
//        bool first = true;
//        while(a >= 0 || first)
//        {
//            Console.WriteLine(a--);
//            first = false;
//        }
//    }
//    static void Main(string[] args)
//    {
//        sample(9);
//        sample(-1);
//    }
////do를 사용하여 간결하게 최초 실행을 일으킬 수 있다.
//    private static void sample(int a)
//    {
//        do
//        {
//            Console.Write(a--);
//        }
//        while (a >= 0);
//    }
//    static void Main(string[] args)
//    {
//        sample(9);
//        sample(-1);
//    }
//}

//1장 6부 루프할 필요가 없는 루프
///조건에 만족하는 가장 첫 번째 값을 얻기 위한 방법 
///


//class Program 
//{
//static void Main(string[] args)
//{
//    int[] array = { 1, -1, 2, -2, 3 };
//    foreach (var item in array)
//    {
//        if(item <0)
//        {
//            Console.WriteLine(item);
//            break;
//        }
//    }
//}
//    static void Main(string[] args)
//    {
//        int[] array = { 1, -1, 2, -2, 3 };
//        Console.WriteLine(array.FirstOrDefault(c => c < 0));

//        //두번째로 조건에 만족하는 값을 알고 싶다면
//        Console.WriteLine(array.Where(c => c < 0).ElementAt(1));
//    }

//}
//1장 7부 장황한 비동기 루프
//스레드를 추가로 사용하지 않고 비동기로 작동시키는 루프
//class Program
//{
//    class countDownWrapper
//    {
//        public AutoResetEvent Done = new AutoResetEvent(false);
//        private int count = 9;
//        public void CountDown()
//        {
//            Console.WriteLine(count--);
//            if (count >= 0) Task.Delay(1000).ContinueWith((c) => { CountDown(); });
//            else Done.Set();
//        }
//    }
//    static void Main(string[] args)
//    {
//        var a = new countDownWrapper();
//        var b = new countDownWrapper();
//        a.CountDown();
//        b.CountDown();
//        AutoResetEvent.WaitAll(new[] { a.Done, b.Done });
//    }
//}
//class Program
//{
//    private static async Task CountDown()
//    {
//        for(int i = 9; i >= 0; i--)
//        {
//            Console.WriteLine(i);
//            await Task.Delay(1000);
//        }
//    }

//    static void Main(string[] args)
//    {
//        var a = CountDown();
//        var b = CountDown();
//        Task.WaitAll(a, b);
//    }
//}

// 1장 8부 해제되지 않는 참조
//메모리 부족이 발생될 때 하드디스크를 사용하지 않고 필요없는 객체를 회수하는 방법

//class SimpleSum
//{
//    private int[] array;
//    private int sum;

//    private void calc()
//    {
//        sum = array.Sum();
//    }
//    public SimpleSum(int max)
//    {
//        array = Enumerable.Range(0, max).ToArray();
//        calc();
//        //array = null;
//        //배열이 계속 살아 있으면 거기에 메모리를 잡아먹기에 calc가 끝나면 배열을 삭제 갈비지 컬렉터가 없애줌

//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        var list = new List<SimpleSum>();
//        for( int i = 0; i <100000; i++)
//        {
//            list.Add(new SimpleSum(100000));
//        }
//    }
//}

//1장 9부 해제했다고 생각한 메모리
//1장 8부와 달리 계속 필요한 배열을 남기는 남기면서 메모리 효율화 => 열거객체로 만든다.

//class SimpleSum
//{
//    public Func<int> GetSum;
//    public SimpleSum(int max)
//    {
//        int[] array = Enumerable.Range(0, max).ToArray();
//        GetSum = () =>
//        {
//            return array.Sum();
//        };
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        var list = new List<SimpleSum>();
//        for(int i = 0; i < 100000; i++)
//        {
//            list.Add(new SimpleSum(100000));
//        }
//    }
//}
//Enumerable 객체는 배열에 모든 값이 들어가 있는 것이 아닌 각각의 값을 반복해서 가져오는 객체이다.
//class SimpleSum
//{
//    public Func<int> GetSum;
//    public SimpleSum(int max)
//    {
//        IEnumerable<int> array = Enumerable.Range(0, max);
//        GetSum = () =>
//        {
//            return enumAll.Sum();
//        };
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        var list = new List<SimpleSum>();
//        for(int i = 0; i < 100000; i++)
//        {
//            list.Add(new SimpleSum(100000));
// }
//    }
//}
//1장 10부 표현력이 과장된 형
//에러가 발생할 때 그 의미를 알기가 어렵기에 포괄적인 방법을 줄여 에러의 원인을 확인하는 방법
//class Submarine
//{
//    public int Males { get; private set; }
//    public Submarine(int n)
//    {
//        Males =n;
//    }
//}
//class Cruiser
//{
//    public int Males { get; private set; }
//    public int Females { get; private set; }
//    public Cruiser(int m , int f)
//    {
//        Males = m;
//        Females = f;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        object[] list = { new Submarine(30), new Cruiser(10, 20) };
//        int sum = 0;
//        foreach(dynamic item in list)
//        {
//            sum += item.Females;
//        }
//        Console.WriteLine("Males in ships are" +sum);
//    }
//}
//class BaseShip
//{
//    public int Males { get; protected set; }
//}
//class Submarine : BaseShip
//{
//    public Submarine(int n)
//    {
//        Males = n;
//    }
//}

//class Cruiser : BaseShip
//{
//    public int Females { get; private set; }
//    public Cruiser(int m, int f)
//    {
//        Males = m;
//        Females = f;
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        BaseShip[] list = { new Submarine(30), new Cruiser(10, 20) };
//        int sum = 0;
//        foreach(var item in list)
//        {
//            sum += item.Females;
//        }//당연하게도 에러가 나오는 데 원인은 Baseship에는 여자가 없기에 리스트 안에 들어가지 않게 된다.
//        Console.WriteLine("Makes in ships are" + sum);
//    }
//}
//1장 11부 표현력이 부족한 형
//형변환이 너무 많을 때 이를 줄이기 위한 방법

//class Base
//{

//}
//class Extended : Base
//{
//    public void SayIt()
//    {
//        Console.WriteLine("i am Extended!");
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Base[] array = { new Base(), new Extended()};
//        foreach(var item in array)
//        {
//            if(item is Extended)
//            {
//                ((Extended)item).SayIt();
//            }
//        }
//        //Linq를 이용하여 지정된 형의 데이터만 추출해서 해당 형으로 반환하는 메서드로 사용
//        foreach(var item in array.OfType<Extended>())
//        {
//            item.SayIt();
//        }

//    }
//}

//1장 12부 의미 없는 구조체 사용
//구조체는 작은 데이터를 이용할 때 사용
//struct TenNumbers
//{
//    public double t0, t1, t2, t3, t4, t5, t6, t7, t8, t9;
//}

//class Program
//{
//    private static double calc(TenNumbers t)
//    {
//        return t.t0 + t.t1 + t.t2 + t.t3 + t.t4 + t.t5+ t.t6 + t.t7 + t.t8 + t.t9;
//    }
//    static void Main(string[] args)
//    {

//        var start = DateTime.Now;
//        double sum = 0;
//        for (int i = 0; i <1000000; i++)
//        {
//            sum += calc(new TenNumbers());
//        }
//        Console.WriteLine(sum);
//        Console.WriteLine(DateTime.Now - start);
//    }
//}
//1장 13부 포인터 사용
//c#포인터는 단점이 너무 많아 사용하지 않는다 그냥 잊어버릴 것
//1장 14부 불필요한 형변환 남용
//형변환이 많을 때는 형자체를 제대로 사용하고 있는 지도 확인 할 것
//class Program
//{
//    static void Main(string[] args)
//    {
//        int a = 0x48;
//        int b = 0x65;
//        byte[] array = new byte[8];
//        array[0] = (byte)a;
//        array[1] = (byte)b;
//        array[2] = (byte)0x6c;
//        array[3] = (byte)0x6c;
//        array[4] = (byte)0x6f;
//        array[5] = (byte)0x20;
//        array[6] = (byte)0x43;
//        array[7] = (byte)0x23;
//        for (int i =0; i < array.Length; i++)
//        {
//            Console.WriteLine((char)array[i]);
//        }
//    }
//    //char 데이터를 바이트 단위로 가진 채로 형변화를 해야만 하도록 가지고 있었다.
//    //그냥 char 형태의 데이터로 저장하고 부르는 게 낮다.
//}

//1장 15부 클래스 하나로 증후군

//class Program
//{
//    private static List<string> customers = new List<string>();

//    private static List<string> products = new List<string>();
//    public static void AddCustomer(string customer)
//    {
//        customers.Add(customer);
//    }
//    public static void AddProducts(string product)
//    {
//        products.Add(product);
//    }
//    static void Main(string[] args)
//    {
//        AddCustomer("전세계 슈포 대기업");
//        AddProducts("자동차 엔진 링크스");
//        AddProducts("즉석 라면 순라면");
//    }

//}//서로 연관이 없는 정보들을 하나의 클래스로 묶는 것이 안좋다
////대상 데이터 단위로 클래스를 나누는 것이 좋다.

//class Customer
//{
//    private static List<string> customers = new List<string>();
//    public static void Add(string customer)
//    {
//        customers.Add(customer);
//    }
//}
//class Product
//{
//    private static List<string> products = new List<string>();
//    public static void Add(string product)
//    {
//        products.Add(product);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Customer.Add("전세계 슈퍼 대기업");
//        Product.Add("자동차 엔진 링크스");
//        Product.Add("즉석 라면 순라면");
//    }
//}

//1장 16부 모두 public으로 증후군
//모든 변수가 public으로 되어 있으면 헷갈릴 수가 있기때문에 외부 접근을 차단하는 방식으로 정리가 가능하다.
//class Product
//{
//    ///<summary>
//    ///길이:센티
//    /// </summary>
//    //public double length;
//    private double length;
//    ///<summary>
//    ///길이:인치
//    /// </summary>
//    public double Length
//    {
//        get { return length *2.54; }
//        set { length = value /2.54; }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        var p = new Product();
//        p.Length =1;
//        p.Length = p.Length +1;
//        Console.WriteLine(p.Length);
//만약 length가 public이라면 잘못접근하여 get을 통하지 않고 수를 꺼내오게 되어 잘못된 값을 얻게 된다.

//    }
//}
//1장 17부 모두 static으로 증후군
//static class CWC
//{
//    public static TextWriter Create()
//    {
//        return File.CreateText("sample.txt");
//    }
//    public static void Close(TextWriter writer)
//    {
//        writer.Close();
//    }
//    public static void Write(TextWriter writer)
//    {
//        writer.WriteLine("samole Message");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        var writer = CWC.Create();
//        CWC.Write(writer);
//        CWC.Close(writer);
//    }
//}
//여기서 문제가 되는 것은 static이다 여러 처리를 병렬로 할때 비효율적이다.

//class CWC
//{
//    private TextWriter writer;
//    public void Create()
//    {
//        writer = File.CreateText("sampel.txt");
//    }
//    public void Close()
//    {
//        writer.Close();
//    }
//    public void Write()
//    {
//        writer.WriteLine("samole Message");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        var cwc = new CWC();
//        cwc.Create();
//        cwc.Write();
//        cwc.Close();
//    }
//}
//static을 사용하지 않음으로 인스턴스가 메서드를 실행하고 그 인자를 계속 사용하게 된다.
//굳이 static으로 사용해서 계속 그 대상 writer를 전달해주면서 작동시킬 필요가 없다.