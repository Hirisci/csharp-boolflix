﻿using csharp_boolflix.Models;

public class TvSeries : MediaContent {
    public int SeasonsCount { get; set; }
    //public int EpisodesNumber { get; set; }
    MediaInfo? MediaInfo { get; set; }
    public List<Episode> Episodes { get; set; }
}
