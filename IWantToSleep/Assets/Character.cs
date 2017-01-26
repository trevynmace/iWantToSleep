using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour 
{
	void Start () 
	{
        CharacterSprite controller = new CharacterSprite();
        Sprite frontFacingSprite = controller.GetFrontFacing();

        GameObject character = GameObject.Find("character");
        SpriteRenderer renderer = character.GetComponent<SpriteRenderer>();
        renderer.sprite = frontFacingSprite;
        
        character.transform.position = new Vector3(0.2f,0.2f,1);
    }
	
	void Update () 
	{
	    //TODO: need to add controls for character and see how the gravity vs ground works.... hopefully like it normally would be expected to work
		if (Input.GetKeyDown (KeyCode.LeftArrow)) 
		{
			GameObject character = GameObject.Find("character");
			var x = character.transform.position.x;
			var y = character.transform.position.y;

			character.transform.position = new Vector3 (x - 0.5f, y, 1);
		}
	}
}