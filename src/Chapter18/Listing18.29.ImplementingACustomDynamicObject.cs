namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_29
{
    using System.Dynamic;
    using System.Linq;
    using System.Xml.Linq;

    public class DynamicXml : DynamicObject
    {
        private XElement Element { get; set; }

        public DynamicXml(System.Xml.Linq.XElement element)
        {
            Element = element;
        }

        public static DynamicXml Parse(string text)
        {
            return new DynamicXml(XElement.Parse(text));
        }

        public override bool TryGetMember(
            GetMemberBinder binder, out object? result)
        {
            bool success = false;
            result = null;
            XElement firstDescendant =
                Element.Descendants(binder.Name).First();
            if(firstDescendant != null)
            {
                if(firstDescendant.Descendants().Any())
                {
                    result = new DynamicXml(firstDescendant);
                }
                else
                {
                    result = firstDescendant.Value;
                }
                success = true;
            }
            return success;
        }

        // TODO: Update listing in Manuscript
        public override bool TrySetMember(
            SetMemberBinder binder, object? value)
        {
            bool success = false;
            XElement firstDescendant =
                Element.Descendants(binder.Name).First();
            if(firstDescendant != null)
            {
                if(value?.GetType() == typeof(XElement))
                {
                    firstDescendant.ReplaceWith(value);
                }
                else
                {
                    firstDescendant.Value = value?.ToString() ?? string.Empty;
                }
                success = true;
            }
            return success;
        }
    }
}
