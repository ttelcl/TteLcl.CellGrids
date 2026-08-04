/*
 * (c) 2026  ttelcl / ttelcl
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TteLcl.CellGrids.Models;

/// <summary>
/// Provides a view on a triplet of <see cref="RowStrip"/>s or <see cref="ColumnStrip"/>s
/// (one for each <see cref="Placement"/>)
/// </summary>
public class StripTriplet<TLine, TStrip>
  where TLine : CellLine
  where TStrip : CellStrip<TLine>
{
  private readonly TStrip[] _strips;

  /// <summary>
  /// Create a new StripTriplet
  /// </summary>
  internal StripTriplet(
    TStrip[] strips)
  {
    if(strips.Length != 3
      || strips[0].StripPlacement != Placement.Start
      || strips[1].StripPlacement != Placement.Middle
      || strips[2].StripPlacement != Placement.End)
    {
      throw new ArgumentException(
        "Expecting 3 strips, one each for each placement");
    }
    _strips = strips;
  }

  /// <summary>
  /// Get a strip by placement
  /// </summary>
  /// <param name="placement"></param>
  /// <returns></returns>
  public TStrip this[Placement placement] => _strips[(int)placement];

  /// <summary>
  /// Get a strip by integer index (0, 1 or 2)
  /// </summary>
  /// <param name="index"></param>
  /// <returns></returns>
  public TStrip this[int index] => _strips[index];

  /// <summary>
  /// Get the start strip
  /// </summary>
  public TStrip Start => _strips[(int)Placement.Start];

  /// <summary>
  /// Get the middle strip
  /// </summary>
  public TStrip Middle => _strips[(int)Placement.Middle];

  /// <summary>
  /// Get the end strip
  /// </summary>
  public TStrip End => _strips[(int)Placement.End];
}
