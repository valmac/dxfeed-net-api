﻿/// Copyright (C) 2010-2016 Devexperts LLC
///
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// http://mozilla.org/MPL/2.0/.

using com.dxfeed.api.events;

namespace com.dxfeed.api
{
    /// <summary>
    /// Interface provides receiving candle events
    /// </summary>
    public interface IDxCandleListener
    {

        /// <summary>
        /// On Candle events received
        /// </summary>
        /// <typeparam name="TB">event buffer type</typeparam>
        /// <typeparam name="TE">event type</typeparam>
        /// <param name="buf">event buffer object</param>
        void OnCandle<TB, TE>(TB buf)
            where TB : IDxEventBuf<TE>
            where TE : IDxCandle;
    }
}
