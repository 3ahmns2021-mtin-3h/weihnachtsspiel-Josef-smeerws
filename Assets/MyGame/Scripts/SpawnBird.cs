using System.Collections;
using UnityEngine;

public class SpawnBird : MonoBehaviour
{
    public GameObject birdPrefab;
    public GameObject parentSpawnGo;

    public void SpawnTheBirds()
    {
        var clones = Instantiate(birdPrefab);
        clones.GetComponent<Transform>().SetParent(parentSpawnGo.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0, 10));
            SpawnTheBirds();
        }
    }
}
