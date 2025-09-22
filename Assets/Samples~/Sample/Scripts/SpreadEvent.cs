/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SpreadEvent.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  09/22/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using System.Collections;
using UnityEngine;

namespace MGS.EventHub.Sample
{
    public class SpreadEvent : MonoBehaviour
    {
        private void Start()
        {
            StartCoroutine(SpreadEvents());
        }

        IEnumerator SpreadEvents()
        {
            yield return new WaitForSeconds(1.0f);
            var colorArg = new ColorEventArg { color = Color.cyan };
            Global.EventHub.Spread(colorArg);

            yield return new WaitForSeconds(1.0f);
            var posArg = new PosEventArg { position = Vector3.up };
            Global.EventHub.Spread(posArg);

            yield return new WaitForSeconds(1.0f);
            var scaleArg = new ScaleEventArg { scale = Vector3.one * 0.5f };
            Global.EventHub.Spread(scaleArg);
        }
    }
}