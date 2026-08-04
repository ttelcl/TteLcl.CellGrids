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
/// A strip of zero or more adjacent rows.
/// </summary>
public class RowStrip : CellStrip<CellRow>
{
  /// <summary>
  /// Create a new <see cref="RowStrip"/>
  /// </summary>
  internal RowStrip(
    CellGrid owner,
    Placement placement)
    : base(owner, StripOrientation.Horizontal, placement)
  {
  }

  /// <summary>
  /// The <see cref="CellRow"/>s in this strip. Rows are added in the
  /// <see cref="CellRow"/> constructor.
  /// </summary>
  public IReadOnlyList<CellRow> Rows => Lines;

  internal int AppendRow(CellRow row)
  {
    if(row.Strip != this)
    {
      throw new InvalidOperationException(
        "Expecting the column to be associated with this strip");
    }
    return AppendLine(row);
  }

}
