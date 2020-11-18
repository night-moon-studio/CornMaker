using System.Text;
public partial class CornMaker
{

    private readonly StringBuilder _days = new StringBuilder();


    /// <summary>
    /// 离第几号最近的工作日
    /// </summary>
    /// <param name="day">第几日</param>
    /// <returns></returns>
    public CornHelper WorkDays(int day)
    {

        if (_days.Length>0)
        {
            _days.Append(',');
        }
        _days.Append(day + "W");
        return this;

    }




    /// <summary>
    /// 任意日都执行
    /// </summary>
    /// <returns></returns>
    public CornHelper AnyDays()
    {
        _days.Clear();
        _days.Append("*");
        return this;

    }




    /// <summary>
    /// 最后一天
    /// </summary>
    /// <returns></returns>
    public CornHelper AtMonthOfLastDays()
    {
        if (_days.Length > 0)
        {
            _days.Append(',');
        }
        _days.Append("L");
        return this;
    }




    /// <summary>
    /// 设置周期日
    /// </summary>
    /// <param name="startDays">在第几日开始运行</param>
    /// <param name="daysInterval">以后每隔几日运行</param>
    /// <returns></returns>
    public CornHelper IntervalDays(int startDays, int daysInterval)
    {
        if (_days.Length > 0)
        {
            _days.Append(',');
        }
        _days.Append($"{startDays}/{daysInterval}");
        return this;

    }




    /// <summary>
    /// 设置第几日工作
    /// </summary>
    /// <param name="days">在第t1、t2、t3....时开始工作</param>
    /// <returns></returns>
    public CornHelper AtDays(params int[] days)
    {

        if (days != null && days.Length > 0)
        {
            if (_days.Length > 0)
            {
                _days.Append(',');
            }
            _days.Append(string.Join(',', days));
        }
        return this;

    }




    /// <summary>
    /// 在日范围内每日都工作
    /// </summary>
    /// <param name="startDays">起始日数</param>
    /// <param name="endDays">截止日数</param>
    /// <returns></returns>
    public CornHelper RangeDays(int startDays, int endDays)
    {

        if (_days.Length > 0)
        {
            _days.Append(',');
        }
        _days.Append($"{startDays}-{endDays}");
        return this;

    }


}
