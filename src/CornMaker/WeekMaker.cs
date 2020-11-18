using System.Text;
public partial class CornMaker
{

    private readonly StringBuilder _week = new StringBuilder();



    /// <summary>
    /// 第几周第几天工作，周日开始
    /// </summary>
    /// <param name="week">第几周</param>
    /// <param name="day">第几日</param>
    /// <returns></returns>
    public CornMaker DayOfWeek(int week,int day)
    {

        if (_week.Length>0)
        {
            _week.Append(',');
        }
        _week.Append($"{day}##{week}");
        return this;

    }




    /// <summary>
    /// 周中每天都执行
    /// </summary>
    /// <returns></returns>
    public CornMaker AnyWeek()
    {

        _week.Clear();
        _week.Append("*");
        return this;

    }




    /// <summary>
    /// 最后一周，第几天，星期日算第一天
    /// </summary>
    /// <returns></returns>
    public CornMaker AtDayOfLastWeek(int weekDay)
    {

        if (_week.Length > 0)
        {
            _week.Append(',');
        }
        _week.Append(weekDay+"L");
        return this;

    }




    /// <summary>
    /// 设置周期运行数
    /// </summary>
    /// <param name="startWeek">在1周中第几天开始运行（周日算第一天）</param>
    /// <param name="weekInterval">每周几运行</param>
    /// <returns></returns>
    public CornMaker IntervalWeek(int startWeek, int weekInterval)
    {

        if (_week.Length > 0)
        {
            _week.Append(',');
        }
        _week.Append($"{startWeek}/{weekInterval}");
        return this;

    }




    /// <summary>
    /// 设置每周中第几天工作，星期日算第1天
    /// </summary>
    /// <param name="week">在每周中第t1、t2、t3....天开始工作</param>
    /// <returns></returns>
    public CornMaker AtWeek(params int[] week)
    {

        if (week != null && week.Length > 0)
        {
            if (_week.Length > 0)
            {
                _week.Append(',');
            }
            _week.Append(string.Join(",", week));
        }
        return this;

    }




    /// <summary>
    /// 在周范围内每周第几天到几天都工作，星期日是第1天
    /// </summary>
    /// <param name="startWeek">起始周天数</param>
    /// <param name="endWeek">截止周天数</param>
    /// <returns></returns>
    public CornMaker RangeWeek(int startWeek, int endWeek)
    {

        if (_week.Length > 0)
        {
            _week.Append(',');
        }
        _week.Append($"{startWeek}-{endWeek}");
        return this;

    }


}
