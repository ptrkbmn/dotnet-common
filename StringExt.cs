namespace pbdev.Common
{
  public static class StringExt
  {
    public static string ToUpperInvariantFirst(this string s)
    {
      if (String.IsNullOrEmpty(s)) return String.Empty;
      return Char.ToUpperInvariant(s[0]) + s.Substring(1);
    }
  }
}