using UnityEngine;
using System.Collections;
using LitJson;

public class DataManager : MonoBehaviour {


	// Use this for initialization
	IEnumerator Start()
	{
		//Load JSON data from a URL
		string url = "";
		WWW www = new WWW(url);
		
		//Load the data and yield (wait) till it's ready before we continue executing the rest of this method.
		yield return www;
		if (www.error == null)
		{
			//Sucessfully loaded the JSON string
			Debug.Log("Loaded following JSON string" + www.text);
			
			//Process books found in JSON file
			//ProcessBooks(www.data);
		}
		else
		{
			Debug.Log("ERROR: " + www.error);
		}
		
	}
	// Update is called once per frame
	void Update () {
	
	}
}

/* Credit goes to 
/* http://blog.paultondeur.com/2010/03/23/tutorial-loading-and-parsing-external-xml-and-json-files-with-unity-part-2-json/  */
