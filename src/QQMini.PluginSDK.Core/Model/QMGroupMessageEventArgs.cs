using QQMini.PluginFramework.Utility.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQMini.PluginSDK.Core.Model
{
	/// <summary>
	/// 表示包含群组消息事件数据的类
	/// </summary>
	public class QMGroupMessageEventArgs : QMEventArgs
	{
		#region --属性--
		/// <summary>
		/// 指示当前事件的子类型
		/// </summary>
		public QMGroupMessageEventSubTypes SubType { get; }
		/// <summary>
		/// 指示当前事件的来源群组
		/// </summary>
		public Group FromGroup { get; }
		/// <summary>
		/// 指示当前事件的来源QQ
		/// </summary>
		public QQ FromQQ { get; }
		/// <summary>
		/// 指示当前事件的消息
		/// </summary>
		public Message Message { get; }
		#endregion

		#region --构造函数--
		/// <summary>
		/// 初始化 <see cref="QMGroupMessageEventArgs"/> 类的新实例
		/// </summary>
		/// <param name="type">事件类型</param>
		/// <param name="subType">事件子类型</param>
		/// <param name="robotQQ">机器人QQ</param>
		/// <param name="fromGroup">来源群组</param>
		/// <param name="fromQQ">来源QQ</param>
		/// <param name="msgNumber">消息序号</param>
		/// <param name="msgId">消息ID</param>
		/// <param name="message">详细信息</param>
		/// <exception cref="ArgumentOutOfRangeException">参数 robotQQ 或 fromQQ 小于 <see cref="QQ.MinValue"/> 或 fromGroup 小于 <see cref="Group.MinValue"/></exception>
		/// <exception cref="ArgumentNullException">参数 message 为 <see langword="null"/></exception>
		public QMGroupMessageEventArgs (int type, int subType, long robotQQ, long fromGroup, long fromQQ, long msgNumber, int msgId, IntPtr message)
			: base (type, robotQQ)
		{
			this.SubType = (QMGroupMessageEventSubTypes)subType;
			this.FromGroup = new Group (fromGroup);
			this.FromQQ = new QQ (fromQQ);
			this.Message = new Message (msgId, msgNumber, message.ToString (Global.DefaultEncoding));
		}
		#endregion
	}
}
