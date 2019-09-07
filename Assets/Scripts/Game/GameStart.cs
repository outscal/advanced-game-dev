using System.Collections;
using System.Collections.Generic;
//using Tanks.Tank;
using UnityEngine;
using Tanks.Tank.AI;
using System.Runtime.Serialization;
using System;
using System.Threading.Tasks;

namespace Tanks.Game
{
    public class GameStart : MonoBehaviour
    {
        async void Start()
        {
            StartCoroutine(GetAsset("askljskl"));

            //AssetBundle bundle = (AssetBundle)(await GetAssetBundle("downloadstring"));

            Task<AssetBundle> task1 = GetAssetBundle("downloadstring1");
            Task<AssetBundle> task2 = GetAssetBundle("downloadstring2");
            Task<AssetBundle> task3 = GetAssetBundle("downloadstring3");

            //Task<GameObject> task4 = LoadGameObject("downloadstring4");
            //Task<GameObject> task5 = LoadGameObject("downloadstring5");

            await task1;
            await task2;
            await task3;
            //await task4;
            //await task5;

            // all your models have been downloading 
        }

        //async Task<GameObject> LoadGameObject(string path)
        //{
        //    // loading game object path 
        //}

        async Task<AssetBundle> GetAssetBundle(string url)
        {
            return (await new WWW(url)).assetBundle;
        }


        private void Update()
        {
            
        }


        private AssetBundle assetBundle;
        IEnumerator GetAsset(string url)
        {
            WWW www = new WWW(url);
            yield return www;
            assetBundle = www.assetBundle;
        }
    }
}
