using UnityEngine;

public class Pipe : floor
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 1);
    }
}
