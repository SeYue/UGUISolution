using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
	public Button Button;

	void Start()
	{
		Button.onClick.AddListener(() =>
		{
			Debug.Log("����˰�ť");

			using (new DisposeTest())
			{
				Debug.Log("using");
			}
		});
	}
}

class DisposeTest : IDisposable
{
	~DisposeTest()
	{
		Debug.Log("��������");
	}

	public void Dispose()
	{
		Debug.Log("1111");
	}
}