using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwitch : MonoBehaviour
{
    public int rndIndex = 0;
    public Material[] material = new Material[6];
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Change());
    }

   public IEnumerator Change()
    {
        yield return new WaitForSeconds(2);
        rndIndex = Random.Range(0, 6);
        this.gameObject.GetComponent<Renderer>().material = material[rndIndex];
        StartCoroutine(Change());
    }

}
