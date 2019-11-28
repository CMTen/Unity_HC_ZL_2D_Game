
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int Score = 0;        //整數
    [Header("最高分數")]
    public int TopScore = 0;
    [Header("水管")]
    public GameObject Pipe;
   

    /// <summary>
    /// 生成水管。
    /// </summary>
    public void SpawnPipe()
    {
        int x = 6;
        float y = Random.Range(-1.3f, 2.0f);
        Vector3 pos = new Vector3(x, y, 0);
        Quaternion rot = new Quaternion(0, 0, 0, 0);

        Object.Instantiate(Pipe, pos, rot);
    }

    /// <summary>
    /// 加分功能
    /// </summary>
    /// <param name="add">添加分數</param>
    public void addscore(int add) 
    {

    }

    /// <summary>
    /// 設定最高分
    /// </summary>
    private void setTopScore()
    {

    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameOver()
    {

    }

    private void Start()
    {
        InvokeRepeating("SpawnPipe", 0, 130f *Time.deltaTime);
    }

}
