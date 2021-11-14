namespace Pang.IoTPlatform.Core.MessageQueueProtocol
{
    /// <summary>
    /// 下行通信协议
    /// </summary>
    internal interface IDownstreamProtocol<out T>
    {
        string Serialize();

        T Deserialize();
    }

    /// <summary>
    /// 下行通信协议
    /// </summary>
    public class DownstreamProtocolStream : IDownstreamProtocol<DownstreamProtocolStream>
    {
        /// <summary>
        /// 设备标识
        /// </summary>
        public string EquipmentId { get; set; } = default!;

        /// <summary>
        /// 消息体
        /// </summary>
        public byte[]? Buffer { get; set; } = default!;

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <returns> </returns>
        /// <exception cref="System.NotImplementedException"> </exception>
        public DownstreamProtocolStream Deserialize()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <returns> </returns>
        /// <exception cref="System.NotImplementedException"> </exception>
        public string Serialize()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// 下行通信协议
    /// </summary>
    public class DownstreamProtocolString : IDownstreamProtocol<DownstreamProtocolStream>
    {
        /// <summary>
        /// 设备标识
        /// </summary>
        public string EquipmentId { get; set; } = default!;

        /// <summary>
        /// 消息体
        /// </summary>
        public string Body { get; set; } = default!;

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <returns> </returns>
        /// <exception cref="System.NotImplementedException"> </exception>
        public DownstreamProtocolStream Deserialize()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <returns> </returns>
        /// <exception cref="System.NotImplementedException"> </exception>
        public string Serialize()
        {
            throw new System.NotImplementedException();
        }
    }
}