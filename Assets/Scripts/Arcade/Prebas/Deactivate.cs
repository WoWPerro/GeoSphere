using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(Deactivatethis());
    }

    IEnumerator Deactivatethis()
    {
        yield return new WaitForSeconds(10);
        this.gameObject.SetActive(false);
    }
}
