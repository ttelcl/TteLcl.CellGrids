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
/// A strip of zero or more adjacent <see cref="CellColumn"/>s
/// </summary>
public sealed class ColumnStrip : CellStrip<CellColumn>
{
  /// <summary>
  /// Create a new ColumnStrip
  /// </summary>
  internal ColumnStrip(
    CellGrid owner,
    Placement placement)
    : base(owner, StripOrientation.Vertical, placement)
  {
  }

  /// <summary>
  /// The <see cref="CellColumn"/>s in this strip. Columns are added in the
  /// <see cref="CellColumn"/> constructor.
  /// </summary>
  public IReadOnlyList<CellColumn> Columns => Lines;

  internal int AppendColumn(CellColumn column)
  {
    if(column.Strip != this)
    {
      throw new InvalidOperationException(
        "Expecting the column to be associated with this strip");
    }
    return AppendLine(column);
  }
}
