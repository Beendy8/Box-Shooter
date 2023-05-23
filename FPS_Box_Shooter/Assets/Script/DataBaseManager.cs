using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Firebase.Database;
using System;

public class DataBaseManager : MonoBehaviour
{
    [SerializeField] TMP_InputField nameInput; 
    [SerializeField] TMP_InputField password; 
    private DatabaseReference dbReference;
    private void Start()
    {
        dbReference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public void CreateUser()
    {
        User newUser = new User(nameInput.text, password.text);
        string jcon = JsonUtility.ToJson(newUser);
        dbReference.Child("Users").Child(nameInput.text).SetRawJsonValueAsync(jcon);
    }

    public IEnumerator GetValue(Action<string> onCallBack)
    {
        var userData = dbReference.Child("Users").Child(nameInput.text).Child("Password").GetValueAsync();
        yield return new WaitUntil(predicate: ()=> userData.IsCompleted);
        if (userData != null)
        {
            DataSnapshot dataSnapshot = userData.Result;
            onCallBack.Invoke(dataSnapshot.Value.ToString());
        }
    }

    public void Check()
    {
        StartCoroutine(GetValue((string v) =>
        {
            if (password.text == v)
            {
                Debug.Log("Вы зашли");
                //Переход на другой уровень
            }
        }));
    }
}

