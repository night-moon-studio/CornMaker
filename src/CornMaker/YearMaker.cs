using System.Text;
public partial class CornMaker
{

    private readonly StringBuilder _year = new StringBuilder();


    /// <summary>
    /// 任意年都执行
    /// </summary>
    /// <returns></returns>
    public CornHelper AnyYear()
    {

        _year.Clear();
        _year.Append("*");
        return this;

    }




    /// <summary>
    /// 设置周期年
    /// </summary>
    /// <param name="startYear">在第几年开始运行</param>
    /// <param name="yearInterval">以后每隔几年运行</param>
    /// <returns></returns>
    public CornHelper IntervalYear(int startYear, int yearInterval)
    {
        if (_year.Length>0)
        {
            _year.Append(',');
        }
        _year.Append($"{startYear}/{yearInterval}");
        return this;

    }




    /// <summary>
    /// 设置第几年工作
    /// </summary>
    /// <param name="year">在第t1、t2、t3....年时开始工作</param>
    /// <returns></returns>
    public CornHelper AtYear(params int[] year)
    {

        if (year != null && year.Length > 0)
        {
            if (_year.Length > 0)
            {
                _year.Append(',');
            }
            _year.Append(string.Join(',', year));
        }
        return this;

    }




    /// <summary>
    /// 在年范围内每分都工作
    /// </summary>
    /// <param name="startYear">起始年数</param>
    /// <param name="endYear">截止年数</param>
    /// <returns></returns>
    public CornHelper RangeYear(int startYear, int endYear)
    {

        if (_year.Length > 0)
        {
            _year.Append(',');
        }
        _year.Append($"{startYear}-{endYear}");
        return this;

    }
}
