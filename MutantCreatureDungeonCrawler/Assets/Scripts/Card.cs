using UnityEngine;
using System.Collections;

public abstract class Card {

	public enum CardType { Spell, Enchantment, Curse, Equipment, Potion };

	/// <summary>
	/// The basic type of the card.
	/// </summary>
	private readonly CardType myType;

	/// <summary>
	/// The amount of mana that must be paid in order to play the card.
	/// </summary>
	private int myManaCost;

	/// <summary>
	/// Initializes a new instance of the <see cref="Card"/> class.
	/// </summary>
	/// <param name="type">The basic type of the card.</param>
	/// <param name="manaCost">The amount of mana that must be paid to play the card.</param>
	public Card (CardType type, int manaCost) {
		this.myType = type;
		this.myManaCost = manaCost;
	}

	public void Show()
	{
		GameObject newObj = new GameObject("medicObj", typeof(SpriteRenderer));
		SpriteRenderer renderer = newObj.GetComponent<SpriteRenderer>();
		Sprite newSprite = Resources.Load<Sprite>("MagicCard");
		renderer.sprite = newSprite;
	}
}
