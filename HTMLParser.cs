public class HTMLParser
{
    readonly MyArrayList<string> tagsArray = new MyArrayList<string>();
    public MyArrayList<string> Parse(string[] input)
    {
        foreach (string item in input)
        {
            foreach (string element in item.Split('<'))
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