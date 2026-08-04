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
/// The logical model for a grid of cells supporting strips of fixed cells
/// at the edges and strips of scrollable cells in the middle
/// </summary>
public class CellGrid
{
  private readonly CellZone[] _cellZones;

  /// <summary>
  /// Create a new CellGrid
  /// </summary>
  public CellGrid()
  {
    RowStrips = new StripTriplet<CellRow, RowStrip>( [
        new RowStrip(this, Placement.Start),
        new RowStrip(this, Placement.Middle),
        new RowStrip(this, Placement.End),
      ]);
    ColumnStrips = new StripTriplet<CellColumn, ColumnStrip>( [
        new ColumnStrip(this, Placement.Start),
        new ColumnStrip(this, Placement.Middle),
        new ColumnStrip(this, Placement.End),
      ]);
    _cellZones = new CellZone[9];
    for(var ri = 0; ri < 3; ri++)
    {
      for(var ci = 0; ci < 3; ci++)
      {
        var zone = new CellZone(RowStrips[ri], ColumnStrips[ci]);
        _cellZones[3*ri + ci] = zone;
      }
    }
  }

  /// <summary>
  /// Get the <see cref="CellZone"/> for the given <see cref="Placement"/> pair
  /// </summary>
  /// <param name="rowStrip"></param>
  /// <param name="columnStrip"></param>
  /// <returns></returns>
  public CellZone this[Placement rowStrip, Placement columnStrip] =>
    _cellZones[((int)rowStrip)*3 + (int)columnStrip];

  /// <summary>
  /// Access the <see cref="RowStrip"/>s (by placement, index, or generic name)
  /// </summary>
  public StripTriplet<CellRow, RowStrip> RowStrips { get; }

  /// <summary>
  /// Get the <see cref="RowStrip"/> for the nonscrolling top rows (a.k.a. the column headers)
  /// </summary>
  public RowStrip TopRows => RowStrips.Start;

  /// <summary>
  /// Get the <see cref="RowStrip"/> for the scrolling (middle) rows
  /// </summary>
  public RowStrip ScrollRows => RowStrips.Middle;

  /// <summary>
  /// Get the <see cref="RowStrip"/> for the nonscrolling bottom rows (the column footers)
  /// </summary>
  public RowStrip BottomRows => RowStrips.End;

  /// <summary>
  /// Access the <see cref="ColumnStrip"/>s (by placement, index, or generic name)
  /// </summary>
  public StripTriplet<CellColumn, ColumnStrip> ColumnStrips { get; }

  /// <summary>
  /// Get the <see cref="ColumnStrip"/> for the nonscrolling left columns (the row headers)
  /// </summary>
  public ColumnStrip LeftColumns => ColumnStrips.Start;

  /// <summary>
  /// Get the <see cref="ColumnStrip"/> for the scrolling (middle) columns
  /// </summary>
  public ColumnStrip ScrollColumns => ColumnStrips.Middle;

  /// <summary>
  /// Get the <see cref="ColumnStrip"/> for the nonscrolling right columns
  /// </summary>
  public ColumnStrip RightColumns => ColumnStrips.End;
}
