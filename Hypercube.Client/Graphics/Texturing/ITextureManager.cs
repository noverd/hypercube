﻿namespace Hypercube.Client.Graphics.Texturing;

public interface ITextureManager
{
    ITexture Create(string path);
    
    ITextureHandle CreateHandler(string path);
    ITextureHandle CrateHandler(ITexture texture);
}