using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelloWolrd : MonoBehaviour
{
	static int numClicks = 0;

	[SerializeField]
	GameObject neato;

	private void Start()
	{
		//numClicks = PlayerPrefs.GetInt("hello", 0); ;
		Debug.Log($"numClicks = {numClicks}");
	}

	public void OnClickEvent()
    {
		numClicks += 1;
		//PlayerPrefs.SetInt("hello", numClicks);
		//PlayerPrefs.Save();
		Debug.Log($"numClicks = {numClicks}");
		SceneManager.LoadScene("SampleScene");
		//Destroy(neato);
		//neato = Instantiate<GameObject>(neato);
		//neato.transform.position = Vector3.zero;
		//neato.transform.rotation = Quaternion.identity;
		//neato.transform.rotation = Quaternion.Euler(180, 180, 180);
	}
}
