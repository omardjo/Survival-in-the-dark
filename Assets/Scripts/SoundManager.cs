using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;

    private bool muted = false;

    // Start is called before the first frame update
    void Start()
    {
        // Check if "muted" exists in PlayerPrefs, otherwise initialize it
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0); // 0 means sound is ON by default
            Load();
        }

        // Load the muted state and update UI accordingly
        Load();
        UpdateSoundState();
    }

    // Function to update the sound state and icon visibility
    private  void UpdateButtonIcon()
    {
        // Update the icons based on whether the sound is muted or not
        if (muted == false)
        {
            soundOnIcon.enabled = true;
            soundOffIcon.enabled = false;
        }
        else
        {
            soundOnIcon.enabled = false;
            soundOffIcon.enabled = true;
        }
    }

    // Call this when the button is pressed to toggle sound
    public void OnButtonPress()
    {
            // Toggle the mute state
    if (muted == false)
    {
    muted = true;
    AudioListener.pause = true;
        Debug.Log("pause equals to true ");
    }
    else
    {
    muted = false;
    AudioListener.pause = false;
        Debug.Log("pause equals to false");
    }
    Save();
    UpdateButtonIcon();
        }

    // Function to apply the mute state (sound on/off)
    private void UpdateSoundState()
    {
        // Mute or unmute the sound based on the "muted" state
        AudioListener.pause = muted;

        // Update the button icons to reflect the current state
        UpdateButtonIcon();
    }

    // Load the saved mute state from PlayerPrefs
    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    // Save the current mute state to PlayerPrefs
    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}