using System;
using System.Text;


public partial class CronMaker
{
    public static CronMaker Create()
    {
        return new CronMaker();
    }



    public CronMaker GetFromDateTime(DateTime dateTime)
    {

        AtSeconds(dateTime.Second)
        .AtMinutes(dateTime.Minute)
        .AtHours(dateTime.Hour)
        .AtDays(dateTime.Day)
        .AtMonth(dateTime.Month);
        return this;

    }




    /// <summary>
    /// 获取 Cron 表达式
    /// </summary>
    /// <returns></returns>
    public string GetCronScript()
    {

        StringBuilder script = new StringBuilder();
        script.Append($"{(_seconds.Length == 0 ? "*" : _seconds.ToString())} ");
        script.Append($"{(_minutes.Length == 0 ? "*" : _minutes.ToString())} ");
        script.Append($"{(_hours.Length == 0 ? "*" : _hours.ToString())} ");
        if (_week.Length > 0)
        {
            script.Append($"? ");
            script.Append($"{(_month.Length == 0 ? "*" : _month.ToString())} ");
            script.Append($"{(_week.Length == 0 ? "*" : _month.ToString())} ");
        }
        else
        {
            script.Append($"{(_days.Length == 0 ? "*" : _days.ToString())} ");
            script.Append($"{(_month.Length == 0 ? "*" : _month.ToString())} ");
            script.Append($"? ");
        }
        script.Append($"{(_year.Length == 0 ? "" : _year.ToString())}");
        return script.ToString();


    }
    public void Clear()
    {
        _days.Clear();
        _hours.Clear();
        _minutes.Clear();
        _month.Clear();
        _seconds.Clear();
        _week.Clear();
        _year.Clear();
    }
}

