using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    [SerializeField] GameObject _boom;

    private void Start()
    {
       
        _boom.SetActive(false);
        StartCoroutine(WaitForExplode());
    }
    IEnumerator WaitForExplode()
   {
        yield return new WaitForSeconds(3);       
        _boom.SetActive(true);
        Debug.Log("Activate");  
        yield return new WaitForSeconds(0.5f); 
        Destroy(gameObject);
    }

    
}
