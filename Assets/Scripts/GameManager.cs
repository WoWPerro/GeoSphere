using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Scene scene;
    public static bool lost = false;
    public static bool win = false;
    public int lostlevelY = -50;
    public GameObject player;
    public int NextLevel = 1;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y < lostlevelY)
        {
            lost = true;
        }
        if(lost)
        {
            SceneManager.LoadScene(scene.name);
            lost = false;
        }
        if(win)
        {
            win = false;
            SceneManager.LoadScene(NextLevel);
        }
    }
}
