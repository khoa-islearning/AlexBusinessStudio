using System.ComponentModel.DataAnnotations;

namespace AlexBusinessStudio.Data
{
    public class PhotoModel
    {
        public int Id;
        public String Name;
        public int x = 1920;
        public int y = 1600;
        public String Note;
        public DateTime Date = DateTime.Now;
        public String Link;
        public String[] TagList = new string[] { "Animal", "Nature" };
    }
}
public class SearchArg
{
    public int sort { get; set; }
    public bool[] status { get; set; }
    public DateTime start { get; set; }
    public DateTime end { get; set; }
    public string[] tagList { get; set; }

    public string searchString { get; set; }
    public SearchArg(int s, bool[] sta, DateTime st, DateTime e,string se, string[] t)
    {
        sort = s;
        status = sta;
        start = st;
        end = e;
        searchString = se;
        tagList = t;
    }
}

public class ListingSearchArg
{
    public int sort { get; set; }
    public bool[] status { get; set; }
    public DateTime start { get; set; }
    public DateTime end { get; set; }
    public string[] tagList { get; set; }
    public string searchString { get; set; }
    public int min { get; set; }
    public int max { get; set; }

    public ListingSearchArg(int s, bool[] sta, DateTime st, DateTime e,string se, string[] t, int min, int max)
    {
        sort = s;
        status = sta;
        start = st;
        end = e;
        searchString = se;
        tagList = t;
        this.min = min;
        this.max = max;
    }
}

public class HistorySearchArg
{
    public int sort { get; set; }
    public DateTime start { get; set; }
    public DateTime end { get; set; }
    public string searchString { get; set; }
    public int min { get; set; }
    public int max { get; set; }

    public HistorySearchArg(int s, DateTime st, DateTime e,string se,  int min, int max)
    {
        sort = s;
        start = st;
        end = e;
        searchString = se;
        this.min = min;
        this.max = max; 
    }
}

public class SaleHistory
{
    public int OrdNumber { get; set; }
    public String CustName { get; set; }
    public DateTime Date { get; set; }
    public int[] PhotoList { get; set; }

    public int Sum { get; set; }
}