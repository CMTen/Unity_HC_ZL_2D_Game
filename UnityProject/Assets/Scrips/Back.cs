using UnityEngine; //引用 Unity API

//類別  類別名稱
public class Back : MonoBehaviour
{
    [Header("速度"), Range(0, 100)]
    public float speed = 0.1f;    //浮點數
    public string prop = "背景"; //字串

    [Header("移動")]
    public Transform tran;

    /// <summary>
    /// 地板移動功能
    /// </summary>
    private void move()
    {
        tran.Translate(-speed * Time.deltaTime, 0, 0);
    }

    private void Update()
    {
        move();
    }
}