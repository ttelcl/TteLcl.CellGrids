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
/// A rectangular subset of a cell grid; the intersection of a 
/// <see cref="RowStrip"/> and a <see cref="ColumnStrip"/>.
/// </summary>
public class CellZone
{
  /// <summary>
  /// Create a new CellZone
  /// </summary>
  public CellZone(
    RowStrip rows,
    ColumnStrip columns)
  {
    if(rows.Owner != columns.Owner)
    {
      throw new ArgumentException(
        "Expecting the same owner for both arguments");
    }
    Rows = rows;
    Columns = columns;
    Owner = Rows.Owner;
  }

  /// <summary>
  /// The <see cref="CellGrid"/> this zone belongs to
  /// </summary>
  public CellGrid Owner { get; }

  /// <summary>
  /// The row collection of this zone
  /// </summary>
  public RowStrip Rows { get; }

  /// <summary>
  /// The column collection of this zone
  /// </summary>
  public ColumnStrip Columns { get; }

}
