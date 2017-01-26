using UnityEngine;
using System.Collections;
using System.IO;

public class CharacterSprite
{
	public Sprite GetFrontFacing()
	{
        Texture2D characterSheet = new Texture2D(2,2);
        characterSheet.LoadImage(File.ReadAllBytes("Assets/Textures/characterSheet.png"));

        int x = 200;
	    int y = 64;
	    int width = 17;
	    int height = 24;

        Color[] pix = characterSheet.GetPixels(x, y, width, height);
        Texture2D destTex = new Texture2D(width, height);
        destTex.SetPixels(pix);

        Rect rec = new Rect(0, 0, width, height);
        Sprite characterSprite = Sprite.Create(destTex, rec, new Vector2(0.5f, 0.5f), 300f);

	    return characterSprite;
	}
}