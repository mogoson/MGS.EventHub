/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SubscribeColor.cs
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
    public class SubscribeColor : MonoBehaviour
    {
        Renderer render;

        private void Awake()
        {
            render = GetComponent<Renderer>();
            Global.EventHub.Subscribe<ColorEventArg>(OnColorEvent);
        }

        private void OnDestroy()
        {
            Global.EventHub.Unsubscribe<ColorEventArg>(OnColorEvent);
        }

        void OnColorEvent(ColorEventArg arg)
        {
            render.material.color = arg.color;
        }
    }
}