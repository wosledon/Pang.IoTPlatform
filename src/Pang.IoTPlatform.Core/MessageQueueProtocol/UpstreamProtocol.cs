using System;
using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;

namespace Pang.IoTPlatform.Core.MessageQueueProtocol
{
    /// <summary>
    /// 上行通信协议
    /// </summary>
    internal interface IUpstreamProtocol<out T>
    {
        string Serialize();

        T Deserialize();
    }

    /// <summary>
    /// 上行通信协议
    /// </summary>
    /// <remarks> 协议体为流 </remarks>
    public class UpstreamProtocolStream : IUpstreamProtocol<UpstreamProtocolStream>
    {
        /// <summary>
        /// 协议头, 用于标记协议类型
        /// </summary>
        public short Protocol { get; set; } = default!;

        /// <summary>
        /// 消息体
        /// </summary>
        public byte[] Buffer { get; set; } = default!;

        /// <summary>
        /// 序列化
        /// </summary>
        /// <returns> </returns>
        public string Serialize()
        {
            var protocol = Convert.ToString(Protocol, 2);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <returns> </returns>
        public UpstreamProtocolStream Deserialize()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 上行通信协议
    /// </summary>
    /// <remarks> 协议体为字符串 </remarks>
    public class UpstreamProtocolString : IUpstreamProtocol<UpstreamProtocolString>
    {
        /// <summary>
        /// 协议头, 用于标记协议类型
        /// </summary>
        public short Protocol { get; set; } = default!;

        /// <summary>
        /// 消息体
        /// </summary>
        public string Body { get; set; } = default!;

        /// <summary>
        /// 序列化
        /// </summary>
        /// <returns> </returns>
        public string Serialize()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <returns> </returns>
        public UpstreamProtocolString Deserialize()
        {
            throw new NotImplementedException();
        }
    }
}