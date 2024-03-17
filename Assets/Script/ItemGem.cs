using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemGem : MonoBehaviour
{

    private int gem = 0;

    [SerializeField] private Text gemText;

    [SerializeField] private AudioSource collisionSoundEffect;

   private void OnTriggerEnter2D(Collider2D collision)
   {
    if (collision.gameObject.CompareTag("gem"))
    {
        collisionSoundEffect.Play();
        Destroy(collision.gameObject);
        gem++;
        gemText.text = ": " + gem;
    } 
   }
}
