namespace HiResImageScraper
{
  internal class Image
  {
    internal Image(string color, string styleNumber, string imageLink)
    {
      Color = color;
      StyleNumber = styleNumber;
      ImageLink = imageLink;
    }

    internal string Color { get; private set; }

    internal string StyleNumber { get; private set; }

    internal string ImageLink { get; private set; }
  }
}
