using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineController : MonoBehaviour {

	public void Fade(GameObject itemToFade, float waitingTime, int direction)
	{
		StartCoroutine(Fading(itemToFade, waitingTime, direction));
	}

	public void Wait(float timeToWait)
	{
		StartCoroutine(Waiting(timeToWait));
	}

	IEnumerator Fading(GameObject itemToFade, float waitingTime, int direction)
    {
        yield return new WaitForSeconds(waitingTime);
        float simpleTime = 0.8f;
		while (itemToFade.GetComponent<CanvasGroup>().alpha != (direction == 1? 1 : 0))
		{
			itemToFade.GetComponent<CanvasGroup>().alpha += Time.deltaTime / simpleTime * direction;
			yield return null;
		}
		itemToFade.GetComponent<CanvasGroup>().interactable = direction == 1? true : false;
		itemToFade.GetComponent<CanvasGroup>().blocksRaycasts = direction == 1? true : false;
        
    }
	
	IEnumerator Waiting(float timeToWait)
	{
		yield return new WaitForSeconds(timeToWait);
	}
}
