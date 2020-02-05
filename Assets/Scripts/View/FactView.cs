using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FactView : MonoBehaviour
{
    public Transform FactObject;
    public Animator FactAnimator;
    public Text Fact;
    public GameObject VerifiedIcon;
    public Scrollbar FactScrollbar;

    public void OpenFactView( Animal animal)
    {
        FactAnimator.SetTrigger("open");
        Fact.text = animal.text;
        Debug.Log(animal.status.verified);
        VerifiedIcon.SetActive(animal.status.verified);
        StartCoroutine(UpdateScroll());
    }


    IEnumerator UpdateScroll()
    {
        yield return new WaitForSeconds(0.2f);
        FactScrollbar.value = 1;
    }
}
