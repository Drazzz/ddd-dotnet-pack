﻿using System;

namespace ddd_dotnet_pack.Domain
{
    public static class SystemClock
    {
        private static DateTime? _customDate;


        public static DateTime Now => _customDate ?? DateTime.UtcNow;


        public static void Set(DateTime customDate) => _customDate = customDate;

        public static void Reset() => _customDate = null;
    }
}