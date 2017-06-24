using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {

		yield return new WaitForSeconds (1f);

		DialogDataAlert alert = new DialogDataAlert ("Welcome", "Lets start!", delegate() {
			Debug.Log("OK Pressed!");

			DialogDataConfirm confirm = new DialogDataConfirm("Buy Gold?", "Do you want buy 100,000 golds?", 
				delegate(bool yn) {
					if(yn){
						Debug.Log("Confirm OK");
					}else{
						Debug.Log("Confirm Cancel");
						
					}
				
			});
			
			DialogManager.Instance.Push(confirm);

		});
		DialogManager.Instance.Push (alert);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
