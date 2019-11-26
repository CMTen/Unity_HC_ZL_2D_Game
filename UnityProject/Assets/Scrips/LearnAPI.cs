using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public Transform tranA;
    public Transform tranB;

    public SpriteRenderer spritA;

    private void Start()
    {
        print("開始！");
        Debug.Log("嗨嗨");

        print(Random.value);

        print("圓周率是" + Mathf.PI);

        print("隨機範圍：" + Random.Range(10.5f, 50.5f));

        Debug.LogWarning("警告");
        Debug.LogError("錯誤");

        // 非靜態屬性：實體類型.屬性
        // print(Transform.position); // 錯誤
        print(tranA.position);
        print(tranB.position);

        tranA.position = new Vector3(-1, 0, 0);

        tranA.localScale = new Vector3(5, 5, 5);

        spritA.flipX = true;
    }

    private void Update()
    {
        print(Input.inputString);

        tranA.Rotate(0, 0, 10);

        if (Input.GetKeyDown("s"))
        {
            print("You dead.");
        }
        
    }
}
