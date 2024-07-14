﻿using Hypercube.Math.Box;
using Hypercube.Math.Vector;
using Hypercube.Shared.Resources;

namespace Hypercube.Client.Graphics.Texturing;

public interface ITexture
{
    ResourcePath Path { get; }
    int Width { get; }
    int Height { get; }
    byte[] Data { get; }
    Box2 QuadCrateTranslated(Vector2 position);
}