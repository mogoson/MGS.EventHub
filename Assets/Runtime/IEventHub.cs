/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  IEventHub.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  09/22/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using System;

namespace MGS.EventHub
{
    public interface IEventHub
    {
        void Subscribe<T>(Action<T> action);

        void Unsubscribe<T>(Action<T> action);

        void Spread<T>(T arg);

        void Clear();
    }
}