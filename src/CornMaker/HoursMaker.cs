using System.Text;
public partial class CornMaker
{

    private readonly StringBuilder _hours = new StringBuilder();

    /// <summary>
    /// 任意小时都执行
    /// </summary>
    /// <returns></returns>
    public CornMaker AnyHours()
    {

        _hours.Clear();
        _hours.Append("*");
        return this;

    }




    /// <summary>
    /// 设置周期小时
    /// </summary>
    /// <param name="startHours">在第几小时开始运行</param>
    /// <param name="hoursInterval">以后每隔几小时运行</param>
    /// <returns></returns>
    public CornMaker IntervalHours(int startHours, int hoursInterval)
    {
        if (_hours.Length>0)
        {
            _hours.Append(',');
        }
        _hours.Append($"{startHours}/{hoursInterval}");
        return this;

    }




    /// <summary>
    /// 设置第几小时工作
    /// </summary>
    /// <param name="hours">在第t1、t2、t3....小时时开始工作</param>
    /// <returns></returns>
    public CornMaker AtHours(params int[] hours)
    {

        if (hours != null && hours.Length > 0)
        {
            if (_hours.Length > 0)
            {
                _hours.Append(',');
            }
            _hours.Append(string.Join(",", hours));
        }
        return this;

    }




    /// <summary>
    /// 在小时范围内每小时都工作
    /// </summary>
    /// <param name="startHours">起始小时数</param>
    /// <param name="endHours">截止小时数</param>
    /// <returns></returns>
    public CornMaker RangeHours(int startHours, int endHours)
    {

        if (_hours.Length > 0)
        {
            _hours.Append(',');
        }
        _hours.Append($"{startHours}-{endHours}");
        return this;

    }
}
