
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int Score = 0;        //整數
    [Header("最高分數")]
    public int TopScore = 0;
    [Header("水管")]
    public GameObject Pipe;
    [Header("遊戲管理")]
    public GameObject goUI;
    [Header("分數介面")]
    public Text textScore;
    [Header("最高分數")]
    public Text textTop;

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
        Score += add;
        textScore.text = Score + "";

        setTopScore();
    }

    /// <summary>
    /// 設定最高分
    /// </summary>
    private void setTopScore()
    {
        if (Score > TopScore)
        {
            TopScore = Score;

            PlayerPrefs.SetInt("最高分數", TopScore);
        }

        textTop.text = TopScore + "";
    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameOver()
    {
        goUI.SetActive(true);

        floor.speed = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene("遊戲場景");
    }

    public void Exit()
    {
        Application.Quit();
    }

    private void Start()
    {
        InvokeRepeating("SpawnPipe", 0, 130f *Time.deltaTime);

        floor.speed = 3.5f;

        TopScore = PlayerPrefs.GetInt("最高分數");
        textTop.text = TopScore + "";
    }

}
