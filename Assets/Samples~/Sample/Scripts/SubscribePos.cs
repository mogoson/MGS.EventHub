/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SubscribePos.cs
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
    public class SubscribePos : MonoBehaviour
    {
        private void Awake()
        {
            Global.EventHub.Subscribe<PosEventArg>(OnPosEvent);
        }

        private void OnDestroy()
        {
            Global.EventHub.Unsubscribe<PosEventArg>(OnPosEvent);
        }

        void OnPosEvent(PosEventArg arg)
        {
            transform.position = arg.position;
        }
    }
}