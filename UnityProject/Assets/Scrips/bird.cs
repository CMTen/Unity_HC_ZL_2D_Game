using UnityEngine; //引用 Unity API

//類別  類別名稱
public class bird : MonoBehaviour
{
    [Header("跳越高度"),Range(50,2000)]
    public int jump = 475;        //整數
    public string prop = "小雞";  //字串
    public bool dead = false;     //布林值(是/否)

    public GameObject goScore, goGM, goFloor;
    public Rigidbody2D Rig;

    public GameManager GM;

    [Header("音效區域")]
    public AudioSource adu;
    public AudioClip aduJUMP, aduHIT, aduADD;

    /// <summary>
    /// 小雞跳躍功能
    /// </summary>
    private void Jump()
    {
        if (dead) return;
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("跳");
            goScore.SetActive(true);
            goGM.SetActive(true);

            adu.PlayOneShot(aduJUMP, 1f);

            Rig.gravityScale = 2f;
            Rig.Sleep();
            Rig.AddForce(new Vector2(0, jump));
        }

        Rig.SetRotation(5.25f * Rig.velocity.y);
    }

    /// <summary>
    /// 小雞死亡功能
    /// </summary>
    private void Dead()
    {
        if (dead) return;

        dead = true;
        GM.GameOver();
        adu.PlayOneShot(aduHIT, 1f);
    }

    /// <summary>
    /// 通過水管
    /// </summary>
    private void passPipe()
    {
        if (dead) return;

        adu.PlayOneShot(aduADD, 1f);
        print("+1");
        GM.addscore(1);
    }

    private void Start()
    {
        Screen.SetResolution(480, 854, false);
    }

    private void Update()
    {
        Jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "地板")
        {
            Dead();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "水管 - 上" || collision.gameObject.name == "水管 - 下")
        {
            Dead();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "加分區域")
        {
            passPipe();
        }
    }
}
