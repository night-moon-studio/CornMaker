using System;


public class IntervalMaker
{

    private long _current;
    private long _timespan;
    private readonly CronMaker _maker;
    private IntervalMaker(long? timespan = null, long? startTime = null)
    {

        _maker = CronMaker.Create();
        _timespan = timespan.HasValue ? timespan.Value : 0;
        _current = startTime.HasValue ? startTime.Value : DateTime.Now.TimestampSeconds();

    }

    /// <summary>
    /// 时间间隔天数
    /// </summary>
    /// <param name="days">天数</param>
    /// <returns></returns>
    public IntervalMaker Days(long days)
    {
        _timespan += days * 86400;
        return this;
    }




    /// <summary>
    /// 时间间隔小时数
    /// </summary>
    /// <param name="hours">小时数</param>
    /// <returns></returns>
    public IntervalMaker Hours(long hours)
    {
        _timespan += hours * 3600;
        return this;
    }




    /// <summary>
    /// 时间间隔分钟数
    /// </summary>
    /// <param name="minutes">分钟数</param>
    /// <returns></returns>
    public IntervalMaker Minutes(long minutes)
    {
        _timespan += minutes * 60;
        return this;
    }



    /// <summary>
    /// 时间间隔秒数
    /// </summary>
    /// <param name="seconds">秒数</param>
    /// <returns></returns>
    public IntervalMaker Seconds(long seconds)
    {
        _timespan += seconds;
        return this;
    }





    /// <summary>
    /// 获取下一个定时表达式
    /// </summary>
    /// <returns></returns>
    public string NextCron()
    {
        _current += _timespan;
        _maker.Clear();
        return _maker.GetFromDateTime(_current.DateTimeFromSeconds()).GetCronScript();
    }


    public static IntervalMaker Create(long? timespan = null, long? startTime = null)
    {
        return new IntervalMaker(timespan);
    }

}

