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
/// A group of neighbouring columns or rows: a two-dimensional grid
/// of cells with one fixed dimension and one undetermined dimension.
/// </summary>
/// <remarks>
/// Some properties:
/// <list type="bullet">
/// <item>
/// A strip can be horizontal (a group of rows) or vertical (a group of columns)
/// </item>
/// <item>Each CellGrid has three strips in each direction, identified by that
/// direction and a Placement (Start, Middle, and End)</item>
/// <item>Those two triplets combine into nine zones</item>
/// <item>Strips can be empty</item>
/// </list>
/// Examples:
/// <list type="bullet">
/// <item>The column header cells (there can be multiple rows in such a strip)</item>
/// <item>The column header cells (there can be multiple columns. Or none)</item>
/// <item>Column footer cells</item>
/// </list>
/// </remarks>
public abstract class CellStrip<TLine> where TLine : CellLine
{
  private readonly List<TLine> _lines = new List<TLine>();

  /// <summary>
  /// Create a new CellStrip
  /// </summary>
  protected CellStrip(
    CellGrid owner,
    StripOrientation orientation,
    Placement placement)
  {
    Owner = owner;
    Orientation = orientation;
    StripPlacement = placement;
  }

  /// <summary>
  /// The owner of this strip
  /// </summary>
  public CellGrid Owner {  get; }

  /// <summary>
  /// The orientation of the strip
  /// </summary>
  public StripOrientation Orientation { get; }

  /// <summary>
  /// The strip's placement: <see cref="Placement.Start"/>,
  /// <see cref="Placement.Middle"/> or <see cref="Placement.End"/>, translating
  /// to left, middle or right for vertical strips, and translating to
  /// top, middle or bottom for horizontal strips.
  /// </summary>
  public Placement StripPlacement { get; }

  /// <summary>
  /// The cell lines (<see cref="CellColumn"/> or <see cref="CellRow"/>) in this strip.
  /// </summary>
  public IReadOnlyList<TLine> Lines => _lines;

  /// <summary>
  /// Append a <see cref="CellLine"/> subclass instance
  /// </summary>
  /// <param name="line"></param>
  /// <returns></returns>
  protected int AppendLine(TLine line)
  {
    _lines.Add(line);
    return _lines.Count-1;
  }
}
