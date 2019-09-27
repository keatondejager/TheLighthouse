using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Player;

public class DB_Puzzle : MonoBehaviour {
    
    public List<Item> requirements;
    public List<Image> requirementsCheckboxes;

    public Sprite acquiredCheck;
    public Sprite missingCheck;

    public GameObject ButtonPrompt;
    public GameObject puzzleUI;
    public Transform ReferencePosition;

    protected PlayerManager manager;
    protected Vector3 defaultPosition;
    

    public int puzzleState = 0;

    private void Start() {
        manager = PlayerReference.instance.manager;
        defaultPosition = this.transform.position;
    }
    
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            PlayerReference.instance.dB_Puzzle = this;
            manager.OnInteractEnter += Interact;
            ButtonPrompt.SetActive(true);
        }
    }   

     private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            PlayerReference.instance.dB_Puzzle = null;
            manager.OnInteractEnter -= Interact;
            ButtonPrompt.SetActive(false);
        }
    }   

    public void Interact () {
        puzzleUI.SetActive(true);
        transform.position = ReferencePosition.position;
    }

    public void ClosePuzzle () {
        puzzleUI.SetActive(false);
        transform.position = defaultPosition;
    }

    public bool CheckRequirements() {
        bool result = true;
        int index = 0;
        foreach (Item item in requirements) {
            bool currentStatus = PlayerReference.instance.PlayerInventory.Contains(item);

            requirementsCheckboxes[index].sprite = currentStatus ? acquiredCheck : missingCheck;

            result = result && currentStatus;
            index ++;
        }

        return result;
    }

}
