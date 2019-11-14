using UnityEngine; //引用 Unity API

//類別  類別名稱
public class bird : MonoBehaviour
{
    [Header("跳越高度"),Range(50,2000)]
    public int jump = 90;        //整數
    public string prop = "小雞"; //字串
    public bool 存活 = true;   //布林值(是/否)
}
