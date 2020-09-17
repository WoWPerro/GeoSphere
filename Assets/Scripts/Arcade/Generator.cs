using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject prefab;
    private List<GameObject> obstacles;
    private List<GameObject> adornos;
    public List<GameObject> adornosprefs;
    public float spawntime = 1;
    public GameObject player;
    public float minmaxX = -10;
    public float minmaxZ = 30;
    public float miny = 500;
    public int poolsize = 30;
    private float lastY = 0;
    private float lastY2 = 0;

    void Start()
    {
        obstacles = new List<GameObject>();
        adornos = new List<GameObject>();
        StartCoroutine(GenerateObstacles());
        StartCoroutine(GenerateAdornos());
    }

    IEnumerator GenerateObstacles()
    {
        yield return new WaitForSeconds(spawntime);
        if (obstacles.Count > poolsize)
        {
            bool found = false;
            int i = 0;
            while(!found && i < obstacles.Count)
            {
                if(!obstacles[i].activeInHierarchy)
                {
                    obstacles[i].SetActive(true);
                    lastY += Random.Range(miny, miny + 100);
                    obstacles[i].transform.position = new Vector3(Random.Range(-minmaxX, minmaxX), lastY, Random.Range(-minmaxZ, minmaxZ));
                    float r = Random.Range(0.3f, 1.5f);
                    obstacles[i].transform.localScale = new Vector3(r, r, r);
                }
                i++;
            }
            
        }
        else
        {
            lastY += Random.Range(miny, miny + 100);
            obstacles.Add(Instantiate(prefab, new Vector3(Random.Range(-minmaxX, minmaxX), lastY, Random.Range(-minmaxZ, minmaxZ)), Quaternion.identity));
        }
        StartCoroutine(GenerateObstacles());
    }

    IEnumerator GenerateAdornos()
    {
        yield return new WaitForSeconds(.5f);
        if (adornos.Count > poolsize * 2)
        {
            bool found = false;
            int i = 0;
            while (!found && i < adornos.Count)
            {
                if (!adornos[i].activeInHierarchy)
                {
                    adornos[i].SetActive(true);
                    lastY2 += Random.Range(miny/4, miny/2);
                    adornos[i].transform.position = new Vector3(Random.Range(-minmaxX, minmaxX)*2, lastY2, Random.Range(-minmaxZ, minmaxZ)*2);
                    float r = Random.Range(0.3f, 1.5f);
                    adornos[i].transform.localScale = new Vector3(r, r, r);
                    adornos[i].transform.rotation = Quaternion.Euler(Random.Range(0, 180), Random.Range(0, 180), Random.Range(0, 180));
                }
                i++;
            }

        }
        else
        {
            lastY2 += Random.Range(miny/ 4, miny/2);
            int r = Random.Range(0, 7);
            adornos.Add(Instantiate(adornosprefs[r], new Vector3(Random.Range(-minmaxX, minmaxX)*2, lastY2, Random.Range(-minmaxZ, minmaxZ)*2), Quaternion.Euler(Random.Range(0,180), Random.Range(0, 180), Random.Range(0, 180))));
        }
        StartCoroutine(GenerateAdornos());
    }
}
