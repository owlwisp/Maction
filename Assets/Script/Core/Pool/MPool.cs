#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Core.Pool
 * 文件名：MPool
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/4/24 15:23:33
 * 描述：缓冲池类
 *
 * ---------------------------------------------------------------*/

#endregion << 版 本 注 释 >>



using System.Collections.Generic;

namespace Assets.Script.Core.Pool
{
    /// <summary>
    /// MPool 的摘要说明
    /// </summary>
    public static class MPool<T> where T : IObject , new()
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        private static List<T> _pool;
        #endregion <变量>

        #region <属性>
        #endregion <属性>

        #region <构造方法和析构方法>

        // 用静态方法 create 创建对象



        #endregion <构造方法和析构方法>

        #region <方法>
        static public void Init(int capacity = 6)
        {
            _pool = new List<T>(capacity);
        }
        public static  T Get()
        {
            T t;
            if (_pool.Count > 0)
            {
                t = _pool[0];
                _pool.RemoveAt(0);

            }
            else
            {
                t = new T();
                t.OnInit();
            }
            t.OnReset();
            t.OnEnable();
            return t;
        }

        public static void Recycle(T t)
        {
            t.OnDisable();
            _pool.Add(t);
        }

        public static void Clear()
        {
            foreach (var item in _pool)
            {
                item.OnDisable();
            }
            _pool.Clear();
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
    }