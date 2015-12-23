using System.IO;
using System.Net;

namespace HiResImageScraper
{
  public class HiResImageScraper
  {
    private string styleNumber;
    private bool isWomensUnisex;
    private string baseDirectory;

    public HiResImageScraper(string styleNumber, string baseDirectory, ProductType productType)
    {
      this.styleNumber = styleNumber;
      this.baseDirectory = baseDirectory;
      isWomensUnisex = (productType == ProductType.WomensUnisex) ? true : false;
    }

    public void DownloadAll()
    {
      var product = new Product(styleNumber, isWomensUnisex);
      foreach (Image image in product.Images)
      {
        Download(image);
      }
    }

    private void Download(Image image)
    {
      string path = SetDownloadDirectory();
      string localFilename = path + "AA_" + image.StyleNumber + "_" + image.Color.CleanColorName() + ".jpg";
      WebClient webClient = new WebClient();
      webClient.DownloadFile(image.ImageLink, localFilename);
    }

    private string SetDownloadDirectory()
    {
      string path = baseDirectory + styleNumber;
      path += isWomensUnisex ? "-W\\" : "\\";
      if (!Directory.Exists(path))
      {
        Directory.CreateDirectory(path);
      }

      return path;
    }
  }
}