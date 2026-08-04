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
/// A one-dimensional slice of cells: a row or a column.
/// Note that the cells are not directly accessible from here.
/// </summary>
public abstract class CellLine
{
  /// <summary>
  /// Create a new CellLine
  /// </summary>
  protected CellLine(
    CellGrid owner,
    StripOrientation orientation)
  {
    Owner = owner;
    Orientation = orientation;
  }

  /// <summary>
  /// The owner of this strip
  /// </summary>
  public CellGrid Owner { get; }

  /// <summary>
  /// The orientation of this <see cref="CellLine"/> (Horizontal, i.e. a row,
  /// or Vertical, i.e. a column)
  /// </summary>
  public StripOrientation Orientation { get; }

}
