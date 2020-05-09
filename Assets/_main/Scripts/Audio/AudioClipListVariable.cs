using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AudioClipListVariable", menuName = "Audio Clip List")]
public class AudioClipListVariable : ScriptableObject
{
    public static string resourcePath = "Audio/AudioClipListVariable";

    public List<AudioClipGroup> clipGroups = new List<AudioClipGroup>();

    private Dictionary<string, int> addresses;
    private Dictionary<string, int> Addresses
    {
        get
        {
            if(addresses == null)
            {
                addresses = new Dictionary<string, int>();
                for(int i = 0; i < clipGroups.Count; i++)
                {
                    addresses.Add(clipGroups[i].name, i);
                }
            }
            return addresses;
        }
    }

    public AudioClip GetRandomClip(string _group)
    {
        var group = clipGroups[Addresses[_group]].clips;
        return group[Random.Range(0, group.Count)];
    }

    public AudioClip GetRandomClip(DeezNuts _group)
    {
        var group = clipGroups[(int)_group].clips;
        return group[Random.Range(0, group.Count)];
    }

    public void RemoveGroup(string _name)
    {
        clipGroups.RemoveAt(Addresses[_name]);
        addresses.Remove(_name);
    }

    [System.Serializable]
    public class AudioClipGroup
    {
        public string name;
        public List<AudioClip> clips = new List<AudioClip>();

        public AudioClipGroup(string name)
        {
            this.name = name;
            clips = new List<AudioClip>();
        }
    }
}