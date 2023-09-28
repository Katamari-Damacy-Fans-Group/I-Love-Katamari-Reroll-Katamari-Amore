using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics;

public class DialogueUI : MonoBehaviour
{

    [SerializeField] private TMP_Text textLabel;

    private void Start()
    {
        GetComponent<TypewriterEffect>().Run("If you can read this, you are in the correct project.", textLabel);
    }
}
