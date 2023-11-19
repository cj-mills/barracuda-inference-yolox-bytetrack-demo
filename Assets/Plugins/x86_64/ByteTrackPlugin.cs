using System;
using System.Runtime.InteropServices;


public static class ByteTrackPlugin
{
    const string dll = "UnityByteTrackPlugin";

    [DllImport(dll)]
    public static extern void init_tracker(float track_thresh=0.23f, int track_buffer=30, float match_thresh=0.8f, int frame_rate=30);

    [DllImport(dll)]
    public static extern void get_track_ids(float[] boxes_probs_array, int num_detections, int[] track_ids_array);
}
