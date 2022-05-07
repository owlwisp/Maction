#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Core.Tree
 * 文件名：DeepTreeEnum
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/5 14:37:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



namespace Assets.Script.Core.Tree
{
    /// <summary>
    /// 深度树当前结点执行状态
    /// </summary>
    #region <DeepTreeStatusType>
    public enum DeepTreeStatusType
    {

        kNone = 0,
        kWaiting = 1,
        kRunning = 2,
        kFinish= 3,
        
    }
    #endregion <DeepTreeStatusType>

  


}
