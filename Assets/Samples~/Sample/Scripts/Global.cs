/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Global.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  09/22/2025
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.EventHub.Sample
{
    public sealed class Global
    {
        public static IEventHub EventHub { get; }

        static Global()
        {
            EventHub = new EventHub();
        }
    }
}