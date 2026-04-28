using UnityEngine;

public class WorldScroller : MonoBehaviour
{
    public SpriteRenderer tileLeft, tileRight;

    public SpriteRenderer[] tilePrefabs;

    private void Update()
    {
        tileLeft.transform.position += new Vector3(GameManager.Instance.worldScrollingSpeed * -Time.deltaTime, 0, 0);
        tileRight.transform.Translate(new Vector3(GameManager.Instance.worldScrollingSpeed * -Time.deltaTime, 0, 0));

        if(tileRight.transform.position.x <= 0)
        {
            SpriteRenderer newTile = Instantiate(
                tilePrefabs[Random.Range(0, tilePrefabs.Length)], transform
                );

            float leftTileWidth = newTile.bounds.size.x;
            float rightTileWidth = tileRight.bounds.size.x;
            newTile.transform.position = tileRight.transform.position 
                + new Vector3(rightTileWidth /2 + leftTileWidth /2, 0, 0);

            Destroy(tileLeft.gameObject);
            tileLeft = tileRight;
            tileRight = newTile;
        }
    }
}
