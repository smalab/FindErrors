using UnityEngine;
using System.Collections;

public class TextPlace : MonoBehaviour {

	public Rect rect1 = new Rect(0, 0, 200, 50);

	public Rect rect2 = new Rect(0, 50, 200, 50);

	public Rect rect3 = new Rect(0, 100, 200, 50);

	public Rect rect4 = new Rect(0, 150, 200, 50);

	public string A;

	public string B;

	public string C;

	public string D;

	public bool isClicked1;

	public bool isClicked2;

	public bool isClicked3;

	public bool isClicked4;

	public GUIStyleState styleState;

	private GUIStyle style;

	public void esakuta(){

		style = new GUIStyle();
		Rect rect = new Rect(10, 10, 400, 300);
		style.normal = styleState;
		GUI.Label(rect, "Stand by Ready!", style);
	

	}

	public void OnGUI()
	{


		 bool isClicked1 = GUI.Button(rect1, A);
		
		 bool isClicked2 = GUI.Button(rect2, B);
		
		 bool isClicked3 = GUI.Button(rect3, C);
		
		 bool isClicked4 = GUI.Button(rect4, D);



		if (isClicked1)
			{
				esakuta();
			}

		if (isClicked2)
			{ 
			}

		if (isClicked3)
			{
			}

		if (isClicked4)
			{
			}
	}
}
