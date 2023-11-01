﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Microsoft.Bot.Schema.SharePoint
{
    /// <summary>
    /// Adaptive Card Extension Client-side action response to render quick view.
    /// </summary>
    public class QuickViewHandleActionResponse : BaseHandleActionResponse
    {
        /// <summary>
        /// Gets the response type.
        /// </summary>
        /// <value>Card.</value>
        [JsonProperty(PropertyName = "responseType")]
        public override ViewResponseType ResponseType => ViewResponseType.QuickView;

        /// <summary>
        /// Gets or sets card view render arguments.
        /// </summary>
        /// <value>Card view render arguments.</value>
        [JsonProperty(PropertyName = "renderArguments")]
        public new QuickViewResponse RenderArguments { get; set; }
    }
}