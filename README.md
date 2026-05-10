# 3D RPG · 角色扮演游戏

> Unity 3D 角色扮演游戏 | 核心开发 | 



## 项目简介

一款第三人称 3D 角色扮演游戏，玩家在开放地图中探索，与敌人战斗，完成任务，获取经验升级。项目实现了角色系统、敌人 AI、对话任务、场景传送、存档读档等完整 RPG 循环。

**Demo亮点**：
- 采用 ScriptableObject 将角色属性、攻击参数、场景配置等抽离为数据资产，实现数据驱动。
- 敌人 AI 基于有限状态机（FSM）设计，结合 NavMeshAgent 寻路，状态独立且可扩展。
- 通过 C# 事件（Action）和观察者模式（IEndGameObserver）解耦输入、战斗、UI 等模块。
- 使用 Addressables 异步加载与卸载场景，配合 Json 存档实现跨场景玩家数据持久化。
- 封装泛型单例基类统一管理 GameManager、SceneController、SaveManager 等全局系统。

## 游戏功能

- 鼠标点击移动，点选敌人自动接近并攻击
- 近战攻击带暴击判定，敌人受击反馈与死亡掉落
- 敌人 AI：巡逻、追击、攻击、死亡状态切换，不同敌人拥有特殊技能（投石、踢飞）
- 玩家血条、经验条实时更新，升级系统
- 对话系统、任务追踪（待扩展）
- 场景传送：同场景内传送点、跨场景过渡
- 世界空间血条跟随角色显示
- JSON 存档/读档，记录玩家位置与属性

## 技术栈

| 类别 | 技术 |
|:---|:---|
| **引擎** | Unity 2023.2.20 |
| **编程语言** | C# |
| **数据配置** | ScriptableObject |
| **敌人 AI** | 有限状态机 + NavMeshAgent |
| **输入系统** | 旧版 Input Manager + 鼠标事件 |
| **动画系统** | Animator |
| **UI** | UGUI + 世界空间 Canvas |
| **事件通信** | C# event Action、观察者模式 |
| **场景管理** | Addressables 异步加载 + SceneManager |
| **数据持久化** | JSON + PlayerPrefs |
| **版本控制** | Git / GitHub |

