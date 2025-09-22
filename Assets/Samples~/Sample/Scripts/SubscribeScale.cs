/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SubscribeScale.cs
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
    public class SubscribeScale : MonoBehaviour
    {
        private void Awake()
        {
            Global.EventHub.Subscribe<ScaleEventArg>(OnScaleEvent);
        }

        private void OnDestroy()
        {
            Global.EventHub.Unsubscribe<ScaleEventArg>(OnScaleEvent);
        }

        void OnScaleEvent(ScaleEventArg arg)
        {
            transform.localScale = arg.scale;
        }
    }
}