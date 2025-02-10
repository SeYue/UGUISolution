using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
	public Button Button;

	void Start()
	{
		Button.onClick.AddListener(() =>
		{
			Debug.Log("µã»÷ÁË°´Å¥");
		});
	}
}
