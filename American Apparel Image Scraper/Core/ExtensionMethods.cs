namespace HiResImageScraper
{
  public static class ExtensionMethods
  {
    public static string CleanColorName(this string originalColor)
    {
      string result = originalColor.Replace(" / ", "_");
      result = originalColor.Replace("/", "_");
      return result;
    }
  }
}
