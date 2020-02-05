using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalsView : MonoBehaviour
{
    public Transform Content;
    public GameObject ListItem;

    public void CreateList(List<Animal> animals)
    {
        for (int i = 0; i < animals.Count; ++i)
        {
            GameObject go = Instantiate(ListItem, Content);
            ItemParams p = go.GetComponent<ItemParams>();
            p.Name.text = animals[i].type.ToString();
            p.Icon.sprite = Resources.Load<Sprite>(AnimalGraphicInfo.AnimalsInfo[animals[i].type].icon);
            p.BgImage.color = AnimalGraphicInfo.AnimalsInfo[animals[i].type].color;
            int index = i;
            Animal animal = animals[i];
            p.AnimalButton.onClick.AddListener(delegate () { OnAnimalClick(index, animal); });
        }
    }

    public void OnAnimalClick(int index, Animal animal)
    {
        Controller.instance.ShowFact(animal);
    }
}