using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMat : MonoBehaviour
{
    private void OnEnable()
    {
        Color32 randomcolor = new Color32(
      (byte)Random.Range(0, 255),
      (byte)Random.Range(0, 255),
      (byte)Random.Range(0, 255),
      255
  );

        Material mymat = GetComponent<Renderer>().material;
        mymat.SetColor("_EmissionColor", randomcolor);
    }
}
