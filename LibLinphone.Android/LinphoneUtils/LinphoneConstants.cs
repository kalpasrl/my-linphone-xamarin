﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace LibLinphone.Android.LinphoneUtils
{
    public struct LinphoneConstants
    {
        public const int LINPHONE_PROXY_CFG_EXPIRE_TIME_SEC = 900;
        public const int LINPHONE_MAX_CONCURRENT_CALLS = 3;
        public const string HEADER_MOBILE_IMEI = "Mobile-IMEI";
        public const string HEADER_DEVICE_NAME = "MyName";
    }
}