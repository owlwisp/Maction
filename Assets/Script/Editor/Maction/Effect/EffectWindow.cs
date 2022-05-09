#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Editor.Maction.Effect
 * 文件名：EffectWindow
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/9 10:40:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>

using UnityEditor;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using Assets.Script.Editor.Maction.Constant;
using System.Collections.Generic;
using Assets.Script.Editor.Maction.Effect.Tree;

namespace Assets.Script.Editor.Maction.Effect
{
    /// <summary>
    /// 配置文件处理窗口
    /// </summary>
    public class EffectWindow : OdinEditorWindow
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        [HorizontalGroup("Split")]
        [BoxGroup("Split/Effect 列表"),PropertyOrder(-Constants.kPropertyOrder)]
        [Button]
        private void New()
        {
            // var effectTitle = new EffectTitle();
            // EffectList.Add(effectTitle);
        }

        [BoxGroup("Split/Effect 列表")]
        [Button]
        private void Load()
        {
  
        }
        [BoxGroup("Split/Effect 列表")]
        [Searchable,PropertyOrder(Constants.kPropertyOrder)]
        public List<EffectTitle> EffectList = new List<EffectTitle>();





    // [TitleGroup("Total")]
    // [HorizontalGroup("Total/Midel")]
    // [VerticalGroup("Total/Split/Middle")]
    [BoxGroup("Split/Effect 树编辑区")]
    public int BoxC1;
    // TreeView tree;

    // [TitleGroup("Total")]
    // [HorizontalGroup("Total/Right")]
    // [VerticalGroup("Total/Split/Right")]
    [BoxGroup("Split/Effect 结点编辑区")]
    public int BoxC;
        // [TitleGroup("Effect List")]
        // [VerticalGroup("Effect List/Split/Left/New")]
        // // [BoxGroup("Multiple Stacked Boxes/Split/Right/Box C")]
        // [ButtonGroup,PropertyOrder(-Constants.kPropertyOrder)]
        // private void New()
        // {
        //     var effectTitle = new EffectTitle();
        //     EffectList.Add(effectTitle);
        // }
        // [ButtonGroup,PropertyOrder(-Constants.kPropertyOrder)]
        // [VerticalGroup("Effect List/Split/Left/Load")]
        // private void Load()
        // {
        // }
        // [PropertyOrder(-Constants.kPropertyOrder)]

        // // [TitleGroup("Effect Tree")]
        // // [VerticalGroup("Effect Tree/Split/Middle")]
        // // TreeView tree = new TreeView();

        // [Searchable]
        // [VerticalGroup("Effect List/Split/Left/EffectList")]
        // public List<EffectTitle> EffectList = new List<EffectTitle>();

        // [VerticalGroup("Total/Split/Middle")]
        // public int BoxC3 ;

        // [VerticalGroup("Total/Split/Right")]
        // public int BoxC31 ;
        // public void Exit()
        // {
   
        // }

        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
