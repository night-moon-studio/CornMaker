using System.Text;


public partial class CornMaker
{ 
    public static CornMaker Create()
    {
        return new CornMaker();
    }


    /// <summary>
    /// 获取 Corn 表达式
    /// </summary>
    /// <returns></returns>
    public string GetCornScript()
    {

        StringBuilder script = new StringBuilder();
        script.Append($"{(_seconds.Length == 0 ? "*" : _seconds.ToString())} ");
        script.Append($"{(_minutes.Length == 0 ? "*" : _minutes.ToString())} ");
        script.Append($"{(_hours.Length == 0 ? "*" : _hours.ToString())} ");
        if (_week.Length>0)
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

}

