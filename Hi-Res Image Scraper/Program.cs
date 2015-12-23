using System;

namespace HiResImageScraper
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //// **********************************************************************
      //// Change these settings before running the application:
      //// **********************************************************************

      string baseDirectory = @"C:\Directory\To\Save\Image\Files\";
      var productType = ProductType.Standard;

      //// **********************************************************************

      string styleNumber = RequestStyleNumber();
      while (styleNumber != "q")
      {
        new HiResImageScraper(styleNumber, baseDirectory, productType).DownloadAll();
        styleNumber = RequestStyleNumber();
      }
    }

    private static string RequestStyleNumber()
    {
      Console.Write("Enter an American Apparel style number or type 'q' to exit: ");
      return Console.ReadLine();
    }
  }
}
