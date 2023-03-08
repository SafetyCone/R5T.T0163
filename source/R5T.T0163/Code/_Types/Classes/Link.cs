using System;


namespace R5T.T0163
{
    public class Link
    {
        #region Static

        public static Link From(
            string href,
            string displayText)
        {
            var link = new Link
            {
                DisplayText = new LinkDisplayText(displayText),
                Href = new LinkHref(href),
            };

            return link;
        }

        #endregion


        public LinkHref Href { get; set; }
        public LinkDisplayText DisplayText { get; set; }
    }
}
