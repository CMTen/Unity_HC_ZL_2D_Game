using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool open;
    public int score = 0;
    public int combo;

    void Start()
    {
        if (true)
        {
            print("嗨");
        }
    }

    private void Update()
    {
        if (open)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }

        if (score>=60)
        {
            print("及格了");
        }

        else if (score>=40)
        {
            print("可以補考");
        }

        else
        {
            print("不及格");    
        }

        if (combo >= 150)
        {
            print("攻擊10倍");
        }
        else if(combo>=100)
        {
            print("攻擊5倍");
        }
        else if (combo >= 50 && combo <= 99)
        {
            print("攻擊2倍");
        }
    }
}
