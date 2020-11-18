using System.Text;
public partial class CornMaker
{

    private readonly StringBuilder _month = new StringBuilder();


    /// <summary>
    /// 任意月都执行
    /// </summary>
    /// <returns></returns>
    public CornHelper AnyMonth()
    {

        _month.Clear();
        _month.Append("*");
        return this;

    }




    /// <summary>
    /// 设置周期月
    /// </summary>
    /// <param name="startMonth">在第几月开始运行</param>
    /// <param name="monthInterval">以后每隔几月运行</param>
    /// <returns></returns>
    public CornHelper IntervalMonth(int startMonth, int monthInterval)
    {
        if (_month.Length>0)
        {
            _month.Append(',');
        }
        _month.Append($"{startMonth}/{monthInterval}");
        return this;

    }




    /// <summary>
    /// 设置第几月工作
    /// </summary>
    /// <param name="month">在第t1、t2、t3....分钟时开始工作</param>
    /// <returns></returns>
    public CornHelper AtMonth(params int[] month)
    {

        if (month != null && month.Length > 0)
        {
            if (_month.Length > 0)
            {
                _month.Append(',');
            }
            _month.Append(string.Join(',', month));
        }
        return this;

    }




    /// <summary>
    /// 在月范围内每分都工作
    /// </summary>
    /// <param name="startMonth">起始月数</param>
    /// <param name="endMonth">截止月数</param>
    /// <returns></returns>
    public CornHelper RangeMonth(int startMonth, int endMonth)
    {

        if (_month.Length > 0)
        {
            _month.Append(',');
        }
        _month.Append($"{startMonth}-{endMonth}");
        return this;

    }
}
