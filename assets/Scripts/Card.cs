using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    [SerializeField] SpriteRenderer card;
    [SerializeField] SpriteRenderer Character;
    [SerializeField] TMP_Text CardnameTMP;
    [SerializeField] TMP_Text CardAkTMP;
    [SerializeField] TMP_Text CardHpTMP;
    [SerializeField] Sprite cardFront;
    [SerializeField] Sprite cardBack;

    public Item item;
    bool isFront;

    public void Setup(Item item, bool isFront)
    {
        this.item = item;
        this.isFront = isFront;

        if (this.isFront)
        {
            Character.sprite = this.item.sprite;
            CardnameTMP.text = this.item.name;
            CardAkTMP.text = this.item.attack.ToString();
            CardHpTMP.text = this.item.health.ToString();
        }
        else
        {
            card.sprite = cardBack;
            CardnameTMP.text = "";
            CardAkTMP.text = "";
            CardHpTMP.text = "";
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
