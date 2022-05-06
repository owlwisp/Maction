#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Process
 * 文件名：UnitProcess
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 17:1:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



namespace Assets.Script.Engine.Process
{
    /// <summary>
    /// 统一创建入口
    /// </summary>
    public static class UnitProcess 
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        public static void OnInit(){
            MPool<DamageData>.Init(12);
        }

        public static void OnDestroy(){
            MPool<DamageData>.Clear();
        }
        
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}