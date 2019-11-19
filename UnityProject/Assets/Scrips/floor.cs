using UnityEngine; //引用 Unity API

//類別  類別名稱
public class floor : MonoBehaviour
{
    [Header("速度"),Range(0,100)]
    public float speed = 0.5f;    //浮點數
    public string prop = "地板"; //字串

    /// <summary>
    /// 地板移動功能
    /// </summary>
    private void move()
    {

    }
}
