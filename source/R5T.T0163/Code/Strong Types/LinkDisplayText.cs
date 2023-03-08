using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0163
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class LinkDisplayText : TypedString, IStrongTypeMarker
    {
        public LinkDisplayText(string value)
            : base(value)
        {
        }
    }
}
