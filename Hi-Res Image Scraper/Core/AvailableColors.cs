using System.Collections.Generic;
using HtmlAgilityPack;

namespace HiResImageScraper
{
  internal class AvailableColors
  {
    private string styleNumber;
    private string url;

    internal AvailableColors(string styleNumber)
    {
      this.styleNumber = styleNumber;
      url = "http://www.americanapparel.net/wholesaleresources/ExpressOrder/Catalog/Product.aspx?s=" + this.styleNumber;
    }

    internal List<string> List
    {
      get
      {
        return GetColorList();
      }
    }

    private List<string> GetColorList()
    {
      List<string> result = new List<string>();
      var htmlDocument = new HtmlDocument();
      htmlDocument = new HtmlWeb().Load(url);
      foreach (HtmlNode colorBoxDiv in htmlDocument.DocumentNode.SelectNodes("//div[@class='colorBox']"))
      {
        foreach (HtmlAttribute attribute in colorBoxDiv.Attributes)
        {
          if (attribute.Name == "onclick")
          {
            result.Add(ParseColor(attribute.Value));
          }
        }
      }

      return result;
    }

    private string ParseColor(string color)
    {
      int start = color.IndexOf("', '") + 4;
      color = color.Substring(start);
      int end = color.IndexOf("');");
      color = color.Substring(0, end);
      return color;
    }
  }
}
