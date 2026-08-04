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
/// A logical column of cells
/// </summary>
public class CellColumn: CellLine
{
  /// <summary>
  /// Create a new CellColumn and add it to a strip
  /// </summary>
  public CellColumn(ColumnStrip strip)
    : base(strip.Owner, StripOrientation.Vertical)
  {
    Strip = strip;
    LogicalIndex = Strip.AppendColumn(this);
  }

  /// <summary>
  /// The <see cref="ColumnStrip"/> this <see cref="CellColumn"/> belongs to.
  /// </summary>
  public ColumnStrip Strip { get; }

  /// <summary>
  /// The logical index of this column (set when this is added to its strip)
  /// </summary>
  public int LogicalIndex { get; }
}
