#region << 文 件 注 释 >>
/*----------------------------------------------------------------
 * 公司名称：TuYooGame
 * 命名空间：Assets.Script.Engine.Ecs.Core
 * 文件名：BuildFactory
 * 
 * 创建者：owlwisp
 * 电子邮箱：owlwisp@163.com
 * 创建时间：2022/5/11 16:57:24
 * 描述：
 *      这个类暂时还是采用静态方式吧，注册式或者多态后面看情况是否需要修改
 * ---------------------------------------------------------------*/

#endregion << 文 件 注 释 >>


using Assets.Script.Engine.Ecs.Component;
using Assets.Script.Engine.Ecs.Component.Logic;
using Assets.Script.Engine.Ecs.Component.Render;
using Assets.Script.Engine.Ecs.Core.Module;
using Assets.Script.Engine.Ecs.Entity;
using Assets.Script.Engine.Ecs.System;
using Assets.Script.Engine.Ecs.System.Logic;
using Assets.Script.Engine.Ecs.System.Render;

namespace Assets.Script.Engine.Ecs.Core
{
    /// <summary>
    /// 建造工厂
    /// </summary>
    static public class BuildFactory 
    {
        #region <属性>

        #endregion <属性>

        #region <方法>
        // 创建组件 
        static public BaseComponent CreateComponent(int id , int EntityId, string type)
        {
            BaseComponent component = null;
            switch (type)
            {
                case "Health":
                    component = new HealthComponent(id, EntityId);
                    break;
                case "Position":
                    component = new PositionComponent(id, EntityId);
                    break;
                case "Input":
                    component = new InputComponent(id, EntityId);
                    break;
                case "Target":
                    component = new TargetComponent(id, EntityId);
                    break;
                case "Status":
                    component = new StatusComponent(id, EntityId);
                    break;
                case "Velocity":
                    component = new VelocityComponent(id, EntityId);
                    break;
                case "Attack":
                    component = new AttackComponent(id, EntityId);
                    break;
                case "Demage":
                    component = new DemageComponent(id, EntityId);
                    break;
                case "Audio":
                    component = new AudioComponent(id, EntityId);
                    break;
                case "Animation":
                    component = new AnimationComponent(id, EntityId);
                    break;
                case "Time":
                    component = new TimeComponent(id, EntityId);
                    break;
                case "Render":
                    component = new RenderComponent(id, EntityId);
                    break;
                case "Logic":
                    component = new LogicComponent(id, EntityId);
                    break;
                case "Effect":
                    component = new EffectComponent(id, EntityId);
                    break;
                case "Skill":
                    component = new SkillComponent(id, EntityId);
                    break;
                case "Ai":
                    component = new AiComponent(id, EntityId);
                    break;

                // case "Collision":
                //     component = new CollisionComponent(id);
                //     break;
                // case "Camera":
                //     component = new CameraComponent(id);
                //     break;
                // case "Buff":
                //     component = new BuffComponent(id);
                //     break;
                // case "SkillBuff":
                //     component = new SkillBuffComponent(id);
                //     break;
                // case "SkillEffect":
                //     component = new SkillEffectComponent(id);
                //     break;
                // case "SkillCollision":
                //     component = new SkillCollisionComponent(id);
                //     break;
                // case "SkillCamera":
                //     component = new SkillCameraComponent(id);
                //     break;
                // case "SkillAudio":
                //     component = new SkillAudioComponent(id);
                //     break;
                // case "SkillEffect":
                //     component = new SkillEffectComponent(id);
                //     break;
                // case "SkillAi":
                //     component = new SkillAiComponent(id);
                //     break;
           
            }
            return component;     
        }
        // 创建实体
        static public BaseEntity CreateEntity(int id)
        {
            return new BaseEntity(id);
        }

        // 创建系统
        static public BaseSystem CreateSystem(string type)
        {
            BaseSystem system = null;
            switch (type)
            {
                case "Health":
                    system = new HealthSystem();
                    break;
                case "Move":
                    system = new MoveSystem();
                    break;
                case "Input":
                    system = new InputSystem();
                    break;
                case "Target":
                    system = new TargetSystem();
                    break;
                case "Status":
                    system = new StatusSystem();
                    break;
                case "Attack":
                    system = new AttackSystem();
                    break;
                case "Demage":
                    system = new DemageSystem();
                    break;
                case "Audio":
                    system = new AudioSystem();
                    break;
                case "Animation":
                    system = new AnimationSystem();
                    break;
                case "Time":
                    system = new TimeSystem();
                    break;
                case "Effect":
                    system = new EffectSystem();
                    break;
                case "Skill":
                    system = new SkillSystem();
                    break;
                case "Ai":
                    system = new AiSystem();
                    break;
                case "Render":
                    system = new RenderSystem();
                    break;
                case "Logic":
                    system = new LogicSystem();
                    break;
                    
                // case "Collision":
                //     system = new CollisionSystem();
                //     break;
                // case "Camera":
                //     system = new CameraSystem();
                //     break;
                // case "Buff":
                //     system = new BuffSystem();
                //     break;
                // case "SkillBuff":
                //     system = new SkillBuffSystem();
                //     break;
                // case "SkillEffect":
                //     system = new SkillEffectSystem();
                //     break;
                // case "SkillCollision":
                //     system = new SkillCollisionSystem();
                //     break;
                // case "SkillCamera":
                //     system = new SkillCameraSystem();
                //     break;
                // case "SkillAudio":
                //     system = new SkillAudioSystem();
                //     break;
                // case "SkillEffect":
                //     system = new SkillEffectSystem();
                //     break;
                // case "SkillAi":
                //     system = new SkillAiSystem();
                //     break;
                // case "SkillBuff":
                //     system = new SkillBuffSystem();
                //     break;
            }
            return system;
        }
  
        #endregion <方法>

        #region <事件>
        #endregion <事件>

        #region <索引器>
        #endregion <索引器>
    }
}
