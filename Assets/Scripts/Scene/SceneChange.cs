using UnityEngine;
using UnityEngine.SceneManagement; // 必须引入场景管理命名空间

public class SceneChange : MonoBehaviour
{
    // 切换到游戏场景（两种调用方式：按场景名称/按索引）
    public void LoadGameScene()
    {
        // 方式A：按场景名称加载（推荐，索引变化不影响）
        SceneManager.LoadScene("Game");

        // 方式B：按场景索引加载（需对应Build Settings中的顺序）
        // SceneManager.LoadScene(1); 
    }
}
