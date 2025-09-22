/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  EventArg.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  09/22/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.EventHub.Sample
{
    public struct ColorEventArg
    {
        public Color color;
    }

    public struct PosEventArg
    {
        public Vector3 position;
    }

    public struct ScaleEventArg
    {
        public Vector3 scale;
    }
}