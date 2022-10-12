using csharp_boolflix.Models;

public class Episode : MediaContent {
    
    public int SeasonNumber { get; set; }
    public int TvSeriesId { get; set; }
    public TvSeries TvSerie { get; set; }

}
