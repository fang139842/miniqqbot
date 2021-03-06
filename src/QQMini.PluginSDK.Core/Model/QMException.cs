using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace QQMini.PluginSDK.Core.Model
{
	/// <summary>
	/// 表示在 QQMini 插件执行过程中发生的错误.
	/// </summary>
	[Serializable]
	public class QMException : Exception, ISerializable
	{
		#region --属性--
		/// <summary>
		/// 获取当前异常的错误代码
		/// </summary>
		public QMExceptionCodes Code { get; }
		#endregion

		#region --构造函数--
		/// <summary>
		/// 初始化 <see cref="QMException"/> 类的新实例
		/// </summary>
		/// <param name="code">当前异常的错误代码</param>
		public QMException (QMExceptionCodes code)
			: base ()
		{
			Code = code;
		}
		/// <summary>
		/// 用指定的错误消息和异常错误代码来初始化 <see cref="QMException"/> 类的新实例
		/// </summary>
		/// <param name="code">当前异常的错误代码</param>
		/// <param name="message">描述错误的消息</param>
		public QMException (QMExceptionCodes code, string message)
			: base (message)
		{
			Code = code;
		}
		/// <summary>
		/// 使用指定的错误消息和对作为此异常原因的内部异常的引用和异常错误代码来初始化 <see cref="QMException"/> 类的新实例
		/// </summary>
		/// <param name="code">当前异常的错误代码</param>
		/// <param name="message">解释异常原因的错误消息</param>
		/// <param name="innerException">导致当前异常的异常；如果未指定内部异常，则是一个 null 引用（在 Visual Basic 中为 Nothing）</param>
		public QMException (QMExceptionCodes code, string message, Exception innerException)
			: base (message, innerException)
		{
			Code = code;
		}
		/// <summary>
		/// 用序列化数据初始化 <see cref="QMException"/> 类的新实例
		/// </summary>
		/// <param name="info"><see cref="SerializationInfo"/>，它保存关于所引发异常的序列化对象数据</param>
		/// <param name="context"><see cref="StreamingContext"/>，它包含关于源或目标的上下文信息</param>
		protected QMException (SerializationInfo info, StreamingContext context) : base (info, context)
		{ }
		#endregion
	}
}
