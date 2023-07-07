using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager
{
    private static AudioManager _instance = null;
    public static AudioManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new AudioManager();

            }
            return _instance;
        }
    }

    #region Music

    /// <summary>
    /// 播放BMG音乐
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <returns></returns>
    public AudioObject PlayMusic(AudioName audioName)
    {
        return AudioController.PlayMusic(audioName.ToString());
    }

    /// <summary>
    /// 播放BMG音乐
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <param name="volume">音量</param>
    /// <returns></returns>
    public AudioObject PlayMusic(AudioName audioName, float volume)
    {
        return AudioController.PlayMusic(audioName.ToString(), volume);
    }

    /// <summary>
    /// 播放BMG音乐
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <param name="volume">音量</param>
    /// <param name="delay">延迟</param>
    /// <param name="startTime">音频开始点</param>
    /// <returns></returns>
    public AudioObject PlayMusic(AudioName audioName, float volume, float delay, float startTime = 0)
    {
        return AudioController.PlayMusic(audioName.ToString(), volume, delay, startTime);
    }

    /// <summary>
    /// 播放BMG音乐
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <param name="parentObj">父物体</param>
    /// <param name="volume">音量</param>
    /// <param name="delay">延迟</param>
    /// <param name="startTime">音频开始点</param>
    /// <returns></returns>
    public AudioObject PlayMusic(AudioName audioName, Transform parentObj, float volume = 1, float delay = 0, float startTime = 0)
    {
        return AudioController.PlayMusic(audioName.ToString(), parentObj, volume, delay, startTime);
    }

    /// <summary>
    /// 播放BMG音乐
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <param name="worldPosition">播放位置</param>
    /// <param name="parentObj">父物体</param>
    /// <param name="volume">音量</param>
    /// <param name="delay">延迟</param>
    /// <param name="startTime">音频开始点</param>
    /// <returns></returns>
    public AudioObject PlayMusic(AudioName audioName, Vector3 worldPosition, Transform parentObj = null, float volume = 1, float delay = 0, float startTime = 0)
    {
        return AudioController.PlayMusic(audioName.ToString(), worldPosition, parentObj, volume, delay, startTime);
    }

    public AudioObject PlayMusic(string audioID)
    {
        return AudioController.PlayMusic(audioID);
    }

    public AudioObject PlayMusic(string audioID, float volume)
    {
        return AudioController.PlayMusic(audioID, volume);
    }

    public AudioObject PlayMusic(string audioID, float volume, float delay, float startTime = 0)
    {
        return AudioController.PlayMusic(audioID, volume, delay, startTime);
    }

    public AudioObject PlayMusic(string audioID, Transform parentObj, float volume = 1, float delay = 0, float startTime = 0)
    {
        return AudioController.PlayMusic(audioID, parentObj, volume, delay, startTime);
    }

    public AudioObject PlayMusic(string audioID, Vector3 worldPosition, Transform parentObj = null, float volume = 1, float delay = 0, float startTime = 0)
    {
        return AudioController.PlayMusic(audioID, worldPosition, parentObj, volume, delay, startTime);
    }

    /// <summary>
    /// 停止BGM音乐
    /// </summary>
    /// <returns></returns>
    public bool StopMusic()
    {
        return AudioController.StopMusic();
    }

    /// <summary>
    /// 停止BGM音乐
    /// </summary>
    /// <param name="fadeOut">淡出时间</param>
    /// <returns></returns>
    public bool StopMusic(float fadeOut)
    {
        return AudioController.StopMusic(fadeOut);
    }

    /// <summary>
    /// 暂停BGM音乐
    /// </summary>
    /// <param name="fadeOut">淡出时间</param>
    /// <returns></returns>
    public bool PauseMusic(float fadeOut = 0)
    {
        return AudioController.PauseMusic(fadeOut);
    }

    /// <summary>
    /// BGM音乐是否暂停
    /// </summary>
    /// <returns></returns>
    public bool IsMusicPaused()
    {
        return AudioController.IsMusicPaused();
    }

    /// <summary>
    /// 恢复BGM音乐
    /// </summary>
    /// <param name="fadeIn">淡入时间</param>
    /// <returns></returns>
    public bool UnpauseMusic(float fadeIn = 0)
    {
        return AudioController.UnpauseMusic(fadeIn);
    }

    /// <summary>
    /// 添加音效至BGM音乐列表
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <returns></returns>
    public int EnqueueMusic(AudioName audioName)
    {
        return AudioController.EnqueueMusic(audioName.ToString());
    }

    public int EnqueueMusic(string audioID)
    {
        return AudioController.EnqueueMusic(audioID);
    }

    /// <summary>
    /// 获取BGM音乐列表
    /// </summary>
    /// <returns></returns>
    public string[] GetMusicPlaylist()
    {
        return AudioController.GetMusicPlaylist();
    }

    /// <summary>
    /// 设置BGM音乐列表
    /// </summary>
    /// <param name="playlist">BGM音乐列表</param>
    public void SetMusicPlaylist(string[] playlist)
    {
        AudioController.SetMusicPlaylist(playlist);
    }

    /// <summary>
    /// 播放BGM音乐列表
    /// </summary>
    /// <returns></returns>
    public AudioObject PlayMusicPlaylist()
    {
        return AudioController.PlayMusicPlaylist();
    }

    /// <summary>
    /// 播放下一首BGM音乐
    /// </summary>
    /// <returns></returns>
    public AudioObject PlayNextMusicOnPlaylist()
    {
        return AudioController.PlayNextMusicOnPlaylist();
    }

    /// <summary>
    /// 播放上一首BGM音乐
    /// </summary>
    /// <returns></returns>
    public AudioObject PlayPreviousMusicOnPlaylist()
    {
        return AudioController.PlayPreviousMusicOnPlaylist();
    }

    /// <summary>
    /// 是否正在播放BGM音乐列表
    /// </summary>
    /// <returns></returns>
    public bool IsPlaylistPlaying()
    {
        return AudioController.IsPlaylistPlaying();
    }

    /// <summary>
    /// 清除BGM音乐列表
    /// </summary>
    public void ClearPlaylist()
    {
        AudioController.ClearPlaylist();
    }

    /// <summary>
    /// 设置BGM音乐的启用状态
    /// </summary>
    /// <param name="b"></param>
    public void EnableMusic(bool b)
    {
        AudioController.EnableMusic(b);
    }

    /// <summary>
    /// 获取BGM音乐的启用状态
    /// </summary>
    /// <returns></returns>
    public bool IsMusicEnabled()
    {
        return AudioController.IsMusicEnabled();
    }

    /// <summary>
    /// 获取当前的BGM音乐
    /// </summary>
    /// <returns></returns>
    public AudioObject GetCurrentMusic()
    {
        return AudioController.GetCurrentMusic();
    }

    #endregion

    #region Sound

    /// <summary>
    /// 
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <returns></returns>
    public AudioObject Play(AudioName audioName)
    {
        return Play(audioName.ToString());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <param name="volume">音量</param>
    /// <param name="delay">延迟</param>
    /// <param name="startTime">音频开始点</param>
    /// <returns></returns>
    public AudioObject Play(AudioName audioName, float volume, float delay = 0, float startTime = 0)
    {
        return Play(audioName.ToString(), volume, delay, startTime);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <param name="parentObj">父物体</param>
    /// <returns></returns>
    public AudioObject Play(AudioName audioName, Transform parentObj)
    {
        return Play(audioName.ToString(), parentObj);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <param name="parentObj">父物体</param>
    /// <param name="volume">音量</param>
    /// <param name="delay">延迟</param>
    /// <param name="startTime">音频开始点</param>
    /// <returns></returns>
    public AudioObject Play(AudioName audioName, Transform parentObj, float volume, float delay = 0, float startTime = 0)
    {
        return Play(audioName.ToString(), parentObj, volume, delay, startTime);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <param name="worldPosition">播放位置</param>
    /// <param name="parentObj">父物体</param>
    /// <returns></returns>
    public AudioObject Play(AudioName audioName, Vector3 worldPosition, Transform parentObj = null)
    {
        return Play(audioName.ToString(), worldPosition, parentObj);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <param name="worldPosition">播放位置</param>
    /// <param name="parentObj">父物体</param>
    /// <param name="volume">音量</param>
    /// <param name="delay">延迟</param>
    /// <param name="startTime">音频开始点</param>
    /// <returns></returns>
    public AudioObject Play(AudioName audioName, Vector3 worldPosition, Transform parentObj, float volume, float delay = 0, float startTime = 0)
    {
        return Play(audioName.ToString(), worldPosition, parentObj, volume, delay, startTime);
    }

    public AudioObject Play(string audioID)
    {
        return AudioController.Play(audioID);
    }

    public AudioObject Play(string audioID, float volume, float delay = 0, float startTime = 0)
    {
        return AudioController.Play(audioID, volume, delay, startTime);
    }

    public AudioObject Play(string audioID, Transform parentObj)
    {
        return AudioController.Play(audioID, parentObj);
    }

    public AudioObject Play(string audioID, Transform parentObj, float volume, float delay = 0, float startTime = 0)
    {
        return AudioController.Play(audioID, parentObj, volume, delay, startTime);
    }

    public AudioObject Play(string audioID, Vector3 worldPosition, Transform parentObj = null)
    {
        return AudioController.Play(audioID, worldPosition, parentObj);
    }

    public AudioObject Play(string audioID, Vector3 worldPosition, Transform parentObj, float volume, float delay = 0, float startTime = 0)
    {
        return AudioController.Play(audioID, worldPosition, parentObj, volume, delay, startTime);
    }

    /// <summary>
    /// 在某个音效播完后播放
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <param name="playingAudio">等待此音效播放完毕</param>
    /// <param name="volume">音量</param>
    /// <param name="startTime">音频开始点</param>
    /// <returns></returns>
    public AudioObject PlayAfter(AudioName audioName, AudioObject playingAudio, float volume = 1.0f, float startTime = 0)
    {
        return PlayAfter(audioName.ToString(), playingAudio, volume, startTime);
    }

    /// <summary>
    /// 在某个音效播完后播放
    /// </summary>
    /// <param name="audioID">音效名称</param>
    /// <param name="playingAudio">等待此音效播放完毕</param>
    /// <param name="volume">音量</param>
    /// <param name="startTime">音频开始点</param>
    /// <returns></returns>
    public AudioObject PlayAfter(string audioID, AudioObject playingAudio, float volume = 1.0f, float startTime = 0)
    {
        return AudioController.PlayAfter(audioID, playingAudio, 0, volume, startTime);
    }

    /// <summary>
    /// 停止某个音效
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <returns></returns>
    public bool Stop(AudioName audioName)
    {
        return Stop(audioName.ToString());
    }

    public bool Stop(string audioID)
    {
        return AudioController.Stop(audioID);
    }

    /// <summary>
    /// 停止某个音效
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <param name="fadeOutLength">淡出时间</param>
    /// <returns></returns>
    public bool Stop(AudioName audioName, float fadeOutLength)
    {
        return Stop(audioName.ToString(), fadeOutLength);
    }

    public bool Stop(string audioID, float fadeOutLength)
    {
        return AudioController.Stop(audioID, fadeOutLength);
    }

    /// <summary>
    /// 停止所有音效
    /// </summary>
    public void StopAll()
    {
        AudioController.StopAll();
    }

    /// <summary>
    /// 停止所有音效
    /// </summary>
    /// <param name="fadeOutLength">淡出时间</param>
    public void StopAll(float fadeOutLength)
    {
        AudioController.StopAll(fadeOutLength);
    }

    /// <summary>
    /// 暂停所有音效
    /// </summary>
    /// <param name="fadeOutLength">淡出时间</param>
    public void PauseAll(float fadeOutLength = 0)
    {
        AudioController.PauseAll(fadeOutLength);
    }

    /// <summary>
    /// 恢复所有音效
    /// </summary>
    /// <param name="fadeInLength">淡入时间</param>
    public void UnpauseAll(float fadeInLength = 0)
    {
        AudioController.UnpauseAll(fadeInLength);
    }

    /// <summary>
    /// 暂停某个音频组
    /// </summary>
    /// <param name="categoryName">组名</param>
    /// <param name="fadeOutLength">淡出时间</param>
    public void PauseCategory(string categoryName, float fadeOutLength = 0)
    {
        AudioController.PauseCategory(categoryName, fadeOutLength);
    }

    /// <summary>
    /// 恢复某个音频组
    /// </summary>
    /// <param name="categoryName">组名</param>
    /// <param name="fadeInLength">淡入时间</param>
    public void UnpauseCategory(string categoryName, float fadeInLength = 0)
    {
        AudioController.UnpauseCategory(categoryName, fadeInLength);
    }

    /// <summary>
    /// 音频是否正在播放
    /// </summary>
    /// <param name="audioName">音频名称</param>
    /// <returns></returns>
    public bool IsPlaying(AudioName audioName)
    {
        return IsPlaying(audioName.ToString());
    }

    public bool IsPlaying(string audioID)
    {
        return AudioController.IsPlaying(audioID);
    }

    /// <summary>
    /// 获取正在播放的音效
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <param name="includePausedAudio">是否包括暂停的音效</param>
    /// <returns></returns>
    public AudioObject[] GetPlayingAudioObjects(AudioName audioName, bool includePausedAudio = false)
    {
        return GetPlayingAudioObjects(audioName.ToString(), includePausedAudio);
    }

    public AudioObject[] GetPlayingAudioObjects(string audioID, bool includePausedAudio = false)
    {
        return AudioController.GetPlayingAudioObjects(audioID, includePausedAudio);
    }

    /// <summary>
    /// 获取音频组中正在播放的音效
    /// </summary>
    /// <param name="categoryName">组名</param>
    /// <param name="includePausedAudio">是否包括暂停的音效</param>
    /// <returns></returns>
    public AudioObject[] GetPlayingAudioObjectsInCategory(string categoryName, bool includePausedAudio = false)
    {
        return AudioController.GetPlayingAudioObjectsInCategory(categoryName, includePausedAudio);
    }

    /// <summary>
    /// 获取所有正在播放的音效
    /// </summary>
    /// <param name="includePausedAudio">是否包括暂停的音效</param>
    /// <returns></returns>
    public AudioObject[] GetPlayingAudioObjects(bool includePausedAudio = false)
    {
        return AudioController.GetPlayingAudioObjects(includePausedAudio);
    }

    /// <summary>
    /// 获取正在播放的音效的数量
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <param name="includePausedAudio">是否包括暂停的音效</param>
    /// <returns></returns>
    public int GetPlayingAudioObjectsCount(AudioName audioName, bool includePausedAudio = false)
    {
        return GetPlayingAudioObjectsCount(audioName.ToString(), includePausedAudio);
    }

    public int GetPlayingAudioObjectsCount(string audioID, bool includePausedAudio = false)
    {
        return AudioController.GetPlayingAudioObjectsCount(audioID, includePausedAudio);
    }

    #endregion

    #region Helper

    /// <summary>
    /// 获取当前的AudioListener
    /// </summary>
    /// <returns></returns>
    public AudioListener GetCurrentAudioListener()
    {
        return AudioController.GetCurrentAudioListener();
    }


    /// <summary>
    /// 获取音频组
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public AudioCategory GetCategory(string name)
    {
        return AudioController.GetCategory(name);
    }

    /// <summary>
    /// 设置音频组音量大小
    /// </summary>
    /// <param name="name"></param>
    /// <param name="volume"></param>
    public void SetCategoryVolume(string name, float volume)
    {
        AudioController.SetCategoryVolume(name, volume);
    }

    /// <summary>
    /// 获取音频组音量大小
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public float GetCategoryVolume(string name)
    {
        return AudioController.GetCategoryVolume(name);
    }

    /// <summary>
    /// 设置全局音量大小
    /// </summary>
    /// <param name="volume"></param>
    public void SetGlobalVolume(float volume)
    {
        AudioController.SetGlobalVolume(volume);
    }

    /// <summary>
    /// 获取全局音量大小
    /// </summary>
    /// <returns></returns>
    public float GetGlobalVolume()
    {
        return AudioController.GetGlobalVolume();
    }

    /// <summary>
    /// 创建音频组
    /// </summary>
    /// <param name="categoryName"></param>
    /// <returns></returns>
    public AudioCategory NewCategory(string categoryName)
    {
        return AudioController.NewCategory(categoryName);
    }

    /// <summary>
    /// 移除音频组
    /// </summary>
    /// <param name="categoryName"></param>
    public void RemoveCategory(string categoryName)
    {
        AudioController.RemoveCategory(categoryName);
    }

    /// <summary>
    /// 添加音效到音频组中
    /// </summary>
    /// <param name="category">音频组</param>
    /// <param name="audioItem">音效数据</param>
    public void AddToCategory(AudioCategory category, AudioItem audioItem)
    {
        AudioController.AddToCategory(category, audioItem);
    }

    /// <summary>
    /// 添加音效到音频组中
    /// </summary>
    /// <param name="category">音频组</param>
    /// <param name="audioClip">音效</param>
    /// <param name="audioName">音效名称</param>
    /// <returns></returns>
    public AudioItem AddToCategory(AudioCategory category, AudioClip audioClip, AudioName audioName)
    {
        return AddToCategory(category, audioClip, audioName.ToString());
    }

    public AudioItem AddToCategory(AudioCategory category, AudioClip audioClip, string audioID)
    {
        return AudioController.AddToCategory(category, audioClip, audioID);
    }

    /// <summary>
    /// 移除某个音频
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <returns></returns>
    public bool RemoveAudioItem(AudioName audioName)
    {
        return RemoveAudioItem(audioName.ToString());
    }

    public bool RemoveAudioItem(string audioID)
    {
        return AudioController.RemoveAudioItem(audioID);
    }

    /// <summary>
    /// 音频ID是否有效
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <returns></returns>
    public bool IsValidAudioID(AudioName audioName)
    {
        return IsValidAudioID(audioName.ToString());
    }

    public bool IsValidAudioID(string audioID)
    {
        return AudioController.IsValidAudioID(audioID);
    }

    /// <summary>
    /// 获取音频数据
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <returns></returns>
    public AudioItem GetAudioItem(AudioName audioName)
    {
        return GetAudioItem(audioName.ToString());
    }

    public AudioItem GetAudioItem(string audioID)
    {
        return AudioController.GetAudioItem(audioID);
    }

    /// <summary>
    /// 如果你想让任何音频播放成为该对象的子物体，则在销毁游戏对象之前，请在游戏对象上使用此方法。
    /// </summary>
    /// <param name="gameObjectWithAudios"></param>
    public void DetachAllAudios(GameObject gameObjectWithAudios)
    {
        AudioController.DetachAllAudios(gameObjectWithAudios);
    }

    /// <summary>
    /// 获取音频的最大播放距离
    /// </summary>
    /// <param name="audioName">音效名称</param>
    /// <returns></returns>
    public float GetAudioItemMaxDistance(AudioName audioName)
    {
        return GetAudioItemMaxDistance(audioName.ToString());
    }

    public float GetAudioItemMaxDistance(string audioID)
    {
        return AudioController.GetAudioItemMaxDistance(audioID);
    }
    #endregion
}