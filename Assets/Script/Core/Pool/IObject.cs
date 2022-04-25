#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Core.Pool
 * 文件名：IObject
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/4/25 16:27:20
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



namespace Assets.Script.Core.Pool
{
    /// <summary>
    /// IObject 的摘要说明
    /// </summary>
    public interface IObject
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit();
        //进入缓存池调用函数
        public void OnEnable();
        //退出缓冲池 调用函数
        public void OnDisable();

        //  重置数据调用函数
        public void OnReset();
        // 回收的时候调用函数
        public void OnRecycle();

        // 获取对象类型
        public string GetType();
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
