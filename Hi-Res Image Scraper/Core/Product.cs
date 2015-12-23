using System.Collections.Generic;

namespace HiResImageScraper
{
  internal class Product
  {
    private string styleNumber;
    private bool isWomensUnisex;

    internal Product(string styleNumber, bool isWomensUnisex)
    {
      this.styleNumber = styleNumber;
      this.isWomensUnisex = isWomensUnisex;
    }

    internal List<Image> Images
    {
      get
      {
        return PopulateImageDetails();
      }
    }

    private List<Image> PopulateImageDetails()
    {
      List<Image> result = new List<Image>();
      List<string> colorList = new AvailableColors(styleNumber).List;
      foreach (string color in colorList)
      {
        string link = "http://i.americanapparel.net/storefront/photos/zoom/serve.asp?media=";
        link += styleNumber;
        link += isWomensUnisex ? "w_" : "_";
        link += color.CleanColorName() + ".jpg";
        result.Add(new Image(color, styleNumber, link));
      }

      return result;
    }
  }
}
