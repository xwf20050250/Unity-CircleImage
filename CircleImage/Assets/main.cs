using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour {

    public Button m_btn;

	// Use this for initialization
	void Start () {
        m_btn.onClick.AddListener(OnBtnClicked);
    }
	
	// Update is called once per frame
	void OnBtnClicked() {
        Debug.LogErrorFormat("button click...");
	}
}
