using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject itemPrefab;
    public float respawnTime = 1f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(ItemWave());
    }

    private void SpawnItems()
    {
        GameObject item = Instantiate(itemPrefab) as GameObject;
        respawnTime = Random.Range(1f, 5f);
        item.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator ItemWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnItems();
        }
    }
}
