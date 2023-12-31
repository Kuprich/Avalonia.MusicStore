﻿using iTunesSearch.Library;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avalonia.MusicStore.Models;

public class Album
{
    private static iTunesSearchManager _searchManager = new ();

    public Album(string? artist, string? title, string? coverUrl)
    {
        Artist = artist;
        Title = title;
        CoverUrl = coverUrl;
    }

    public string? Artist { get; set; }
    public string? Title { get; set; }
    public string? CoverUrl { get; set; }


    public static async Task<IEnumerable<Album>> SearchAsync(string searchTerm)
    {
        var query = await _searchManager.GetAlbumsAsync(searchTerm).ConfigureAwait(false);

        return query.Albums.Select(x => 
            new Album(x.ArtistName, x.CollectionName, x.ArtworkUrl100.Replace("100x100bb", "600x600bb")));
    }

}
