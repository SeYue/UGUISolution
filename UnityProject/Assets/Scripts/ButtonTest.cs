using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
	public Button Button;
	delegate void ActionTest();
	ActionTest at;

	public AddMoneyEvent addMoneyEvent;

	void Start()
	{
		at = OnClick;
		Debug.Log(at.Target);
		Debug.Log(at.Method);
		at.Method.Invoke(this, null);
		Button.onClick.AddListener(OnClick);
	}

	public void OnClick()
	{
		Debug.Log("����˰�ť");

		using (new DisposeTest())
		{
			Debug.Log("using");
		}
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