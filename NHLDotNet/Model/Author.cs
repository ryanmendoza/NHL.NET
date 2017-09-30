// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents an author of an article
    /// </summary>
    public class Author
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }
    }
}