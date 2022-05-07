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
    public class MPool<T> where T : IObject , new()
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        // 单例类
        private  List<T> _pool;
        #endregion <变量>

        #region <属性>
        #endregion <属性>

        #region <构造方法和析构方法>
        // 单例模式实例
        private static MPool<T> _instance;

        public static MPool<T> Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MPool<T>();
                }
                return _instance;
            }
        }

        #endregion <构造方法和析构方法>

        #region <方法>
        public void Init(int capacity = 6)
        {
            _pool = new List<T>(capacity);
        }
        public T Get()
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

        public void Recycle(T t)
        {
            t.OnDisable();
            _pool.Add(t);
        }

        public void Clear()
        {
            foreach (var item in _pool)
            {
                item.OnDisable();
            }
            _pool.Clear();
        }

        public void Destroy()
        {
            _pool = null;
        }
        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
    }
