using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    public string playerName;

    public KeyCode left, right;

    private int moveSpaceMult = 2;

    void Update()
    {
        if (Input.GetKeyDown(left))
            if (transform.localPosition.x > -4)
                transform.Translate(Vector3.left * moveSpaceMult);

        if (Input.GetKeyDown(right))
            if (transform.localPosition.x < 4)
                transform.Translate(Vector3.right * moveSpaceMult);
    }
}
