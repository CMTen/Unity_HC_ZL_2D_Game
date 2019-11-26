using UnityEngine;

public class LearnOpertor : MonoBehaviour
{
    public int a = 10, b = 3, c = 9, d = 1;

    private void Start()
    {
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);
        print(6 / 2 * (2 + 1));

        print(a++);
        print(++a);

        print(c > d);
        print(c < d);
        print(c >= d);
        print(c <= d);
        print(c == d);
        print(c != d);
    }

    private void Update()
    {
        //print(++a);
    }
}
