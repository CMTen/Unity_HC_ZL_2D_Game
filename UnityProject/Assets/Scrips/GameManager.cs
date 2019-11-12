using UnityEngine; //引用 Unity API

//類別  類別名稱
public class GameManager : MonoBehaviour
{
    public int 目前分數 = 0;        //整數
    public int 最高分數 = 0;
    float speed = 0.5f;    //浮點數
    string prop = "地板"; //字串
    bool misson = true;   //布林值(是/否)
}