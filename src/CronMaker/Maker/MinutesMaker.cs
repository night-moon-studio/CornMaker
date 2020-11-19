using System.Text;
public partial class CronMaker
{

    private readonly StringBuilder _minutes = new StringBuilder();


    /// <summary>
    /// 任意分钟都执行
    /// </summary>
    /// <returns></returns>
    public CronMaker AnyMinutes()
    {

        _minutes.Clear();
        _minutes.Append("*");
        return this;

    }




    /// <summary>
    /// 设置周期分钟
    /// </summary>
    /// <param name="startMinutes">在第几分钟开始运行</param>
    /// <param name="minutesInterval">以后每隔几分钟运行</param>
    /// <returns></returns>
    public CronMaker IntervalMinutes(int startMinutes, int minutesInterval)
    {
        if (_minutes.Length>0)
        {
            _minutes.Append(',');
        }
        _minutes.Append($"{startMinutes}/{minutesInterval}");
        return this;

    }




    /// <summary>
    /// 设置第几分钟工作
    /// </summary>
    /// <param name="minutes">在第t1、t2、t3....时开始工作</param>
    /// <returns></returns>
    public CronMaker AtMinutes(params int[] minutes)
    {

        if (minutes != null && minutes.Length > 0)
        {
            if (_minutes.Length > 0)
            {
                _minutes.Append(',');
            }
            _minutes.Append(string.Join(",", minutes));
        }
        return this;

    }




    /// <summary>
    /// 在分钟范围内每分都工作
    /// </summary>
    /// <param name="startMinutes">起始分钟数</param>
    /// <param name="endMinutes">截止分钟数</param>
    /// <returns></returns>
    public CronMaker RangeMinutes(int startMinutes, int endMinutes)
    {

        if (_minutes.Length > 0)
        {
            _minutes.Append(',');
        }
        _minutes.Append($"{startMinutes}-{endMinutes}");
        return this;

    }
}
