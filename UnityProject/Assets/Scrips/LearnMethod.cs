using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    private void Test()
    {

    }

    /// <summary>
    /// 小鳥飛。
    /// </summary>
    /// <param name="speed"></param>
    private void Fly(int speed)
    {
        print("飛行時速：" + speed);
    }

    private string Name(string name)
    {
        return "嗨！" + name + "，歡迎使用本軟體！";
    }

    private void Shoot(int count, string direction = "前方", string prop = "無")
    {
        print("弓箭數量：" + count);
        print("弓箭向" + direction + "發射");
        print("弓箭屬性：" + prop);
    }

    private void Start()
    {
        Fly(10);
        Shoot(5,"左右");
        Shoot(10, prop:"火");
        print(Name("小明"));
        string na = Name("小明");
        print(na);
    }
}
