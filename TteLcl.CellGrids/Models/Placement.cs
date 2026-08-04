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
/// Describes the placement of a strip in its cellgrid in its orientation
/// </summary>
public enum Placement
{
  /// <summary>
  /// A strip at the start: a row header or column header
  /// </summary>
  Start = 0,

  /// <summary>
  /// A strip in the middle: the main scrollable bulk of cells
  /// </summary>
  Middle = 1,

  /// <summary>
  /// A strip at the end: an unscrollable region at the right or bottom of a cellgrid.
  /// Commonly empty.
  /// </summary>
  End = 2,
}
