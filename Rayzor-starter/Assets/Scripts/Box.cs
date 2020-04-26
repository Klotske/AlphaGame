using System.Collections;using System.Collections.Generic;using UnityEngine;using UnityEngine.UI;//using UnityEngine.CoreModule;public class Box : MonoBehaviour{    public GameObject dialogBox;    public GameObject ImageBox;    public GameObject CodeLock;    public Sprite sprite;    public Text dialogText;    public string dialog;    public bool ItsCodeLock;    public bool bigBox;    private bool playerInRange;    // Start is called before the first frame update    void Start()    {            }        // Update is called once per frame    void Update()    {        if(Input.GetKeyDown(KeyCode.F) && playerInRange && !ItsCodeLock)        {            if (ImageBox.activeInHierarchy)
            {
                ImageBox.SetActive(false);
            }            else
            {
                ImageBox.SetActive(true);
                Image image = ImageBox.GetComponent("Image") as UnityEngine.UI.Image;
                image.sprite = sprite;
            }        }        else if (Input.GetKeyDown(KeyCode.F) && playerInRange && ItsCodeLock)        {            if (CodeLock.activeInHierarchy)
            {
                CodeLock.SetActive(false);
            }            else
            {
                CodeLockBox codeLockBox = CodeLock.GetComponent("CodeLockBox") as CodeLockBox;
                codeLockBox.ItsBig(bigBox);
                CodeLock.SetActive(true);
            }        }    }        private void OnTriggerEnter2D(Collider2D other)    {        if (other.CompareTag("Player"))        {            Debug.Log("Player in range");            dialogBox.SetActive(true);            dialogText.text = dialog;            playerInRange = true;        }    }    private void OnTriggerExit2D(Collider2D other)    {        if (other.CompareTag("Player"))        {            Debug.Log("Player left range");            dialogBox.SetActive(false);            playerInRange = false;            ImageBox.SetActive(false);            CodeLock.SetActive(false);        }    }}