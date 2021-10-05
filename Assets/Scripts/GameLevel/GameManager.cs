using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private GameObject squarePreFab;
    [SerializeField]
    private Transform squarePanel;
    private GameObject[] squareArray = new GameObject[25];
    // Use this for initialization
    void Start()
    {
        CreateSquare();
    }

    // Update is called once per frame
    public void CreateSquare()
    {
        for (int i = 0; i < 25; i++)
        {
            GameObject square = Instantiate(squarePreFab, squarePanel);
            squareArray[i] = square;
        }
		EditTextSquare();
		StartCoroutine(DoFadeRouting());
    }
    IEnumerator DoFadeRouting()
    {
        foreach (var item in squareArray)
        {
			item.GetComponent<CanvasGroup>().DOFade(1,0.2f);
			yield return new WaitForSeconds(0.07f);
        }
		
    }
	public void EditTextSquare(){
		foreach (var item in squareArray)
		{
			int randomNum = Random.Range(1,13);
			item.transform.GetChild(0).GetComponent<Text>().text = randomNum.ToString();
		}
	}
}