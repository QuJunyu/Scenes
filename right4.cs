using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class right4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 获取 Image 组件，并添加点击事件
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnImageClick);
    }

    void OnImageClick()
    {
        // 切换到场景 "1"
        SceneManager.LoadScene(5);
    }
}
