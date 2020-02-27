using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class End : MonoBehaviour {
      void Start()
     {
         StartCoroutine(LoadLevelAfterDelay(130f));     
     }
 
     IEnumerator LoadLevelAfterDelay(float delay)
     {
      yield return new WaitForSeconds(delay);
      SceneManager.LoadScene("Result");
     }
}
