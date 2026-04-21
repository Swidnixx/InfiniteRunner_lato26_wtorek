using UnityEngine;

public class WorldScroller : MonoBehaviour
{
    public Transform tileLeft, tileRight;

    private void Update()
    {
        tileLeft.position += new Vector3(GameManager.Instance.worldScrollingSpeed * -Time.deltaTime, 0, 0);
        tileRight.Translate(new Vector3(GameManager.Instance.worldScrollingSpeed * -Time.deltaTime, 0, 0));

        if(tileRight.position.x <= 0)
        {
            tileLeft.position += new Vector3(24.05f * 2f, 0, 0);

            Transform tmp = tileLeft;
            tileLeft = tileRight;
            tileRight = tmp;
        }
    }
}
