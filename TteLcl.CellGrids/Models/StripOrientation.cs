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
/// Description of StripOrientation
/// </summary>
public enum StripOrientation
{
  /// <summary>
  /// A horizontal strip, i.e. zero or more rows
  /// </summary>
  Horizontal = 0,

  /// <summary>
  /// A vertical strip, i.e. zero or more columns
  /// </summary>
  Vertical = 1,
}
