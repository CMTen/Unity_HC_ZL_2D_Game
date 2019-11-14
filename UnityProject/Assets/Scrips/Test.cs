using UnityEngine; //引用 Unity API

//類別  類別名稱
public class Test : MonoBehaviour
{
    public int 目前分數 = 0;        //整數
    public int 最高分數 = 0;
    float speed = 0.5f;    //浮點數
    string prop = "地板"; //字串
    bool misson = true;   //布林值(是/否)

    //標題：[Header(“標題內容”)]
    //提示：[Tooltip(“提示內容”)]
    //範圍：[Range(最小值，最大值)]
    
    [Header("血量")]
    [Range(0,999)]
    [Tooltip("生命值")]
    public int HP = 100;

    [Header("魔力")]
    [Range(0, 999)]
    [Tooltip("法力值")]
    public int MP = 20;

    [Header("跳越高度"), Range(0.1f, 199f)]
    public float High = 99f;

    [Header("死亡"),Tooltip("判斷玩家是否死亡，有勾=死亡，沒勾=存活")]
    public bool dead = false;
}