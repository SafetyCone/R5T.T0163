using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0163
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class LinkHref : TypedString, IStrongTypeMarker
    {
        public LinkHref(string value)
            : base(value)
        {
        }
    }
}
