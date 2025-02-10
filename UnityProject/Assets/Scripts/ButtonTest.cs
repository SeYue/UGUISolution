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
			Debug.Log("点击了按钮");

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
		Debug.Log("析构函数");
	}

	public void Dispose()
	{
		Debug.Log("1111");
	}
}