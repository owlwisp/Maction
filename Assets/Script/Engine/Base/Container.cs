#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Base
 * 文件名：Container<T>
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 16:37:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using System.Collections.Generic;

namespace Assets.Script.Engine.Base
{
    /// <summary>
    /// effect 管理类
    /// </summary>
    public class Container<T>
    {
        #region <属性>
        private static Container<T> m_instance;
        //存储T的链表
        private List<T> m_list = new List<T>();
        //按照id存储列表的字典
        private Dictionary<int, List<T>> m_dict = new Dictionary<int, List<T>>();

        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void OnInit()
        {

        }

        //单例模式实例
        
        public static Container<T> Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new Container<T>();
                }
                return m_instance;
            }
        }

        // 通过id和T给字典和list增加元素
        public void Add(T t,int id){
            if(!m_dict.ContainsKey(id)){
                m_dict.Add(id,new List<T>());
            }
            m_dict[id].Add(t);
            m_list.Add(t);
        }

        // 通过id和T给字典和list删除元素
        public void Remove(T t,int id){
            if(m_dict.ContainsKey(id)){
                m_dict[id].Remove(t);
                m_list.Remove(t);
            }
        }

        // 获取对象
        public T Get(int id){
            if(m_dict.ContainsKey(id)){
                if(m_dict[id].Count > 0){
                    return m_dict[id][0];
                }
            }
            return default(T);
        }

  
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
