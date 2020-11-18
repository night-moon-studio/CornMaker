using System.Text;
public partial class CornMaker
{

    private readonly StringBuilder _seconds = new StringBuilder();


    /// <summary>
    /// 任意秒都执行
    /// </summary>
    /// <returns></returns>
    public CornMaker AnySeconds()
    {

        _seconds.Clear();
        _seconds.Append("*");
        return this;

    }




    /// <summary>
    /// 设置周期秒
    /// </summary>
    /// <param name="startSeconds">在第几秒开始运行</param>
    /// <param name="secondsInterval">以后每隔几秒运行</param>
    /// <returns></returns>
    public CornMaker IntervalSeconds(int startSeconds, int secondsInterval)
    {
        if (_seconds.Length>0)
        {
            _seconds.Append(',');
        }
        _seconds.Append($"{startSeconds}/{secondsInterval}");
        return this;

    }




    /// <summary>
    /// 设置第几秒工作
    /// </summary>
    /// <param name="seconds">在第t1、t2、t3....秒时开始工作</param>
    /// <returns></returns>
    public CornMaker AtSeconds(params int[] seconds)
    {

        if (seconds != null && seconds.Length > 0)
        {
            if (_seconds.Length > 0)
            {
                _seconds.Append(',');
            }
            _seconds.Append(string.Join(",", seconds));
        }
        return this;

    }




    /// <summary>
    /// 在秒范围内每秒都工作
    /// </summary>
    /// <param name="startSeconds">起始秒数</param>
    /// <param name="endSeconds">截止秒数</param>
    /// <returns></returns>
    public CornMaker RangeSeconds(int startSeconds, int endSeconds)
    {

        if (_seconds.Length > 0)
        {
            _seconds.Append(',');
        }
        _seconds.Append($"{startSeconds}-{endSeconds}");
        return this;

    }
}
