using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class Controller : MonoBehaviour
{
    public static Controller instance = null;

    public AnimalsView animalsView;
    public FactView factView;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(
            GetRequest("https://cat-fact.herokuapp.com/facts/random?animal_type=cat,dog,horse&amount=10",
             animalsView.CreateList)
          );
    }

    IEnumerator GetRequest(string uri, Action<List<Animal>> callBack)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                string json = webRequest.downloadHandler.text;
                List<Animal> animals = JsonConvert.DeserializeObject<List<Animal>>(json);
                callBack(animals);
            }
        }
    }

    public void ShowFact(Animal animal)
    {
        factView.OpenFactView(animal);
    }

}
