using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimalType
{
    dog,
    cat,
    horse,
}

public struct Status
{
    public bool verified { set; get; }
    public int sentCount { set; get; }
}

public class Animal
{
    public bool used { set; get; }
    public string source { set; get; }
    public AnimalType type { set; get; }
    public bool deleted { set; get; }
    public string _id { set; get; }
    public string updatedAt { set; get; }
    public string createdAt { set; get; }
    public string user { set; get; }
    public string text { set; get; }
    public int __v { set; get; }
    public Status status { set; get; }

    public Animal(bool used, string source, AnimalType type, bool deleted, string id,
        string updatedAt, string createdAt, string user, string text, int v,
        Status status)
    {
        this.used = used;
        this.source = source;
        this.type = type;
        this.deleted = deleted;
        _id = id;
        this.updatedAt = updatedAt;
        this.createdAt = createdAt;
        this.user = user;
        this.text = text;
        __v = v;
        this.status = status;
    }
}
