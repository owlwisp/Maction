#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Core.Container
 * 文件名：Container<T>
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 16:37:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using System;
using System.Collections.Generic;
using Assets.Script.Core.Pool;

namespace Assets.Script.Core.Container
{
    /// <summary>
    /// container 管理类
    /// </summary>
    public class Container<T> where T : IObject , new()
    {
        #region <属性>
        private static Container<T> _instance;
        //存储T的链表
        private List<T> _list ;

        #endregion <属性>

        #region <方法>
        // 第一次创建出来 之后调用函数
        public void Init()
        {
            _list = new List<T>();
        }

        public void Release(){
            _list.Clear();

        }

        public void Destroy(){
            _list = null;
        }

        //单例模式实例
        
        public static Container<T> Instance
        {
            get
            {
                if ( _instance == null)
                {
                    _instance = new Container<T>();
                }
                return _instance;
            }
        }

        // 通过id和T给字典和list增加元素
        public void Add(T t){
            _list.Add(t);
        }

        // 通过id和T给字典和list删除元素
        public void Remove(T t){
            _list.Remove(t);
        }
        // 遍历数组获取对象
        public T Get(int id){
            //TODO:
            // 遍历数组
            foreach (var t in _list)
            {
                if (t.Id == id)
                {
                    return t;
                }
            }
            return default(T);
        }

  

        // 根据筛选函数获取链表
        public List<T> GetList(System.Func<T,bool> func){
            List<T> list = new List<T>();
            foreach(T t in _list){
                if(func(t)){
                    list.Add(t);
                }
            }
            return list;
        }



        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
