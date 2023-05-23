using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User 
{
    public string Name;

    public string Password;
    public User(string Name, string Password)
    {
        this.Name = Name;
        this.Password = Password;
    }
}
