using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public enum Mixer
{
    SFX,
    MUSIC
}

namespace Managers
{
    public class ManagerAudio : MonoBehaviour
    {
        public AudioDrop audioPrefab;
        public AudioMixerGroup[] mixers;

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

        public void PlaySound(DeezNuts _group, Vector3 _pos, Mixer _soundType)
        {
            var ad = PoolManager.Spawn(audioPrefab.gameObject, _pos, Quaternion.identity).GetComponent<AudioDrop>();
            ad.audioSource.outputAudioMixerGroup = mixers[(int)_soundType];
            ad.audioSource.clip = audioList.GetRandomClip(_group);
            ad.audioSource.spatialize = true;
            ad.Play();
        }

        public void PlaySound(DeezNuts _group, int sound, Vector3 _pos, Mixer _soundType)
        {
            var ad = PoolManager.Spawn(audioPrefab.gameObject, _pos, Quaternion.identity).GetComponent<AudioDrop>();
            ad.audioSource.outputAudioMixerGroup = mixers[(int)_soundType];
            ad.audioSource.clip = audioList.clipGroups[(int)_group].clips[sound];
            ad.audioSource.spatialize = false;
            ad.Play();
        }

        public void PlaySoundGlobal(DeezNuts _group, Mixer _soundType)
        {
            var ad = PoolManager.Spawn(audioPrefab.gameObject, Vector3.zero, Quaternion.identity).GetComponent<AudioDrop>();
            ad.audioSource.outputAudioMixerGroup = mixers[(int)_soundType];
            ad.audioSource.clip = audioList.GetRandomClip(_group);
            ad.audioSource.spatialize = false;
            ad.Play();
        }

        public void PlaySoundGlobal(DeezNuts _group, int sound, Mixer _soundType)
        {
            var ad = PoolManager.Spawn(audioPrefab.gameObject, Vector3.zero, Quaternion.identity).GetComponent<AudioDrop>();
            ad.audioSource.outputAudioMixerGroup = mixers[(int)_soundType];
            ad.audioSource.clip = audioList.clipGroups[(int)_group].clips[sound];
            ad.audioSource.spatialize = false;
            ad.Play();
        }

        public void PlaySoundGlobal(int _group, Mixer _soundType)
        {
            PlaySoundGlobal((DeezNuts)_group, _soundType);
        }

        public void PlaySoundGlobalLoop(DeezNuts _group, int sound, Mixer _soundType)
        {
            StartCoroutine(LoopSong(audioList.clipGroups[(int)_group].clips[sound], _soundType));
        }

        public void StopGlobalSounds()
        {
            StopAllCoroutines();
        }

        private IEnumerator LoopSong(AudioClip audio, Mixer _soundType)
        {
            while(true)
            {
                var ad = PoolManager.Spawn(audioPrefab.gameObject, Vector3.zero, Quaternion.identity).GetComponent<AudioDrop>();
                ad.audioSource.outputAudioMixerGroup = mixers[(int)_soundType];
                ad.audioSource.clip = audio;
                ad.audioSource.spatialize = false;
                ad.Play();
                yield return new WaitForSeconds(audio.length);
            }
        }
    }
}
