#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Pool
 * 文件名：MPool
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/4/24 15:23:33
 * 描述：缓冲池类
 *
 * ---------------------------------------------------------------*/

#endregion << 版 本 注 释 >>



namespace Assets.Script.Pool
{
    /// <summary>
    /// MPool 的摘要说明
    /// </summary>
    public static class MPool<T>
    {
        #region <常量>
        #endregion <常量>

        #region <变量>
        #endregion <变量>

        #region <属性>
        #endregion <属性>

        #region <构造方法和析构方法>
        public MPool()
        {

        }

        ~MPool()
        {

        }

        // 用静态方法 create 创建对象
        static public T create<T>() where T : new()
        {
            return new T();
        }

        #endregion <构造方法和析构方法>

        #region <方法>
                private static readonly object @lock = new object();
        private static readonly Stack<List<T>> free = new Stack<List<T>>();
        private static readonly HashSet<List<T>> busy = new HashSet<List<T>>();

        public static List<T> New()
        {
            lock (@lock)
            {
                if (free.Count == 0)
                {
                    free.Push(new List<T>());
                }

                var array = free.Pop();

                busy.Add(array);

                return array;
            }
        }

        public static void Free(List<T> list)
        {
            lock (@lock)
            {
                if (!busy.Contains(list))
                {
                    throw new ArgumentException("The list to free is not in use by the pool.", nameof(list));
                }

                list.Clear();

                busy.Remove(list);

                free.Push(list);
            }
        }
    }

        #endregion <方法>

        #region <事件>
        #endregion <事件>
    }
}
