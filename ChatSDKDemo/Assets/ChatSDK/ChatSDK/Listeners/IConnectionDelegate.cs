﻿using System;
using System.Collections.Generic;

namespace ChatSDK
{
    public interface IConnectionDelegate
    {
        /// <summary>
        /// 连接回调
        /// </summary>
        void OnConnected();

        /// <summary>
        /// 断开连接回调
        /// </summary>
        /// <param name="i">断开连接错误号</param>
        void OnDisconnected(int i);


        /// <summary>
        /// Token过期通知
        /// </summary>
        void OnTokenExpired();


        /// <summary>
        /// Token将要过期通知
        /// </summary>
        void OnTokenWillExpire();
    }

}