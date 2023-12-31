﻿using Avalonia.MusicStore.Models;

namespace Avalonia.MusicStore.ViewModels;

public class AlbumViewModel : ViewModelBase
{
    private readonly Album _album;

    public AlbumViewModel(Album album)
    {
        _album = album;
    }

    public string? Title => _album.Title;
    public string? Artist => _album.Artist;

}
