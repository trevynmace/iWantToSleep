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
        GameObject character = GameObject.Find("character");
        //Rigidbody2D rb = character.GetComponent<Rigidbody2D>();

        var moveSpeed = 2f;
	    var jumpPower = 6f;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //rb.MovePosition(rb.position + new Vector2(rb.position.x + 2, rb.position.y) * Time.deltaTime);
            character.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
	    if (Input.GetKey(KeyCode.LeftArrow))
	    {
            //rb.MovePosition(rb.position + new Vector2(rb.position.x - 2, rb.position.y) * Time.deltaTime);
            transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
        }

	    if (Input.GetKey(KeyCode.Space))
	    {
	        character.transform.Translate(Vector3.up * jumpPower * Time.deltaTime);
	    }
	}
}