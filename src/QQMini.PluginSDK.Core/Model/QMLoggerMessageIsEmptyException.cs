using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace QQMini.PluginSDK.Core.Model
{
	/// <summary>
	/// 表示在 QQMini 插件执行过程中发生的日志信息是空的异常
	/// </summary>
	[Serializable]
	public class QMLoggerMessageIsEmptyException : QMException
	{
		#region --属性--
		/// <summary>
		/// 获取描述当前异常的消息
		/// </summary>
		public override string Message => $"日志消息是空";
		#endregion

		#region --构造函数--
		/// <summary>
		/// 初始化 <see cref="QMLoggerMessageIsEmptyException"/> 类的新实例
		/// </summary>
		public QMLoggerMessageIsEmptyException ()
			: base (QMExceptionCodes.LoggerMessageIsEmpty)
		{

		}
		/// <summary>
		/// 用序列化数据初始化 <see cref="QMLoggerMessageIsEmptyException"/> 类的新实例
		/// </summary>
		/// <param name="info"><see cref="SerializationInfo"/>，它保存关于所引发异常的序列化对象数据</param>
		/// <param name="context"><see cref="StreamingContext"/>，它包含关于源或目标的上下文信息</param>
		protected QMLoggerMessageIsEmptyException (SerializationInfo info, StreamingContext context)
			: base (info, context)
		{
		}
		#endregion
	}
}
