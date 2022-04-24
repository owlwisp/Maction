#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Core
 * 文件名：MSingleton
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/4/24 15:05:13
 * 描述：范式单例类
 *
 * ---------------------------------------------------------------*/

#endregion << 版 本 注 释 >>



using System;

namespace Assets.Script.Core
{
    /// <summary>
    /// MSingleton 的摘要说明
    /// </summary>
    public static class MSingleton<T>
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        private static T _instance;
        private static readonly object @_lock = new object();
        
        #endregion <变量>

        #region <属性>
        #endregion <属性>

        #region <构造方法和析构方法>
        static MSingleton()
        {

        }

        #endregion <构造方法和析构方法>

        #region <方法>

        public static T instance
        {
            get
            {
                lock (@_lock)
                {
               
                    if (_instance == null)
                    {
                        _instance = (T)Activator.CreateInstance(typeof(T));
                    }

                    return _instance;
                }
            }
        }
        
        public static void OnDestroy(T instance)
        {
            _instance = default(T);
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
