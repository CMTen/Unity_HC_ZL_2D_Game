using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    private void Start()
    {
        print("開始！");
        Debug.Log("嗨嗨");

        print(Random.value);

        print("圓周率是" + Mathf.PI);

        print("隨機範圍：" + Random.Range(10.5f, 50.5f));

        Debug.LogWarning("警告");
        Debug.LogError("錯誤");
    }

    private void Update()
    {
        print(Input.inputString);

        if (Input.GetKeyDown("s"))
        {
            print("You dead.");
        }
        
    }
}
