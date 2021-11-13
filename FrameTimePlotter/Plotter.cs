using System;
using System.IO;
using UnityEngine;

namespace FrameTimePlotter
{
    public class Plotter : MonoBehaviour
    {
        float lastTime;
        StreamWriter writer;
        public void Start()
        {
            lastTime = Time.realtimeSinceStartup;
            writer = new StreamWriter("FrameTimePlot.csv");
            DontDestroyOnLoad(this);
        }

        public void OnDestroy()
        {
            writer.Dispose();
            writer = null;
        }

        public void Update()
        {
            float currentTime = Time.realtimeSinceStartup;
            //Convert to milliseconds.
            float timeDelta = currentTime - lastTime;
            float timeDeltaMs = 1000f * timeDelta;
            float fps = 1f / timeDelta;
            lastTime = currentTime;
            writer.WriteLine($"{currentTime},{timeDeltaMs},{fps}");
        }
    }
}
