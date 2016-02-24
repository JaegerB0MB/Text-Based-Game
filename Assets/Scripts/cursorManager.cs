using UnityEngine;
using System.Collections;

public class cursorManager : MonoBehaviour {

	public Texture2D hand;
	Vector2 handOffSet;

	// Use this for initialization
	void Start () {
		// resizez the cursor of the Texture2D attached in the public field (in the inspector)
		handOffSet = new Vector2 ((hand.width * .45f ), (hand.height * .2f ));
	}
	

	public void mouseOverHand(){
		// call this through the event system to switch the cursor to the 'hand' texture2D
		Cursor.SetCursor (hand, handOffSet  , CursorMode.Auto);
	}

	public void defaultCursor(){
		// call this through the event system to switch the cursor to Unity's default arrow cursor
		Cursor.SetCursor(null, Vector2.zero , CursorMode.Auto);
	}
}
