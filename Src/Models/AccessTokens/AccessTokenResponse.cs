﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MpWeiXin.Models.AccessTokens
{
    /// <summary>
    /// AccessToken响应
    /// </summary>
    public class AccessTokenResponse
    {
        /// <summary>
        /// 获取到的凭证
        /// </summary>
        /// <value>
        /// The access_token.
        /// </value>
        public string access_token { get; set; }

        /// <summary>
        /// 凭证有效时间，单位：秒
        /// </summary>
        /// <value>
        /// The expires_in.
        /// </value>
        public int expires_in { get; set; }
    }
}