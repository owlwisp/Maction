#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Editor.Maction
 * 文件名：Lanugh
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/9 10:4:23
 * 描述：
 *
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>



using Assets.Script.Core.Base;
using Assets.Script.Editor.Maction.Action;
using Assets.Script.Editor.Maction.Config;
using Assets.Script.Editor.Maction.Effect;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor;

namespace Assets.Script.Editor.Maction
{
    /// <summary>
    /// 编辑器启动窗口
    /// </summary>
    public class Lanugh : OdinEditorWindow
    {
        #region <属性>
        #endregion <属性>

        #region <方法>
        

        [MenuItem("Tools/技能编辑器基础配置/Open &1")]
        private static void OpenConfigWinow()
        {
            LoadConfig();
            GetWindow<ConfigWindow>("编辑器配置").Show();
        }

        [MenuItem("Tools/技能编辑器效果部分/Open &2")]
        private static void OpenEffectWinow()
        {
            LoadConfig();
            GetWindow<EffectWindow>("效果编辑器").Show();
     
        }

        [MenuItem("Tools/技能编辑器动作部分/Open &3")]
        private static void OpenActionWinow()
        {
            LoadConfig();
            GetWindow<ActionWindow>("动作编辑器").Show();
        }
        //-------------------------------基础部分----------------------------------//
        private static void LoadConfig()
        {
            MSingleton<ConfigManager>.Instance.LoadConfig();
        }


        //[InfoBox("如果需要修改技能编辑器所需组件，则点击下面按钮")]
        //[Button(ButtonSizes.Large), PropertyOrder(- Constant.kPropertyOrder)]
        //private void OpenConfig()
        //{
        //    var window = EditorWindow.GetWindow<Config>("技能编辑器组件配置");
        //}




        //[Button(ButtonSizes.Large), GUIColor(1, 0, 0), PropertyOrder(Constant.kPropertyOrder)]
        //private void ExportAction()
        //{
        //    MSingleton<OutPutManager>.Instance.Export();
        //    Close();
        //}

        //-------------------------------人物部分----------------------------------//
        // [TabGroup("Master")]
        // [HideLabel]
        // public Player Master;

        // [TabGroup("Enemys")]
        // [HideLabel]
        // public List<Player> Enemys;

        // [TabGroup("MainCamera")]
        // [HideLabel]
        // public MainCamera Camera;



        // [Button(ButtonSizes.Medium)]
        // private void Play(string action)
        // {
        //     Master.Play(action);
        // }
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
