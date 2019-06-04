using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {

    //public GameObject startUI, shopUI;

    //private CanvasGroup fadeGroup;
    //private float fadeInSpeed = 0.33f;

    //public Transform shopMenu;
    //public Transform levelMenu;
    //public Transform mainMenu;


    //private Quaternion startRotation;

    /*private Vector3 desiredPosition;
    private Quaternion desiredRotation;

    public Transform shopWaypoint;
    public Transform levelWaypoint;*/

    /*public RectTransform menuContainer;
    public Transform levelPanel;*/

    //private Vector3 desiredMenuPosition;

    private void Start()
    {
        //Start with white screen
        //fadeGroup = FindObjectOfType<CanvasGroup>();
        //fadeGroup.alpha = 1f;

        //Move menu
        /*startPosition = desiredPosition = transform.localPosition;
        startRotation = desiredRotation = transform.localRotation;*/

        //InitShop();

        //InitLevel();



    }

   

    private void Update()
    {
        //Fade-in
        //fadeGroup.alpha = 1 - Time.timeSinceLevelLoad * fadeInSpeed;


        //Move menu
        //menuContainer.anchoredPosition3D = Vector3.Lerp(menuContainer.anchoredPosition3D, desiredMenuPosition, 0.1f);

        //transform.localPosition = Vector3.Lerp(mainMenu.localPosition, desiredMenuPosition, 0.1f);
        //transform.localRotation = Quaternion.Lerp(transform.localRotation, desiredRotation, 0.1f);

    }

    /*private void InitShop()
    {
        Debug.Log("Shop Initiatilisation");
    }

    private void InitLevel()
    {
        Debug.Log("Level Initiatilisation");
    }

    private void NavigateTo(int menuIndex)
    {
        switch (menuIndex)
        {
            //1 = Play Menu
            case 1:
                desiredMenuPosition = Vector3.right * 1280;
                //menuCam.MoveToLevel();
                break;
            //2 = Shop Menu
            case 2:
                desiredMenuPosition = Vector3.left * 1280;
                //menuCam.MoveToShop();
                break;
            //0 && default case = main menu
            default:
            case 0:
                desiredMenuPosition = Vector3.zero;
                //menuCam.BackToMainMenu();
                break;

        }
    }*/

    public void OnPlayClick()
    {
        SceneManager.LoadScene(1);
        //NavigateTo(1);
    }

    /*public void OnShopClick()
    {
        NavigateTo(2);
    }

    public void OnBackClick()
    {
        NavigateTo(0);
    }*/

    // Use this for initialization
    /* public void ToggleUI()
     {
         startUI.SetActive(!startUI.activeSelf);
         shopUI.SetActive(!shopUI.activeSelf);
     }*/

    /* public void BackToMainMenu()
     {
         desiredPosition = startPosition;
         desiredRotation = startRotation;
     }

     public void MoveToShop()
     {
         desiredPosition = shopWaypoint.localPosition;
         desiredRotation = shopWaypoint.localRotation;
     }

     public void MoveToLevel()
     {
         desiredPosition = levelWaypoint.localPosition;
         desiredRotation = levelWaypoint.localRotation;
     }*/


}
