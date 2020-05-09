using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

namespace Managers
{
    public class ManagerAudio : MonoBehaviour
    {
        public AudioDrop audioPrefab;

        AudioClipListVariable audioList;

        private void Awake()
        {
            ManagerStatic.audioManager = this;
        }

        private void Start()
        {
            audioList = Resources.Load<AudioClipListVariable>(AudioClipListVariable.resourcePath);
            PoolManager.MakePool(audioPrefab.gameObject, 50, 20, true);
        }

        public void PlaySound(DeezNuts _group, Vector3 _pos)
        {
            var ad = PoolManager.Spawn(audioPrefab.gameObject, _pos, Quaternion.identity).GetComponent<AudioDrop>();
            ad.audioSource.clip = audioList.GetRandomClip(_group);
            ad.audioSource.spatialize = true;
            ad.Play();
        }

        public void PlaySoundGlobal(DeezNuts _group)
        {
            var ad = PoolManager.Spawn(audioPrefab.gameObject, Vector3.zero, Quaternion.identity).GetComponent<AudioDrop>();
            ad.audioSource.clip = audioList.GetRandomClip(_group);
            ad.audioSource.spatialize = false;
            ad.Play();
        }

        public void PlaySoundGlobal(int _group)
        {
            PlaySoundGlobal((DeezNuts)_group);
        }
    }
}
