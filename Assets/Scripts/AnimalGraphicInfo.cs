using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalGraphicInfo
{
    public AnimalGraphicInfo(Color color, string icon)
    {
        this.color = color;
        this.icon = icon;
    }

    public Color color { set; get; }
    public string icon { set; get; }

    public static readonly AnimalGraphicInfo DogInfo =
        new AnimalGraphicInfo(new Color32(239, 82, 130, 255), "dogIcon");
    public static readonly AnimalGraphicInfo CatInfo =
        new AnimalGraphicInfo(new Color32(141, 182, 201, 255), "catIcon");
    public static readonly AnimalGraphicInfo HorseInfo =
         new AnimalGraphicInfo(new Color32(243, 168, 70, 255), "horseIcon");

    public static readonly Dictionary<AnimalType, AnimalGraphicInfo> AnimalsInfo =
        new Dictionary<AnimalType, AnimalGraphicInfo>  {
        {AnimalType.dog, DogInfo},
        {AnimalType.cat, CatInfo},
        {AnimalType.horse, HorseInfo}
    };
}
