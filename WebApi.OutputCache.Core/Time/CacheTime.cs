﻿using System;

namespace WebApi.OutputCache.Core.Time
{
    public class CacheTime
    {
        public TimeSpan ClientTimeSpan { get; set; }

        public TimeSpan? SharedTimeSpan { get; set; }

        public DateTimeOffset AbsoluteExpiration { get; set; }
    }
}
