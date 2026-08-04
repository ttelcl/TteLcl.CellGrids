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
/// A logical row of Cells
/// </summary>
public class CellRow: CellLine
{
  /// <summary>
  /// Create a new CellRow and append it to <paramref name="strip"/>
  /// </summary>
  public CellRow(RowStrip strip)
    : base(strip.Owner, StripOrientation.Horizontal)
  {
    Strip = strip;
    LogicalIndex = Strip.AppendRow(this);
  }

  /// <summary>
  /// The <see cref="RowStrip"/> this <see cref="CellRow"/> belongs to.
  /// </summary>
  public RowStrip Strip { get; }

  /// <summary>
  /// The logical index of this column (set when this is added to its strip)
  /// </summary>
  public int LogicalIndex { get; }

}
