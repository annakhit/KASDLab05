public class HTMLParser
{
    readonly MyArrayList<string> tagsArray = new MyArrayList<string>();
    public MyArrayList<string> Parse(string[] rows)
    {
        foreach (string row in rows)
        {
            foreach (string element in row.Split('<'))
            {
                if (element.IndexOf('>', 0) != -1)
                {
                    string tag = element.ToLower().Substring(0, element.IndexOf('>', 0)).Replace("/", "");
                    if (!tagsArray.Contains(tag)) tagsArray.AddElement(tag);
                }
            }
        }

        return tagsArray;
    }
}