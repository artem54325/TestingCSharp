namespace TestingCSharp.ВопросыСобеседования;

public class VolaliteTest
{
    // volatile int _firstBool;
    // volatile int _secondBool;
    // volatile string _firstString;
    // volatile string _secondString;
    int _firstBool;
    int _secondBool;
    string _firstString;
    string _secondString;

    int _okCount;
    int _failCount;

    public static void Start()
    {
        long gg = 123;
        AutoResetEvent evt = new AutoResetEvent(false);
        evt.Set();
        evt.WaitOne();
        ManualResetEventSlim manualResetEvent = new ManualResetEventSlim(false);
        manualResetEvent.Set();
        manualResetEvent.Reset();
        new VolaliteTest().Go();
    }

    private void Go()
    {
           
        while (true)
        {
            Parallel.Invoke(DoThreadA, DoThreadB);
            if (_firstString == null && _secondString == null)
            {
                _failCount++;
            }
            else
            {
                _okCount++;
            }
            Console.WriteLine("ok - {0}, fail - {1}, fail percent - {2}",  
                _okCount, _failCount, GetFailPercent());

            // Clear();
        }
    }

    private float GetFailPercent()
    {
        return (float)_failCount / (_okCount + _failCount) * 100;
    }

    private void Clear()
    {
        _firstBool = 0;
        _secondBool = 0;
        _firstString = null;
        _secondString = null;
    }

    private void DoThreadA()
    {
        _firstBool = 1;
        //Thread.MemoryBarrier();
        if (_secondBool == 1)
        {
            _firstString = "a";
        }
    }

    private void DoThreadB()
    {
        _secondBool = 1;
        //Thread.MemoryBarrier();
        if (_firstBool == 1)
        {
            _secondString = "a";
        }
    }

}