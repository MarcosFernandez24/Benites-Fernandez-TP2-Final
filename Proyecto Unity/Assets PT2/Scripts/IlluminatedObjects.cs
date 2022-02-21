using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IlluminatedObjects : MonoBehaviour
{

    [SerializeField] private Light[] SceneFrontCarLights;
    [SerializeField] private Light[] SceneBackCarLights;
    [SerializeField] private Light[] SceneLampLights;
    [SerializeField] private Light[] SceneDefeatLights;
    [SerializeField] private Light[] SceneFlashlightLight;
    [SerializeField] private Light[] SceneDirectionalLight;

    public class PointLights : IlluminatedObjects
    {

        public class LightRangeAndIntensity : PointLights
        {

            private void Awake()
            {
                for (int i = 0; i < 2; i++)
                {
                    SceneFrontCarLights[i].intensity = 0;

                    SceneFrontCarLights[i].range = 0;
                }

                for (int i = 0; i < 4; i++)
                {
                    SceneBackCarLights[i].intensity = 0;

                    SceneBackCarLights[i].range = 0;
                }

                for (int i = 0; i < 4; i++)
                {
                    SceneDefeatLights[i].intensity = 0;

                    SceneDefeatLights[i].range = 0;
                }

                for (int i = 0; i < 1; i++)
                {
                    SceneDirectionalLight[i].intensity = 0;
                }

                for (int i = 0; i < 1; i++)
                {
                    SceneFlashlightLight[i].intensity = 0;

                    SceneFlashlightLight[i].range = 0;
                }

                for (int i = 0; i < 4; i++)
                {
                    SceneLampLights[i].intensity = 0;

                    SceneLampLights[i].range = 0;
                }
            }

        }
    }
        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; i < 2; i++)
            {
                SceneFrontCarLights[i].intensity = 5;

                SceneFrontCarLights[i].range = 10;
            }

            for (int i = 0; i < 4; i++)
            {
                SceneBackCarLights[i].intensity = 0.8f;

                SceneBackCarLights[i].range = 10;
            }

            for (int i = 0; i < 4; i++)
            {
                SceneDefeatLights[i].intensity = 2;

                SceneDefeatLights[i].range = 10;
            }

            for (int i = 0; i < 1; i++)
            {
                SceneDirectionalLight[i].intensity = 1;
            }

            for (int i = 0; i < 1; i++)
            {
                SceneFlashlightLight[i].intensity = 2.1f;

                SceneFlashlightLight[i].range = 10;
            }

            for (int i = 0; i < 4; i++)
            {
                SceneLampLights[i].intensity = 1;

                SceneLampLights[i].range = 15.12f;
            }
        }

        // Update is called once per frame
        void Update()
        {



        }
    }



